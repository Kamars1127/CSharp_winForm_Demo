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

namespace AskingThingsSystem.HistoriesTools
{
    public partial class WhichOneToSearchForm : Form
    {
        List<string[]> listInfo = new List<string[]>();
        int count;
        int selectedIndex; //選擇的資料列之索引值

        public string confirmContactNum { get; set; }


        public WhichOneToSearchForm()
        {
            InitializeComponent();
        }

        public WhichOneToSearchForm(List<string[]> listPersonalInfo)
        {
            InitializeComponent();
            listInfo = listPersonalInfo;
            count = listPersonalInfo.Count;
        }

        private void WhichOneToSearchForm_Load(object sender, EventArgs e)
        {
            //視窗開啟位置
            FormFunction.SetFormLocation(this);

            for(int index=0; index < count; index++)
                personalInfoView.Rows.Add(listInfo[index][1], listInfo[index][3], listInfo[index][2]);

            personalInfoView.ClearSelection(); //清除資料列預選
        }


        /*--- 視窗可拖移 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }


        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void personalInfoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;

                // 啟用確認按鈕
                OftenUseColor.ButtonEnable(btnConfirm);
            }
        }

        /*--- 確認 ---*/
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirmContactNum = listInfo[selectedIndex][0];
            this.Close();
        }
    }
}
