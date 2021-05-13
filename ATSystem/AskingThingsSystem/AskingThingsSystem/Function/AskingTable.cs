using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.Function
{
    public class AskingTable
    {
        /*-- 問事表的元件 --*/
        private IconButton menuTableBtn; //Menu: 問事表
        private Label tableTitleLbl; //問事表Menu標題(用來遮擋button disable時的文字顏色)
        private Panel labelsAreaPan; //問事表標籤區
        private Panel tablesAreaPan; //問事表區
        private IconButton iconOnOff; //上下箭頭
        
        private IconButton activeLabel; //目前開啟的標籤

        public int tableLabel_count { get; set; } //標籤數量
        public FormFunction formFun { get; }
        public DateTime date { get; set; } //建立問事表的日期
        public string placeName { get; set; } //建立問事表的地點名稱


        /*-- 建構子
         *-參數1: 問事表的元件
         *-參數2: FormFunction物件
         *--------------------------*/
        public AskingTable(ArrayList askingTableData, FormFunction formFunction)
        {
            menuTableBtn = (IconButton)askingTableData[0];
            tableTitleLbl = (Label)askingTableData[1];
            iconOnOff = (IconButton)askingTableData[2];
            labelsAreaPan = (Panel)askingTableData[3];
            tablesAreaPan = (Panel)askingTableData[4];

            formFun = formFunction;
        }


        /*--- 建立標籤和表 
         *- 參數1:問事表名稱
         *- 參數2:是否為打開舊檔
         *---------------------------*/
        public void CreateLabelandTable(string tableName, bool isOpenOld)
        {
            /*-- 判斷是否已開啟一樣的問事表 --*/
            foreach (Control control in labelsAreaPan.Controls)
            {
                if(control.Text == tableName)
                {
                    formFun.OpenFocusForm(new Message.WarningForm(tableName + " 已經開啟"));
                    return;
                }
            }
            
            /*-- 判斷是否已開啟問事表Menu --*/
            if (labelsAreaPan.Visible == false)
            {
                /*- 問事表按鈕 -*/
                menuTableBtn.Enabled = true; //啟用
                menuTableBtn.BackColor = OftenUseColor.tableLabelBackColor;
                menuTableBtn.IconColor = Color.White;

                tableTitleLbl.Visible = false; //隱藏遮擋用的文字
                labelsAreaPan.Visible = true; //顯示問事表標籤區
                iconOnOff.Visible = true; //顯示展開圖示
            }

            /*-- 建立標籤 --*/
            IconButton label = CreateLabel(labelsAreaPan, tableName);

            /*-- 是否開啟舊表 --*/
            if (isOpenOld)
            {
                OpenOldTable(tablesAreaPan, label, tableName);
            }
            else
            {
                CreateTable(tablesAreaPan, label);
            }
        }


        /*--- 建立問事表標籤 
         *-參數1:標籤要加的地方
         *-參數2:問事表名稱
         *-------------------------------*/
        private IconButton CreateLabel(Panel addInPan, string tableName)
        {
            tableLabel_count++;

            IconButton tableLabel = new IconButton();

            /*- 是否有開啟的Table Label
             *- if: 沒有
             *- else: 有
             *----------------------------*/
            if(activeLabel==null)
                activeLabel = tableLabel;
            else
            {
                OffTableLabel(activeLabel);
                activeLabel = tableLabel;
            }


            tableLabel.Dock = DockStyle.Top;
            tableLabel.Size = new Size(200, 44);
            /*- 樣式 -*/
            tableLabel.BackColor = OftenUseColor.selectedColor;
            tableLabel.FlatStyle = FlatStyle.Flat;
            tableLabel.FlatAppearance.BorderSize = 0;
            tableLabel.Padding = new Padding(5, 0, 0, 0);
            /*- icon -*/
            tableLabel.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            tableLabel.IconColor = OftenUseColor.textColor;
            tableLabel.IconSize = 30;
            tableLabel.ImageAlign = ContentAlignment.BottomLeft;
            /*- text -*/
            tableLabel.Text = tableName;
            tableLabel.ForeColor = OftenUseColor.textColor;
            tableLabel.TextImageRelation = TextImageRelation.ImageBeforeText;

            /*- 把問事表的標籤加到標籤區 -*/
            addInPan.Controls.Add(tableLabel);

            /*- Event -*/
            tableLabel.Click += new EventHandler(tableLabel_Click);

            return tableLabel;
        }


        /*-------- 建立問事表
         *-『CreateTable』: 建立新問事表
         *-『CreateTable』: 開啟舊問事表
         *-----------------------------*/

        /*--- 建立新問事表 
         *-參數1: 問事表要加的地方
         *-參數2: 標籤
         *-------------------------------*/
        private void CreateTable(Panel addInPan, IconButton label)
        {
            Menu.AskingTablesForm atForm = new Menu.AskingTablesForm(label, this);
            
            label.Tag = atForm; //table綁定對應的label
            atForm.Text = label.Text;
            atForm.Dock = DockStyle.Fill;
            atForm.TopLevel = false;

            addInPan.Controls.Add(atForm);
            atForm.BringToFront();
            atForm.Show();
        }

        /*--- 開啟舊問事表 ----------------- 
         * 
         *-參數1: 問事表要加的地方
         *-參數2: 標籤
         *-參數3: 問事表名稱
         *-------------------------------*/
        private void OpenOldTable(Panel addInPan, IconButton label, string tableName)
        {
            Menu.AskingTablesForm atForm = new Menu.AskingTablesForm(label, this, tableName);

            label.Tag = atForm; //table綁定對應的label
            atForm.Text = label.Text;
            atForm.Dock = DockStyle.Fill;
            atForm.TopLevel = false;

            addInPan.Controls.Add(atForm);
            atForm.BringToFront();
            atForm.Show();
        }


        /*------ 問事表標籤
         *-『tableLabel_Click』:當點擊問事表標籤時，開啟問事表
         *-『OnTableLabel』:打開狀態
         *-『OffTableLabel』:關閉狀態
         *-『MinimizeTable』:縮小問事表
         *-『CloseTable』:關閉問事表
         *----------------------------------------------------------*/

        /*--- 當點擊問事表標籤時，開啟問事表 ---*/
        private void tableLabel_Click(object sender, EventArgs e)
        {
            formFun.CloseMenu(); //關閉其他 Menu

            IconButton btn = (IconButton)sender;
            
            /*-- 判斷是否按同一個標籤 
             *- if: 按同一個標籤時，不做任何事
             *- else if: 沒有標籤已開啟時，直接開啟起問事表
             *- else: 按不同標籤時，先關閉已開啟的，再開啟問事表
             *-------------------------------------------------*/
            if (activeLabel == btn)
            {
                // Console.WriteLine("相同");
                return;
            }
            else if (activeLabel == null)
            {
                activeLabel = btn;
                OnTableLabel(btn); //打開欲開啟的標籤
            }
            else
            {
                OffTableLabel(activeLabel); //關閉開啟的標籤
                activeLabel = btn;
                OnTableLabel(btn); //打開欲開啟的標籤
            }
        }

        /*--- 打開狀態 ---*/
        private void OnTableLabel(IconButton tableLabel)
        {
            tableLabel.BackColor = OftenUseColor.selectedColor;
            tableLabel.IconColor = OftenUseColor.textColor;
            tableLabel.ForeColor = OftenUseColor.textColor;

            /*- 顯示對應table -*/
            Form askingTable = (Form)tableLabel.Tag;
            //Console.WriteLine("Open:" + askingTable);
            askingTable.Visible = true;
        }

        /*--- 關閉狀態 ---*/
        private void OffTableLabel(IconButton tableLabel)
        {
            tableLabel.BackColor = OftenUseColor.tableLabelBackColor;
            tableLabel.IconColor = Color.White;
            tableLabel.ForeColor = Color.White;

            /*- 隱藏對應table -*/
            Form askingTable = (Form)tableLabel.Tag;
            //Console.WriteLine("隱藏:" + askingTable);
            askingTable.Visible = false;
        }

        /*--- 縮小問事表 ---*/
        public void MinimizeTable(IconButton tableLabel)
        {
            tableLabel.BackColor = OftenUseColor.tableLabelBackColor;
            tableLabel.IconColor = Color.White;
            tableLabel.ForeColor = Color.White;

            activeLabel = null;
        }

        /*--- 關閉問事表 ---*/
        public void CloseTable(IconButton tableLabel)
        {
            tableLabel.Dispose(); //移除問事表標籤
            tableLabel_count--;

            /*-- 當標籤數為0時，禁用問事表按鈕 --*/
            if (tableLabel_count == 0)
            {
                menuTableBtn.Enabled = false; //禁用
                menuTableBtn.BackColor = OftenUseColor.menuOffStatusColor;
                menuTableBtn.IconColor = OftenUseColor.menuDisableTxtColor;

                tableTitleLbl.Visible = true; //顯示遮擋用的文字
                labelsAreaPan.Visible = false; //隱藏問事表標籤區
                iconOnOff.Visible = false; //隱藏展開圖示
            }
        }
    }
}
