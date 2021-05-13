using AskingThingsSystem.Function;
using AskingThingsSystem.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;
using System.Collections;

namespace AskingThingsSystem
{
    public partial class MainForm : Form
    {
        public static Point mainFormLocation; //主視窗位置
        FormFunction formFun = new FormFunction();
        AskingTable at;

        public MainForm()
        {
            InitializeComponent();
            /*--- 建立名稱為at的AskingTable物件
             *-『tableData[0]』:問事表按鈕
             *-『tableData[1]』:用來遮擋文字的lbl
             *-『tableData[2]』:展開及收合icon
             *-『tableData[3]』:問事表標籤區 
             *-『tableData[4]』:主視窗工作區 
             *----------------------------------------------*/
            ArrayList tableData = new ArrayList() { btnAskingTable, lblAskingTable, iconOnOff, panTablesArea, workDesktop };
            at = new AskingTable(tableData, formFun);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //最大化的極限 等於 桌面的工作區域）
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //取得主視窗位置
            mainFormLocation = this.Location;
        }


        /*------ 視窗功能
         *-『btnCloseForm_Click』:關閉視窗
         *-『btnMaximize_Click』:視窗最大化
         *-『btnMinimize_Click』:視窗最小化
         *-『formBar_MouseDown』:視窗拖移功能
         *-----------------------------------------*/

        /*--- 關閉視窗 ---*/
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 視窗最大化 ---*/
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //重新取得主視窗位置
            mainFormLocation = this.Location;

            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Clone;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
        }

        /*--- 視窗最小化 ---*/
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*--- 視窗拖移功能 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);

            //重新取得主視窗位置
            mainFormLocation = this.Location;
        }


        /*------ Menu
         *-『btnHome_Click』:檔案
         *-『btnAskingTable_Click』:問事表
         *-『btnContact_Click』:聯絡資訊
         *-『btnHistories_Click』:問事記錄
         *-『btnAbout_Click』:關於
         *----------------------------------------------*/

        /*--- 檔案 ---*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            formFun.OpenMenuForm(new HomeForm(btnHome, at), workDesktop, btnHome);
        }

        /*--- 問事表 
         *- 說明: 與其他Menu不同，其功能為展開或收合問事表標籤
         *-------------------------------------------------------*/
        private void btnAskingTable_Click(object sender, EventArgs e)
        {
            formFun.CloseMenu(); //關閉其他Menu

            /*-- 判斷目前是否為展開狀態
             *-if :為展開狀態
             *-else :為收合狀態
             *---------------------------------*/
            if (panTablesArea.Visible == true)
            {
                panTablesArea.Visible = false; //不顯示標籤區
                /*- 改變按鈕和icon顏色 -*/
                btnAskingTable.BackColor = OftenUseColor.menuOffStatusColor;
                iconOnOff.BackColor = OftenUseColor.menuOffStatusColor;
                iconOnOff.IconChar = FontAwesome.Sharp.IconChar.AngleDown; //icon改為收合
                AddMenuEvent(); //新增事件
            }
            else
            {
                panTablesArea.Visible = true; //顯示標籤區
                /*- 改變按鈕和icon顏色 -*/
                btnAskingTable.BackColor = OftenUseColor.tableLabelBackColor;
                iconOnOff.BackColor = OftenUseColor.tableLabelBackColor;
                iconOnOff.IconChar = FontAwesome.Sharp.IconChar.AngleUp; //icon改為展開
                RemoveMenuEvent(); //移除事件
            }
        }

        /*--- 聯絡資訊 ---*/
        private void btnContact_Click(object sender, EventArgs e)
        {
            formFun.OpenMenuForm(new ContactsForm(btnContact), workDesktop, btnContact);
        }

        /*--- 問事記錄 ---*/
        private void btnHistories_Click(object sender, EventArgs e)
        {
            formFun.OpenMenuForm(new HistoriesForm(btnHistories), workDesktop, btnHistories);
        }

        /*--- 關於 ---*/
        private void btnAbout_Click(object sender, EventArgs e)
        {
            formFun.OpenMenuForm(new AboutForm(btnAbout), workDesktop, btnAbout);
        }
      

        /*--- 操作說明 ---*/
        private void btnManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kamars1127.github.io/ATSystemWeb/ATSystem/functionIntro.html");
        }


        /*------ 當滑鼠進入或離開問事表按鈕範圍時，改變對應的icon顏色
         *-『btnAskingTable_MouseEnter』:當滑鼠進入問事表按鈕
         *-『btnAskingTable_MouseLeave』:當滑鼠離開問事表按鈕
         *-----------------------------------------------------------*/
        /*--- 滑鼠進入 ---*/
        private void btnAskingTable_MouseEnter(object sender, EventArgs e)
        {
            iconOnOff.BackColor = OftenUseColor.tableLabelBackColor;
        }

        /*--- 滑鼠離開 ---*/
        private void btnAskingTable_MouseLeave(object sender, EventArgs e)
        {
            iconOnOff.BackColor = OftenUseColor.menuOffStatusColor;
        }


        /*------ Other Method
         *-『AddMenuEvent』:加入Menu事件
         *-『RemoveMenuEvent』:移除Menu事件
         *-------------------------------------*/
        /*--- 加入Menu事件---*/
        public void AddMenuEvent()
        {
            btnAskingTable.MouseEnter += new EventHandler(btnAskingTable_MouseEnter);
            btnAskingTable.MouseLeave += new EventHandler(btnAskingTable_MouseLeave);
        }

        /*--- 移除Menu事件---*/
        public void RemoveMenuEvent()
        {
            btnAskingTable.MouseEnter -= new EventHandler(btnAskingTable_MouseEnter);
            btnAskingTable.MouseLeave -= new EventHandler(btnAskingTable_MouseLeave);
        }
    }
}
