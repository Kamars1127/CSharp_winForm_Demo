using System;
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

namespace AskingThingsSystem.TableTools
{
    public partial class PersonalContactInfoForm : Form
    {
        Form parentForm;

        public PersonalContactInfoForm()
        {
            InitializeComponent();
        }

        public PersonalContactInfoForm(string contactNum, Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            ShowInfo(contactNum);
            ShowAskingTotal(contactNum);
        }

        /*--- 設定視窗開啟位置 ---*/
        private void PersonalContactInfoForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this, parentForm, 25, 120);
        }

        /*--- 拖移視窗 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInfo(string contactNum)
        {
            DateTime date;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 姓名, 新增日期, 聯絡電話, 居住地, 備註 " +
                                "from Personal_Info " +
                                "where 聯絡編號=\'" + contactNum + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        date = Convert.ToDateTime(dr["新增日期"]);

                        lblName.Text = dr["姓名"].ToString();
                        lblDate.Text = date.ToString("yyyy年 MM月 dd日");
                        lblPhone.Text = dr["聯絡電話"].ToString();
                        lblPlace.Text = dr["居住地"].ToString();
                        lblRemark.Text = dr["備註"].ToString();
                    }
                }
                dr.Close();
            }
        }

        private void ShowAskingTotal(string contactNum)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select count(*) " +
                                "from Asking_Histories " +
                                "where 聯絡編號=\'" + contactNum + "\'";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                lblTotal.Text = cmd.ExecuteScalar().ToString();
            }
        }
    }
}
