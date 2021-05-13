using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskingThingsSystem.Function;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.IO;

namespace AskingThingsSystem.HomeTools
{
    public partial class BrowseTablesEdit : Form
    {
        AskingTable askingTable;

        /*-- 暫存問事表的資料 
         *- askingDT[0] : 姓名
         *- askingDT[1] : 紀錄事項
         *- askingDT[2] : 電話
         *- askingDT[3] : 備註
         *------------------------------*/
        DataTable askingDT = new DataTable();

        public bool isDeleted{get;set;} //是否執行刪除

        public BrowseTablesEdit()
        {
            InitializeComponent();
        }

        public BrowseTablesEdit(AskingTable askingTable, String tableName)
        {
            InitializeComponent();
            this.formTitle.Text = tableName;
            this.askingTable = askingTable;

            //開啟位置為滑鼠所在位置
            this.Location = new System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*------ 4個功能
         *-『btnOpen_Click』:開啟舊問事表
         *-『btnDelete_Click』:刪除整個問事表(包含問事紀錄)
         *-『btnExportPDF_Click』:匯出PDF
         *-『』:
         *-------------------------*/
        /*--- 開啟舊問事表 ---*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            SetDateAndPlace(formTitle.Text);

            askingTable.CreateLabelandTable(formTitle.Text, true);
            this.Close(); //關閉 BrowseTablesEdit
            askingTable.formFun.CloseMenu(); // 關閉HomeForm
        }

        /*--- 刪除整個問事表(包含問事紀錄) ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*- 確認是否要刪除 -*/
            Message.ConfirmForm confirm = new Message.ConfirmForm("該表的全部問事紀錄也會一並刪除哦");
            FormFunction form = new FormFunction();
            form.OpenFocusForm(confirm);

            /*- 確認要刪除 -*/
            if (confirm.isOk)
            {
                isDeleted = true;
                DeleteAllAskingHistories(formTitle.Text); //刪除全部紀錄
                DeleteAskingTable(formTitle.Text); //刪除問事表
                this.Close();
            }
        }

        /*--- 匯出PDF ---*/
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            /*-- 設定 AskingTable 的日期和地點  --*/
            SetDateAndPlace(formTitle.Text);
            /*-- 取得問事資料，並加到DataTable中 --*/
            GetAskingTableData(formTitle.Text);

            /*-- 存檔 & 匯出PDF --*/
            ExportPDF exportPDF = new ExportPDF();

            string placeName = askingTable.placeName; //問事地點
            /*- 西元轉民國 -*/
            int year = askingTable.date.Year;
            year -= 1911; 
            string datrStr = askingTable.date.ToString(year + " 年 MM 月 dd 日");
            /*- 存檔預設檔名 -*/
            string fileName = datrStr + " 問事報名資料表 " + placeName;
            //Console.WriteLine(askingTable.placeName);
            //Console.WriteLine(fileName);
            exportPDF.GeneratePDF(fileName, askingDT);

            this.Close();

            /*
            foreach (DataColumn c in askingDT.Columns)
            {
                Console.Write(c+"\t");
            }
            Console.WriteLine("輛:"+askingDT.Rows.Count);
            for (int i=0; i< askingDT.Rows.Count; i++)
            {
                for(int j = 0; j < askingDT.Columns.Count; j++)
                {
                    Console.Write(askingDT.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }*/
        }

        /*------ Database
         *-『DeleteAllAskingHistories』: 刪除問事表的全部紀錄
         *-『DeleteAskingTable』: 刪除問事表
         *-『SetDateAndPlace』: 設定 AskingTable 的日期和地點
         *-『GetAskingTableData』: 取得問事資料，並加到DataTable中
         *-『GetPeraonalInfo』: 取得姓名和電話
         *--------------------------------------------------------------*/

        /*--- 刪除問事表的全部紀錄
         *- 參數: 問事表名稱
         *------------------------------*/
        private void DeleteAllAskingHistories(string tableName)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Histories " +
                               "where 問事表名稱=@name";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters["@name"].Value = tableName;
                cmd.ExecuteNonQuery();
            }
        }

        /*--- 刪除問事表
         *- 參數: 問事表名稱
         *------------------------------*/
        private void DeleteAskingTable(string tableName)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Tables " +
                                "where 問事表名稱=@name";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters["@name"].Value = tableName;
                cmd.ExecuteNonQuery();
            }
        }

        /*--- 設定 AskingTable 的日期和地點
         *- 參數: 問事表名稱
         *- 說明: 取得問事表的日期和地點，給AskingTable物件
         *---------------------------------------------------------*/
        private void SetDateAndPlace(string tableName)
        {
            string placeCode="";
            bool isExistData=false; //是否有找到資料

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                /*- 先取得問事表的地點編號和問事日期 -*/
                string sqlStr = "select 地點編號, 問事日期 " +
                              "from Asking_Tables " +
                              "where 問事表名稱 = N\'" + tableName + "\'";
               

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    isExistData = true; //有找到資料
                    placeCode = dr["地點編號"].ToString();
                    askingTable.date = Convert.ToDateTime(dr["問事日期"]);
                }
                dr.Close();

                /*-- 有找到資料，再找出與地點編號對應的地點名稱 --*/
                if (isExistData)
                {
                    string sqlStr2 = "select 地點名稱 " +
                                "from Asking_Place " +
                                "where 地點編號=\'" + placeCode + "\'";

                    SqlCommand cmd2 = new SqlCommand(sqlStr2, cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    while (dr2.Read())
                    {
                        askingTable.placeName = dr2["地點名稱"].ToString();
                    }
                    dr2.Close();
                }
            }
        }

        /*--- 取得問事資料，並加到DataTable中 
         *- 參數: 問事表名稱
         *- 說明: 把取得問事表的全部資料加到DataTable物件中，以便於匯出PDF
         *-----------------------------------------------------------------------*/
        private void GetAskingTableData(string tableName)
        {
            askingDT.Columns.Add(new DataColumn("姓名"));
            askingDT.Columns.Add(new DataColumn("紀錄事項"));
            askingDT.Columns.Add(new DataColumn("聯絡電話"));
            askingDT.Columns.Add(new DataColumn("備註"));
            
            List<string> personal_info;
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 聯絡編號, 紀錄事項, 備註 " +
                                "from Asking_Histories " +
                                "where 問事表名稱 =N\'" + tableName + "\' " +
                                "order by 問事序號 ASC";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DataRow rows = askingDT.NewRow();
                    personal_info = GetPeraonalInfo(dr["聯絡編號"].ToString()); //取得姓名和電話
                    rows["姓名"] = personal_info[0];
                    rows["紀錄事項"] = dr["紀錄事項"];
                    rows["聯絡電話"] = personal_info[1];
                    rows["備註"] = dr["備註"];
                    askingDT.Rows.Add(rows);
                }
                dr.Close();
            }
        }

        /*--- 取得姓名和電話
         *- 參數 : 聯絡編號
         *--------------------------*/
        private List<string> GetPeraonalInfo(string contactNum)
        {
            List<string> list = new List<string>(); //暫存要回傳的資料
            
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 姓名, 聯絡電話 " +
                             "from Personal_Info " +
                             "where 聯絡編號 =\'" + contactNum + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr["姓名"].ToString());
                    list.Add(dr["聯絡電話"].ToString());
                }

                dr.Close();
            }

            return list;
        }
    }
}
