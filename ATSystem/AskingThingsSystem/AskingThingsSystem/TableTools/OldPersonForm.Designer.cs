
namespace AskingThingsSystem.TableTools
{
    partial class OldPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldPersonForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameMsg = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panRemark = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCancel = new XanderUI.XUIButton();
            this.btnSignUp = new XanderUI.XUIButton();
            this.formBar.SuspendLayout();
            this.panName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.panRemark.SuspendLayout();
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
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(15, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(98, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "報名 - 舊人";
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
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
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
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.White;
            this.panName.Controls.Add(this.txtName);
            this.panName.Location = new System.Drawing.Point(88, 67);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(115, 35);
            this.panName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(8, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
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
            this.lblNameMsg.TabIndex = 3;
            this.lblNameMsg.Text = "     必須輸入";
            this.lblNameMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameMsg.Visible = false;
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.AllowUserToResizeColumns = false;
            this.resultView.AllowUserToResizeRows = false;
            this.resultView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.resultView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.resultView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultView.ColumnHeadersHeight = 44;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPlace,
            this.colPhone});
            this.resultView.EnableHeadersVisualStyles = false;
            this.resultView.Location = new System.Drawing.Point(69, 127);
            this.resultView.MultiSelect = false;
            this.resultView.Name = "resultView";
            this.resultView.ReadOnly = true;
            this.resultView.RowHeadersVisible = false;
            this.resultView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.resultView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.resultView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.resultView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultView.RowTemplate.Height = 40;
            this.resultView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultView.Size = new System.Drawing.Size(344, 175);
            this.resultView.TabIndex = 4;
            this.resultView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultView_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "居住地";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            this.colPlace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "聯絡電話";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "備註 :";
            // 
            // panRemark
            // 
            this.panRemark.BackColor = System.Drawing.Color.White;
            this.panRemark.Controls.Add(this.txtRemark);
            this.panRemark.Location = new System.Drawing.Point(88, 344);
            this.panRemark.Name = "panRemark";
            this.panRemark.Size = new System.Drawing.Size(325, 154);
            this.panRemark.TabIndex = 6;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemark.Location = new System.Drawing.Point(8, 7);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(310, 140);
            this.txtRemark.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(35, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnSignUp.ButtonImage = null;
            this.btnSignUp.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSignUp.ButtonText = "報名";
            this.btnSignUp.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSignUp.ClickTextColor = System.Drawing.Color.White;
            this.btnSignUp.CornerRadius = 16;
            this.btnSignUp.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSignUp.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSignUp.HoverTextColor = System.Drawing.Color.White;
            this.btnSignUp.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSignUp.Location = new System.Drawing.Point(373, 522);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(72, 46);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // OldPersonForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(483, 596);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panRemark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.lblNameMsg);
            this.Controls.Add(this.panName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldPersonForm";
            this.Text = "OldPersonForm";
            this.Load += new System.EventHandler(this.OldPersonForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.panRemark.ResumeLayout(false);
            this.panRemark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameMsg;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private XanderUI.XUIButton btnCancel;
        private XanderUI.XUIButton btnSignUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}