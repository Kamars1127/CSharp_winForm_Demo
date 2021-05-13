
namespace AskingThingsSystem.HomeTools
{
    partial class ModifyPlaceNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new XanderUI.XUIButton();
            this.lblOldName = new System.Windows.Forms.Label();
            this.btnCancel = new XanderUI.XUIButton();
            this.inText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.formTitle);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(350, 42);
            this.formBar.TabIndex = 0;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(20, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(120, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "更改地點名稱";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(302, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "舊地名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "新地名 :";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnOK.ButtonImage = null;
            this.btnOK.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOK.ButtonText = "確認";
            this.btnOK.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOK.ClickTextColor = System.Drawing.Color.White;
            this.btnOK.CornerRadius = 16;
            this.btnOK.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOK.HoverTextColor = System.Drawing.Color.White;
            this.btnOK.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOK.Location = new System.Drawing.Point(258, 219);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 46);
            this.btnOK.TabIndex = 3;
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Location = new System.Drawing.Point(122, 73);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(84, 26);
            this.lblOldName.TabIndex = 4;
            this.lblOldName.Text = "選取地點";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "取消";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.White;
            this.btnCancel.CornerRadius = 16;
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(148, 219);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inText
            // 
            this.inText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.inText.Location = new System.Drawing.Point(10, 4);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(100, 27);
            this.inText.TabIndex = 6;
            this.inText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inText_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.inText);
            this.panel1.Location = new System.Drawing.Point(122, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 35);
            this.panel1.TabIndex = 7;
            // 
            // ModifyPlaceNameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(350, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ModifyPlaceNameForm";
            this.Text = "ModifyPlaceNameForm";
            this.Load += new System.EventHandler(this.ModifyPlaceNameForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private System.Windows.Forms.Label formTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btnOK;
        private System.Windows.Forms.Label lblOldName;
        private XanderUI.XUIButton btnCancel;
        private System.Windows.Forms.TextBox inText;
        private System.Windows.Forms.Panel panel1;
    }
}