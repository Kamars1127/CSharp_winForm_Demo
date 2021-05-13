
namespace AskingThingsSystem.HomeTools
{
    partial class NewTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTableForm));
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.todayDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelectPlace = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new XanderUI.XUIButton();
            this.lblPlaceMsg = new System.Windows.Forms.Label();
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
            this.formBar.Size = new System.Drawing.Size(468, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(20, 8);
            this.formTitle.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(102, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "新增問事表";
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
            this.btnClose.Location = new System.Drawing.Point(420, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "今天日期 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(36, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "問事地點 :";
            // 
            // todayDate
            // 
            this.todayDate.Location = new System.Drawing.Point(142, 76);
            this.todayDate.Margin = new System.Windows.Forms.Padding(0);
            this.todayDate.MaximumSize = new System.Drawing.Size(175, 35);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(155, 34);
            this.todayDate.TabIndex = 3;
            // 
            // btnSelectPlace
            // 
            this.btnSelectPlace.BackColor = System.Drawing.Color.White;
            this.btnSelectPlace.FlatAppearance.BorderSize = 0;
            this.btnSelectPlace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnSelectPlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnSelectPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPlace.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnSelectPlace.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSelectPlace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectPlace.IconSize = 24;
            this.btnSelectPlace.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSelectPlace.Location = new System.Drawing.Point(142, 166);
            this.btnSelectPlace.Name = "btnSelectPlace";
            this.btnSelectPlace.Size = new System.Drawing.Size(135, 35);
            this.btnSelectPlace.TabIndex = 4;
            this.btnSelectPlace.Text = "選擇地點";
            this.btnSelectPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectPlace.UseVisualStyleBackColor = false;
            this.btnSelectPlace.Click += new System.EventHandler(this.btnSelectPlace_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCreate.ButtonImage = null;
            this.btnCreate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCreate.ButtonText = "建立";
            this.btnCreate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCreate.ClickTextColor = System.Drawing.Color.White;
            this.btnCreate.CornerRadius = 16;
            this.btnCreate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCreate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCreate.HoverTextColor = System.Drawing.Color.White;
            this.btnCreate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCreate.Location = new System.Drawing.Point(360, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(72, 46);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPlaceMsg
            // 
            this.lblPlaceMsg.AutoSize = true;
            this.lblPlaceMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblPlaceMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblPlaceMsg.Image")));
            this.lblPlaceMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlaceMsg.Location = new System.Drawing.Point(283, 170);
            this.lblPlaceMsg.Name = "lblPlaceMsg";
            this.lblPlaceMsg.Size = new System.Drawing.Size(140, 26);
            this.lblPlaceMsg.TabIndex = 6;
            this.lblPlaceMsg.Text = "     必須選擇地點";
            this.lblPlaceMsg.Visible = false;
            // 
            // NewTableForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(468, 388);
            this.Controls.Add(this.lblPlaceMsg);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelectPlace);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTableForm";
            this.Text = "NewTableForm";
            this.Load += new System.EventHandler(this.NewTableForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker todayDate;
        private FontAwesome.Sharp.IconButton btnSelectPlace;
        private XanderUI.XUIButton btnCreate;
        private System.Windows.Forms.Label lblPlaceMsg;
    }
}