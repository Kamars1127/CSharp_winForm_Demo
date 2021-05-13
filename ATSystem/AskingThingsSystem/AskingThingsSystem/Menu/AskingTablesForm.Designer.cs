
namespace AskingThingsSystem.Menu
{
    partial class AskingTablesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExportToPDF = new FontAwesome.Sharp.IconButton();
            this.btnSignUpList = new FontAwesome.Sharp.IconButton();
            this.btnSignUp = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panSignUPList = new System.Windows.Forms.Panel();
            this.btnUpdate = new XanderUI.XUIButton();
            this.btnAsking = new XanderUI.XUIButton();
            this.btnRemoveName = new XanderUI.XUIButton();
            this.btnInfoView = new XanderUI.XUIButton();
            this.nameView = new System.Windows.Forms.DataGridView();
            this.colListNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panInput = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.askingTableView = new System.Windows.Forms.DataGridView();
            this.colTableNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTablePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new XanderUI.XUIButton();
            this.btnDeleteLog = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWaitedCount = new System.Windows.Forms.Label();
            this.lblSignUpCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panTable = new System.Windows.Forms.Panel();
            this.formBar.SuspendLayout();
            this.panSignUPList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameView)).BeginInit();
            this.panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.askingTableView)).BeginInit();
            this.panTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));
            this.formBar.Controls.Add(this.btnMinimize);
            this.formBar.Controls.Add(this.btnExportToPDF);
            this.formBar.Controls.Add(this.btnSignUpList);
            this.formBar.Controls.Add(this.btnSignUp);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(1080, 43);
            this.formBar.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(984, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 43);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnExportToPDF.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExportToPDF.FlatAppearance.BorderSize = 0;
            this.btnExportToPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnExportToPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPDF.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnExportToPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportToPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnExportToPDF.IconColor = System.Drawing.Color.White;
            this.btnExportToPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportToPDF.IconSize = 27;
            this.btnExportToPDF.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExportToPDF.Location = new System.Drawing.Point(280, 0);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExportToPDF.Size = new System.Drawing.Size(168, 43);
            this.btnExportToPDF.TabIndex = 3;
            this.btnExportToPDF.Text = "匯出成PDF";
            this.btnExportToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportToPDF.UseVisualStyleBackColor = false;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnSignUpList
            // 
            this.btnSignUpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnSignUpList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSignUpList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignUpList.FlatAppearance.BorderSize = 0;
            this.btnSignUpList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnSignUpList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnSignUpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpList.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnSignUpList.ForeColor = System.Drawing.Color.White;
            this.btnSignUpList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnSignUpList.IconColor = System.Drawing.Color.White;
            this.btnSignUpList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUpList.IconSize = 30;
            this.btnSignUpList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSignUpList.Location = new System.Drawing.Point(112, 0);
            this.btnSignUpList.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignUpList.Name = "btnSignUpList";
            this.btnSignUpList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignUpList.Size = new System.Drawing.Size(168, 43);
            this.btnSignUpList.TabIndex = 2;
            this.btnSignUpList.Text = "顯示報名列";
            this.btnSignUpList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUpList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUpList.UseVisualStyleBackColor = false;
            this.btnSignUpList.Click += new System.EventHandler(this.btnSignUpList_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.IconChar = FontAwesome.Sharp.IconChar.Signature;
            this.btnSignUp.IconColor = System.Drawing.Color.White;
            this.btnSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUp.IconSize = 32;
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSignUp.Location = new System.Drawing.Point(0, 0);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignUp.Size = new System.Drawing.Size(112, 43);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "報名";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
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
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panSignUPList
            // 
            this.panSignUPList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.panSignUPList.Controls.Add(this.btnUpdate);
            this.panSignUPList.Controls.Add(this.btnAsking);
            this.panSignUPList.Controls.Add(this.btnRemoveName);
            this.panSignUPList.Controls.Add(this.btnInfoView);
            this.panSignUPList.Controls.Add(this.nameView);
            this.panSignUPList.Controls.Add(this.panInput);
            this.panSignUPList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSignUPList.Location = new System.Drawing.Point(0, 43);
            this.panSignUPList.Name = "panSignUPList";
            this.panSignUPList.Size = new System.Drawing.Size(234, 715);
            this.panSignUPList.TabIndex = 1;
            this.panSignUPList.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnUpdate.ButtonImage = null;
            this.btnUpdate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUpdate.ButtonText = "更新";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnUpdate.ClickTextColor = System.Drawing.Color.White;
            this.btnUpdate.CornerRadius = 16;
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnUpdate.HoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(145, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAsking
            // 
            this.btnAsking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.btnAsking.ButtonImage = null;
            this.btnAsking.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAsking.ButtonText = "問事";
            this.btnAsking.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAsking.ClickTextColor = System.Drawing.Color.White;
            this.btnAsking.CornerRadius = 16;
            this.btnAsking.Enabled = false;
            this.btnAsking.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAsking.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAsking.HoverTextColor = System.Drawing.Color.White;
            this.btnAsking.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAsking.Location = new System.Drawing.Point(145, 576);
            this.btnAsking.Name = "btnAsking";
            this.btnAsking.Size = new System.Drawing.Size(72, 46);
            this.btnAsking.TabIndex = 5;
            this.btnAsking.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(62)))), ((int)(((byte)(42)))));
            this.btnAsking.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAsking.Click += new System.EventHandler(this.btnAsking_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.btnRemoveName.ButtonImage = null;
            this.btnRemoveName.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRemoveName.ButtonText = "刪除";
            this.btnRemoveName.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnRemoveName.ClickTextColor = System.Drawing.Color.White;
            this.btnRemoveName.CornerRadius = 16;
            this.btnRemoveName.Enabled = false;
            this.btnRemoveName.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveName.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnRemoveName.HoverTextColor = System.Drawing.Color.White;
            this.btnRemoveName.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRemoveName.Location = new System.Drawing.Point(145, 641);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(72, 46);
            this.btnRemoveName.TabIndex = 4;
            this.btnRemoveName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(62)))), ((int)(((byte)(42)))));
            this.btnRemoveName.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveName.Click += new System.EventHandler(this.btnDeleteName_Click);
            // 
            // btnInfoView
            // 
            this.btnInfoView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInfoView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.btnInfoView.ButtonImage = null;
            this.btnInfoView.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInfoView.ButtonText = "檢視";
            this.btnInfoView.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnInfoView.ClickTextColor = System.Drawing.Color.White;
            this.btnInfoView.CornerRadius = 16;
            this.btnInfoView.Enabled = false;
            this.btnInfoView.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInfoView.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnInfoView.HoverTextColor = System.Drawing.Color.White;
            this.btnInfoView.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInfoView.Location = new System.Drawing.Point(16, 576);
            this.btnInfoView.Name = "btnInfoView";
            this.btnInfoView.Size = new System.Drawing.Size(72, 46);
            this.btnInfoView.TabIndex = 3;
            this.btnInfoView.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(62)))), ((int)(((byte)(42)))));
            this.btnInfoView.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInfoView.Click += new System.EventHandler(this.btnInfoView_Click);
            // 
            // nameView
            // 
            this.nameView.AllowUserToAddRows = false;
            this.nameView.AllowUserToDeleteRows = false;
            this.nameView.AllowUserToResizeColumns = false;
            this.nameView.AllowUserToResizeRows = false;
            this.nameView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nameView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.nameView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.nameView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.nameView.ColumnHeadersHeight = 44;
            this.nameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.nameView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colListNum,
            this.colListName});
            this.nameView.EnableHeadersVisualStyles = false;
            this.nameView.Location = new System.Drawing.Point(16, 83);
            this.nameView.Margin = new System.Windows.Forms.Padding(0);
            this.nameView.MultiSelect = false;
            this.nameView.Name = "nameView";
            this.nameView.ReadOnly = true;
            this.nameView.RowHeadersVisible = false;
            this.nameView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.nameView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nameView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.nameView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nameView.RowTemplate.Height = 40;
            this.nameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nameView.Size = new System.Drawing.Size(201, 472);
            this.nameView.TabIndex = 2;
            this.nameView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nameView_CellClick);
            // 
            // colListNum
            // 
            this.colListNum.FillWeight = 60.9137F;
            this.colListNum.HeaderText = "序號";
            this.colListNum.Name = "colListNum";
            this.colListNum.ReadOnly = true;
            this.colListNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colListName
            // 
            this.colListName.FillWeight = 139.0863F;
            this.colListName.HeaderText = "姓名";
            this.colListName.Name = "colListName";
            this.colListName.ReadOnly = true;
            this.colListName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panInput
            // 
            this.panInput.BackColor = System.Drawing.Color.White;
            this.panInput.Controls.Add(this.txtInput);
            this.panInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panInput.Location = new System.Drawing.Point(16, 20);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(116, 46);
            this.panInput.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInput.Location = new System.Drawing.Point(19, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(80, 27);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "輸入姓名";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // askingTableView
            // 
            this.askingTableView.AllowUserToAddRows = false;
            this.askingTableView.AllowUserToDeleteRows = false;
            this.askingTableView.AllowUserToResizeColumns = false;
            this.askingTableView.AllowUserToResizeRows = false;
            this.askingTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.askingTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.askingTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.askingTableView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.askingTableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.askingTableView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.askingTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.askingTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.askingTableView.ColumnHeadersHeight = 44;
            this.askingTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.askingTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableNum,
            this.colTableName,
            this.colTableContent,
            this.colTablePhone,
            this.colTableRemarks});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.askingTableView.DefaultCellStyle = dataGridViewCellStyle12;
            this.askingTableView.EnableHeadersVisualStyles = false;
            this.askingTableView.Location = new System.Drawing.Point(27, 77);
            this.askingTableView.MultiSelect = false;
            this.askingTableView.Name = "askingTableView";
            this.askingTableView.ReadOnly = true;
            this.askingTableView.RowHeadersVisible = false;
            this.askingTableView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.askingTableView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.askingTableView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.askingTableView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.askingTableView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.askingTableView.RowTemplate.Height = 40;
            this.askingTableView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.askingTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.askingTableView.Size = new System.Drawing.Size(793, 527);
            this.askingTableView.TabIndex = 2;
            this.askingTableView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.askingTableView_CellClick);
            // 
            // colTableNum
            // 
            this.colTableNum.FillWeight = 46.29724F;
            this.colTableNum.HeaderText = "序號";
            this.colTableNum.Name = "colTableNum";
            this.colTableNum.ReadOnly = true;
            // 
            // colTableName
            // 
            this.colTableName.FillWeight = 84.00038F;
            this.colTableName.HeaderText = "姓名";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            this.colTableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTableContent
            // 
            this.colTableContent.FillWeight = 140.435F;
            this.colTableContent.HeaderText = "紀錄事項";
            this.colTableContent.Name = "colTableContent";
            this.colTableContent.ReadOnly = true;
            this.colTableContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTablePhone
            // 
            this.colTablePhone.FillWeight = 88.83249F;
            this.colTablePhone.HeaderText = "聯絡電話";
            this.colTablePhone.Name = "colTablePhone";
            this.colTablePhone.ReadOnly = true;
            this.colTablePhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTableRemarks
            // 
            this.colTableRemarks.FillWeight = 140.435F;
            this.colTableRemarks.HeaderText = "備註";
            this.colTableRemarks.Name = "colTableRemarks";
            this.colTableRemarks.ReadOnly = true;
            this.colTableRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnEdit.ButtonImage = null;
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "編輯";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit.CornerRadius = 16;
            this.btnEdit.Enabled = false;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(739, 641);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 46);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnDeleteLog.ButtonImage = null;
            this.btnDeleteLog.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeleteLog.ButtonText = "刪除";
            this.btnDeleteLog.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnDeleteLog.ClickTextColor = System.Drawing.Color.White;
            this.btnDeleteLog.CornerRadius = 16;
            this.btnDeleteLog.Enabled = false;
            this.btnDeleteLog.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteLog.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnDeleteLog.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteLog.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeleteLog.Location = new System.Drawing.Point(614, 641);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(72, 46);
            this.btnDeleteLog.TabIndex = 8;
            this.btnDeleteLog.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDeleteLog.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(511, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "今日報名人數 :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "等待人數 :";
            // 
            // lblWaitedCount
            // 
            this.lblWaitedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaitedCount.AutoSize = true;
            this.lblWaitedCount.ForeColor = System.Drawing.Color.White;
            this.lblWaitedCount.Location = new System.Drawing.Point(776, 31);
            this.lblWaitedCount.Name = "lblWaitedCount";
            this.lblWaitedCount.Size = new System.Drawing.Size(22, 26);
            this.lblWaitedCount.TabIndex = 11;
            this.lblWaitedCount.Text = "0";
            // 
            // lblSignUpCount
            // 
            this.lblSignUpCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignUpCount.AutoSize = true;
            this.lblSignUpCount.ForeColor = System.Drawing.Color.White;
            this.lblSignUpCount.Location = new System.Drawing.Point(634, 31);
            this.lblSignUpCount.Name = "lblSignUpCount";
            this.lblSignUpCount.Size = new System.Drawing.Size(22, 26);
            this.lblSignUpCount.TabIndex = 12;
            this.lblSignUpCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // panTable
            // 
            this.panTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.panTable.Controls.Add(this.btnEdit);
            this.panTable.Controls.Add(this.btnDeleteLog);
            this.panTable.Controls.Add(this.lblWaitedCount);
            this.panTable.Controls.Add(this.lblSignUpCount);
            this.panTable.Controls.Add(this.askingTableView);
            this.panTable.Controls.Add(this.label2);
            this.panTable.Controls.Add(this.label1);
            this.panTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTable.Location = new System.Drawing.Point(234, 43);
            this.panTable.Name = "panTable";
            this.panTable.Size = new System.Drawing.Size(846, 715);
            this.panTable.TabIndex = 14;
            // 
            // AskingTablesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1080, 758);
            this.Controls.Add(this.panTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panSignUPList);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AskingTablesForm";
            this.Text = "                          ";
            this.formBar.ResumeLayout(false);
            this.panSignUPList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameView)).EndInit();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.askingTableView)).EndInit();
            this.panTable.ResumeLayout(false);
            this.panTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnSignUp;
        private FontAwesome.Sharp.IconButton btnSignUpList;
        private FontAwesome.Sharp.IconButton btnExportToPDF;
        private System.Windows.Forms.Panel panSignUPList;
        private XanderUI.XUIButton btnInfoView;
        private System.Windows.Forms.DataGridView nameView;
        private System.Windows.Forms.Panel panInput;
        private XanderUI.XUIButton btnAsking;
        private XanderUI.XUIButton btnRemoveName;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView askingTableView;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIButton btnDeleteLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWaitedCount;
        private System.Windows.Forms.Label lblSignUpCount;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panTable;
        private XanderUI.XUIButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTablePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableRemarks;
    }
}