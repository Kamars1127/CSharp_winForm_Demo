using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace AskingThingsSystem.Function
{
    public static class OftenUseColor
    {
        /*------ Color
         *-『extColor』:文字顏色(#323232)
         *-『selectedColor』:被選取時顏色(#90C4FF)
         *-『promptTxtColor』:提示文字顏色(#A5A5A5)
         *-『menuOnStatusColor』:Menu onStatus(#6c6c6c)
         *-『menuOffStatusColor』:Menu offStatus(#343434)
         *-『menuDisableTxtColor』:Menu disable時的文字顏色(#656565)
         *-『tableLabelBackColor』:標籤區顏色(#4a7bb2)
         *-------------------------------------------------------------------*/
        public static Color textColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        public static Color selectedColor = Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
        public static Color promptTxtColor = Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
        public static Color menuOnStatusColor = Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
        public static Color menuOffStatusColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
        public static Color menuDisableTxtColor = Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
        public static Color tableLabelBackColor = Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));


        /*------ TextBox(輸入框)
         *-『SetPromptTextStatus』:提示狀態
         *-『SetInputTextStatus』:輸入狀態
         *----------------------------------------*/

        /*--- 提示狀態
         *- 參數1: 目標TextBox
         *- 參數2: 提示文字
         *------------------------------*/
        public static void SetPromptTextStatus(TextBox textBox, string content)
        {
            textBox.Text = content;
            textBox.ForeColor = promptTxtColor;
        }

        /*--- 輸入狀態
         *- 參數: 目標TextBox
         *------------------------------*/
        public static void SetInputTextStatus(TextBox textBox)
        {
            textBox.Text = ""; // 清空提示文字
            textBox.ForeColor = textColor;
        }


        /*------ Button
         *-『ButtonDisable』:禁用狀態
         *-『ButtonEnable』:啟用狀態
         *-----------------------------------*/

        /*--- 禁用狀態 ---*/
        public static void ButtonDisable(XUIButton btn)
        {
            btn.Enabled = false;
            btn.BackgroundColor = Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            btn.TextColor = Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
        }

        /*--- 啟用狀態 ---*/
        public static void ButtonEnable(XUIButton btn)
        {
            btn.Enabled = true;
            btn.BackgroundColor = Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            btn.TextColor = Color.White;
        }
    }
}
