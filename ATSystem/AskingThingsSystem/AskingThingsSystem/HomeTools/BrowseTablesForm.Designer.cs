
namespace AskingThingsSystem.HomeTools
{
    partial class BrowseTablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseTablesForm));
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnShowAll = new XanderUI.XUIButton();
            this.btnSearch = new XanderUI.XUIButton();
            this.panInput = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.tablesView = new System.Windows.Forms.DataGridView();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inWarningMsg = new System.Windows.Forms.Label();
            this.panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1032, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnShowAll.ButtonImage = null;
            this.btnShowAll.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnShowAll.ButtonText = "顯示全部";
            this.btnShowAll.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnShowAll.ClickTextColor = System.Drawing.Color.White;
            this.btnShowAll.CornerRadius = 16;
            this.btnShowAll.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAll.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnShowAll.HoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowAll.Location = new System.Drawing.Point(65, 59);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(108, 46);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.TextColor = System.Drawing.Color.White;
            this.btnShowAll.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSearch.Location = new System.Drawing.Point(943, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panInput
            // 
            this.panInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panInput.BackColor = System.Drawing.Color.White;
            this.panInput.Controls.Add(this.txtInput);
            this.panInput.Location = new System.Drawing.Point(658, 59);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(253, 46);
            this.panInput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInput.Location = new System.Drawing.Point(30, 10);
            this.txtInput.Margin = new System.Windows.Forms.Padding(0);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 27);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "輸入關鍵字";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // tablesView
            // 
            this.tablesView.AllowUserToAddRows = false;
            this.tablesView.AllowUserToDeleteRows = false;
            this.tablesView.AllowUserToResizeColumns = false;
            this.tablesView.AllowUserToResizeRows = false;
            this.tablesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.tablesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.tablesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablesView.ColumnHeadersHeight = 44;
            this.tablesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableName,
            this.colDate,
            this.colPlace});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablesView.EnableHeadersVisualStyles = false;
            this.tablesView.Location = new System.Drawing.Point(65, 147);
            this.tablesView.Margin = new System.Windows.Forms.Padding(0);
            this.tablesView.MultiSelect = false;
            this.tablesView.Name = "tablesView";
            this.tablesView.ReadOnly = true;
            this.tablesView.RowHeadersVisible = false;
            this.tablesView.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tablesView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablesView.RowTemplate.Height = 40;
            this.tablesView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesView.Size = new System.Drawing.Size(950, 531);
            this.tablesView.TabIndex = 4;
            this.tablesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesView_CellClick);
            this.tablesView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablesView_ColumnHeaderMouseClick);
            // 
            // colTableName
            // 
            this.colTableName.HeaderText = "問事表名稱";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "問事日期";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "問事地點";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 43);
            this.panel1.TabIndex = 5;
            // 
            // inWarningMsg
            // 
            this.inWarningMsg.AutoSize = true;
            this.inWarningMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.inWarningMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.inWarningMsg.Image = ((System.Drawing.Image)(resources.GetObject("inWarningMsg.Image")));
            this.inWarningMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inWarningMsg.Location = new System.Drawing.Point(695, 111);
            this.inWarningMsg.Name = "inWarningMsg";
            this.inWarningMsg.Size = new System.Drawing.Size(248, 26);
            this.inWarningMsg.TabIndex = 6;
            this.inWarningMsg.Text = "     必須輸入內容，才能做查詢";
            this.inWarningMsg.Visible = false;
            // 
            // BrowseTablesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1080, 715);
            this.Controls.Add(this.tablesView);
            this.Controls.Add(this.inWarningMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowseTablesForm";
            this.Text = "BrowseTablesForm";
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private XanderUI.XUIButton btnShowAll;
        private XanderUI.XUIButton btnSearch;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView tablesView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.Label inWarningMsg;
    }
}