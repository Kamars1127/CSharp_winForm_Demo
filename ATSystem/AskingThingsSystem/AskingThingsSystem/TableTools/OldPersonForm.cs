using AskingThingsSystem.Menu;
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
using System.Data.SqlClient;
using AskingThingsSystem.Function;
using AskingThingsSystem.Message;

namespace AskingThingsSystem.TableTools
{
    public partial class OldPersonForm : Form
    {
        AskingTablesForm askingTablesForm; //問事表
        Form parentForm; //SignUpForm (報名視窗)
        /*- 同姓名的聯絡編號 -*/
        List<string> contactNum = new List<string>();
        /*- 選取資料列的資料 -*/
        string selectedContactNum; // 選取的聯絡編號
        string selectedName; // 選取的姓名
        FormFunction formFun = new FormFunction();


        public OldPersonForm()
        {
            InitializeComponent();
        }


        public OldPersonForm(AskingTablesForm askingTablesForm, Form parentForm)
        {
            InitializeComponent();
            this.askingTablesForm = askingTablesForm;
            this.parentForm = parentForm;
        }

        private void OldPersonForm_Load(object sender, EventArgs e)
        {
            FormFunction.FormLocationWithParent(this, parentForm);
            parentForm.Visible = false; //隱藏SignUpForm (報名視窗)
        }


        /*--- 關閉視窗 ---*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 視窗拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }

        /*------ TextBox『txtName』------------------
         *
         *-『txtName_KeyPress』:限制輸入
         *-『txtName_KeyUp』:及時輸入搜尋
         *------------------------------------------*/
        /*--- 限制輸入 ---*/
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            lblNameMsg.Visible = false; //隱藏 『必須輸入』
        }

        /*--- 及時輸入搜尋 ---*/
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            string inStr = txtName.Text.Trim();
            if (inStr != "")
            {
                resultView.Rows.Clear(); //清空檢視表
                SearchName(inStr); //搜尋輸入的姓名
            }
        }

        /*------ 檢視表 ----------------------------------
         * 
         *- 說明: 取得選取列的聯絡編號和姓名
         *-----------------------------------------------*/
        private void resultView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedContactNum = contactNum[e.RowIndex];
                selectedName = resultView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }



        /*--- 報名 ---*/
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string inStr = txtName.Text.Trim();

            /*- if: 輸入內容不能為空 
             *- else if: 必須選擇姓名
             *-------------------------*/
            if (inStr == "")
            {
                lblNameMsg.Visible = true; //顯示 『必須輸入』
                return;
            }
            else if (selectedName == null)
            {
                formFun.OpenFocusForm(new WarningForm("必須選擇性名"));
                return;
            }

            /*-- 確認要報名嗎? --*/
            ConfirmForm confirmForm = new ConfirmForm("確認要報名嗎?");
            formFun.OpenFocusForm(confirmForm);
            if (confirmForm.isOk)
                askingTablesForm.AddNameTo_SignUpList(selectedContactNum, selectedName, txtRemark.Text);
            else
                return;
           
            this.Close();
        }

        /*------ DataBase 資料操作 -----------
         *
         *-『SearchName』:搜尋姓名
         *----------------------------------*/

        /*--- 搜尋姓名 ---*/
        private void SearchName(string name)
        {
            contactNum.Clear(); //清空資料

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 聯絡編號, 姓名, 居住地, 聯絡電話 " +
                                "from Personal_Info " +
                                "where 姓名 like N\'%" + name + "%\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        contactNum.Add(dr["聯絡編號"].ToString());
                        resultView.Rows.Add(dr["姓名"], dr["居住地"], dr["聯絡電話"]);
                    }
                }

                dr.Close();
            }
            resultView.ClearSelection(); //清除預選列
        }
    }
}
