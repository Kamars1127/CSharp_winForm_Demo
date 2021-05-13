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
    public partial class PersonalSignUpInfo : Form
    {
        public PersonalSignUpInfo()
        {
            InitializeComponent();
        }

        public PersonalSignUpInfo(string contactNum, string remark)
        {
            InitializeComponent();
            ShowInfo(contactNum);
            lblRemark.Text = remark;
        }

        private void PersonalSignUpInfo_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this, 200, 10);
        }


        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 視窗拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }

        /*--- 取得姓名、聯絡電話、居住地 ---*/
        private void ShowInfo(string contactNum)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 姓名, 聯絡電話, 居住地 " +
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
                        lblPlace.Text = dr["居住地"].ToString();
                    }
                }

                dr.Close();
            }
        }
    }
}
