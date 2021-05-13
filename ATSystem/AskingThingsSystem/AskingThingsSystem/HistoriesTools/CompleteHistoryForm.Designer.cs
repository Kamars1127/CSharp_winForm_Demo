
namespace AskingThingsSystem.HistoriesTools
{
    partial class CompleteHistoryForm
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
            this.panContent = new System.Windows.Forms.Panel();
            this.panRemarks = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panRemarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Controls.Add(this.formTitle);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(742, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(15, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(63, 26);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "label1";
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
            this.btnClose.Location = new System.Drawing.Point(694, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "紀錄事項 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "備註 :";
            // 
            // panContent
            // 
            this.panContent.AutoScroll = true;
            this.panContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panContent.Controls.Add(this.lblContent);
            this.panContent.Location = new System.Drawing.Point(109, 91);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(600, 256);
            this.panContent.TabIndex = 3;
            // 
            // panRemarks
            // 
            this.panRemarks.AutoScroll = true;
            this.panRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panRemarks.Controls.Add(this.lblRemarks);
            this.panRemarks.Location = new System.Drawing.Point(73, 433);
            this.panRemarks.Name = "panRemarks";
            this.panRemarks.Size = new System.Drawing.Size(600, 173);
            this.panRemarks.TabIndex = 4;
            // 
            // lblContent
            // 
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Location = new System.Drawing.Point(0, 0);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new System.Windows.Forms.Padding(10);
            this.lblContent.Size = new System.Drawing.Size(600, 256);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "label3";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemarks.Location = new System.Drawing.Point(0, 0);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(10);
            this.lblRemarks.Size = new System.Drawing.Size(600, 173);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "label3";
            // 
            // CompleteHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(742, 632);
            this.Controls.Add(this.panRemarks);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompleteHistoryForm";
            this.Text = "CompleteHistoryForm";
            this.Load += new System.EventHandler(this.CompleteHistoryForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panContent.ResumeLayout(false);
            this.panRemarks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panRemarks;
        private System.Windows.Forms.Label lblRemarks;
    }
}