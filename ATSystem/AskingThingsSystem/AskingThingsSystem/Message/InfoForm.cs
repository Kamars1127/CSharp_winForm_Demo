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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(string msg)
        {
            InitializeComponent();
            msgContent.Text = msg;
        }

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
