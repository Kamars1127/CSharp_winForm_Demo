
namespace AskingThingsSystem.TableTools
{
    partial class AddAskingContentForm
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
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.formTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContactInfo = new XanderUI.XUIButton();
            this.btnHistories = new XanderUI.XUIButton();
            this.btnAdd = new XanderUI.XUIButton();
            this.panName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panContent = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panRemark = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.formBar.SuspendLayout();
            this.panName.SuspendLayout();
            this.panPhone.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.btnMinimize);
            this.formBar.Controls.Add(this.btnMaximize);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Controls.Add(this.formTitle);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(685, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(541, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 42);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.Location = new System.Drawing.Point(589, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 42);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(637, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(15, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(120, 26);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "新增問事內容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "聯絡電話 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "紀錄事項 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "備註 :";
            // 
            // btnContactInfo
            // 
            this.btnContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContactInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnContactInfo.ButtonImage = null;
            this.btnContactInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnContactInfo.ButtonText = "聯絡資訊";
            this.btnContactInfo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnContactInfo.ClickTextColor = System.Drawing.Color.White;
            this.btnContactInfo.CornerRadius = 16;
            this.btnContactInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnContactInfo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnContactInfo.HoverTextColor = System.Drawing.Color.White;
            this.btnContactInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnContactInfo.Location = new System.Drawing.Point(400, 61);
            this.btnContactInfo.Name = "btnContactInfo";
            this.btnContactInfo.Size = new System.Drawing.Size(108, 46);
            this.btnContactInfo.TabIndex = 5;
            this.btnContactInfo.TextColor = System.Drawing.Color.White;
            this.btnContactInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnContactInfo.Click += new System.EventHandler(this.btnContactInfo_Click);
            // 
            // btnHistories
            // 
            this.btnHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnHistories.ButtonImage = null;
            this.btnHistories.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHistories.ButtonText = "歷史紀錄";
            this.btnHistories.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnHistories.ClickTextColor = System.Drawing.Color.White;
            this.btnHistories.CornerRadius = 16;
            this.btnHistories.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHistories.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnHistories.HoverTextColor = System.Drawing.Color.White;
            this.btnHistories.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHistories.Location = new System.Drawing.Point(538, 61);
            this.btnHistories.Name = "btnHistories";
            this.btnHistories.Size = new System.Drawing.Size(108, 46);
            this.btnHistories.TabIndex = 6;
            this.btnHistories.TextColor = System.Drawing.Color.White;
            this.btnHistories.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHistories.Click += new System.EventHandler(this.btnHistories_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAdd.ButtonImage = null;
            this.btnAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAdd.ButtonText = "新增";
            this.btnAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAdd.ClickTextColor = System.Drawing.Color.White;
            this.btnAdd.CornerRadius = 16;
            this.btnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdd.Location = new System.Drawing.Point(577, 601);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panName.Controls.Add(this.lblName);
            this.panName.Location = new System.Drawing.Point(88, 74);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(91, 26);
            this.panName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label5";
            // 
            // panPhone
            // 
            this.panPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panPhone.Controls.Add(this.lblPhone);
            this.panPhone.Location = new System.Drawing.Point(124, 150);
            this.panPhone.Name = "panPhone";
            this.panPhone.Size = new System.Drawing.Size(129, 26);
            this.panPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPhone.Location = new System.Drawing.Point(0, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(129, 26);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "label6";
            // 
            // panContent
            // 
            this.panContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContent.BackColor = System.Drawing.Color.White;
            this.panContent.Controls.Add(this.txtContent);
            this.panContent.Location = new System.Drawing.Point(124, 231);
            this.panContent.Name = "panContent";
            this.panContent.Padding = new System.Windows.Forms.Padding(5);
            this.panContent.Size = new System.Drawing.Size(522, 204);
            this.panContent.TabIndex = 10;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtContent.Location = new System.Drawing.Point(6, 6);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(510, 192);
            this.txtContent.TabIndex = 0;
            // 
            // panRemark
            // 
            this.panRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRemark.BackColor = System.Drawing.Color.White;
            this.panRemark.Controls.Add(this.txtRemark);
            this.panRemark.Location = new System.Drawing.Point(86, 485);
            this.panRemark.Name = "panRemark";
            this.panRemark.Size = new System.Drawing.Size(443, 110);
            this.panRemark.TabIndex = 11;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRemark.Location = new System.Drawing.Point(7, 7);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(0);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(430, 96);
            this.txtRemark.TabIndex = 0;
            // 
            // AddAskingContentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(685, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panRemark);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panPhone);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHistories);
            this.Controls.Add(this.btnContactInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "AddAskingContentForm";
            this.Text = "AddAskingContentForm";
            this.Load += new System.EventHandler(this.AddAskingContentForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panPhone.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panRemark.ResumeLayout(false);
            this.panRemark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton btnContactInfo;
        private XanderUI.XUIButton btnHistories;
        private XanderUI.XUIButton btnAdd;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panRemark;
        private System.Windows.Forms.TextBox txtRemark;
    }
}