
namespace AskingThingsSystem.ContactsTools
{
    partial class NewPersonalInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPersonalInfoForm));
            this.formBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.formTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.panPlace = new System.Windows.Forms.Panel();
            this.panRemarks = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnCancel = new XanderUI.XUIButton();
            this.btnAdd = new XanderUI.XUIButton();
            this.lblNameMsg = new System.Windows.Forms.Label();
            this.lblPlaceMsg = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panPlace.SuspendLayout();
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
            this.formBar.Size = new System.Drawing.Size(483, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
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
            this.btnClose.Location = new System.Drawing.Point(435, 0);
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
            this.formTitle.Location = new System.Drawing.Point(12, 10);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(120, 26);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "新增聯絡資訊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "今天日期 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "聯絡電話 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "居住地 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "備註 :";
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.White;
            this.panName.Controls.Add(this.txtName);
            this.panName.Location = new System.Drawing.Point(88, 67);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(115, 35);
            this.panName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtName.Location = new System.Drawing.Point(8, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 8;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Location = new System.Drawing.Point(126, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 35);
            this.panel2.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPhone.Location = new System.Drawing.Point(8, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 27);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(131, 134);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(155, 34);
            this.dateTime.TabIndex = 10;
            // 
            // txtPlace
            // 
            this.txtPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPlace.Location = new System.Drawing.Point(8, 4);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 27);
            this.txtPlace.TabIndex = 11;
            // 
            // panPlace
            // 
            this.panPlace.BackColor = System.Drawing.Color.White;
            this.panPlace.Controls.Add(this.txtPlace);
            this.panPlace.Location = new System.Drawing.Point(107, 262);
            this.panPlace.Name = "panPlace";
            this.panPlace.Size = new System.Drawing.Size(115, 35);
            this.panPlace.TabIndex = 8;
            // 
            // panRemarks
            // 
            this.panRemarks.BackColor = System.Drawing.Color.White;
            this.panRemarks.Controls.Add(this.txtRemarks);
            this.panRemarks.Location = new System.Drawing.Point(90, 328);
            this.panRemarks.Name = "panRemarks";
            this.panRemarks.Size = new System.Drawing.Size(334, 171);
            this.panRemarks.TabIndex = 8;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRemarks.Location = new System.Drawing.Point(10, 8);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(315, 155);
            this.txtRemarks.TabIndex = 12;
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
            this.btnCancel.Location = new System.Drawing.Point(40, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
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
            this.btnAdd.Location = new System.Drawing.Point(370, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNameMsg
            // 
            this.lblNameMsg.AutoSize = true;
            this.lblNameMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.lblNameMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblNameMsg.Image")));
            this.lblNameMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameMsg.Location = new System.Drawing.Point(209, 71);
            this.lblNameMsg.Name = "lblNameMsg";
            this.lblNameMsg.Size = new System.Drawing.Size(104, 26);
            this.lblNameMsg.TabIndex = 13;
            this.lblNameMsg.Text = "     必須輸入";
            this.lblNameMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameMsg.Visible = false;
            // 
            // lblPlaceMsg
            // 
            this.lblPlaceMsg.AutoSize = true;
            this.lblPlaceMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.lblPlaceMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblPlaceMsg.Image")));
            this.lblPlaceMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlaceMsg.Location = new System.Drawing.Point(228, 265);
            this.lblPlaceMsg.Name = "lblPlaceMsg";
            this.lblPlaceMsg.Size = new System.Drawing.Size(104, 26);
            this.lblPlaceMsg.TabIndex = 14;
            this.lblPlaceMsg.Text = "     必須輸入";
            this.lblPlaceMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlaceMsg.Visible = false;
            // 
            // NewPersonalInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(483, 596);
            this.Controls.Add(this.lblPlaceMsg);
            this.Controls.Add(this.lblNameMsg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panPlace);
            this.Controls.Add(this.panRemarks);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPersonalInfoForm";
            this.Text = "NewPersonalInfoForm";
            this.Load += new System.EventHandler(this.NewPersonalInfoForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panPlace.ResumeLayout(false);
            this.panPlace.PerformLayout();
            this.panRemarks.ResumeLayout(false);
            this.panRemarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Panel panPlace;
        private System.Windows.Forms.Panel panRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private XanderUI.XUIButton btnCancel;
        private XanderUI.XUIButton btnAdd;
        private System.Windows.Forms.Label lblNameMsg;
        private System.Windows.Forms.Label lblPlaceMsg;
    }
}