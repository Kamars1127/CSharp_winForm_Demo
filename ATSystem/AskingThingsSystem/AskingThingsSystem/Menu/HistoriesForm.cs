using FontAwesome.Sharp;
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
using System.Data.SqlClient;
using AskingThingsSystem.HistoriesTools;

namespace AskingThingsSystem.Menu
{
    public partial class HistoriesForm : Form
    {
        IconButton menuBtn; //Menu: 問事紀錄
        FormFunction formFun = new FormFunction();
        string contactNum; //聯絡編號
        string tableName; //問事表名稱
        string content; //紀錄事項
        string remarks; //備註

        public HistoriesForm()
        {
            InitializeComponent();
        }

        public HistoriesForm(IconButton menuBtn)
        {
            InitializeComponent();
            this.menuBtn = menuBtn;
        }

        private void HistoriesForm_Load(object sender, EventArgs e)
        {
            //設定panInput 的 radius
            RadiusTool rt = new RadiusTool();
            rt.SetControlRadius(panInput, 50);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            menuBtn.BackColor = OftenUseColor.menuOffStatusColor;
            this.Close();
        }


        /*------ TextBox『txtInContent』
         *-『txtInContent_KeyPress』:限制輸入
         *-『txtInContent_Enter』:輸入狀態
         *-『txtInContent_Leave』:提示狀態
         *----------------------------------------*/

        /*--- 限制輸入:只能輸入數字、文字、控制項 ---*/
        private void txtInContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏錯誤訊息

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 輸入狀態 ---*/
        private void txtInContent_Enter(object sender, EventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏錯誤訊息
            OftenUseColor.SetInputTextStatus(txtInContent);
        }

        /*--- 提示狀態 ---*/
        private void txtInContent_Leave(object sender, EventArgs e)
        {
            OftenUseColor.SetPromptTextStatus(txtInContent, "輸入姓名");
        }


        /*------ Button 『btnSearch』
         *-『btnSearch_Click』:查詢
         *-『btnComplete_Click』:完整內容
         *-『btnDelete_Click』:刪除
         *-----------------------------------*/

        /*--- 查詢 ---*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblName.Text = ""; //清空顯示的姓名

            string searchContent = txtInContent.Text.Trim();

            /*-- 輸入的內容不能為空 --*/
            if (searchContent == "" || searchContent == null)
            {
                inWarningMsg.Visible = true; // 顯示警告訊息
                return;
            }

            /*-- 輸入的姓名是否存在，是否有同名同姓存在 --*/
            List<string[]> listInfo = CheckPersonExist(searchContent);
            int count = listInfo.Count; //查詢到的人數

            /*- 依查詢到的人數，執行對應的動作 -*/
            /*- count=0 : 查無
             *- count=1 : 只有一人
             *- count=2 : 兩個人以上 (必須確認是要查哪一個人)
             *----------------------------------------------------*/
            if (count == 0)
            {
                formFun.OpenFocusForm(new Message.WarningForm("查無此姓名"));
                return;
            }   
            else if (count == 1)
            {
                contactNum =  listInfo[0][0]; //取得聯絡編號
                ShowHistories(contactNum);
            }
            else if (count >= 2)
            {
                WhichOneToSearchForm wotsForm = new WhichOneToSearchForm(listInfo);
                formFun.OpenFocusForm(wotsForm);
                contactNum = wotsForm.confirmContactNum; //取得聯絡編號
                ShowHistories(contactNum);
            }

            lblName.Text = searchContent;
            historiesView.Focus();
        }


        /*--- 完整內容 ---*/
        private void btnComplete_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new CompleteHistoryForm(lblName.Text, tableName, content, remarks));
        }

        /*--- 刪除 ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("確認要刪除該筆紀錄嗎?");
            formFun.OpenFocusForm(confirmForm);

            if (confirmForm.isOk)
            {
                DeleteHistory(contactNum, tableName); //刪除問事記錄
                ShowHistories(contactNum); //重新顯示全部的問事紀錄
            }
        }


        /*------ DataBase 資料操作
         *-『CheckPersonExist』:查詢的姓名(此人)是否存在
         *-『ShowHistories』:顯示問事記錄
         *-『DeleteHistory』:刪除問事記錄
         *---------------------------*/

        /*--- 查詢的姓名(此人)是否存在 ---*/
        /*- 參數: 查詢的『姓名』
         *- 回傳值: 查詢到姓名的聯絡資訊
         *--------------------------------*/
        private List<string[]> CheckPersonExist(string name)
        {
            List<string[]> listPersonalInfo = new List<string[]>();

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 聯絡編號, 姓名, 聯絡電話, 居住地 " +
                                "from Personal_Info " +
                                "where 姓名=N\'" + name + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listPersonalInfo.Add(new string[4]{dr["聯絡編號"].ToString(), dr["姓名"].ToString(), dr["聯絡電話"].ToString(), dr["居住地"].ToString()});
                    }
                }

                dr.Close();
            }
            return listPersonalInfo;
        }

        /*--- 顯示問事記錄 ---*/
        /*- 參數: 查詢人的『聯絡編號』
         *--------------------------------*/
        private void ShowHistories(string contactNun)
        {
            historiesView.Rows.Clear(); // 清除檢視表的資料
            DisableButton(); // 禁用按鈕

            int number = 0;//序號
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 問事表名稱, 紀錄事項, 備註 " +
                                "from Asking_Histories " +
                                "where 聯絡編號=\'" + contactNun + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        number++;
                        historiesView.Rows.Add(number, dr["問事表名稱"], dr["紀錄事項"], dr["備註"]);
                    }
                }

                dr.Close();
            }

            historiesView.ClearSelection();//清除預選
        }

        /*--- 刪除問事記錄 ---*/
        /*- 參數1: 查詢人的『聯絡編號』
         *- 參數2: 欲刪除的『問事表名稱』
         *--------------------------------*/
        private void DeleteHistory(string contactNum, string tableName)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Histories " +
                                "where 聯絡編號=@number " +
                                "and 問事表名稱=@name";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters["@number"].Value = contactNum;
                cmd.Parameters["@name"].Value = tableName;

                cmd.ExecuteNonQuery();
            }
        }


        /*------ DataGridView 『historiesView』
         *-『historiesView_ColumnHeaderMouseClick』:點擊標題列時，不選取資料列
         *-『historiesView_CellClick』:取得選取列的資料
         *----------------------------------------------------------------------------*/

        /*--- 點擊標題列時，不選取資料列 ---*/
        private void historiesView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            historiesView.ClearSelection();
        }

        private void historiesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*- 取得問事表名稱 -*/
                tableName =  historiesView.Rows[e.RowIndex].Cells[1].Value.ToString();
                /*- 取得紀錄事項 -*/
                content = historiesView.Rows[e.RowIndex].Cells[2].Value.ToString();
                /*- 取得備註 -*/
                remarks = historiesView.Rows[e.RowIndex].Cells[3].Value.ToString();

                EnableButton(); //啟用按鈕
            }
        }

        /*------ Other
         *-『EnableButton』:啟用按鈕
         *-『DisableButton』:禁用按鈕
         *------------------------------------*/
        /*--- 啟用按鈕 ---*/
        private void EnableButton()
        {
            OftenUseColor.ButtonEnable(btnDelete); //啟用『刪除』按鈕
            OftenUseColor.ButtonEnable(btnComplete); //啟用『完整內容』按鈕
        }

        /*--- 禁用按鈕 ---*/
        private void DisableButton()
        {
            OftenUseColor.ButtonDisable(btnDelete); //禁用『刪除』按鈕
            OftenUseColor.ButtonDisable(btnComplete); //禁用『完整內容』按鈕
        }
    }
}
