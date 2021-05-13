
namespace AskingThingsSystem.HomeTools
{
    partial class EditAskingPlaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panInput = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new XanderUI.XUIButton();
            this.placeView = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new XanderUI.XUIButton();
            this.btnDelete = new XanderUI.XUIButton();
            this.btnModify = new XanderUI.XUIButton();
            this.formBar.SuspendLayout();
            this.panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeView)).BeginInit();
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
            this.formBar.Size = new System.Drawing.Size(304, 42);
            this.formBar.TabIndex = 0;
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
            this.formTitle.Text = "編輯問事地點";
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
            this.btnClose.Location = new System.Drawing.Point(256, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "問事地點 :";
            // 
            // panInput
            // 
            this.panInput.BackColor = System.Drawing.Color.White;
            this.panInput.Controls.Add(this.txtInput);
            this.panInput.Location = new System.Drawing.Point(112, 54);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(95, 35);
            this.panInput.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtInput.Location = new System.Drawing.Point(7, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(80, 27);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "輸入地點";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnSearch.ButtonImage = null;
            this.btnSearch.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "查詢";
            this.btnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSearch.ClickTextColor = System.Drawing.Color.White;
            this.btnSearch.CornerRadius = 8;
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearch.Location = new System.Drawing.Point(219, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // placeView
            // 
            this.placeView.AllowUserToAddRows = false;
            this.placeView.AllowUserToDeleteRows = false;
            this.placeView.AllowUserToResizeRows = false;
            this.placeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.placeView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.placeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.placeView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.placeView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.placeView.ColumnHeadersHeight = 44;
            this.placeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.placeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colPlace});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.placeView.DefaultCellStyle = dataGridViewCellStyle4;
            this.placeView.EnableHeadersVisualStyles = false;
            this.placeView.Location = new System.Drawing.Point(17, 105);
            this.placeView.Margin = new System.Windows.Forms.Padding(0);
            this.placeView.MultiSelect = false;
            this.placeView.Name = "placeView";
            this.placeView.ReadOnly = true;
            this.placeView.RowHeadersVisible = false;
            this.placeView.RowHeadersWidth = 40;
            this.placeView.RowTemplate.Height = 40;
            this.placeView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.placeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.placeView.Size = new System.Drawing.Size(190, 276);
            this.placeView.TabIndex = 4;
            this.placeView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.placeView_CellClick);
            this.placeView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.placeView_ColumnHeaderMouseClick);
            // 
            // colNum
            // 
            this.colNum.FillWeight = 65.98985F;
            this.colNum.HeaderText = "序號";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colPlace
            // 
            this.colPlace.FillWeight = 134.0102F;
            this.colPlace.HeaderText = "地點";
            this.colPlace.Name = "colPlace";
            this.colPlace.ReadOnly = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnShowAll.ButtonImage = null;
            this.btnShowAll.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnShowAll.ButtonText = "全部";
            this.btnShowAll.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnShowAll.ClickTextColor = System.Drawing.Color.White;
            this.btnShowAll.CornerRadius = 16;
            this.btnShowAll.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAll.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnShowAll.HoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowAll.Location = new System.Drawing.Point(219, 221);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(72, 46);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.TextColor = System.Drawing.Color.White;
            this.btnShowAll.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(219, 335);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnModify.ButtonImage = null;
            this.btnModify.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnModify.ButtonText = "修改";
            this.btnModify.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnModify.ClickTextColor = System.Drawing.Color.White;
            this.btnModify.CornerRadius = 16;
            this.btnModify.Enabled = false;
            this.btnModify.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnModify.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnModify.HoverTextColor = System.Drawing.Color.White;
            this.btnModify.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnModify.Location = new System.Drawing.Point(219, 278);
            this.btnModify.Margin = new System.Windows.Forms.Padding(0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 46);
            this.btnModify.TabIndex = 7;
            this.btnModify.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnModify.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // EditAskingPlaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(229)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(304, 398);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.placeView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAskingPlaceForm";
            this.Text = "EditAskingPlaceForm";
            this.Load += new System.EventHandler(this.EditAskingPlaceForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panInput;
        private XanderUI.XUIButton btnSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView placeView;
        private XanderUI.XUIButton btnShowAll;
        private XanderUI.XUIButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private XanderUI.XUIButton btnModify;
    }
}