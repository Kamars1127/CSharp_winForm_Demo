
namespace AskingThingsSystem.TableTools
{
    partial class PersonalContactInfoForm
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.formTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panDate = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panPlace = new System.Windows.Forms.Panel();
            this.lblPlace = new System.Windows.Forms.Label();
            this.panRemark = new System.Windows.Forms.Panel();
            this.lblRemark = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.panTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panDate.SuspendLayout();
            this.panPhone.SuspendLayout();
            this.panPlace.SuspendLayout();
            this.panRemark.SuspendLayout();
            this.panName.SuspendLayout();
            this.panTotal.SuspendLayout();
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
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(14, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(84, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "聯絡資訊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "新增日期 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(29, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "居住地 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "聯絡電話 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(29, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "備註 :";
            // 
            // panDate
            // 
            this.panDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panDate.Controls.Add(this.lblDate);
            this.panDate.Location = new System.Drawing.Point(123, 126);
            this.panDate.Name = "panDate";
            this.panDate.Size = new System.Drawing.Size(178, 26);
            this.panDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(178, 26);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label6";
            // 
            // panPhone
            // 
            this.panPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panPhone.Controls.Add(this.lblPhone);
            this.panPhone.Location = new System.Drawing.Point(122, 182);
            this.panPhone.Name = "panPhone";
            this.panPhone.Size = new System.Drawing.Size(129, 26);
            this.panPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblPhone.Location = new System.Drawing.Point(0, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(129, 26);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "label6";
            // 
            // panPlace
            // 
            this.panPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panPlace.Controls.Add(this.lblPlace);
            this.panPlace.Location = new System.Drawing.Point(105, 238);
            this.panPlace.Name = "panPlace";
            this.panPlace.Size = new System.Drawing.Size(83, 26);
            this.panPlace.TabIndex = 7;
            // 
            // lblPlace
            // 
            this.lblPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblPlace.Location = new System.Drawing.Point(0, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(83, 26);
            this.lblPlace.TabIndex = 0;
            this.lblPlace.Text = "label6";
            // 
            // panRemark
            // 
            this.panRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panRemark.Controls.Add(this.lblRemark);
            this.panRemark.Location = new System.Drawing.Point(87, 295);
            this.panRemark.Name = "panRemark";
            this.panRemark.Size = new System.Drawing.Size(359, 136);
            this.panRemark.TabIndex = 8;
            // 
            // lblRemark
            // 
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblRemark.Location = new System.Drawing.Point(0, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(359, 136);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(312, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "問事次數 :";
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label6";
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panName.Controls.Add(this.lblName);
            this.panName.Location = new System.Drawing.Point(86, 70);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(91, 26);
            this.panName.TabIndex = 6;
            // 
            // panTotal
            // 
            this.panTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panTotal.Controls.Add(this.lblTotal);
            this.panTotal.Location = new System.Drawing.Point(405, 70);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(52, 26);
            this.panTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 26);
            this.lblTotal.TabIndex = 0;
            // 
            // PersonalContactInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(483, 454);
            this.Controls.Add(this.panTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panRemark);
            this.Controls.Add(this.panPlace);
            this.Controls.Add(this.panPhone);
            this.Controls.Add(this.panDate);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalContactInfoForm";
            this.Text = "PersonalInfoForm";
            this.Load += new System.EventHandler(this.PersonalContactInfoForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panDate.ResumeLayout(false);
            this.panPhone.ResumeLayout(false);
            this.panPlace.ResumeLayout(false);
            this.panRemark.ResumeLayout(false);
            this.panName.ResumeLayout(false);
            this.panTotal.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Panel panRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}