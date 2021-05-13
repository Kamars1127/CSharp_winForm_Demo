
namespace AskingThingsSystem.HomeTools
{
    partial class AddAskingPlaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAskingPlaceForm));
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new XanderUI.XUIButton();
            this.msgNotNull = new System.Windows.Forms.Label();
            this.msgPlaceExist = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.formBar.Size = new System.Drawing.Size(344, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(20, 8);
            this.formTitle.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(120, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "新增問事地點";
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
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(296, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "問事地點 :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Location = new System.Drawing.Point(117, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 35);
            this.panel1.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInput.Location = new System.Drawing.Point(9, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(98, 27);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "輸入地點";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
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
            this.btnAdd.Location = new System.Drawing.Point(263, 165);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // msgNotNull
            // 
            this.msgNotNull.AutoSize = true;
            this.msgNotNull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.msgNotNull.Image = ((System.Drawing.Image)(resources.GetObject("msgNotNull.Image")));
            this.msgNotNull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgNotNull.Location = new System.Drawing.Point(236, 83);
            this.msgNotNull.Name = "msgNotNull";
            this.msgNotNull.Size = new System.Drawing.Size(104, 26);
            this.msgNotNull.TabIndex = 4;
            this.msgNotNull.Text = "     必須輸入";
            this.msgNotNull.Visible = false;
            // 
            // msgPlaceExist
            // 
            this.msgPlaceExist.AutoSize = true;
            this.msgPlaceExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.msgPlaceExist.Image = ((System.Drawing.Image)(resources.GetObject("msgPlaceExist.Image")));
            this.msgPlaceExist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgPlaceExist.Location = new System.Drawing.Point(128, 116);
            this.msgPlaceExist.Name = "msgPlaceExist";
            this.msgPlaceExist.Size = new System.Drawing.Size(140, 26);
            this.msgPlaceExist.TabIndex = 5;
            this.msgPlaceExist.Text = "     該地點已存在";
            this.msgPlaceExist.Visible = false;
            // 
            // AddAskingPlaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(344, 220);
            this.Controls.Add(this.msgPlaceExist);
            this.Controls.Add(this.msgNotNull);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAskingPlaceForm";
            this.Text = "AddAskingPlaceForm";
            this.Load += new System.EventHandler(this.AddAskingPlaceForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInput;
        private XanderUI.XUIButton btnAdd;
        private System.Windows.Forms.Label msgNotNull;
        private System.Windows.Forms.Label msgPlaceExist;
    }
}