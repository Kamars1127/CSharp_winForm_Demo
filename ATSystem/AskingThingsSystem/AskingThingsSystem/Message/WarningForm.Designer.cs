
namespace AskingThingsSystem.Message
{
    partial class WarningForm
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
            this.panContent = new System.Windows.Forms.Panel();
            this.msgContent = new System.Windows.Forms.Label();
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panBackground.SuspendLayout();
            this.panContent.SuspendLayout();
            this.formBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBackground
            // 
            this.panBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panBackground.Controls.Add(this.panContent);
            this.panBackground.Controls.Add(this.formBar);
            this.panBackground.Location = new System.Drawing.Point(2, 2);
            this.panBackground.Name = "panBackground";
            this.panBackground.Size = new System.Drawing.Size(268, 167);
            this.panBackground.TabIndex = 0;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.msgContent);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 32);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(268, 135);
            this.panContent.TabIndex = 1;
            // 
            // msgContent
            // 
            this.msgContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msgContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msgContent.Location = new System.Drawing.Point(0, 0);
            this.msgContent.Name = "msgContent";
            this.msgContent.Size = new System.Drawing.Size(268, 135);
            this.msgContent.TabIndex = 0;
            this.msgContent.Text = "訊息內容";
            this.msgContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.formBar.Controls.Add(this.formTitle);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(268, 32);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // formTitle
            // 
            this.formTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.formTitle.Size = new System.Drawing.Size(117, 32);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "警告訊息";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.Location = new System.Drawing.Point(236, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // WarningForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(272, 171);
            this.Controls.Add(this.panBackground);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "WarningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorForm";
            this.panBackground.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.formBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBackground;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label msgContent;
        private System.Windows.Forms.Panel formBar;
        private System.Windows.Forms.Label formTitle;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}