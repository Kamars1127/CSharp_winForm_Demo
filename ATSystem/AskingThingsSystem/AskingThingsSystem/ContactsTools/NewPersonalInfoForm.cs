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
using System.Collections;
using AskingThingsSystem.Menu;

namespace AskingThingsSystem.ContactsTools
{
    public partial class NewPersonalInfoForm : Form
    {
        AskingTablesForm askingTablesForm; //問事表視窗
        Form parentForm; //SignUpForm (報名視窗)
        bool isFromTableForm; // 是否由AskingTablesForm 開啟
        FormFunction form = new FormFunction();

        public NewPersonalInfoForm()
        {
            InitializeComponent();
        }

        /*------ 建構子2 (從AskingTablesForm開啟)----------
         *
         *- 參數1: AskingTablesForm 物件 (問事表視窗)
         *- 參數2: SignUpForm (報名視窗)
         *------------------------------------------------*/
        public NewPersonalInfoForm(AskingTablesForm askingTablesForm, Form parentForm)
        {
            InitializeComponent();
            this.askingTablesForm = askingTablesForm;
            this.parentForm = parentForm;
            isFromTableForm = true; //從AskingTablesForm開啟
            formTitle.Text = "報名 - 新人"; //更改視窗標題
            btnAdd.ButtonText = "報名"; //更改按鈕名稱
        }

        private void NewPersonalInfoForm_Load(object sender, EventArgs e)
        {
            /*--- 視窗開啟位置 ----------------
             * 
             *- if: 位置與 SignUpForm 相同
             *-------------------------------*/
            if (isFromTableForm == true)
            {
                FormFunction.FormLocationWithParent(this, parentForm);
                parentForm.Visible = false; //隱藏 SignUpForm
            }
            else
                FormFunction.SetFormLocation(this);
        }

        /*------ Button -------------------------------
         * 
         *-『formBar_MouseDown』:移動視窗
         *-『btnClose_Click』:關閉視窗
         *-『btnCancel_Click』:關閉視窗
         *-『btnAdd_Click』:新增聯絡資訊
         *-------------------------------------------*/
        /*--- 移動視窗 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 關閉視窗 ---*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*--- 新增聯絡資訊 ---*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contactNum, addName, addPhone, addPlace, addRemarks;
            addName = txtName.Text.Trim();
            DateTime addDate = dateTime.Value;
            addPhone = txtPhone.Text.Trim();
            addPlace = txtPlace.Text.Trim();
            addRemarks = txtRemarks.Text.Trim();
            // Console.WriteLine("姓名: " + addName);
            //Console.WriteLine("日期: " + addDate);
            //Console.WriteLine("電話: " + addPhone);
            //Console.WriteLine("地點: " + addPlace);
            // Console.WriteLine("備註: " + addRemarks);


            /*-- 姓名和居住地不能為空 --*/
            if (addName == "" || addPlace == "")
            {
                if (addName == "")
                    lblNameMsg.Visible = true;
                if (addPlace == "")
                    lblPlaceMsg.Visible = true;

                return;
            }

            /*- 把資料加到資料庫的 Personal_Info -*/
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("確認要報名嗎?");
            form.OpenFocusForm(confirmForm);
            
            if (confirmForm.isOk)
            {
                /* 新增的聯絡資料是否已存在 */
                if (IsRepeatData(addName, addPhone, addPlace))
                {
                    form.OpenFocusForm(new Message.WarningForm(addName + "已經新增過了"));
                    return;
                }

                /* 產生聯絡編號 */
                CodeGenerator cg = new CodeGenerator();
                contactNum = addDate.ToString("yyyyMMddhhmm") + cg.LettersCode(3);
                /* 把資料加到資料庫 */
                AddDataToDB(contactNum, addName, addPhone, addPlace, addDate, addRemarks);
                /* 如果由問事表開啟，就把資料加到問事表視窗 */
                if (isFromTableForm == true)
                    askingTablesForm.AddNameTo_SignUpList(contactNum, addName, addRemarks);

                this.Close();
            }
        }


        /*------- TextBox ------------------------------------
         * 
         *-『txtInput_KeyPress』:只能輸入文字和控制鍵
         *-『txtPhone_KeyPress』:只能輸入數字和控制鍵
         *--------------------------------------------------*/
        /*--- 只能輸入文字和控制鍵 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 只能輸入數字和控制鍵 ---*/
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        /*------ DataBase 資料操作 --------------------
         * 
         *-『IsRepeatData』:是否為重複資料
         *-『AddDataToDB』:新增聯絡資料到DB
         *-------------------------------------------*/

        /*--- 是否為重複資料 --------------------------------------------------
         *
         *- 說明: 姓名、聯絡電話和居住地，不能皆相同，否則為重複資料
         *- 參數1: 姓名
         *- 參數2: 聯絡電話
         *- 參數3: 居住地
         *- 回傳值: false為沒有重複，true為重複
         *--------------------------------------------------------------------*/
        private bool IsRepeatData(string name, string phoneNum, string livePlace)
        {
            int count;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select count(*) " +
                              "from Personal_Info " +
                              "where 姓名=N\'" + name + "\' " +
                              "and 聯絡電話=\'" + phoneNum + "\' " +
                              "and 居住地=N\'" + livePlace + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                count = (int)cmd.ExecuteScalar();
            }

            if (count == 0)
                return false;
            else
                return true;
        }

        /*--- 新增聯絡資料到DB -------------------------
         * 
         *- 參數1: 聯絡編號
         *- 參數2: 姓名
         *- 參數3: 聯絡電話
         *- 參數4: 居住地
         *- 參數5: 新增日期
         *- 參數6: 備註
         *--------------------------------------------*/
        private void AddDataToDB(string contactNum, string name, string phoneNum, string livePlace, DateTime addDate, string remarks)
        {
            int result;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "insert into Personal_Info(聯絡編號, 姓名, 聯絡電話, 居住地, 新增日期, 備註) " +
                                "values (@contactNum, @name, @phone, @place, @date, @remarks)";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                
                cmd.Parameters.Add(new SqlParameter("@contactNum", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@remarks", SqlDbType.NText));

                cmd.Parameters["@contactNum"].Value = contactNum;
                cmd.Parameters["@name"].Value = name;
                cmd.Parameters["@phone"].Value = phoneNum;
                cmd.Parameters["@place"].Value = livePlace;
                cmd.Parameters["@date"].Value = addDate;
                cmd.Parameters["@remarks"].Value = remarks;

                result = cmd.ExecuteNonQuery();
            }

            if (result == 0)
            {
                form.OpenFocusForm(new Message.WarningForm("新增失敗"));
                return;
            }
        }
    }
}
