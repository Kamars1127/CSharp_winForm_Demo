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
using AskingThingsSystem.Function;
using AskingThingsSystem.Menu;

namespace AskingThingsSystem.TableTools
{
    public partial class SignUpForm : Form
    {
        AskingTablesForm askingTablesForm;
        FormFunction formFun = new FormFunction();

        public SignUpForm()
        {
            InitializeComponent();
        }
       
        public SignUpForm(AskingTablesForm askingTablesForm)
        {
            InitializeComponent();
            this.askingTablesForm = askingTablesForm;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this);
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

        /*--- 新人 ---*/
        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new ContactsTools.NewPersonalInfoForm(askingTablesForm, this));
            this.Close();
        }

        /*--- 舊人 ---*/
        private void btnOldPerson_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new TableTools.OldPersonForm(askingTablesForm, this));
            this.Close();
        }
    }
}
