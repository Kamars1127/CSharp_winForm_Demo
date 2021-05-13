
namespace AskingThingsSystem.TableTools
{
    partial class SignUpForm
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
            this.btnNewPerson = new XanderUI.XUIButton();
            this.btnOldPerson = new XanderUI.XUIButton();
            this.formBar.SuspendLayout();
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
            this.formBar.Size = new System.Drawing.Size(266, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "報名";
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
            this.btnClose.Location = new System.Drawing.Point(218, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnNewPerson.ButtonImage = null;
            this.btnNewPerson.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNewPerson.ButtonText = "新人";
            this.btnNewPerson.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnNewPerson.ClickTextColor = System.Drawing.Color.White;
            this.btnNewPerson.CornerRadius = 16;
            this.btnNewPerson.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewPerson.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnNewPerson.HoverTextColor = System.Drawing.Color.White;
            this.btnNewPerson.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNewPerson.Location = new System.Drawing.Point(36, 85);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(72, 46);
            this.btnNewPerson.TabIndex = 1;
            this.btnNewPerson.TextColor = System.Drawing.Color.White;
            this.btnNewPerson.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // btnOldPerson
            // 
            this.btnOldPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnOldPerson.ButtonImage = null;
            this.btnOldPerson.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOldPerson.ButtonText = "舊人";
            this.btnOldPerson.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOldPerson.ClickTextColor = System.Drawing.Color.White;
            this.btnOldPerson.CornerRadius = 16;
            this.btnOldPerson.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOldPerson.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOldPerson.HoverTextColor = System.Drawing.Color.White;
            this.btnOldPerson.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOldPerson.Location = new System.Drawing.Point(158, 85);
            this.btnOldPerson.Name = "btnOldPerson";
            this.btnOldPerson.Size = new System.Drawing.Size(72, 46);
            this.btnOldPerson.TabIndex = 2;
            this.btnOldPerson.TextColor = System.Drawing.Color.White;
            this.btnOldPerson.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOldPerson.Click += new System.EventHandler(this.btnOldPerson_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(266, 169);
            this.Controls.Add(this.btnOldPerson);
            this.Controls.Add(this.btnNewPerson);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnClose;
        private XanderUI.XUIButton btnNewPerson;
        private XanderUI.XUIButton btnOldPerson;
    }
}