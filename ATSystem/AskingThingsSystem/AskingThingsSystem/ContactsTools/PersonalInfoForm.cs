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
    public partial class PersonalInfoForm : Form
    {
        Form parentForm;
        Panel parentPan;
        Label formTitle;
        string contactNum; //聯絡編號
        FormFunction form = new FormFunction();

        public PersonalInfoForm()
        {
            InitializeComponent();
        }

        public PersonalInfoForm(Form parentForm, Panel parentPan, Label formTitle, string contactNum)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.parentPan = parentPan;
            this.contactNum = contactNum;
            this.formTitle = formTitle;
            formTitle.Text = "檢視完整資訊";
        }
            

        private void PersonalInfoForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }


        /*------ Button
         *-『btnModify_Click』:修改聯絡資訊
         *-『btnDelete_Click』:刪除聯絡資訊
         *-『btnAskingLog_Click』:顯示問事記錄
         *----------------------------------------*/
        /*--- 修改聯絡資訊 ---*/
        private void btnModify_Click(object sender, EventArgs e)
        {
            form.OpenToolForm(new ModifyInfoForm(parentForm, parentPan, formTitle, contactNum, lblName.Text, lblPhone.Text, lblLivePlace.Text, lblRemarks.Text), parentPan);
            this.Close();
        }

        /*--- 刪除聯絡資訊 ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "要刪除 " + lblName.Text + " 的聯絡資料嗎??\n\n問事資料也會被清除哦!!!";
            Message.ConfirmForm confirmForm = new Message.ConfirmForm(msg);
            form.OpenFocusForm(confirmForm);

            /*-- 確認刪除 --*/
            if (confirmForm.isOk)
            {
                bool deleteState = false;
                
                /*- 先清除問事資料 -*/
                if (Convert.ToInt32(lblAskingCount.Text) > 0)
                    deleteState = DeleteAskingData();
                else
                    deleteState = true; //直接清除聯絡資料

                /*- 再清除聯絡資料 -*/
                if (deleteState)
                {
                    DeleteContactData();
                }
            }
        }

        /*--- 顯示問事記錄 ---*/
        private void btnAskingLog_Click(object sender, EventArgs e)
        {
            //原本問事次數
            int originAskingCount = Convert.ToInt32(lblAskingCount.Text);

            HistoriesTools.PersonalHistoriesForm phForm = new HistoriesTools.PersonalHistoriesForm(contactNum, lblName.Text);
            form.OpenFocusForm(phForm);

            /*- 如果有刪除紀錄，必須更新 -*/
            if (originAskingCount != phForm.logCount)
                lblAskingCount.Text = phForm.logCount.ToString();
        }

        /*------ DataBase
         *-『ShowInfo』:顯示聯絡資料
         *-『DeleteContactData』:清除聯絡資料
         *-『DeleteAskingData』:清除問事資料
         *--------------------------------------------*/

        /*--- 顯示聯絡資料 ---*/
        private void ShowInfo()
        {
            DateTime date;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                //問事次數
                string sqlStr1 = "select count(*) from Asking_Histories where 聯絡編號=\'" + contactNum + "\'";
                //聯絡資訊
                string sqlStr2 = "select 姓名, 聯絡電話, 居住地, 新增日期, 備註 " +
                                 "from Personal_Info " +
                                 "where 聯絡編號=\'" + contactNum + "\'";

                SqlCommand cmdAskingCount, cmdContactInfo;
                SqlDataReader dr;

                cn.Open();
                /*-- 取得問事次數 --*/
                cmdAskingCount = new SqlCommand(sqlStr1, cn);
                lblAskingCount.Text = cmdAskingCount.ExecuteScalar().ToString();

                /*-- 取得聯絡資訊 --*/
                cmdContactInfo = new SqlCommand(sqlStr2, cn);
                dr = cmdContactInfo.ExecuteReader();

                while (dr.Read())
                {
                    date = Convert.ToDateTime(dr["新增日期"]);

                    lblName.Text = dr["姓名"].ToString();
                    lblDate.Text = date.ToString("yyyy年 MM月 dd日");
                    lblPhone.Text = dr["聯絡電話"].ToString();
                    lblLivePlace.Text = dr["居住地"].ToString();
                    lblRemarks.Text = dr["備註"].ToString();
                }
            }
        }

        /*--- 清除聯絡資料 ---*/
        private void DeleteContactData()
        {
            int result = 0;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Personal_Info where 聯絡編號=@number";
                
                cn.Open();

                SqlCommand cmdDeletePI = new SqlCommand(sqlStr, cn);
                cmdDeletePI.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar));
                cmdDeletePI.Parameters["@number"].Value = contactNum;
                result =  cmdDeletePI.ExecuteNonQuery();
            }

            Console.WriteLine("清除聯絡資料:" + result);
            if (result == 1)
            {
                form.OpenFocusForm(new Message.SuccessForm("資料全部刪除完成"));
                this.Close();
                parentForm.Close();
            }
        }

        /*--- 清除問事資料 
         *- 說明1: 回傳true表示刪除成功
         *- 說明2: 回傳false表示刪除失敗
         *------------------------------------*/
        private bool DeleteAskingData()
        {
            int result = 0;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Histories where 聯絡編號=@number";

                cn.Open();

                SqlCommand cmdDeleteAH = new SqlCommand(sqlStr, cn);
                cmdDeleteAH.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar));
                cmdDeleteAH.Parameters["@number"].Value = contactNum;
                result = cmdDeleteAH.ExecuteNonQuery();
            }

            Console.WriteLine("清除問事資料 :" + result);
            if (result == 1)
            {
                return true;
            }
            else
            {
                form.OpenFocusForm(new Message.WarningForm("刪除失敗"));
                return false;
            }
        }
    }
}
