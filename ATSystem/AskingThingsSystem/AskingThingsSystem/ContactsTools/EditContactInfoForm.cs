using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.ContactsTools
{
    public partial class EditContactInfoForm : Form
    {
        string contactNum; //聯絡編號

        public EditContactInfoForm()
        {
            InitializeComponent();
        }

        public EditContactInfoForm(string contactNum)
        {
            InitializeComponent();
            this.contactNum = contactNum;
        }

        private void EditContactInfoForm_Load(object sender, EventArgs e)
        {
            Function.FormFunction.SetFormLocation(this);
            Function.FormFunction form = new Function.FormFunction();
            form.OpenToolForm(new PersonalInfoForm(this,editArea,formTitle,contactNum),editArea);
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 拖移視窗功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            Function.FormFunction.FormMobileFunction(this.Handle);
        }
    }
}
