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
    public partial class SuccessForm : Form
    {
        public SuccessForm()
        {
            InitializeComponent();
        }

        public SuccessForm(string msg)
        {
            InitializeComponent();
            msgContent.Text = msg;
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            Function.FormFunction.FormMobileFunction(this.Handle);
        }
    }
}
