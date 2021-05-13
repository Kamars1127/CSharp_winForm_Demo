using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskingThingsSystem.Function;
using AskingThingsSystem.Message;
using System.Data.SqlClient;

namespace AskingThingsSystem.HomeTools
{
    public partial class AddAskingPlaceForm : Form
    {
        FormFunction formFun = new FormFunction();

        public AddAskingPlaceForm()
        {
            InitializeComponent();
        }

        private void AddAskingPlaceForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }


        /*------ TextBox『txtInput』
         *-『txtInput_Enter』:輸入時的文字顏色
         *-『txtInput_KeyPress』:限制輸入
         *-------------------------------------------*/
        /*--- 輸入時的文字顏色 ---*/
        private void txtInput_Enter(object sender, EventArgs e)
        {
            msgNotNull.Visible = false; //隱藏『必須輸入』
            OftenUseColor.SetInputTextStatus(txtInput);
        }

        /*--- 只能輸入字母、數字、控制鍵 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            msgNotNull.Visible = false; //隱藏『必須輸入』
            msgPlaceExist.Visible = false; //隱藏『該地點已存在』

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 新增問事地點 ---*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inStr = txtInput.Text;

            /* 輸入內容不能為空或原本的提示字 */
            if (inStr == "" || inStr == "輸入地點")
            {
                msgNotNull.Visible = true; //顯示 『必須輸入』
                return;
            }
            
            /*- 取得資料庫最後一筆地點編號 -*/
            string lastPlaceCode = GetLastPlaceCode(inStr);
            /*- 當取得結果不為空，就可以新增該地點到資料庫中 -*/
            if (lastPlaceCode != "")
            {
                //MessageBox.Show("地點編號:" + placeCode);
                /* 去除AP代碼，取得數字，最後+1建立新編號*/
                int number = Convert.ToInt32(lastPlaceCode.Remove(0, 2))+1;
                string newPlaceCode = String.Format("{0:AP000}", number);
                //MessageBox.Show("新編號編號:" + newPlaceCode);
                AddplaceToDB(inStr, newPlaceCode); //把資料加到DB
                this.Close(); //關閉 AddAskingPlaceForm
            }
            else
            {
                msgPlaceExist.Visible = true; //顯示『該地點已存在』
                return;
            }
        }

        /*------ Database
         *-『GetLastPlaceCode』:取得資料庫中最後一個地點編號
         *-『AddplaceToDB』:把地點資料加到資料庫中
         *------------------------------------------------------*/

        /*--- 取得資料庫中最後一個地點編號 
         *- 參數1 :欲新增的地點名稱
         *- 說明: 先判斷地點是否已存在，再回傳地點編號。
         *- return值 ="" : 表示欲新增的地點已存在
         *- return值 !="" : 回傳在資料庫中最後一筆地點編號
         *------------------------------------------------*/
        private string GetLastPlaceCode(string placeName)
        {
            string placeCode = "";

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點編號, 地點名稱 " +
                                "from Asking_Place " +
                                "order by 地點編號 ASC";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    /* 欲新增的地點是否已存在 */
                    if (placeName == dr["地點名稱"].ToString())
                    {
                        return "";
                    }
                    placeCode = dr["地點編號"].ToString();
                }
                dr.Close();
            }
            return placeCode;
        }

        /*--- 把地點資料加到資料庫中
         *- 參數1 :地點名稱
         *- 參數2 :地點編號 
         *---------------------------------*/
        private void AddplaceToDB(string placeName, string placeCode)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "insert into Asking_Place(地點編號, 地點名稱) " +
                                "values(@placeCode, @placeName)";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@placeCode", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@placeName", SqlDbType.NVarChar));
                cmd.Parameters["@placeCode"].Value = placeCode;
                cmd.Parameters["@placeName"].Value = placeName;
                result = cmd.ExecuteNonQuery();
            }

            /* 顯示新增成功 */
            if (result == 1)
            {
                formFun.OpenFocusForm(new SuccessForm(placeName + " 新增成功"));
            }
        }
    }
}
