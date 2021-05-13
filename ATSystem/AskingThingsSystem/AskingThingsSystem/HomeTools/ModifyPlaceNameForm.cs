using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AskingThingsSystem.Function;

namespace AskingThingsSystem.HomeTools
{
    public partial class ModifyPlaceNameForm : Form
    {
        FormFunction formFun = new FormFunction();

        public string oldPlaceName { get; set; } //原本的地名
        public bool isModified { get; set; } //是否修改

        public ModifyPlaceNameForm()
        {
            InitializeComponent();
        }

        private void ModifyPlaceNameForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this, 350, 42);
            lblOldName.Text = oldPlaceName;
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /*------ TextBox『inText』
         *-『inText_KeyPress』:限制輸入
         *-『btnCancel_Click』:關閉視窗
         *-『btnOK_Click』:確認修改
         *-----------------------------------------------------*/

        /*--- 只能輸入字母、數字、控制鍵 ---*/
        private void inText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 關閉視窗 ---*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            isModified = false; //未修改
        }

        /*--- 確認修改 ---*/
        private void btnOK_Click(object sender, EventArgs e)
        {
            string content = inText.Text;

            if (content == "")
            {
                formFun.OpenFocusForm(new Message.WarningForm("請輸入新的地名"));
                return;
            }

            if (ModifyPlace(content))
            {
                string placeCode = GetPlaceCode(content); //取得地點代碼
                /*-- 取得的地點代碼不能為空 --*/
                if (placeCode != "")
                {
                    /*- 是否有被用於建立問事表，有的話就要改問事表明稱 -*/
                    if(IsPalceUsed(placeCode))
                        ModifyAskingTablesName(oldPlaceName, content, placeCode);
                    else
                    {
                        formFun.OpenFocusForm(new Message.SuccessForm("修改成功"));
                        isModified = true;
                        this.Close();
                    }
                }
            }
        }


        /*------ Database --------------------------------------
         *
         *-『ModifyPlace』:修改地名
         *-『GetPlaceCode』:取得地點代碼
         *-『IsPalceUsed』:地點是否有被使用
         *-『ModifyAskingTablesName』:修改問事表名稱
         *-----------------------------------------------------*/

        /*--- 修改地名 -----------------
         * 
         *- 參數1: 欲修改的地名
         *- 回傳值true:  修改成功
         *- 回傳值false: 修改失敗
         *-------------------------------*/
        private bool ModifyPlace(string name)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點名稱 from Asking_Place where 地點名稱 =@name";

                string sqlStr2 = "update Asking_Place " +
                                 "set 地點名稱=@placeName " +
                                 "where 地點名稱=@oldPlaceName";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters["@name"].Value = name;
                SqlDataReader dr = cmd.ExecuteReader();

                /*- 新地名是否已存在資料庫中 -*/
                if (dr.HasRows)
                {
                    string msg = name + " 已存在，請重新輸入";
                    formFun.OpenFocusForm(new Message.WarningForm(msg));
                    dr.Close();
                    return false;
                }
                dr.Close();

                /*- 把新地名加到資料庫中 -*/
                cmd.CommandText = sqlStr2;
                cmd.Parameters.Add(new SqlParameter("@placeName", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@oldPlaceName", SqlDbType.NVarChar));
                cmd.Parameters["@placeName"].Value = name;
                cmd.Parameters["@oldPlaceName"].Value = oldPlaceName;
                result = cmd.ExecuteNonQuery();
            }

            if (result <= 0)
                return false;
            else
                return true;
        }

        /*--- 取得地點代碼 --------------------
         * 
         *- 參數: 欲取得代碼的地名
         *- 回傳值(空字串):取得失敗 
         *-----------------------------------*/
        private string GetPlaceCode(string placeName)
        {
            string placeCode ="";
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點編號 " +
                                "from Asking_Place " +
                                "where 地點名稱=@name";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters["@name"].Value = placeName;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        placeCode = dr["地點編號"].ToString();
                    }
                }
            }

            return placeCode;
        }

        /*--- 地點是否有被使用 ----------------------------
         * 
         *- 說明: 地點是否有被用來建立問事表
         *- 參數: 地點代碼
         *- 回傳值(false): 沒有被使用
         *- 回傳值(true): 被使用
         *-----------------------------------------------*/
        private bool IsPalceUsed(string placeCode)
        {
            int result = 0;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select count(*) from Asking_Tables " +
                                "where 地點編號=@placeCode";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@placeCode", SqlDbType.NVarChar));
                cmd.Parameters["@placeCode"].Value = placeCode;
                result = (int)cmd.ExecuteScalar();
            }

            if (result > 0)
                return true;
            else
                return false;
        }

        /*--- 修改問事表名稱 ---*/
        private void ModifyAskingTablesName(string oldStr, string newStr, string placeCode)
        {
            int result = 0;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "UPDATE Asking_Tables SET 問事表名稱 = REPLACE(問事表名稱, @oldStr, @newStr) " +
                                "where 地點編號 = @placeCode";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@oldStr", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@newStr", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@placeCode", SqlDbType.NVarChar));
                cmd.Parameters["@oldStr"].Value = oldStr;
                cmd.Parameters["@newStr"].Value = newStr;
                cmd.Parameters["@placeCode"].Value = placeCode;
                result = cmd.ExecuteNonQuery();
            }

            if (result <= 0)
            {
                formFun.OpenFocusForm(new Message.WarningForm("修改失敗!!!"));
                return;
            }
            else
            {
                formFun.OpenFocusForm(new Message.SuccessForm("修改成功"));
                isModified = true;
                this.Close();
            } 
        }
    }
}
