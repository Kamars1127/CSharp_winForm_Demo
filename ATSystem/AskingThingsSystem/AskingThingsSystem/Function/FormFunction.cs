using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.Function
{
    public class FormFunction
    {
        private Form menuForm; //暫存開啟的 menu視窗
        private Form toolForm; //暫存開啟的 工具視窗
        private Form aloneForm; //暫存開啟的 獨立視窗
        private IconButton menuBtn; //暫存開啟的 menu按鈕


        /*------ 開啟子視窗
         *-『OpenMenuForm』: 開啟 Menu視窗
         *-『OpenToolForm』: 開啟 工具視窗
         *-『OpenFocusForm』: 開啟 焦點視窗
         *-『OpenAloneForm』: 開啟 獨立視窗
         *------------------------------------*/

        /*--- 開啟 Menu視窗 
         *- 說明: 主要用於 MainForm 開啟「檔案，問事表，聯絡資訊，問事記錄，關於」
         *- 參數1: subForm:欲開起的視窗
         *- 參數2: addInPane:在哪個panel上開啟
         *- 參數3: btn:「檔案，問事表，聯絡資訊，問事記錄，關於」
         *---------------------------------------------------------------------------*/

        public void OpenMenuForm(Form subForm, Panel addInPane, IconButton btn)
        {

            /*-- Menu視窗是否已開啟 
             *- 外if: 是否有menu開啟
             *- 內if: 是否為欲開啟的視窗
             *------------------------------------*/
            if (menuForm != null && menuBtn!=null) 
            {
                //Console.WriteLine(subForm.Text);
               
                if (subForm.Text== menuForm.Text)
                {
                    //MessageBox.Show("視窗已存在");
                    return;
                }

                CloseMenu(); //關閉已開啟的視窗
            }
            
            
            menuForm = subForm;
            menuBtn = btn;
            btn.BackColor = OftenUseColor.menuOnStatusColor; // Menue on狀態時的顏色 
            subForm.TopLevel = false; //該視窗非最上層視窗
            subForm.Dock = DockStyle.Fill; //佔滿整個 panel

            addInPane.Controls.Add(subForm);
            addInPane.Tag = subForm;

            subForm.BringToFront(); //該視窗顯示在上層，才不會被遮擋
            subForm.Show();
        }

        /*--- 開啟 工具視窗 
         *- 說明: 用來開啟Menu視窗上方工具列的工具
         *- 參數1: subForm:欲開起的視窗
         *- 參數2: addInPane:在哪個panel上開啟
         *---------------------------------------------*/
        public void OpenToolForm(Form subForm, Panel addInPane)
        {
            /*-- 不重複開啟 --*/
            if (toolForm != null && toolForm.Text == subForm.Text)
                return;

            toolForm = subForm;
            subForm.TopLevel = false;
            subForm.Dock = DockStyle.Fill;

            addInPane.Controls.Add(subForm);
            addInPane.Tag = subForm;

            subForm.BringToFront();
            subForm.Show();
        }

        /*--- 開啟 焦點視窗 
         *- 說明1: 用來開啟 Message中的「ConfirmForm, InfoForm, SuccessForm, WarningForm」
         *- 說明2: 必須對該視窗處理才能做其他的事
         *- 參數1: subForm:欲開起的視窗
         *----------------------------------------------------------------------------------*/
        public void OpenFocusForm(Form subForm)
        {
            subForm.BringToFront();
            subForm.ShowDialog();
        }

        /*--- 開啟 獨立視窗 ---*/
        public void OpenAloneForm(Form subForm)
        {
            if (aloneForm != null && aloneForm.Text == subForm.Text)
                return;

            aloneForm = subForm;
            subForm.BringToFront();
            subForm.Show();
        }


        /*-------------------
         * 關閉 Menu視窗
         *------------------*/
        public void CloseMenu()
        {
            menuForm.Close(); //關掉已開啟的menu視窗
            menuBtn.BackColor = OftenUseColor.menuOffStatusColor; //Menue off狀態時的顏色 
        }


        /*----------------
         * 拖移表格的功能
         *----------------*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void FormMobileFunction(IntPtr hWnd)
        {
            ReleaseCapture();
            FormFunction.SendMessage(hWnd, 0x112, 0xf012, 0);
        }


        /*------ 設定開啟視窗的位置
         *-『SetFormLocation』: 主視窗X+245, 主視窗Y+113
         *-『SetFormLocation』: 主視窗X+245, 主視窗Y+113
         *-『SetFormLocation』: 依據父視窗來自訂位置
         *-『FormLocationWithParent』: 與父視窗位置一樣
         *-------------------------------------------------------*/

        /*--- 主視窗X+245, 主視窗Y+113 
         *- 參數: 欲開啟的視窗
         *-----------------------------------*/
        public static void SetFormLocation(Form currentForm)
        {
            int xMainForm = MainForm.mainFormLocation.X; //主視窗X座標
            int yMainForm = MainForm.mainFormLocation.Y; //主視窗Y座標
            currentForm.Location = new Point(xMainForm + 245, yMainForm + 113);
        }

        /*--- 主視窗(X+245, Y+113)，再加上指定的量
         *- 參數1: 欲開啟的視窗
         *- 參數2: 指定要加的X量
         *- 參數3: 指定要加的Y量
         *--------------------------------------------*/
        public static void SetFormLocation(Form currentForm, int xPoint, int yPoint)
        {
            int xMainForm = MainForm.mainFormLocation.X; //主視窗X座標
            int yMainForm = MainForm.mainFormLocation.Y; //主視窗Y座標
            currentForm.Location = new Point(xMainForm + 245 + xPoint, yMainForm + 113 + yPoint);
        }

        /*--- 依據父視窗來自訂位置 
         *- 參數1: 欲開啟的視窗
         *- 參數2: 父視窗
         *- 參數3: 指定要加的X量
         *- 參數4: 指定要加的Y量
         *------------------------------*/
        public static void SetFormLocation(Form currentForm, Form parent, int xPoint, int yPoint)
        {
            int xParent = parent.Location.X; //父視窗X座標
            int yParent = parent.Location.Y; //父視窗Y座標
            currentForm.Location = new Point(xParent + xPoint, yParent + yPoint);
        }

        /*--- 與父視窗位置一樣 
         *- 參數1: 欲開啟的視窗
         *- 參數2: 父視窗
         *---------------------------------*/
        public static void FormLocationWithParent(Form currentForm, Form parentForm)
        {
            int xParent = parentForm.Location.X; //父視窗X座標
            int yParent = parentForm.Location.Y; //父視窗Y座標
            currentForm.Location = new Point(xParent, yParent);
        }

    }
}
