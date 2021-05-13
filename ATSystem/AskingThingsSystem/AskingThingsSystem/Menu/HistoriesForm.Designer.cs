
namespace AskingThingsSystem.Menu
{
    partial class HistoriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriesForm));
            this.formBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.historiesView = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new XanderUI.XUIButton();
            this.btnComplete = new XanderUI.XUIButton();
            this.btnSearch = new XanderUI.XUIButton();
            this.panInput = new System.Windows.Forms.Panel();
            this.txtInContent = new System.Windows.Forms.TextBox();
            this.inWarningMsg = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiesView)).BeginInit();
            this.panInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(1080, 43);
            this.formBar.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.btnClose.Location = new System.Drawing.Point(1032, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(74, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 26);
            this.lblName.TabIndex = 2;
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
            this.colHistory,
            this.colRemarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historiesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.historiesView.EnableHeadersVisualStyles = false;
            this.historiesView.Location = new System.Drawing.Point(65, 187);
            this.historiesView.MultiSelect = false;
            this.historiesView.Name = "historiesView";
            this.historiesView.ReadOnly = true;
            this.historiesView.RowHeadersVisible = false;
            this.historiesView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historiesView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.historiesView.RowTemplate.Height = 3;
            this.historiesView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historiesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historiesView.Size = new System.Drawing.Size(950, 540);
            this.historiesView.TabIndex = 3;
            this.historiesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historiesView_CellClick);
            this.historiesView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.historiesView_ColumnHeaderMouseClick);
            // 
            // colNum
            // 
            this.colNum.FillWeight = 30.45685F;
            this.colNum.HeaderText = "序號";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colTableName
            // 
            this.colTableName.FillWeight = 123.181F;
            this.colTableName.HeaderText = "問事表名稱";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            // 
            // colHistory
            // 
            this.colHistory.FillWeight = 123.181F;
            this.colHistory.HeaderText = "紀錄事項";
            this.colHistory.Name = "colHistory";
            this.colHistory.ReadOnly = true;
            this.colHistory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRemarks
            // 
            this.colRemarks.FillWeight = 123.181F;
            this.colRemarks.HeaderText = "備註";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            this.colRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btnDelete.Location = new System.Drawing.Point(65, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnComplete.ButtonImage = null;
            this.btnComplete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnComplete.ButtonText = "完整內容";
            this.btnComplete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnComplete.ClickTextColor = System.Drawing.Color.White;
            this.btnComplete.CornerRadius = 16;
            this.btnComplete.Enabled = false;
            this.btnComplete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComplete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnComplete.HoverTextColor = System.Drawing.Color.White;
            this.btnComplete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnComplete.Location = new System.Drawing.Point(166, 108);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(104, 46);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnComplete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnSearch.ButtonImage = null;
            this.btnSearch.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "查詢";
            this.btnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSearch.ClickTextColor = System.Drawing.Color.White;
            this.btnSearch.CornerRadius = 16;
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearch.Location = new System.Drawing.Point(943, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 46);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panInput
            // 
            this.panInput.BackColor = System.Drawing.Color.White;
            this.panInput.Controls.Add(this.txtInContent);
            this.panInput.Location = new System.Drawing.Point(664, 108);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(253, 46);
            this.panInput.TabIndex = 7;
            // 
            // txtInContent
            // 
            this.txtInContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInContent.Location = new System.Drawing.Point(31, 10);
            this.txtInContent.Name = "txtInContent";
            this.txtInContent.Size = new System.Drawing.Size(193, 27);
            this.txtInContent.TabIndex = 8;
            this.txtInContent.Text = "輸入姓名";
            this.txtInContent.Enter += new System.EventHandler(this.txtInContent_Enter);
            this.txtInContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInContent_KeyPress);
            this.txtInContent.Leave += new System.EventHandler(this.txtInContent_Leave);
            // 
            // inWarningMsg
            // 
            this.inWarningMsg.AutoSize = true;
            this.inWarningMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.inWarningMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.inWarningMsg.Image = ((System.Drawing.Image)(resources.GetObject("inWarningMsg.Image")));
            this.inWarningMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inWarningMsg.Location = new System.Drawing.Point(704, 157);
            this.inWarningMsg.Name = "inWarningMsg";
            this.inWarningMsg.Size = new System.Drawing.Size(230, 26);
            this.inWarningMsg.TabIndex = 8;
            this.inWarningMsg.Text = "     必須入姓名，才能做查詢";
            this.inWarningMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inWarningMsg.Visible = false;
            // 
            // HistoriesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1080, 758);
            this.Controls.Add(this.inWarningMsg);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.historiesView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriesForm";
            this.Text = "HistoriesForm";
            this.Load += new System.EventHandler(this.HistoriesForm_Load);
            this.formBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historiesView)).EndInit();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView historiesView;
        private XanderUI.XUIButton btnDelete;
        private XanderUI.XUIButton btnComplete;
        private XanderUI.XUIButton btnSearch;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.TextBox txtInContent;
        private System.Windows.Forms.Label inWarningMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
    }
}