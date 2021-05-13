
namespace AskingThingsSystem.ContactsTools
{
    partial class ModifyInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.txtInName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panPhone = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.panRemarks = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panLivePlace = new System.Windows.Forms.Panel();
            this.txtLivePlace = new System.Windows.Forms.TextBox();
            this.btnComplete = new XanderUI.XUIButton();
            this.btnCancel = new XanderUI.XUIButton();
            this.msgName = new System.Windows.Forms.Label();
            this.msgPlace = new System.Windows.Forms.Label();
            this.panName.SuspendLayout();
            this.panPhone.SuspendLayout();
            this.panRemarks.SuspendLayout();
            this.panLivePlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.White;
            this.panName.Controls.Add(this.txtInName);
            this.panName.ForeColor = System.Drawing.Color.White;
            this.panName.Location = new System.Drawing.Point(89, 24);
            this.panName.Margin = new System.Windows.Forms.Padding(0);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(120, 35);
            this.panName.TabIndex = 2;
            // 
            // txtInName
            // 
            this.txtInName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInName.Location = new System.Drawing.Point(8, 4);
            this.txtInName.Name = "txtInName";
            this.txtInName.Size = new System.Drawing.Size(100, 27);
            this.txtInName.TabIndex = 3;
            this.txtInName.Text = "姓名";
            this.txtInName.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInName.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "聯絡電話 :";
            // 
            // panPhone
            // 
            this.panPhone.BackColor = System.Drawing.Color.White;
            this.panPhone.Controls.Add(this.txtPhone);
            this.panPhone.ForeColor = System.Drawing.Color.White;
            this.panPhone.Location = new System.Drawing.Point(128, 91);
            this.panPhone.Margin = new System.Windows.Forms.Padding(0);
            this.panPhone.Name = "panPhone";
            this.panPhone.Size = new System.Drawing.Size(139, 35);
            this.panPhone.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtPhone.Location = new System.Drawing.Point(8, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 27);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "電話號碼";
            this.txtPhone.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(35, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "備註 :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtRemarks.Location = new System.Drawing.Point(7, 8);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(320, 155);
            this.txtRemarks.TabIndex = 7;
            this.txtRemarks.Text = "備註內容";
            this.txtRemarks.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtRemarks.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // panRemarks
            // 
            this.panRemarks.BackColor = System.Drawing.Color.White;
            this.panRemarks.Controls.Add(this.txtRemarks);
            this.panRemarks.Location = new System.Drawing.Point(90, 226);
            this.panRemarks.Name = "panRemarks";
            this.panRemarks.Size = new System.Drawing.Size(334, 171);
            this.panRemarks.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(35, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "居住地 :";
            // 
            // panLivePlace
            // 
            this.panLivePlace.BackColor = System.Drawing.Color.White;
            this.panLivePlace.Controls.Add(this.txtLivePlace);
            this.panLivePlace.ForeColor = System.Drawing.Color.White;
            this.panLivePlace.Location = new System.Drawing.Point(110, 155);
            this.panLivePlace.Margin = new System.Windows.Forms.Padding(0);
            this.panLivePlace.Name = "panLivePlace";
            this.panLivePlace.Size = new System.Drawing.Size(115, 35);
            this.panLivePlace.TabIndex = 4;
            // 
            // txtLivePlace
            // 
            this.txtLivePlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLivePlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtLivePlace.Location = new System.Drawing.Point(8, 4);
            this.txtLivePlace.Name = "txtLivePlace";
            this.txtLivePlace.Size = new System.Drawing.Size(100, 27);
            this.txtLivePlace.TabIndex = 3;
            this.txtLivePlace.Text = "地名";
            this.txtLivePlace.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtLivePlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtLivePlace.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // btnComplete
            // 
            this.btnComplete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnComplete.ButtonImage = null;
            this.btnComplete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnComplete.ButtonText = "完成";
            this.btnComplete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnComplete.ClickTextColor = System.Drawing.Color.White;
            this.btnComplete.CornerRadius = 16;
            this.btnComplete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComplete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnComplete.HoverTextColor = System.Drawing.Color.White;
            this.btnComplete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnComplete.Location = new System.Drawing.Point(376, 449);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(72, 46);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.TextColor = System.Drawing.Color.White;
            this.btnComplete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(35, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // msgName
            // 
            this.msgName.AutoSize = true;
            this.msgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.msgName.Image = ((System.Drawing.Image)(resources.GetObject("msgName.Image")));
            this.msgName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgName.Location = new System.Drawing.Point(212, 28);
            this.msgName.Name = "msgName";
            this.msgName.Size = new System.Drawing.Size(122, 26);
            this.msgName.TabIndex = 12;
            this.msgName.Text = "     不能為空白";
            this.msgName.Visible = false;
            // 
            // msgPlace
            // 
            this.msgPlace.AutoSize = true;
            this.msgPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.msgPlace.Image = ((System.Drawing.Image)(resources.GetObject("msgPlace.Image")));
            this.msgPlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgPlace.Location = new System.Drawing.Point(228, 160);
            this.msgPlace.Name = "msgPlace";
            this.msgPlace.Size = new System.Drawing.Size(122, 26);
            this.msgPlace.TabIndex = 12;
            this.msgPlace.Text = "     不能為空白";
            this.msgPlace.Visible = false;
            // 
            // ModifyInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(483, 511);
            this.Controls.Add(this.msgPlace);
            this.Controls.Add(this.msgName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.panLivePlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyInfoForm";
            this.Text = "ModifyContactInfo";
            this.Load += new System.EventHandler(this.ModifyInfoForm_Load);
            this.panName.ResumeLayout(false);
            this.panName.PerformLayout();
            this.panPhone.ResumeLayout(false);
            this.panPhone.PerformLayout();
            this.panRemarks.ResumeLayout(false);
            this.panRemarks.PerformLayout();
            this.panLivePlace.ResumeLayout(false);
            this.panLivePlace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.TextBox txtInName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel panRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLivePlace;
        private System.Windows.Forms.TextBox txtLivePlace;
        private XanderUI.XUIButton btnComplete;
        private XanderUI.XUIButton btnCancel;
        private System.Windows.Forms.Label msgName;
        private System.Windows.Forms.Label msgPlace;
    }
}