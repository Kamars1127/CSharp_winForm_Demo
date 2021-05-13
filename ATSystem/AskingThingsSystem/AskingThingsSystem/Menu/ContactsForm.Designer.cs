
namespace AskingThingsSystem.Menu
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.formBar = new System.Windows.Forms.Panel();
            this.btnNewContact = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnShowAll = new XanderUI.XUIButton();
            this.btnSearch = new XanderUI.XUIButton();
            this.panInText = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contactDataView = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompleteData = new XanderUI.XUIButton();
            this.btnDelete = new XanderUI.XUIButton();
            this.inWarningMsg = new System.Windows.Forms.Label();
            this.formBar.SuspendLayout();
            this.panInText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.formBar.Controls.Add(this.btnNewContact);
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Margin = new System.Windows.Forms.Padding(0);
            this.formBar.Name = "formBar";
            this.formBar.Size = new System.Drawing.Size(1080, 43);
            this.formBar.TabIndex = 0;
            // 
            // btnNewContact
            // 
            this.btnNewContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnNewContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewContact.FlatAppearance.BorderSize = 0;
            this.btnNewContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnNewContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewContact.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnNewContact.ForeColor = System.Drawing.Color.White;
            this.btnNewContact.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNewContact.IconColor = System.Drawing.Color.White;
            this.btnNewContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewContact.IconSize = 28;
            this.btnNewContact.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNewContact.Location = new System.Drawing.Point(0, 0);
            this.btnNewContact.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewContact.Size = new System.Drawing.Size(188, 43);
            this.btnNewContact.TabIndex = 1;
            this.btnNewContact.Text = "新增聯絡資訊";
            this.btnNewContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewContact.UseVisualStyleBackColor = false;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
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
            this.btnShowAll.Location = new System.Drawing.Point(65, 103);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(0);
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
            this.btnSearch.Location = new System.Drawing.Point(791, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panInText
            // 
            this.panInText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panInText.BackColor = System.Drawing.Color.White;
            this.panInText.Controls.Add(this.txtInput);
            this.panInText.Location = new System.Drawing.Point(575, 103);
            this.panInText.Margin = new System.Windows.Forms.Padding(0);
            this.panInText.Name = "panInText";
            this.panInText.Size = new System.Drawing.Size(200, 46);
            this.panInText.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInput.Location = new System.Drawing.Point(26, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 27);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "輸入查詢內容";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // contactDataView
            // 
            this.contactDataView.AllowUserToAddRows = false;
            this.contactDataView.AllowUserToDeleteRows = false;
            this.contactDataView.AllowUserToResizeRows = false;
            this.contactDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.contactDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.contactDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactDataView.ColumnHeadersHeight = 44;
            this.contactDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.contactDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colName,
            this.colPhone,
            this.colPlace,
            this.colDate,
            this.colRemarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contactDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.contactDataView.EnableHeadersVisualStyles = false;
            this.contactDataView.Location = new System.Drawing.Point(65, 187);
            this.contactDataView.Margin = new System.Windows.Forms.Padding(0);
            this.contactDataView.MultiSelect = false;
            this.contactDataView.Name = "contactDataView";
            this.contactDataView.ReadOnly = true;
            this.contactDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.contactDataView.RowHeadersVisible = false;
            this.contactDataView.RowHeadersWidth = 40;
            this.contactDataView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.contactDataView.RowTemplate.Height = 40;
            this.contactDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contactDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactDataView.Size = new System.Drawing.Size(798, 540);
            this.contactDataView.TabIndex = 4;
            this.contactDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataView_CellClick);
            this.contactDataView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.contactDataView_ColumnHeaderMouseClick);
            // 
            // colNum
            // 
            this.colNum.FillWeight = 59.28933F;
            this.colNum.HeaderText = "序號";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 94.25979F;
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.FillWeight = 123.5252F;
            this.colPhone.HeaderText = "聯絡電話";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colPlace
            // 
            this.colPlace.FillWeight = 82.35012F;
            this.colPlace.HeaderText = "居住地";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 164.7002F;
            this.colDate.HeaderText = "新增日期";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colRemarks
            // 
            this.colRemarks.FillWeight = 205.8753F;
            this.colRemarks.HeaderText = "備註";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            // 
            // btnCompleteData
            // 
            this.btnCompleteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnCompleteData.ButtonImage = null;
            this.btnCompleteData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCompleteData.ButtonText = "檢視全整資訊";
            this.btnCompleteData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCompleteData.ClickTextColor = System.Drawing.Color.White;
            this.btnCompleteData.CornerRadius = 16;
            this.btnCompleteData.Enabled = false;
            this.btnCompleteData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCompleteData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCompleteData.HoverTextColor = System.Drawing.Color.White;
            this.btnCompleteData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCompleteData.Location = new System.Drawing.Point(892, 187);
            this.btnCompleteData.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompleteData.Name = "btnCompleteData";
            this.btnCompleteData.Size = new System.Drawing.Size(144, 46);
            this.btnCompleteData.TabIndex = 5;
            this.btnCompleteData.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCompleteData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCompleteData.Click += new System.EventHandler(this.btnCompleteData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDelete.Location = new System.Drawing.Point(892, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inWarningMsg
            // 
            this.inWarningMsg.AutoSize = true;
            this.inWarningMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.inWarningMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.inWarningMsg.Image = ((System.Drawing.Image)(resources.GetObject("inWarningMsg.Image")));
            this.inWarningMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inWarningMsg.Location = new System.Drawing.Point(615, 155);
            this.inWarningMsg.Name = "inWarningMsg";
            this.inWarningMsg.Size = new System.Drawing.Size(248, 26);
            this.inWarningMsg.TabIndex = 7;
            this.inWarningMsg.Text = "     必須輸入內容，才能做查詢";
            this.inWarningMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inWarningMsg.Visible = false;
            // 
            // ContactsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1080, 758);
            this.Controls.Add(this.inWarningMsg);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCompleteData);
            this.Controls.Add(this.contactDataView);
            this.Controls.Add(this.panInText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.formBar.ResumeLayout(false);
            this.panInText.ResumeLayout(false);
            this.panInText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnNewContact;
        private FontAwesome.Sharp.IconButton btnClose;
        private XanderUI.XUIButton btnShowAll;
        private XanderUI.XUIButton btnSearch;
        private System.Windows.Forms.Panel panInText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView contactDataView;
        private XanderUI.XUIButton btnCompleteData;
        private XanderUI.XUIButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.Label inWarningMsg;
    }
}