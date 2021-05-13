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
using AskingThingsSystem.Message;

namespace AskingThingsSystem.HomeTools
{
    public partial class EditAskingPlaceForm : Form
    {
        string selectedPlace;
        FormFunction formFun = new FormFunction();

        public EditAskingPlaceForm()
        {
            InitializeComponent();
        }

        private void EditAskingPlaceForm_Load(object sender, EventArgs e)
        {
            FormFunction.SetFormLocation(this);
            ShowAllPlace();
        }

        /*--- 關閉視窗 ---*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*--- 取得選擇的地點名稱 ---*/
        private void placeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
                selectedPlace = placeView.Rows[rowIndex].Cells[1].Value.ToString();

            EnEditBtn(); //啟用編輯按鈕
        }


        /*------ DataBase 資料操作
         *-『ShowAllPlace』:顯示全部地點
         *-『CheckDeletePlace』:檢查欲刪除的地點
         *-『DeletePlace』:刪除地點
         *-『SearchPlace』:搜尋輸入的地點
         *------------------------------------------------*/

        /*--- 顯示全部地點 ---*/
        private void ShowAllPlace()
        {
            placeView.Rows.Clear(); //清空檢視表資料

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                int number = 0; //第幾筆資料
                string sqlStr = "select 地點名稱 from Asking_Place";

                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    number++;
                    placeView.Rows.Add(number, dr["地點名稱"]);
                }

                dr.Close();
            }

            placeView.ClearSelection(); //取消預選
            
        }

        /*--- 檢查欲刪除的地點 
         *- 說明 :欲刪除的地點，不能有相關的問事表
         *- 參數 :欲刪除的地點
         *- 回傳(false) :存在相關問事表，無法刪除
         *- 回傳(true) : 可以被刪除
         *-------------------------------------------------*/
        private bool CheckDeletePlace(string place)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select * " +
                                "from Asking_Tables " +
                                "where 地點編號 = (" +
                                        "select 地點編號 " +
                                        "from Asking_Place " +
                                        "where 地點名稱=N\'" + place +"\')";

                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if(dr.HasRows)
                {
                    string msg ="欲刪除的『"+ place + "』\n\n存在相關問事表，所以無法刪除";
                    formFun.OpenFocusForm(new WarningForm(msg));
                    dr.Close();
                    return false;
                }
                else
                {
                    dr.Close();
                    return true;
                } 
            }
           
        }

        /*--- 刪除地點 
         *- 參數: 欲刪除得地點
         *-----------------------------*/
        private void DeletePlace(string place)
        {
            string msg = place;
            int result = 0;
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "delete from Asking_Place " +
                                "where 地點名稱 = @placeName";

                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, cn);

                cmd.Parameters.Add(new SqlParameter("@placeName", SqlDbType.NVarChar));
                cmd.Parameters["@placeName"].Value = place;
                result = cmd.ExecuteNonQuery();
            }

            if (result==1)
            {
                msg += " 已被刪除";
                formFun.OpenFocusForm(new SuccessForm(msg));
                ShowAllPlace();
            }
            else
            {
                msg += " 無法被刪除";
                formFun.OpenFocusForm(new WarningForm(msg));
            } 
        }

        /*--- 搜尋輸入的地點
         *- 參數: 輸入的內容
         *-------------------------*/
        private void SearchPlace(string input)
        {
            int number = 0; //第幾筆資料

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.connectStr))
            {
                string sqlStr = "select 地點名稱 from Asking_Place " +
                                "where 地點名稱 like N\'%" + input + "%\'";

                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                placeView.Focus();

                if (dr.HasRows)
                {
                    placeView.Rows.Clear(); //清空資料列

                    while (dr.Read())
                    {
                        number++;
                        placeView.Rows.Add(number, dr["地點名稱"]);
                    }

                    placeView.ClearSelection(); //取消預選
                    DisEditBtn(); //禁用編輯按鈕
                }
                else
                {
                    formFun.OpenFocusForm(new WarningForm("找不到 " + input));
                }

                dr.Close();
            }
        }

        /*------ TextBox 『txtInput』
        *-『txtInput_Enter』:輸入狀態
        *-『txtInput_Leave』:提示狀態
        *-『txtInput_KeyPress』:限制輸入
        * -------------------------------------*/

        /* txtInput 輸入狀態 */
        private void txtInput_Enter(object sender, EventArgs e)
        {
            OftenUseColor.SetInputTextStatus(txtInput);
        }

        /*--- txtInput 提示狀態 ---*/
        private void txtInput_Leave(object sender, EventArgs e)
        {
            OftenUseColor.SetPromptTextStatus(txtInput, "輸入地點");
        }

        /*--- 只能輸入文字或數字、控制鍵 ---*/
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        /*------ Button 區
         *-『btnSearch_Click』:查詢指定的地點
         *-『btnShowAll_Click』:顯示全部問事地點
         *-『btnDelete_Click』:刪除選取的地點
         *-『btnModify_Click』:更改選取的地點
         *------------------------------------------*/

        /*--- 查詢指定的地點 ---*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inStr = txtInput.Text;

            if (inStr == "" || inStr == "輸入地點")
            { 
                formFun.OpenFocusForm(new WarningForm("請輸入內容，才能做查詢"));
                return;
            }

            SearchPlace(inStr);
        }

        /*--- 顯示全部問事地點 ---*/
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllPlace();
        }

        /*--- 刪除選取的地點 ---*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* 確定是否可以刪除 */
            bool canDelete = CheckDeletePlace(selectedPlace);

            if (canDelete)
            {
                string sendMsg = "確定要刪除 " + selectedPlace + " 嗎?";
                ConfirmForm confirm = new ConfirmForm(sendMsg);
                formFun.OpenFocusForm(confirm);
                bool toDelete = confirm.isOk; //確定要刪除嗎?

                if (toDelete)
                    DeletePlace(selectedPlace);
                else
                {
                    placeView.ClearSelection(); //清除預選
                    DisEditBtn(); //禁用編輯按鈕
                }
            }
            else
            {
                placeView.ClearSelection(); //清除預選
                DisEditBtn(); //禁用編輯按鈕
            }
        }

        /*--- 更改選取的地點 ---*/
        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyPlaceNameForm modifyForm = new ModifyPlaceNameForm();
            /* 把地名設定給modifyForm物件的oldPlaceName */
            modifyForm.oldPlaceName = selectedPlace;
            formFun.OpenFocusForm(modifyForm);

            /* 判斷是否修改 */
            if (modifyForm.isModified)
            {
                ShowAllPlace();
            }
            else
            {
                placeView.ClearSelection(); //清除預選
                DisEditBtn(); //禁用編輯按鈕
            }
        }

        /*------ Other
         *-『DisEditBtn』:禁用 修改、刪除
         *-『EnEditBtn』:啟用 修改、刪除
         *-『placeView_ColumnHeaderMouseClick』:點擊檢視表標題欄時，不選取資料列
         *--------------------------------------------------------------------------*/

        /*--- 禁用 修改、刪除 ---*/
        private void DisEditBtn()
        {
            OftenUseColor.ButtonDisable(btnModify); //禁用修改按鈕
            OftenUseColor.ButtonDisable(btnDelete); //禁用刪除按鈕
        }

        /*--- 啟用 修改、刪除 ---*/
        private void EnEditBtn()
        {
            OftenUseColor.ButtonEnable(btnModify); //啟用修改按鈕
            OftenUseColor.ButtonEnable(btnDelete); //啟用刪除按鈕
        }


        /*--- 點擊檢視表標題欄時，不選取資料列 ---*/
        private void placeView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            placeView.ClearSelection();
        }
    }
}
