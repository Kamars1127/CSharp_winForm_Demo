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
using System.Data.SqlClient;
using FontAwesome.Sharp;
using System.Collections;

namespace AskingThingsSystem.HomeTools
{
    public partial class NewTableForm : Form
    {
        AskingTable askingTable;

        RadiusTool rt = new RadiusTool(); //設定元件的Radius
        ListBox placeList;
        int dataCount = 0; //有幾筆資料
        

        public NewTableForm()
        {
            InitializeComponent();
        }

        public NewTableForm(AskingTable askingTable)
        {
            InitializeComponent();
            this.askingTable = askingTable;
        }

        private void NewTableForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this);

            /*--- 設定元件的Radius ---*/
            rt.SetControlRadius(btnSelectPlace, 16);

            /*--- 建立 PlaceList ---*/
            CreatePlaceList();

            /*--- 從資料庫撈出『地點名稱』，並加到 ListBox『placeList』中 ---*/
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點名稱 from Asking_Place";
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataCount++; //幾筆資料
                    placeList.Items.Add(dr["地點名稱"]);
                }
                dr.Close();
            }

            /*--- 動態繪製 placeList的高度 ---*/
            if (dataCount > 6)
                placeList.Size = new Size(135, 26 * 6);
            else
                placeList.Size = new Size(135, 26 * dataCount);

            rt.SetControlRadius(placeList, 16);
        }

            

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*--- 拖移視窗 ---*/
        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormFunction.FormMobileFunction(this.Handle);
        }


        /*--- 選擇地點
         *- 說明: 點擊時，判斷placeList是否顯示，來做對應的狀態
         *--------------------------------------------------------*/
        private void btnSelectPlace_Click(object sender, EventArgs e)
        {
            if (placeList.Visible)
            {
                placeList.Visible = false;
                btnSelectPlace.BackColor = Color.White;
                btnSelectPlace.ForeColor = OftenUseColor.textColor;
                btnSelectPlace.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                btnSelectPlace.IconColor = OftenUseColor.textColor;
            }
            else
            {
                placeList.Visible = true;
                btnSelectPlace.BackColor = Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
                btnSelectPlace.ForeColor = Color.White;
                btnSelectPlace.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                btnSelectPlace.IconColor = Color.White;
            }
            
        }


        /*------ ListBox『placeList』
         *-『CreatePlaceList』:建立 ListBox物件、設定屬性
         *-『placeList_DrawItem』:繪製 placeList item 的選取顏色、顯示文字
         *-『placeList_SelectedIndexChanged』:選取項目時，關閉placeList，且更新選擇地點的文字
         * --------------------------------------------------------------------------------------*/

        /*--- 建立 ListBox物件、設定屬性 ---*/
        private void CreatePlaceList()
        {
            placeList = new ListBox();
            placeList.BorderStyle = BorderStyle.None;
            placeList.DrawMode = DrawMode.OwnerDrawFixed;
            placeList.Font = new Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            placeList.ForeColor = OftenUseColor.textColor;
            placeList.FormattingEnabled = true;
            placeList.ItemHeight = 26;
            placeList.Location = new Point(142, 200);
            placeList.Visible = false; //隱藏

            this.Controls.Add(placeList);
            
            /*- Event -*/
            placeList.DrawItem += new DrawItemEventHandler(placeList_DrawItem);
            placeList.SelectedIndexChanged += new EventHandler(placeList_SelectedIndexChanged);
        }

        /*--- 繪製 placeList item 的選取顏色、顯示文字 ---*/
        private void placeList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Console.WriteLine("index:" + e.Index);
            Console.WriteLine("e.state:" + e.State);
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                       e.Font,
                       e.Bounds,
                       e.Index,
                       e.State ^ DrawItemState.Selected,
                       e.ForeColor,
                       OftenUseColor.selectedColor);//Choose the color 

            // Draw the background of the ListBox control for each item. 
            e.DrawBackground();

            // 繪製項目的文字 
            e.Graphics.DrawString(placeList.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item. 
            //e.DrawFocusRectangle();
        }

        /*--- 選取項目時，關閉placeList，且更新選擇地點的文字---*/
        private void placeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPlaceMsg.Visible = false; //隱藏『必須選擇地點』
            placeList.Visible = false; //關閉placeList
            /*-- btnSelectPlace --*/
            btnSelectPlace.BackColor = Color.White;
            btnSelectPlace.ForeColor = OftenUseColor.textColor;
            btnSelectPlace.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            btnSelectPlace.IconColor = OftenUseColor.textColor;
            btnSelectPlace.Text = placeList.SelectedItem.ToString(); //將selectPlace的內容變更為『選取的內容』
            btnSelectPlace.Focus();
        }


        /*--- 建立新的問事表 ---*/
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strPlace = btnSelectPlace.Text;

            if (strPlace == "選擇地點")
            {
                lblPlaceMsg.Visible = true; //顯示『必須選擇地點』
                return;
            }


            string strDate = todayDate.Value.ToString("yyyyMMdd");
            string tableName = strDate + strPlace; //建立問事表名稱

            /*-- 確認資料庫中是否存在相同問事表 --*/
            if (CheckTabelIsExist(tableName))
            {
                FormFunction form = new FormFunction();
                form.OpenFocusForm(new Message.WarningForm("資料表已經存在"));
            }
            else
            {
                askingTable.date = todayDate.Value; //設定建表日期
                askingTable.placeName = strPlace; //設定建表地點
                askingTable.CreateLabelandTable(tableName, false);
                this.Close(); // 關閉 NewTableForm
                askingTable.formFun.CloseMenu(); // 關閉HomeForm
            }
        }


        /*--- 確認資料庫中是否已存在該問事表 ---*/
        private bool CheckTabelIsExist(string tableName)
        {
            bool isExist = false; //預設不存在

            using (SqlConnection cn= new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select count(*) " +
                                "from Asking_Tables " +
                                "where 問事表名稱=N\'" + tableName + "\'";
               

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);

                int count = (int)cmd.ExecuteScalar();

                if (count != 0)
                    isExist = true;
            }

            return isExist;
        }
    }
}
