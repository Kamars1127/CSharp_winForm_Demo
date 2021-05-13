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

namespace AskingThingsSystem.ContactsTools
{
    public partial class ModifyInfoForm : Form
    {
        /*- EditContactInfoForm -*/
        Form parentForm;
        Panel parentPan;
        Label formTitle;
        
        string contactNum; //聯絡編號
        string oldName, oldPhoneNum, oldLivePlace, oldRemarks; //原有資訊
        string newName, newPhoneNum,newLivePlace, newRemarks; //新資訊 (輸入的內容)
        bool nonSame_Name, nonSame_PhomeNum, nonSame_LivePlace, nonSame_Rematks; //資料是否有更動


        public ModifyInfoForm()
        {
            InitializeComponent();
        }


        public ModifyInfoForm(Form parentForm, Panel parentPan, Label formTitle, string contactNum, string name, string phoneNum, string livePlace, string remarks)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.parentPan = parentPan;
            this.formTitle = formTitle;
            this.contactNum = contactNum;

            formTitle.Text = name + " - 更新聯絡資料";

            /*- 舊資訊 -*/
            oldName = name;
            oldPhoneNum = phoneNum;
            oldLivePlace = livePlace;
            oldRemarks = remarks;
        }

        /*--- 在輸入框顯示舊資訊 ---*/
        private void ModifyInfoForm_Load(object sender, EventArgs e)
        {
            txtInName.Text = oldName;
            txtPhone.Text = oldPhoneNum;
            txtLivePlace.Text = oldLivePlace;
            txtRemarks.Text = oldRemarks;
        }


        /*------ TextBox『txtInput』
         *-『txtInput_Enter』:輸入狀態
         *-『txtInput_Leave』:非輸入狀態
         *-『txtInput_KeyPress』:限制狀態
         *-『txtPhone_KeyPress』:限制狀態(聯絡電話)
         *---------------------------------------------*/

        /*--- 輸入狀態 ---*/
        private void txtInput_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = OftenUseColor.textColor;

            Console.WriteLine("neame:" + textBox.Name);
            
            /*-- 當點擊的輸入框是姓名或居住地時，隱藏警示訊息 --*/
            if (textBox.Name == "txtInName")
            {
                msgName.Visible = false;
            }
            if(textBox.Name== "txtLivePlace")
            {
                msgPlace.Visible = false;
            }
        }


        /*--- 非輸入狀態 ---*/
        private void txtInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = OftenUseColor.promptTxtColor;
        }

        /*--- 限制輸入 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*--- 限制輸入(聯絡電話) ---*/
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /*------ Button
         *-『btnCancel_Click』:取消，關閉視窗
         *-『btnComplete_Click』:修改
         *--------------------------*/

        /*--- 取消，關閉視窗 ---*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

        /*--- 修改 ---*/
        private void btnComplete_Click(object sender, EventArgs e)
        {
            btnComplete.Focus(); //修改按鈕取得焦點
            FormFunction form = new FormFunction();
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("是否確認要修改??");
            form.OpenFocusForm(confirmForm);

            /*-- 取消修改 --*/
            if (!confirmForm.isOk)
                return;

            /*-- 輸入的內容 --*/
            newName = txtInName.Text.Trim();
            newPhoneNum = txtPhone.Text.Trim();
            newLivePlace = txtLivePlace.Text.Trim();
            newRemarks = txtRemarks.Text.Trim();

            /*-- 姓名或居住地不能為空，否則不進行修改 --*/
            if (newName == "" || newLivePlace == "")
            {
                if (newName == "")
                    msgName.Visible = true;
                if (newLivePlace == "")
                    msgPlace.Visible = true;

                return;
            }
                
            /*-- 資料內容是否有更動
             *- if: 無更動，不須更新資料庫
             *- else: 有更動，須更新資料庫
             *-----------------------------------*/
            if (oldName == newName && oldPhoneNum == newPhoneNum && oldLivePlace == newLivePlace && oldRemarks == newRemarks)
            {
                form.OpenFocusForm(new Message.InfoForm("無任何內容更動"));
            }
            else
            {
                /*- 判斷哪個資料內容有更動 
                 *第1個if :姓名
                 *第2個if :聯絡電話
                 *第3個if :居住地
                 *第4個if :備註
                 *---------------------------*/
                if (oldName != newName)
                    nonSame_Name = true; //有更動 }
                if (oldPhoneNum != newPhoneNum)
                    nonSame_PhomeNum = true;
                if (oldLivePlace != newLivePlace)
                    nonSame_LivePlace = true;
                if (oldRemarks != newRemarks)
                    nonSame_Rematks = true;

                UpdateDBData(); //更新資料庫資料
            }
           
            this.Close();
            form.OpenToolForm(new PersonalInfoForm(parentForm, parentPan, formTitle, contactNum), parentPan);
        }

        /*--- 更新資料庫資料
         *- 說明: 會依每個資料有無更動來做更新
         *--------------------------------------------*/
        private void UpdateDBData()
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                cn.Open();
                SqlCommand cmd;

                /*- 更新『姓名』-*/
                if (nonSame_Name)
                {
                    string sqlStr = "update Personal_Info set 姓名 = @name " +
                             "where 聯絡編號 = @number";

                    
                    cmd = new SqlCommand(sqlStr, cn);
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.Char));
                    cmd.Parameters["@name"].Value = newName;
                    cmd.Parameters["@number"].Value = contactNum;
                    cmd.ExecuteNonQuery();
                }

                /*- 更新『聯絡電話』-*/
                if (nonSame_PhomeNum)
                {
                    string sqlStr = "update Personal_Info set 聯絡電話=@phoneNum " +
                                    "where 聯絡編號 = @number";

                    cmd = new SqlCommand(sqlStr, cn);
                    cmd.Parameters.Add(new SqlParameter("@phoneNum", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.Char));
                    cmd.Parameters["@phoneNum"].Value = newPhoneNum;
                    cmd.Parameters["@number"].Value = contactNum;
                    cmd.ExecuteNonQuery();
                }

                /*- 更新『居住地』-*/
                if (nonSame_LivePlace)
                {
                    string sqlStr = "update Personal_Info set 居住地=@livePlace " +
                                    "where 聯絡編號 = @number";

                    cmd = new SqlCommand(sqlStr, cn);
                    cmd.Parameters.Add(new SqlParameter("@livePlace", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.Char));
                    cmd.Parameters["@livePlace"].Value = newLivePlace;
                    cmd.Parameters["@number"].Value = contactNum;
                    cmd.ExecuteNonQuery();
                }

                /*- 更新『備註』-*/
                if (nonSame_Rematks)
                {
                    string sqlStr = "update Personal_Info set 備註=@remarks " +
                                    "where 聯絡編號 = @number";

                    cmd = new SqlCommand(sqlStr, cn);
                    cmd.Parameters.Add(new SqlParameter("@remarks", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.Char));
                    cmd.Parameters["@remarks"].Value = newRemarks;
                    cmd.Parameters["@number"].Value = contactNum;
                    cmd.ExecuteNonQuery();
                }
            }

            FormFunction form = new FormFunction();
            form.OpenFocusForm(new Message.SuccessForm("聯絡資料更新完成"));
        }
    }
}
