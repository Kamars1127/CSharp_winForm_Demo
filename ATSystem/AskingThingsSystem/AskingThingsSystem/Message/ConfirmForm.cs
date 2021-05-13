using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.Message
{
    public partial class ConfirmForm : Form
    {
        public bool isOk { get; set; }

        public ConfirmForm()
        {
            InitializeComponent();
        }

        public ConfirmForm(String msg)
        {
            InitializeComponent();
            msgContent.Text = msg;
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 關閉視窗 ---*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOk = false;
            this.Close();
        }

        /*--- 確定要刪除 ---*/
        private void btnOk_Click(object sender, EventArgs e)
        {
            isOk = true;
            this.Close();
        }

        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            Function.FormFunction.FormMobileFunction(this.Handle);
        }
    }
}
