
namespace AskingThingsSystem.HistoriesTools
{
    partial class WhichOneToSearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formBar = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.personalInfoView = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new XanderUI.XUIButton();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoView)).BeginInit();
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
            this.formBar.Size = new System.Drawing.Size(400, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(15, 8);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(156, 26);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "確認要查詢的對象";
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
            this.btnClose.Location = new System.Drawing.Point(352, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // personalInfoView
            // 
            this.personalInfoView.AllowUserToAddRows = false;
            this.personalInfoView.AllowUserToDeleteRows = false;
            this.personalInfoView.AllowUserToResizeColumns = false;
            this.personalInfoView.AllowUserToResizeRows = false;
            this.personalInfoView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personalInfoView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.personalInfoView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personalInfoView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.personalInfoView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personalInfoView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.personalInfoView.ColumnHeadersHeight = 44;
            this.personalInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.personalInfoView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPlace,
            this.colPhone});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personalInfoView.DefaultCellStyle = dataGridViewCellStyle4;
            this.personalInfoView.EnableHeadersVisualStyles = false;
            this.personalInfoView.Location = new System.Drawing.Point(16, 58);
            this.personalInfoView.MultiSelect = false;
            this.personalInfoView.Name = "personalInfoView";
            this.personalInfoView.ReadOnly = true;
            this.personalInfoView.RowHeadersVisible = false;
            this.personalInfoView.RowTemplate.Height = 40;
            this.personalInfoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personalInfoView.Size = new System.Drawing.Size(368, 212);
            this.personalInfoView.TabIndex = 1;
            this.personalInfoView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personalInfoView_CellClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnConfirm.ButtonImage = null;
            this.btnConfirm.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirm.ButtonText = "確認";
            this.btnConfirm.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnConfirm.ClickTextColor = System.Drawing.Color.White;
            this.btnConfirm.CornerRadius = 16;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirm.Location = new System.Drawing.Point(312, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(72, 46);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnConfirm.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // WhichOneToSearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(400, 366);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.personalInfoView);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WhichOneToSearchForm";
            this.Text = "WhichOneToSearchForm";
            this.Load += new System.EventHandler(this.WhichOneToSearchForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private System.Windows.Forms.Label formTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DataGridView personalInfoView;
        private XanderUI.XUIButton btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}