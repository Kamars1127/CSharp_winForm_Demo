
namespace AskingThingsSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panMenu = new System.Windows.Forms.Panel();
            this.iconOnOff = new FontAwesome.Sharp.IconButton();
            this.lblAskingTable = new System.Windows.Forms.Label();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnHistories = new FontAwesome.Sharp.IconButton();
            this.btnContact = new FontAwesome.Sharp.IconButton();
            this.panTablesArea = new System.Windows.Forms.Panel();
            this.btnAskingTable = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.formBar = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnCloseForm = new FontAwesome.Sharp.IconButton();
            this.workDesktop = new System.Windows.Forms.Panel();
            this.btnManual = new XanderUI.XUIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.formBar.SuspendLayout();
            this.workDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panMenu.Controls.Add(this.iconOnOff);
            this.panMenu.Controls.Add(this.lblAskingTable);
            this.panMenu.Controls.Add(this.btnAbout);
            this.panMenu.Controls.Add(this.btnHistories);
            this.panMenu.Controls.Add(this.btnContact);
            this.panMenu.Controls.Add(this.panTablesArea);
            this.panMenu.Controls.Add(this.btnAskingTable);
            this.panMenu.Controls.Add(this.btnHome);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(200, 800);
            this.panMenu.TabIndex = 0;
            // 
            // iconOnOff
            // 
            this.iconOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));
            this.iconOnOff.Enabled = false;
            this.iconOnOff.FlatAppearance.BorderSize = 0;
            this.iconOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconOnOff.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.iconOnOff.IconColor = System.Drawing.Color.White;
            this.iconOnOff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOnOff.IconSize = 30;
            this.iconOnOff.Location = new System.Drawing.Point(151, 120);
            this.iconOnOff.Name = "iconOnOff";
            this.iconOnOff.Size = new System.Drawing.Size(32, 23);
            this.iconOnOff.TabIndex = 11;
            this.iconOnOff.UseVisualStyleBackColor = false;
            this.iconOnOff.Visible = false;
            // 
            // lblAskingTable
            // 
            this.lblAskingTable.AutoSize = true;
            this.lblAskingTable.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.lblAskingTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.lblAskingTable.Location = new System.Drawing.Point(63, 111);
            this.lblAskingTable.Name = "lblAskingTable";
            this.lblAskingTable.Size = new System.Drawing.Size(81, 32);
            this.lblAskingTable.TabIndex = 10;
            this.lblAskingTable.Text = "問事表";
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 30;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 583);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(200, 85);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "關於";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHistories
            // 
            this.btnHistories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHistories.FlatAppearance.BorderSize = 0;
            this.btnHistories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnHistories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnHistories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistories.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnHistories.ForeColor = System.Drawing.Color.White;
            this.btnHistories.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistories.IconColor = System.Drawing.Color.White;
            this.btnHistories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistories.IconSize = 30;
            this.btnHistories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistories.Location = new System.Drawing.Point(0, 498);
            this.btnHistories.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistories.Name = "btnHistories";
            this.btnHistories.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHistories.Size = new System.Drawing.Size(200, 85);
            this.btnHistories.TabIndex = 7;
            this.btnHistories.Text = "問事紀錄";
            this.btnHistories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistories.UseVisualStyleBackColor = true;
            this.btnHistories.Click += new System.EventHandler(this.btnHistories_Click);
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnContact.IconColor = System.Drawing.Color.White;
            this.btnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContact.IconSize = 30;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 413);
            this.btnContact.Margin = new System.Windows.Forms.Padding(0);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(200, 85);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "聯絡資訊";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panTablesArea
            // 
            this.panTablesArea.AutoScroll = true;
            this.panTablesArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));
            this.panTablesArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTablesArea.Location = new System.Drawing.Point(0, 170);
            this.panTablesArea.Name = "panTablesArea";
            this.panTablesArea.Size = new System.Drawing.Size(200, 243);
            this.panTablesArea.TabIndex = 5;
            this.panTablesArea.Visible = false;
            // 
            // btnAskingTable
            // 
            this.btnAskingTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAskingTable.Enabled = false;
            this.btnAskingTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAskingTable.FlatAppearance.BorderSize = 0;
            this.btnAskingTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));
            this.btnAskingTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(178)))));
            this.btnAskingTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAskingTable.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnAskingTable.ForeColor = System.Drawing.Color.White;
            this.btnAskingTable.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnAskingTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnAskingTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAskingTable.IconSize = 30;
            this.btnAskingTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAskingTable.Location = new System.Drawing.Point(0, 85);
            this.btnAskingTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnAskingTable.Name = "btnAskingTable";
            this.btnAskingTable.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAskingTable.Size = new System.Drawing.Size(200, 85);
            this.btnAskingTable.TabIndex = 1;
            this.btnAskingTable.Text = "問事表";
            this.btnAskingTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAskingTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAskingTable.UseVisualStyleBackColor = true;
            this.btnAskingTable.Click += new System.EventHandler(this.btnAskingTable_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Noto Sans TC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 85);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "檔案";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.formBar.Controls.Add(this.appName);
            this.formBar.Controls.Add(this.btnMinimize);
            this.formBar.Controls.Add(this.btnMaximize);
            this.formBar.Controls.Add(this.btnCloseForm);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(200, 0);
            this.formBar.Margin = new System.Windows.Forms.Padding(0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(1080, 42);
            this.formBar.TabIndex = 1;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(427, 8);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(99, 26);
            this.appName.TabIndex = 3;
            this.appName.Text = "AT System";
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
            this.btnMinimize.Location = new System.Drawing.Point(936, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 42);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.Location = new System.Drawing.Point(984, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 42);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseForm.IconSize = 30;
            this.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseForm.Location = new System.Drawing.Point(1032, 0);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(48, 42);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // workDesktop
            // 
            this.workDesktop.Controls.Add(this.btnManual);
            this.workDesktop.Controls.Add(this.lblTitle);
            this.workDesktop.Controls.Add(this.lblVersion);
            this.workDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workDesktop.Location = new System.Drawing.Point(200, 42);
            this.workDesktop.Name = "workDesktop";
            this.workDesktop.Size = new System.Drawing.Size(1080, 758);
            this.workDesktop.TabIndex = 2;
            // 
            // btnManual
            // 
            this.btnManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnManual.ButtonImage = null;
            this.btnManual.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnManual.ButtonText = "操作說明";
            this.btnManual.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnManual.ClickTextColor = System.Drawing.Color.White;
            this.btnManual.CornerRadius = 16;
            this.btnManual.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnManual.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnManual.HoverTextColor = System.Drawing.Color.White;
            this.btnManual.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnManual.Location = new System.Drawing.Point(460, 332);
            this.btnManual.Margin = new System.Windows.Forms.Padding(0);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(160, 52);
            this.btnManual.TabIndex = 2;
            this.btnManual.TextColor = System.Drawing.Color.White;
            this.btnManual.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans TC", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(314, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(470, 67);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "歡迎使用『 AT系統 』";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Noto Sans TC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(859, 714);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(209, 35);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "當前版本: ver.1.05";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.workDesktop);
            this.Controls.Add(this.formBar);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.workDesktop.ResumeLayout(false);
            this.workDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnCloseForm;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel workDesktop;
        private System.Windows.Forms.Label appName;
        private XanderUI.XUIButton btnManual;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panTablesArea;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnHistories;
        private FontAwesome.Sharp.IconButton btnContact;
        private FontAwesome.Sharp.IconButton btnAskingTable;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label lblAskingTable;
        private FontAwesome.Sharp.IconButton iconOnOff;
    }
}

