
namespace AskingThingsSystem.Message
{
    partial class ConfirmForm
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
            this.panBackground = new System.Windows.Forms.Panel();
            this.btnOk = new XanderUI.XUIButton();
            this.btnCancel = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgContent = new System.Windows.Forms.Label();
            this.formBar = new System.Windows.Forms.Panel();
            this.fromTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.formBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBackground
            // 
            this.panBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panBackground.Controls.Add(this.btnOk);
            this.panBackground.Controls.Add(this.btnCancel);
            this.panBackground.Controls.Add(this.panel1);
            this.panBackground.Controls.Add(this.formBar);
            this.panBackground.Location = new System.Drawing.Point(2, 2);
            this.panBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panBackground.Name = "panBackground";
            this.panBackground.Size = new System.Drawing.Size(306, 202);
            this.panBackground.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnOk.ButtonImage = null;
            this.btnOk.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOk.ButtonText = "正確";
            this.btnOk.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOk.ClickTextColor = System.Drawing.Color.White;
            this.btnOk.CornerRadius = 8;
            this.btnOk.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOk.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOk.HoverTextColor = System.Drawing.Color.White;
            this.btnOk.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOk.Location = new System.Drawing.Point(212, 160);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "取消";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.White;
            this.btnCancel.CornerRadius = 8;
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(35, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msgContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 116);
            this.panel1.TabIndex = 1;
            // 
            // msgContent
            // 
            this.msgContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msgContent.Location = new System.Drawing.Point(0, 0);
            this.msgContent.Margin = new System.Windows.Forms.Padding(0);
            this.msgContent.Name = "msgContent";
            this.msgContent.Size = new System.Drawing.Size(306, 116);
            this.msgContent.TabIndex = 0;
            this.msgContent.Text = "訊息內容";
            this.msgContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.formBar.Controls.Add(this.fromTitle);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Margin = new System.Windows.Forms.Padding(0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(306, 32);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // fromTitle
            // 
            this.fromTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.fromTitle.ForeColor = System.Drawing.Color.White;
            this.fromTitle.Location = new System.Drawing.Point(0, 0);
            this.fromTitle.Margin = new System.Windows.Forms.Padding(0);
            this.fromTitle.Name = "fromTitle";
            this.fromTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fromTitle.Size = new System.Drawing.Size(109, 32);
            this.fromTitle.TabIndex = 1;
            this.fromTitle.Text = "確認訊息";
            this.fromTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.IconSize = 26;
            this.btnClose.Location = new System.Drawing.Point(274, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(310, 206);
            this.Controls.Add(this.panBackground);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmForm";
            this.panBackground.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.formBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBackground;
        private XanderUI.XUIButton btnOk;
        private XanderUI.XUIButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label msgContent;
        private System.Windows.Forms.Panel formBar;
        private System.Windows.Forms.Label fromTitle;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}