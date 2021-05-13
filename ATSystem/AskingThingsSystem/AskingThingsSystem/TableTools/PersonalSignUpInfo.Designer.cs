
namespace AskingThingsSystem.TableTools
{
    partial class PersonalSignUpInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panPlace = new System.Windows.Forms.Panel();
            this.lblPlace = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panRemark = new System.Windows.Forms.Panel();
            this.lblRemark = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panName.SuspendLayout();
            this.panPhone.SuspendLayout();
            this.panPlace.SuspendLayout();
            this.panRemark.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.label1);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(483, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "報名資訊";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "聯絡電話 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "居住地 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(35, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "備註 :";
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panName.Controls.Add(this.lblName);
            this.panName.Location = new System.Drawing.Point(91, 70);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(91, 26);
            this.panName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label6";
            // 
            // panPhone
            // 
            this.panPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panPhone.Controls.Add(this.lblPhone);
            this.panPhone.Controls.Add(this.label8);
            this.panPhone.Location = new System.Drawing.Point(128, 126);
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
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "label7";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "label6";
            // 
            // panPlace
            // 
            this.panPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panPlace.Controls.Add(this.lblPlace);
            this.panPlace.Controls.Add(this.label10);
            this.panPlace.Location = new System.Drawing.Point(108, 183);
            this.panPlace.Name = "panPlace";
            this.panPlace.Size = new System.Drawing.Size(91, 26);
            this.panPlace.TabIndex = 8;
            // 
            // lblPlace
            // 
            this.lblPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblPlace.Location = new System.Drawing.Point(0, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(91, 26);
            this.lblPlace.TabIndex = 1;
            this.lblPlace.Text = "label9";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "label6";
            // 
            // panRemark
            // 
            this.panRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(186)))));
            this.panRemark.Controls.Add(this.lblRemark);
            this.panRemark.Controls.Add(this.label12);
            this.panRemark.Location = new System.Drawing.Point(91, 240);
            this.panRemark.Name = "panRemark";
            this.panRemark.Size = new System.Drawing.Size(350, 136);
            this.panRemark.TabIndex = 9;
            // 
            // lblRemark
            // 
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.lblRemark.Location = new System.Drawing.Point(0, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(350, 136);
            this.lblRemark.TabIndex = 1;
            this.lblRemark.Text = "label11";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(350, 136);
            this.label12.TabIndex = 0;
            this.label12.Text = "label6";
            // 
            // PersonalSignUpInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(483, 402);
            this.Controls.Add(this.panRemark);
            this.Controls.Add(this.panPlace);
            this.Controls.Add(this.panPhone);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalSignUpInfo";
            this.Text = "PersonalSignUpInfo";
            this.Load += new System.EventHandler(this.PersonalSignUpInfo_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panPhone.ResumeLayout(false);
            this.panPlace.ResumeLayout(false);
            this.panRemark.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label label12;
    }
}