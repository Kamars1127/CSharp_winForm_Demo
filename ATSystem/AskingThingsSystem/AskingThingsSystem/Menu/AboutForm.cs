using FontAwesome.Sharp;
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

namespace AskingThingsSystem.Menu
{
    public partial class AboutForm : Form
    {
        IconButton menuBtn;

        public AboutForm()
        {
            InitializeComponent();
        }

        public AboutForm(IconButton btn)
        {
            InitializeComponent();
            menuBtn = btn;
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menuBtn.BackColor = OftenUseColor.menuOffStatusColor;
        }
    }
}
