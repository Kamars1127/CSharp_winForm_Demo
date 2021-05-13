using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskingThingsSystem.Menu;
using AskingThingsSystem.Function;
using System.Data.SqlClient;

namespace AskingThingsSystem.TableTools
{
    public partial class AddAskingContentForm : Form
    {
        string contactNum; //聯絡編號
        AskingTablesForm atForm;
        FormFunction formFun = new FormFunction();

        public AddAskingContentForm()
        {
            InitializeComponent();
        }

        /*--- 建構子2 --------------------------
         *
         *- 說明: 第一次新增
         *- 參數1: 聯絡編號
         *- 參數2: 備註
         *- 參數3: AskingTablesForm 物件
         *-------------------------------------*/
        public AddAskingContentForm(string contactNum, string remark, AskingTablesForm atForm)
        {
            InitializeComponent();
            this.contactNum = contactNum;
            txtRemark.Text = remark;
            this.atForm = atForm;

            ShowInfo();
        }

        /*--- 建構子3 --------------
         *
         *- 說明: 編輯時
         *- 參數1: 問事資料
         *- 參數2: AskingTablesForm 物件
         *------------------------------*/
        public AddAskingContentForm(List<string> askingData, AskingTablesForm atForm)
        {
            InitializeComponent();
            this.contactNum = askingData[0]; //聯絡編號
            lblName.Text = askingData[1]; //姓名
            lblPhone.Text = askingData[3]; //聯絡電話
            txtContent.Text = askingData[2]; //紀錄事項
            txtRemark.Text = askingData[4]; //備註
            this.atForm = atForm;
            formTitle.Text = "編輯問事內容"; //視窗標題
            btnAdd.ButtonText = "修改"; //更改按鈕名稱
            btnAdd.Click -= new EventHandler(btnAdd_Click); //移除新增事件
            btnAdd.Click += new EventHandler(ModifyData); //增加修改事件
        }

        private void AddAskingContentForm_Load(object sender, EventArgs e)
        {
            /*- 視窗開啟位置 -*/
            FormFunction.SetFormLocation(this, 200, 5);
        }

        /*--- 拖移視窗 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle); 
        }


        /*------ Button Event --------------------
         * 
         *-『btnClose_Click』:關閉視窗
         *-『btnMaximize_Click』:最大化視窗
         *-『btnMinimize_Click』:最小化視窗
         *-『btnContactInfo_Click』:聯絡資訊
         *-『btnHistories_Click』:歷史紀錄
         *-『btnAdd_Click』:新增
         *-『ModifyData』:修改
         *---------------------------------------*/

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 最大化視窗 ---*/
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Clone;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
        }

        /*--- 最小化視窗 ---*/
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*--- 聯絡資訊 ---*/
        private void btnContactInfo_Click(object sender, EventArgs e)
        {
            formFun.OpenAloneForm(new PersonalContactInfoForm(contactNum, this));
        }

        /*--- 歷史紀錄 ---*/
        private void btnHistories_Click(object sender, EventArgs e)
        {
            formFun.OpenAloneForm(new HistoriesTools.PersonalHistoriesForm(contactNum, lblName.Text, true));
        }

        /*--- 新增 ---*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("確定要新增嗎?");
            formFun.OpenFocusForm(confirmForm);
            if (confirmForm.isOk)
            {
                List<string> askingData_list = new List<string>();
                askingData_list.Add(lblName.Text);
                askingData_list.Add(txtContent.Text.Trim()) ;
                askingData_list.Add(lblPhone.Text);
                askingData_list.Add(txtRemark.Text.Trim());

                /*-- 把問事資料加到資料庫中 --*/
                atForm.AddAskingDataToDB(contactNum, askingData_list);
                /*-- 把問事資料加到問事表上 --*/
                atForm.AddAskingData(contactNum, askingData_list);
                this.Close(); //關閉該視窗
            }
        }

        /*--- 修改 ---*/
        private void ModifyData(object sender, EventArgs e)
        {
            Message.ConfirmForm confirmForm = new Message.ConfirmForm("確定要修改嗎?");
            formFun.OpenFocusForm(confirmForm);

            if (confirmForm.isOk)
            {
                /*-- 更新資料庫的問事資料 --*/
                atForm.ModifyHistoriesData(contactNum, txtContent.Text, txtRemark.Text);
                /*-- 更新到問事表上的資料 --*/
                atForm.ModifyAskingTableData(txtContent.Text, txtRemark.Text);
                this.Close(); //關閉該視窗
            }
        }


        /*------ 資料操作 ----------------------
         * 
         *-『ShowInfo』: 顯示姓名、電話
         *-------------------------------------*/

        private void ShowInfo()
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 姓名, 聯絡電話 " +
                                "from Personal_Info " +
                                "where 聯絡編號=\'" + contactNum + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lblName.Text = dr["姓名"].ToString();
                        lblPhone.Text = dr["聯絡電話"].ToString();
                    }
                }
                dr.Close();
            }
        }
    }
}