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
using FontAwesome.Sharp;
using AskingThingsSystem.Message;

namespace AskingThingsSystem.Menu
{
    public partial class ContactsForm : Form
    {
        IconButton menuBtn;
        FormFunction formFun = new FormFunction();
        List<string> contactNumList; // 儲存聯絡編號
        int selectedIndex = 0; // 選取的資料列索引
        string selectedContactNum; // 選取的聯絡編號
        string selectedName; // 選取的姓名

        public ContactsForm()
        {
            InitializeComponent();
        }

        public ContactsForm(IconButton btn)
        {
            InitializeComponent();
            menuBtn = btn;

            /*- 電話欄和備註 不能點擊排序 -*/
            colPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
            colRemarks.SortMode = DataGridViewColumnSortMode.NotSortable;
        }


        private void ContactsForm_Load(object sender, EventArgs e)
        {
            RadiusTool rt = new RadiusTool();
            rt.SetControlRadius(panInText, 50);

            ShowAllData(); //顯示全部聯絡資訊
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menuBtn.BackColor = OftenUseColor.menuOffStatusColor;
        }


        /*------ DataBase 資料操作
        *-『ShowAllData』:顯示全部資料
        *-『SearchData』:搜尋輸入的內容
        *-『DeleteContactData』:清除聯絡資料
        *-『DeleteAskingData』:清除問事資料
        *------------------------------------------*/

        /*--- 顯示全部資料 ---*/
        private void ShowAllData()
        {
            int number=0; // 序號
            DateTime date; //儲存撈出的『新增日期』
            string dateStr; //把日期轉成指定字串格式
            contactNumList = new List<string>();

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select * from Personal_Info";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                //是否有資料
                if (dr.HasRows)
                {
                    contactDataView.Rows.Clear(); //清除檢視表的資料

                    while (dr.Read())
                    {
                        number++;

                        date = Convert.ToDateTime(dr["新增日期"]);
                        dateStr = date.ToString("yyyy年 MM月 dd日");
                        contactDataView.Rows.Add(number, dr["姓名"], dr["聯絡電話"], dr["居住地"], dateStr, dr["備註"]);
                        
                        contactNumList.Add(dr["聯絡編號"].ToString());//儲存聯絡編號
                    }
                }
                dr.Close();
            }

            contactDataView.ClearSelection(); //取消預選
            DisEditBtn(); //禁用編輯按鈕
        }

        /*--- 搜尋輸入的內容 ---*/
        private bool SearchData(string searchStr)
        {
            int number = 0; // 序號
            DateTime date; //儲存撈出的『新增日期』
            string dateStr; //把日期轉成指定字串格式

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select * from Personal_Info " +
                                "where 姓名 like N\'%" + searchStr + "%\' " +
                                "or 聯絡電話 like N\'%" + searchStr + "%\' " +
                                "or 居住地 like N\'%" + searchStr + "%\' " +
                                "or 新增日期 like N\'%" + searchStr + "%\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                //是否有資料
                if (dr.HasRows)
                {
                    contactNumList = new List<string>();
                    contactDataView.Rows.Clear(); //清除檢視表資料

                    while (dr.Read())
                    {
                        number++;
                        date = Convert.ToDateTime(dr["新增日期"]);
                        dateStr = date.ToString("yyyy年 MM月 dd日");
                        contactDataView.Rows.Add(number, dr["姓名"], dr["聯絡電話"], dr["居住地"], dateStr, dr["備註"]);
                        
                        contactNumList.Add(dr["聯絡編號"].ToString()); //儲存聯絡編號
                    }

                    contactDataView.ClearSelection(); //取消預選
                    DisEditBtn(); //禁用編輯按鈕
                    return false; //有資料
                }
                else
                {
                    formFun.OpenFocusForm(new WarningForm("查無相關資訊"));
                    return true; //找不到資料
                }
            }
        }


        /*--- 清除聯絡資料 ---*/
        private void DeleteContactData()
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Personal_Info where 聯絡編號=@number";

                cn.Open();

                SqlCommand cmdDeletePI = new SqlCommand(sqlStr, cn);
                cmdDeletePI.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar));
                cmdDeletePI.Parameters["@number"].Value = selectedContactNum;
                cmdDeletePI.ExecuteNonQuery();
            }
        }

        /*--- 清除問事資料 ---*/
        private void DeleteAskingData()
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Histories where 聯絡編號=@number";

                cn.Open();

                SqlCommand cmdDeleteAH = new SqlCommand(sqlStr, cn);
                cmdDeleteAH.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar));
                cmdDeleteAH.Parameters["@number"].Value = selectedContactNum;
                cmdDeleteAH.ExecuteNonQuery();
            }
        }



        /*--- 新增聯絡資訊 ---*/
        private void btnNewContact_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new ContactsTools.NewPersonalInfoForm());
            ShowAllData(); // 顯示全部資料
        }


        /*------ TextBox 『txtInput
         *-『txtInput_KeyPres』:限制輸入
         *-『txtInput_Enter』:輸入狀態
         *-『txtInput_Leave』:提示狀態
         *-----------------------------------*/

        /*--- 限制輸入，只能輸入文字和數字 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏『必須輸入內容，才能做查詢』

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 輸入狀態 ---*/
        private void txtInput_Enter(object sender, EventArgs e)
        {
            inWarningMsg.Visible = false; //隱藏『必須輸入內容，才能做查詢』

            OftenUseColor.SetInputTextStatus(txtInput);
        }

        /*--- 提示狀態 ---*/
        private void txtInput_Leave(object sender, EventArgs e)
        {
            OftenUseColor.SetPromptTextStatus(txtInput, "輸入查詢內容");
        }


        /*------Button
        *-『btnShowAll_Click』:顯示全部資料
        *-『btnSearch_Click』:查詢輸入的聯絡資料
        *-『btnCompleteData_Click』:顯示完整資訊 
        *-『btnDelete_Click』:刪除資料
        *--------------------------------------------------------------------------*/

        /*--- 顯示全部資料 ---*/
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        /*--- 查詢輸入的聯絡資料 ---*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtInput.Text.Trim();

            //是否有輸入查詢內容
            if (searchStr == "" || searchStr == "輸入查詢內容")
            {
                contactDataView.ClearSelection(); //取消預選
                DisEditBtn(); //禁用編輯按鈕
                
                inWarningMsg.Visible = true; //顯示『必須輸入內容，才能做查詢』
                return;
            }

            //是否找不到查詢的資料
            bool isNoExistSearchData = SearchData(searchStr);

            if (isNoExistSearchData)
                ShowAllData();

            contactDataView.Focus(); //DataGridView 取得焦點
        }

        /*--- 顯示完整資訊 ---*/
        private void btnCompleteData_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new ContactsTools.EditContactInfoForm(selectedContactNum));
            ShowAllData(); // 更新全部資訊
        }

        /*--- 刪除資料 ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "要刪除 " + selectedName + " 的聯絡資料嗎??\n\n問事資料也會被清除哦!!!";
            Message.ConfirmForm confirmForm = new Message.ConfirmForm(msg);
            formFun.OpenFocusForm(confirmForm);

            /*-- 確認刪除 --*/
            if (confirmForm.isOk)
            {
                /*- 先清除問事資料 -*/
                DeleteAskingData();

                /*- 再清除聯絡資料 -*/
                DeleteContactData();
                formFun.OpenFocusForm(new Message.SuccessForm("資料全部刪除完成"));
                ShowAllData(); //更新顯示全部資料
            }
        }

        /*------ 檢視表
         *-『contactDataView_CellClick』:取得被選取資料
         *-『contactDataView_ColumnHeaderMouseClick』:點擊標題欄時，不預選資料列
         *----------------------------------------------------------------------------*/

        /*--- 取得被選取資料的聯絡編號、姓名 ---*/
        private void contactDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedIndex = e.RowIndex;
                
                if (selectedIndex >= 0)
                {
                    selectedContactNum = contactNumList[selectedIndex];
                    selectedName = contactDataView.Rows[selectedIndex].Cells[1].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            EnEditBtn(); //啟用編輯按鈕
        }

        /*--- 點擊標題欄時，不預選資料列 ---*/
        private void contactDataView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contactDataView.ClearSelection();
        }


        /*------ Other
         *-『EnEditBtn』:啟用編輯按鈕
         *-『DisEditBtn』:禁用編輯按鈕
         *------------------------------------*/

        /*--- 啟用編輯按鈕 ---*/
        private void EnEditBtn()
        {
            OftenUseColor.ButtonEnable(btnCompleteData);
            OftenUseColor.ButtonEnable(btnDelete);
        }

        /*--- 禁用編輯按鈕 ---*/
        private void DisEditBtn()
        {
            OftenUseColor.ButtonDisable(btnCompleteData);
            OftenUseColor.ButtonDisable(btnDelete);
        }
    }
}
