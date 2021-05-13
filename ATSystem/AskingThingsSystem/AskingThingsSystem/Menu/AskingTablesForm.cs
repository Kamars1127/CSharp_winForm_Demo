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
using AskingThingsSystem.Message;
using AskingThingsSystem.TableTools;
using System.Collections;
using XanderUI;
using System.Data.SqlClient;

namespace AskingThingsSystem.Menu
{
    public partial class AskingTablesForm : Form
    {
        private AskingTable table;
        private IconButton tableLabel; //問事表標籤
        private bool isSaved_askingTable = false; //是否儲存問事表，預設: 否
        private int signUpTotal = 0; //總報名人數
        private int askingNumber = 0;
        FormFunction formFun = new FormFunction();
        FormFunction formFun2 = new FormFunction();
        /*-- 儲存個人報名資訊 ----------------------------------
         * 
         *- string[0]: 聯絡編號
         *- string[1]: 姓名
         *- string[2]: 備註
         * -------------------------------------------------------*/
        List<string[]> personalSignUp_Info = new List<string[]>();
        List<string[]> searched_Info = new List<string[]>(); //暫存搜尋姓名的報名資訊
        /*-- 儲存問事完的個人聯絡編號及姓名 ----------------------
         * 
         *- string[0]: 聯絡編號
         *- string[1]: 姓名
         * -------------------------------------------------------*/
        List<string[]> personalInfo_list = new List<string[]>();
        /*-- 報名列區 --*/
        int index_signUpList;//選取報名表的索引
        string contactNum_signUpList; //選取報名表的聯絡編號
        string remark_signUpList; //選取報名表的備註
        bool isSearchOn; //是否為搜尋姓名中
        /*-- 問事表區 --*/
        int index_askingTable; //選取問事表的索引
        string contactNum_askingTable; //選取問事表的聯絡編號


        /*------ 建構子 ------------------------------------------------------------------
         * 
         *- AskingTablesForm()
         *- AskingTablesForm(IconButton tableLabel, AskingTable table)
         *- AskingTablesForm(IconButton tableLabel, AskingTable table, string tableName)
         *--------------------------------------------------------------------------------*/

        public AskingTablesForm()
        {
            InitializeComponent();
        }

        /*--- 建立新表 ------------------
         * 
         *- 參數1: 問事表標籤
         *- 參數2: AskingTable物件
         *-----------------------------*/
        public AskingTablesForm(IconButton tableLabel, AskingTable table)
        {
            InitializeComponent();
            InitAskingTableView();
            this.tableLabel = tableLabel;
            this.table = table;

            /*- 設定報名列的輸入框圓角 -*/
            RadiusTool rt = new RadiusTool();
            rt.SetControlRadius(panInput, 45);
        }

        /*--- 開啟舊表 -----------------
         * 
         *- 參數1: 問事表標籤
         *- 參數2: AskingTable物件
         *- 參數3: 問事表名稱
         *-----------------------------*/
        public AskingTablesForm(IconButton tableLabel, AskingTable table, string tableName)
        {
            InitializeComponent();
            InitAskingTableView();
            this.tableLabel = tableLabel;
            this.table = table;
            isSaved_askingTable = true; //問事表資料已儲存

            /*- 設定報名列的輸入框圓角 -*/
            RadiusTool rt = new RadiusTool();
            rt.SetControlRadius(panInput, 45);

            ShowAskingContents(tableName); //顯示問事資料

            /*- 顯示姓名、聯絡電話 -*/
            for(int i=0; i < personalInfo_list.Count; i++)
            {
                string contactNum = personalInfo_list[i][0]; //取得聯絡編號
                string name = ShowPersonalInfo(contactNum, i); //取得姓名
                personalInfo_list[i][1] = name;
            }
        }


        /*------ 檢視表 ---------------------------------------------
         *
         *--- 報名列
         *-『nameView_CellClick』: 取得選取列的索引、姓名、啟用報名列按鈕
         *
         *--- 問事表區
         *-『askingTableView_CellClick』: 取得問事表該列的聯絡編號
         *--------------------------------------------------------------*/

        /*--- 取得選取列的索引、姓名、啟用報名列按鈕 ---*/
        private void nameView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index_signUpList = e.RowIndex; // 選取資料列的索引
                string selectedName = nameView.Rows[e.RowIndex].Cells[1].Value.ToString(); //取得姓名

                /*-- 判斷資料表上的資訊是『搜尋結果』還是『完整報名』
                 * 
                 *- if: 搜尋結果
                 *- else: 完整報名
                 *-----------------------------------------------------*/
                if (isSearchOn)
                {
                    /*- 嚴謹確認選取姓名的聯絡編號 -*/
                    if (searched_Info[e.RowIndex].Contains(selectedName))
                    {
                        contactNum_signUpList = searched_Info[e.RowIndex][0]; //取得聯絡編號
                        remark_signUpList = searched_Info[e.RowIndex][2]; //取得備註
                    }
                }
                else
                {
                    /*- 嚴謹確認選取姓名的聯絡編號 -*/
                    if (personalSignUp_Info[e.RowIndex].Contains(selectedName))
                    {
                        contactNum_signUpList = personalSignUp_Info[e.RowIndex][0]; //取得聯絡編號
                        remark_signUpList = personalSignUp_Info[e.RowIndex][2]; //取得備註
                    }
                }

                /*- 啟用報名列按鈕 -*/
                EnableBtn_signUpList(btnInfoView);
                EnableBtn_signUpList(btnAsking);
                EnableBtn_signUpList(btnRemoveName);
            }
        }

        private void askingTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index_askingTable = e.RowIndex;
                string selectedName = askingTableView.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (personalInfo_list[e.RowIndex].Contains(selectedName))
                {
                    contactNum_askingTable = personalInfo_list[e.RowIndex][0];
                }

                /*- 啟用問事表區按鈕 -*/
                EnableBtn_askingTable();
            }
        }


        /*------ Buttons Event ---------------------------
         *
         *--- 視窗
         *-『btnMinimize_Click』: 縮小問事表視窗
         *-『btnClose_Click』: 關閉視窗
         *
         *--- 工具列 
         *-『btnSignUp_Click』: 報名
         *-『btnSignUpList_Click』: 顯示或隱藏報名列
         *-『btnExportToPDF_Click』: 匯出PDF
         *
         *--- 報名列區
         *-『btnUpdate_Click』: 重整報名列的姓名
         *-『btnDeleteName_Click』: 從報名列刪除指定的姓名
         *-『btnInfoView_Click』: 查看個人報名資訊
         *-『btnAsking_Click』: 新增問事內容
         *
         *--- 問事表區
         *-『btnEdit_Click』: 編輯問事內容
         *-『btnDeleteLog_Click』: 刪除該筆問事資料
         *---------------------------------------------------------------------*/

        /*--- 縮小問事表視窗 ---*/
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table.MinimizeTable(tableLabel);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            table.CloseTable(tableLabel);
            this.Close();
        }

        /*--- 報名 ---*/
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new TableTools.SignUpForm(this));
        }

        /*--- 顯示或隱藏報名列 ---*/
        private void btnSignUpList_Click(object sender, EventArgs e)
        {
            if (panSignUPList.Visible == false)
            {
                btnSignUpList.Text = "關閉報名列";
                panSignUPList.Visible = true;
            }
            else if (panSignUPList.Visible == true)
            {
                btnSignUpList.Text = "顯示報名列";
                panSignUPList.Visible = false;
            }
        }

        /*--- 匯出PDF ---*/
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            ExportPDF exportPDF = new ExportPDF();

            string placeName = table.placeName;
            int year = table.date.Year;
            year -= 1911; //換算成民國
            string datrStr = table.date.ToString(year + " 年 MM 月 dd 日");
            string fileName = datrStr + " 問事報名資料表 " + placeName;
            //Console.WriteLine(table.placeName);
            //Console.WriteLine(fileName);

            exportPDF.GeneratePDF(fileName, askingTableView);
        }

        /*--- 重整報名列的姓名 ---*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            nameView.Focus();
            ShowAllName();
        }

        /*--- 從報名列刪除指定的姓名 ---*/
        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            string name = nameView.Rows[index_signUpList].Cells[1].Value.ToString();

            ConfirmForm confirmForm = new ConfirmForm("確認要刪除 \"" + name + "\" 嗎?");
            formFun.OpenFocusForm(confirmForm);

            /*--- 確認要刪除 ---*/
            if (confirmForm.isOk)
                RemoveName(true);
        }

        /*--- 查看個人報名資訊 ---*/
        private void btnInfoView_Click(object sender, EventArgs e)
        {
            formFun.OpenAloneForm(new PersonalSignUpInfo(contactNum_signUpList, remark_signUpList));
        }

        /*--- 新增問事內容 ---*/
        private void btnAsking_Click(object sender, EventArgs e)
        {
            formFun2.OpenAloneForm(new AddAskingContentForm(contactNum_signUpList, remark_signUpList, this));
        }


        /*--- 編輯問事內容 ---*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> askingData = new List<string>();
            askingData.Add(contactNum_askingTable); //聯絡編號
            /*- 姓名 -*/
            askingData.Add(askingTableView.Rows[index_askingTable].Cells[1].Value.ToString());
            /*- 紀錄事項 -*/
            askingData.Add(askingTableView.Rows[index_askingTable].Cells[2].Value.ToString());
            /*- 聯絡電話 -*/
            askingData.Add(askingTableView.Rows[index_askingTable].Cells[3].Value.ToString());
            /*- 備註 -*/
            askingData.Add(askingTableView.Rows[index_askingTable].Cells[4].Value.ToString());

            formFun.OpenFocusForm(new AddAskingContentForm(askingData, this));
        }

        /*--- 刪除該筆問事資料 ---*/
        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm = new ConfirmForm("確認要刪除嗎?");
            formFun.OpenFocusForm(confirm);

            if (confirm.isOk)
            {
                /*- 從問事表中刪除 -*/
                askingTableView.Rows.RemoveAt(index_askingTable);
                int rowsCount = askingTableView.Rows.Count;

                for (int i = 0; i < rowsCount; i++)
                {
                    askingTableView.Rows[i].Cells[0].Value = i + 1;
                }

                askingTableView.ClearSelection(); // 取消預選

                /*- 把指定 personalInfo_list 的資料刪除-*/
                string contentNum = personalInfo_list[index_askingTable][0];
                if (contentNum == contactNum_askingTable)
                    personalInfo_list.RemoveAt(index_askingTable);

                /*- 從資料庫中刪除 -*/
                DeleteHistoriesData(contactNum_askingTable, tableLabel.Text);

                /*- 禁用問事表區按鈕 -*/
                DisableBtn_askingTable();
            }
        }


        /*------ TextBox Event ----------------------
        * 
        *-『txtInput_Enter』: 輸入狀態
        *-『txtInput_Leave』: 提示狀態
        *-『txtInput_KeyPress』: 限制輸入
        *-『txtInput_KeyUp』: 即時搜尋輸入的姓名
        *-------------------------------------------*/
        /*--- 輸入狀態 ---*/
        private void txtInput_Enter(object sender, EventArgs e)
        {
            OftenUseColor.SetInputTextStatus(txtInput);
        }

        /*--- 提示狀態 ---*/
        private void txtInput_Leave(object sender, EventArgs e)
        {
            OftenUseColor.SetPromptTextStatus(txtInput, "輸入姓名");
        }

        /*--- 限制輸入 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 即時搜尋輸入的姓名 ---*/
        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            string inStr = txtInput.Text.Trim();

            if (inStr != "")
                SearchName(inStr); //搜尋輸入的姓名
        }

        
        /*------ 其他 Method ------------------------------------------------
         *
         *-『InitAskingTableView』: 初始化 askingTableView 欄位文字對齊位置
         *-『EnableBtn_signUpList』: 啟用按鈕『報名列』
         *-『DisableBtn_signUpList』: 禁用按鈕『報名列』
         *-『EnableBtn_askingTable』: 啟用按鈕『問事區』
         *-『DisableBtn_askingTable』: 禁用按鈕『問事區』
         *------------------------------------------------------------------*/

        /*--- 初始化 askingTableView 欄位文字對齊位置----*/
        private void InitAskingTableView()
        {
            /*- 紀錄事項 -*/
            askingTableView.Columns["colTableContent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            /*- 備註 -*/
            askingTableView.Columns["colTableRemarks"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        /*--- 啟用按鈕『報名列』---*/
        private void EnableBtn_signUpList(XUIButton btn)
        {
            btn.Enabled = true;
            btn.BackgroundColor = Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            btn.TextColor = Color.White;
        }

        /*--- 禁用按鈕『報名列』---*/
        private void DisableBtn_signUpList(XUIButton btn)
        {
            btn.Enabled = false;
            btn.BackgroundColor = Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            btn.TextColor = Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(62)))), ((int)(((byte)(42)))));
        }

        /*--- 啟用按鈕『問事區』 ---*/
        private void EnableBtn_askingTable()
        {
            OftenUseColor.ButtonEnable(btnEdit);
            OftenUseColor.ButtonEnable(btnDeleteLog);
        }

        /*--- 禁用按鈕 『問事區』 ---*/
        private void DisableBtn_askingTable()
        {
            OftenUseColor.ButtonDisable(btnEdit);
            OftenUseColor.ButtonDisable(btnDeleteLog);
        }



        /*------ Data 操作 -----------------------------------------
         *
         *-『AddNameTo_SignUpList』:加報名資訊到報名列
         *-『ShowAllName』: 顯示全部報名姓名
         *-『SearchName』: 搜尋輸入的姓名
         *-『RemoveName』: 刪除報名資訊
         *-『AddAskingData』: 把問事資料加到問事表上
         *-『AddAskingDataToDB』: 把問事資料加到資料庫
         *-『GetPlaceCode』: 取得問事地點代碼
         *-『ShowAskingContents』: 從資料庫中撈出問事內容
         *-『ShowPersonalInfo』: 從資料庫中撈出問事人的個資
         *-『ModifyAskingTableData』: 更新到問事表上的資料
         *-『ModifyHistoriesData』: 更新資料庫的問事資料
         *-『DeleteHistoriesData』: 刪除資料庫的問事資料
         *--------------------------------------------------------*/

        /*--- 加報名資訊到報名列 -------------
         * 
         *-參數1: 聯絡編號
         *-參數2: 姓名
         *-參數3: 報名備註
         *----------------------------------*/
        public void AddNameTo_SignUpList(string contactNum, string name, string remark)
        {
            /*-- 是否有重複報名 --*/
            foreach (var s in personalSignUp_Info)
            {
                if (s.Contains(contactNum))
                {
                    formFun.OpenFocusForm(new WarningForm(name + "已報名"));
                    return;
                }
            }

            /*-- 是否有重複報名 --*/
            foreach (var s in personalInfo_list)
            {
                if (s.Contains(contactNum))
                {
                    formFun.OpenFocusForm(new WarningForm(name + "已問過事"));
                    return;
                }
            }

            personalSignUp_Info.Add(new string[] { contactNum, name, remark });
            signUpTotal += 1; //報名數加1
            ShowAllName(); //顯示姓名到報名表中

            /*-- 開啟報名列 --*/
            if (panSignUPList.Visible == false)
            {
                btnSignUpList.Text = "關閉報名列";
                panSignUPList.Visible = true;
            }
        }

        /*--- 顯示全部報名姓名 ---*/
        private void ShowAllName()
        {
            nameView.Rows.Clear(); //清空資料列
            isSearchOn = false; //非搜尋姓名中
            int count = personalSignUp_Info.Count; //等待人數
            lblWaitedCount.Text = count.ToString(); //顯示等待人數
            lblSignUpCount.Text = signUpTotal.ToString(); //顯示總報名人數

            for (int i = 0; i < count; i++)
                nameView.Rows.Add(i + 1, personalSignUp_Info[i][1]);

            nameView.ClearSelection(); //取消預選
            /*- 禁用報名列按鈕 -*/
            DisableBtn_signUpList(btnAsking);
            DisableBtn_signUpList(btnInfoView);
            DisableBtn_signUpList(btnRemoveName);
        }

        /*--- 搜尋輸入的姓名 ---*/
        private void SearchName(string name)
        {
            nameView.Rows.Clear(); //清空姓名檢視表
            searched_Info.Clear(); //清空暫存資料
            int number = 0; //序號
            bool isExist = false; //輸入的姓名是否在報名列中
            isSearchOn = true; //搜尋姓名中 

            /*- 個人報名資訊中是否有輸入的姓名，有的話就顯示 -*/
            foreach (var s in personalSignUp_Info)
            {
                if (s[1] == name)
                {
                    isExist = true;
                    searched_Info.Add(new string[] { s[0], s[1], s[2] });
                    number++;
                    nameView.Rows.Add(number, s[1]);
                }
            }

            /*- 個人報名資訊中沒有輸入的姓名 -*/
            if (!isExist)
            {
                nameView.Focus();
                ShowAllName(); //顯示全部報名姓名
                return;
            }

            nameView.ClearSelection(); //取消預選
            /*- 禁用報名列按鈕 -*/
            DisableBtn_signUpList(btnAsking);
            DisableBtn_signUpList(btnInfoView);
            DisableBtn_signUpList(btnRemoveName);
        }

        /*--- 刪除報名資訊 -----------------
         * 
         *- 參數1: 是否為單純刪除報名
         *--------------------------------*/
        private void RemoveName(bool isDelete)
        {
            int num = 0;

            foreach(var s in personalSignUp_Info)
            {
                if (s[0] == contactNum_signUpList)
                {
                    personalSignUp_Info.RemoveAt(num);
                    break;
                }
                num++;
            }

            /*- 單純刪除報名 -*/
            if(isDelete)
                signUpTotal -= 1; //總報名人數減1

            ShowAllName(); //更新資料表
        }

        /*--- 把問事資料加到問事表上 -------------------------------
         * 
         *- 參數1: 聯絡編號
         *- 參數2: 問事資料(0:姓名;1:紀錄事項;2:聯絡電話;3:備註)
         *--------------------------------------------------------*/
        public void AddAskingData(string contactNum, List<string> data)
        {
            askingNumber += 1; //問事表序號
            int number = personalInfo_list.Count + 1;
            askingTableView.Rows.Add(number, data[0], data[1], data[2], data[3]);
            askingTableView.ClearSelection(); //取消預選
            RemoveName(false);//從報名列刪除
            /* 把聯絡編號、姓名加到 personalInfo_list */
            personalInfo_list.Add(new string[] { contactNum, data[0] });
        }

        /*--- 把問事資料加到資料庫 --------------------------------------
         *
         *- 參數1: 聯絡編號
         *- 參數2: 問事資料(0:姓名;1:紀錄事項;2:聯絡電話;3:備註)
         *--------------------------------------------------------------*/
        public void AddAskingDataToDB(string contactNum, List<string> data)
        {
            /*-- 是否已把問事表加到DB --*/
            if (!isSaved_askingTable)
            {
                AddAskingTableToDB();
            }

            /*-- 把問事資料加到資料庫 --*/
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "Insert into Asking_Histories(聯絡編號, 問事表名稱, 問事序號, 紀錄事項, 備註) " +
                                "values(@contactNum, @tableName, @number, @content, @remark)";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@contactNum", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@tableName", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@content", SqlDbType.NText));
                cmd.Parameters.Add(new SqlParameter("@remark", SqlDbType.NText));
                cmd.Parameters["@contactNum"].Value = contactNum;
                cmd.Parameters["@tableName"].Value = tableLabel.Text;
                cmd.Parameters["@number"].Value = askingNumber;
                cmd.Parameters["@content"].Value = data[1];
                cmd.Parameters["@remark"].Value = data[3];
                cmd.ExecuteNonQuery();
            }
        }

        /*--- 把問事表加到資料庫 ---*/
        private void AddAskingTableToDB()
        {
            string placeCode = GetPlaceCode(table.placeName); //取得地點代碼

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "Insert into Asking_Tables(問事表名稱, 地點編號, 問事日期) " +
                                "values(@tableName, @placeNum, @date)";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@tableName", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@placeNum", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime));
                cmd.Parameters["@tableName"].Value = tableLabel.Text;
                cmd.Parameters["@placeNum"].Value = placeCode;
                cmd.Parameters["@date"].Value = table.date;
                cmd.ExecuteNonQuery();
                isSaved_askingTable = true;
            }
        }

        /*--- 取得問事地點代碼 ---*/
        private string GetPlaceCode(string placeName)
        {
            string placeCode="";

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點編號 " +
                                "from Asking_Place " +
                                "where 地點名稱=N\'" + placeName + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
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

        /*--- 從資料庫中撈出問事內容 
         * 
         *- 參數: 問事表名稱
         *-------------------------*/
        private void ShowAskingContents(string tableName)
        {
            int number = 0;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 聯絡編號, 紀錄事項, 備註, 問事序號 " +
                                "from Asking_Histories " +
                                "where 問事表名稱 =N\'" + tableName + "\' " +
                                "order by 問事序號 ASC";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    number++;
                    askingTableView.Rows.Add(number, "", dr["紀錄事項"], "", dr["備註"]);

                    personalInfo_list.Add(new string[] { dr["聯絡編號"].ToString(), ""});
                    askingNumber = (int)dr["問事序號"]; //最後的問事序號
                }

                dr.Close();
            }
        }

        /*--- 從資料庫中撈出問事人的個資
         * 
         *- 參數1: 聯絡編號
         *- 參數2: 問事序號
         *------------------------------*/
        private string ShowPersonalInfo(string contactNum, int askingNumber)
        {
            string name = "";

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 姓名, 聯絡電話 " +
                                "from Personal_Info " +
                                "where 聯絡編號=\'" + contactNum + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    askingTableView.Rows[askingNumber].Cells[1].Value = dr["姓名"];
                    askingTableView.Rows[askingNumber].Cells[3].Value = dr["聯絡電話"];

                    name = dr["姓名"].ToString();
                }

                dr.Close();
            }
            askingTableView.ClearSelection(); //取消預選
            return name;
        }

        /*--- 更新到問事表上的資料 ---*/
        public void ModifyAskingTableData(string content, string remark)
        {
            askingTableView.Rows[index_askingTable].Cells[2].Value = content;
            askingTableView.Rows[index_askingTable].Cells[4].Value = remark;
        }

        /*--- 更新資料庫的問事資料 ---*/
        public void ModifyHistoriesData(string contactNum, string content, string remark)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "update Asking_Histories " +
                                "set 紀錄事項=@content, 備註=@remark " +
                                "where 聯絡編號=@contactNum " +
                                "and 問事表名稱=@tableName";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@content", SqlDbType.NText));
                cmd.Parameters.Add(new SqlParameter("@remark", SqlDbType.NText));
                cmd.Parameters.Add(new SqlParameter("@contactNum", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@tableName", SqlDbType.NVarChar));
                cmd.Parameters["@content"].Value = content;
                cmd.Parameters["@remark"].Value = remark;
                cmd.Parameters["@contactNum"].Value = contactNum;
                cmd.Parameters["@tableName"].Value = tableLabel.Text;
                cmd.ExecuteNonQuery();
            }
        }

        /*--- 刪除資料庫的問事資料 ---*/
        private void DeleteHistoriesData(string contactNum, string tableName)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Histories " +
                              "where 聯絡編號 = @contactNum " +
                              "and 問事表名稱 = @tableName";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cmd.Parameters.Add(new SqlParameter("@contactNum", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@tableName", SqlDbType.NVarChar));
                cmd.Parameters["@contactNum"].Value = contactNum;
                cmd.Parameters["@tableName"].Value = tableName;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
