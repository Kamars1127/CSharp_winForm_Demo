
namespace AskingThingsSystem.HistoriesTools
{
    partial class PersonalHistoriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formBar = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnCompleteContent = new XanderUI.XUIButton();
            this.btnDelete = new XanderUI.XUIButton();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiesView = new System.Windows.Forms.DataGridView();
            this.formBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiesView)).BeginInit();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.lblName);
            this.formBar.Controls.Add(this.label1);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(1022, 42);
            this.formBar.TabIndex = 0;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(104, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 26);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "歷史紀錄 -";
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
            this.btnClose.Location = new System.Drawing.Point(974, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCompleteContent
            // 
            this.btnCompleteContent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnCompleteContent.ButtonImage = null;
            this.btnCompleteContent.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCompleteContent.ButtonText = "完整內容";
            this.btnCompleteContent.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCompleteContent.ClickTextColor = System.Drawing.Color.White;
            this.btnCompleteContent.CornerRadius = 16;
            this.btnCompleteContent.Enabled = false;
            this.btnCompleteContent.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCompleteContent.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCompleteContent.HoverTextColor = System.Drawing.Color.White;
            this.btnCompleteContent.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCompleteContent.Location = new System.Drawing.Point(883, 460);
            this.btnCompleteContent.Name = "btnCompleteContent";
            this.btnCompleteContent.Size = new System.Drawing.Size(103, 46);
            this.btnCompleteContent.TabIndex = 2;
            this.btnCompleteContent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCompleteContent.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCompleteContent.Click += new System.EventHandler(this.btnCompleteContent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDelete.ButtonText = "刪除";
            this.btnDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnDelete.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete.CornerRadius = 16;
            this.btnDelete.Enabled = false;
            this.btnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDelete.Location = new System.Drawing.Point(781, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // colRemarks
            // 
            this.colRemarks.FillWeight = 125.2115F;
            this.colRemarks.HeaderText = "備註";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            this.colRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colContent
            // 
            this.colContent.FillWeight = 125.2115F;
            this.colContent.HeaderText = "紀錄事項";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            this.colContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTableName
            // 
            this.colTableName.FillWeight = 125.2115F;
            this.colTableName.HeaderText = "問事表名稱";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.FillWeight = 24.36548F;
            this.colNum.HeaderText = "序號";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // historiesView
            // 
            this.historiesView.AllowUserToAddRows = false;
            this.historiesView.AllowUserToDeleteRows = false;
            this.historiesView.AllowUserToResizeColumns = false;
            this.historiesView.AllowUserToResizeRows = false;
            this.historiesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historiesView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historiesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.historiesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historiesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.historiesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historiesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historiesView.ColumnHeadersHeight = 44;
            this.historiesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historiesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colTableName,
            this.colContent,
            this.colRemarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historiesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.historiesView.EnableHeadersVisualStyles = false;
            this.historiesView.Location = new System.Drawing.Point(36, 78);
            this.historiesView.MultiSelect = false;
            this.historiesView.Name = "historiesView";
            this.historiesView.ReadOnly = true;
            this.historiesView.RowHeadersVisible = false;
            this.historiesView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.historiesView.RowTemplate.Height = 40;
            this.historiesView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historiesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historiesView.Size = new System.Drawing.Size(950, 352);
            this.historiesView.TabIndex = 1;
            this.historiesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historiesView_CellClick);
            this.historiesView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.historiesView_ColumnHeaderMouseClick);
            // 
            // PersonalHistoriesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1022, 525);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCompleteContent);
            this.Controls.Add(this.historiesView);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalHistoriesForm";
            this.Text = "PersonalHistoriesForm";
            this.Load += new System.EventHandler(this.PersonalHistoriesForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private XanderUI.XUIButton btnCompleteContent;
        private XanderUI.XUIButton btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridView historiesView;
    }
}