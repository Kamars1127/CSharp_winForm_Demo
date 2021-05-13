using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskingThingsSystem.Function;
using AskingThingsSystem.Menu;
using AskingThingsSystem.Message;

namespace AskingThingsSystem.HomeTools
{
    public partial class BrowseTablesForm : Form
    {
        AskingTable askingTable;


        public BrowseTablesForm()
        {
            InitializeComponent();
        }

        public BrowseTablesForm(AskingTable askingTable)
        {
            InitializeComponent();
            this.askingTable = askingTable;

            /*--- 設定元件的Radius ---*/
            RadiusTool rt = new RadiusTool();
            rt.SetControlRadius(panInput, 50);

            /*--- 顯示全部問事表 ---*/
            ShowAllTables();
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*------ TextBox 『txtInput』
         *-『txtInput_Enter』:輸入狀態
         *-『txtInput_Leave』:提示狀態
         *-『txtInput_KeyPress』:限制輸入
         * -------------------------------*/

        /*--- 輸入狀態 ---*/
        private void txtInput_Enter(object sender, EventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏『必須輸入內容，才能做查詢』
            OftenUseColor.SetInputTextStatus(txtInput); //設定輸入字的顏色
        }

        /*--- 提示狀態 ---*/
        private void txtInput_Leave(object sender, EventArgs e)
        {
            OftenUseColor.SetPromptTextStatus(txtInput, "輸入關鍵字");
        }

        /*--- 只能輸入字母、數字、控制鍵、空白鍵 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏『必須輸入內容，才能做查詢』

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                FormFunction formFun = new FormFunction();
                formFun.OpenFocusForm(new WarningForm("只能輸入\"字母\"或\"數字\""));
                e.Handled = true;
            }
        }

        /*------ Button
         *-『btnShowAll』:顯示全部問事表
         *-『btnSearch』:指定查詢的問事表
         * -------------------------------------*/

        /*--- 顯示全部問事表 ---*/
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllTables(); 
        }

        /*--- 指定查詢的問事表 ---*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string content = txtInput.Text.Trim(); //取得去頭尾空白的輸入內容

            if (content == "" || content == "輸入關鍵字")
            {
                FormFunction formFun = new FormFunction();
                inWarningMsg.Visible = true; //顯示『必須輸入內容，才能做查詢』
                return;
            }

            DateTime date;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select Asking_Tables.問事表名稱, Asking_Tables.問事日期, Asking_Place.地點名稱 " +
                                "from Asking_Tables " +
                                "inner join Asking_Place " +
                                "on Asking_Tables.地點編號=Asking_Place.地點編號 " +
                                "where Asking_Tables.問事表名稱 like N\'%" + content + "%\'";

                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                /*-- 是否有符合的資料存在 --*/
                if (dr.HasRows)
                {
                    tablesView.Rows.Clear(); //清空檢視表的資料

                    while (dr.Read())
                    {
                        date = Convert.ToDateTime(dr["問事日期"]);
                        string dateStr = date.ToString("yyyy年 MM月 dd日");
                        tablesView.Rows.Add(dr["問事表名稱"], dateStr, dr["地點名稱"]);
                    }

                    tablesView.Focus();
                }
                else
                {
                    dr.Close();
                    FormFunction formFun = new FormFunction();
                    formFun.OpenFocusForm(new WarningForm("查無所輸入的內容"));
                    tablesView.Focus();
                    return;
                }
            }

            tablesView.ClearSelection(); //清除預選
        }


        /*------ DataBase 資料操作
         *-『ShowAllTables』:顯示全部問事表
         * --------------------------------------*/

        /*--- 顯示全部問事表 ---*/
        private void ShowAllTables()
        {
            DateTime date;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select Asking_Tables.問事表名稱, Asking_Tables.問事日期, Asking_Place.地點名稱 " +
                                "from Asking_Tables " +
                                "inner join Asking_Place " +
                                "on Asking_Tables.地點編號 = Asking_Place.地點編號";

                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    tablesView.Rows.Clear();

                    while (dr.Read())
                    {
                        date = Convert.ToDateTime(dr["問事日期"]);
                        string dateStr = date.ToString("yyyy年 MM月 dd日");
                        tablesView.Rows.Add(dr["問事表名稱"],dateStr, dr["地點名稱"]);
                    }
                }

                dr.Close();
            }

            tablesView.ClearSelection(); //清除預選
        }


        /*------ DataGridView 『tableView』
         *-『tablesView_CellClic』:點擊該行資料，開啟編輯工具
         *-『tablesView_ColumnHeaderMouseClick』:點擊標題欄時，不選資料列
         *-----------------------------------------------------------------*/
        private void tablesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                string tableName = tablesView.Rows[rowIndex].Cells[0].Value.ToString();
                FormFunction formFun = new FormFunction();
                BrowseTablesEdit tablesEdit = new BrowseTablesEdit(askingTable, tableName);
                formFun.OpenFocusForm(tablesEdit);

                /*- 刪除問事表及其內容後，更新畫面顯示 -*/
                if (tablesEdit.isDeleted)
                    ShowAllTables();
            }
        }

        /*--- 點擊標題欄時，不選資料列 ---*/
        private void tablesView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tablesView.ClearSelection();
        }
    }
}
