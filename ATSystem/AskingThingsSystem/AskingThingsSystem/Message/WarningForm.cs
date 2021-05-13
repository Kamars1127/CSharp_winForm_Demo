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
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }

        public WarningForm(String msg)
        {
            InitializeComponent();

            msgContent.Text = msg;
        }

        /*--- 關閉視窗 ---*/
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            Function.FormFunction.FormMobileFunction(this.Handle);
        }
    }
}
