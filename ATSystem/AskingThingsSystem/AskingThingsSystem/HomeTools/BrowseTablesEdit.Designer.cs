
namespace AskingThingsSystem.HomeTools
{
    partial class BrowseTablesEdit
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
            this.btnOpen = new XanderUI.XUIButton();
            this.btnDelete = new XanderUI.XUIButton();
            this.btnExportPDF = new XanderUI.XUIButton();
            this.formBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.formTitle);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Margin = new System.Windows.Forms.Padding(0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(302, 42);
            this.formBar.TabIndex = 0;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(20, 8);
            this.formTitle.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(102, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "問事表名稱";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Coral;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(254, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnOpen.ButtonImage = null;
            this.btnOpen.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOpen.ButtonText = "開啟";
            this.btnOpen.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOpen.ClickTextColor = System.Drawing.Color.White;
            this.btnOpen.CornerRadius = 16;
            this.btnOpen.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOpen.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOpen.HoverTextColor = System.Drawing.Color.White;
            this.btnOpen.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOpen.Location = new System.Drawing.Point(36, 65);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(72, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.TextColor = System.Drawing.Color.White;
            this.btnOpen.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDelete.ButtonText = "刪除";
            this.btnDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnDelete.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete.CornerRadius = 16;
            this.btnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDelete.Location = new System.Drawing.Point(36, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnExportPDF.ButtonImage = null;
            this.btnExportPDF.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnExportPDF.ButtonText = "匯出PDF";
            this.btnExportPDF.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnExportPDF.ClickTextColor = System.Drawing.Color.White;
            this.btnExportPDF.CornerRadius = 16;
            this.btnExportPDF.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExportPDF.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnExportPDF.HoverTextColor = System.Drawing.Color.White;
            this.btnExportPDF.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExportPDF.Location = new System.Drawing.Point(143, 65);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(124, 46);
            this.btnExportPDF.TabIndex = 3;
            this.btnExportPDF.TextColor = System.Drawing.Color.White;
            this.btnExportPDF.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // BrowseTablesEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(302, 207);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowseTablesEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BrowseTablesEdit";
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private XanderUI.XUIButton btnOpen;
        private XanderUI.XUIButton btnDelete;
        private XanderUI.XUIButton btnExportPDF;
    }
}