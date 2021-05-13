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
using AskingThingsSystem.HomeTools;
using FontAwesome.Sharp;

namespace AskingThingsSystem.Menu
{
    public partial class HomeForm : Form
    {
        IconButton menuHomeBtn;
        FormFunction formFun = new FormFunction();
        AskingTable table;

        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(IconButton menuHomeBtn, AskingTable askingTable)
        {
            InitializeComponent();
            this.menuHomeBtn = menuHomeBtn;
            table = askingTable;
        }


        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menuHomeBtn.BackColor = OftenUseColor.menuOffStatusColor;
        }


        /*--- 新增問事表 ---*/
        private void btnNewTable_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new NewTableForm(table));
        }

        /*--- 瀏覽問事表 ---*/
        private void btnBrowseTables_Click(object sender, EventArgs e)
        {
            formFun.OpenToolForm(new BrowseTablesForm(table), workDesktop);
        }

        /*--- 新增問事地點 ---*/
        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new AddAskingPlaceForm());
        }

        /*--- 編輯問事地點 ---*/
        private void btnEditPlace_Click(object sender, EventArgs e)
        {
            formFun.OpenFocusForm(new EditAskingPlaceForm());
        }
    }
}
