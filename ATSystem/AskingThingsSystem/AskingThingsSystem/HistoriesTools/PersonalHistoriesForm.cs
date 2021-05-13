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


namespace AskingThingsSystem.HistoriesTools
{
    public partial class PersonalHistoriesForm : Form
    {
        string contactNum; //聯絡編號
        string name; //姓名

        /*-- 取得選取的內容 --*/
        string tableName; //問事表名稱
        string content; //紀錄事項
        string remarks; //備註

        FormFunction formFunction = new FormFunction();

        public int logCount{get; set;} //幾筆紀錄


        public PersonalHistoriesForm()
        {
            InitializeComponent();
        }

        /*--- 建構子2
         *-參數1 :聯絡編號
         *-參數2 :姓名
         *------------------*/
        public PersonalHistoriesForm(string contactNum, string name)
        {
            InitializeComponent();
            this.contactNum = contactNum;
            this.name = name;
            lblName.Text = name; //視窗標題
        }

        /*--- 建構子3
         *-說明: 由問世事表視窗開啟
         *-參數1 :聯絡編號
         *-參數2 :姓名
         *-參數3 :表示由問世事表視窗開啟(無任何功能)
         *-------------------------------------------------*/
        public PersonalHistoriesForm(string contactNum, string name, bool isOpFronTableForm)
        {
            InitializeComponent();
            this.contactNum = contactNum;
            this.name = name;
            lblName.Text = name; //視窗標題
            btnDelete.Visible = false; //隱藏刪除按鈕
        }

        private void PersonalHistoriesForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this);
            ShowAllAskingLog(contactNum);
        }

        /*--- 視窗拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }


        /*------ 檢視表『historiesView』
         *-『historiesView_ColumnHeaderMouseClick』:點選標題列不選取資料列
         *-『historiesView_CellClick』:取得資料列的資料
         *---------------------------------------------------------------------*/

        /*--- 點選標題列不選取資料列 ---*/
        private void historiesView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            historiesView.ClearSelection();
        }

        /*--- 取得資料列的資料 ---*/
        private void historiesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*- 取得問事表名稱 -*/
                tableName = historiesView.Rows[e.RowIndex].Cells[1].Value.ToString();
                /*- 取得紀錄事項 -*/
                content = historiesView.Rows[e.RowIndex].Cells[2].Value.ToString();
                /*- 取得備註 -*/
                remarks = historiesView.Rows[e.RowIndex].Cells[3].Value.ToString();

                /*- 啟用按鈕 -*/
                OftenUseColor.ButtonEnable(btnCompleteContent);
                OftenUseColor.ButtonEnable(btnDelete);
            }
        }


        /*------ Button
         *-『btnClose_Click』:關閉視窗
         *-『btnCompleteContent_Click』:顯示完整內容
         *-『btnDelete_Click』:刪除選取的問事記錄
         *-----------------------------------------------*/
        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            logCount = historiesView.Rows.Count; //總共幾筆紀錄
            this.Close();
        }

        /*--- 顯示完整內容 ---*/
        private void btnCompleteContent_Click(object sender, EventArgs e)
        {
            formFunction.OpenFocusForm(new HistoriesTools.CompleteHistoryForm(name, tableName, content, remarks));
        }

        /*--- 刪除選取的問事記錄 ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("確認要刪除該筆紀錄嗎?");
            formFunction.OpenFocusForm(confirmForm);

            /*-- 確認要刪除 --*/
            if (confirmForm.isOk)
            {
                DeleteLog(contactNum, tableName);
                ShowAllAskingLog(contactNum); //顯示DataGridView的內容

                /*- 禁用按鈕 -*/
                OftenUseColor.ButtonDisable(btnCompleteContent);
                OftenUseColor.ButtonDisable(btnDelete);
            }
        }


        /*------ DataBase 資料操作
         *-『ShowAllAskingLog』:顯示全部問事記錄
         *-『DeleteLog』:刪除選取的紀錄
         *----------------------------------------*/

        /*--- 顯示全部問事記錄 
         *-參數: 聯絡編號
         *--------------------------------*/
        private void ShowAllAskingLog(string contactNum)
        {
            historiesView.Rows.Clear(); //清除檢視表資料
            int number = 0; //序號

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 問事表名稱, 紀錄事項, 備註 " +
                                "from Asking_Histories " +
                                "where 聯絡編號=\'" + contactNum +"\'";

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
            historiesView.ClearSelection(); //取消預選
        }

        /*--- 刪除選取的紀錄
         *-參數1: 聯絡編號
         *-參數2: 問事表名稱
         *--------------------------------*/
        private void DeleteLog(string contactNum, string tableName)
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
    }
}
