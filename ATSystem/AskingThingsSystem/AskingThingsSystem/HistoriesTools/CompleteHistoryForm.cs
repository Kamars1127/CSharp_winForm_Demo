using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.HistoriesTools
{
    public partial class CompleteHistoryForm : Form
    {
        public CompleteHistoryForm()
        {
            InitializeComponent();
        }

        /*------ 建構子2
         *-參數1: 姓名
         *-參數2: 問事表名稱
         *-參數3: 紀錄事項
         *-參數4: 備註
         *----------------------------*/
        public CompleteHistoryForm(string name, string tableName, string content, string remarks)
        {
            InitializeComponent();

            /*- 視窗標題 -*/
            formTitle.Text = tableName + " - " + name;
            /*- 紀錄事項 -*/
            lblContent.Text = content;
            /*- 備註 -*/
            lblRemarks.Text = remarks;
        }

        private void CompleteHistoryForm_Load(object sender, EventArgs e)
        {
            Function.FormFunction.SetFormLocation(this);
        }


        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 視窗拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            Function.FormFunction.FormMobileFunction(this.Handle);
        }
    }
}
