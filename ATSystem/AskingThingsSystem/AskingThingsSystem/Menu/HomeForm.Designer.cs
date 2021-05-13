
namespace AskingThingsSystem.Menu
{
    partial class HomeForm
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
            this.formBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnEditPlace = new FontAwesome.Sharp.IconButton();
            this.btnAddPlace = new FontAwesome.Sharp.IconButton();
            this.btnBrowseTables = new FontAwesome.Sharp.IconButton();
            this.btnNewTable = new FontAwesome.Sharp.IconButton();
            this.workDesktop = new System.Windows.Forms.Panel();
            this.formBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.formBar.Controls.Add(this.btnClose);
            this.formBar.Controls.Add(this.btnEditPlace);
            this.formBar.Controls.Add(this.btnAddPlace);
            this.formBar.Controls.Add(this.btnBrowseTables);
            this.formBar.Controls.Add(this.btnNewTable);
            this.formBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBar.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(1032, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditPlace
            // 
            this.btnEditPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnEditPlace.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditPlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditPlace.FlatAppearance.BorderSize = 0;
            this.btnEditPlace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnEditPlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnEditPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPlace.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnEditPlace.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnEditPlace.IconColor = System.Drawing.Color.White;
            this.btnEditPlace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPlace.IconSize = 30;
            this.btnEditPlace.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditPlace.Location = new System.Drawing.Point(517, 0);
            this.btnEditPlace.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPlace.Name = "btnEditPlace";
            this.btnEditPlace.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditPlace.Size = new System.Drawing.Size(185, 43);
            this.btnEditPlace.TabIndex = 3;
            this.btnEditPlace.Text = "編輯問事地點";
            this.btnEditPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPlace.UseVisualStyleBackColor = false;
            this.btnEditPlace.Click += new System.EventHandler(this.btnEditPlace_Click);
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnAddPlace.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddPlace.FlatAppearance.BorderSize = 0;
            this.btnAddPlace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnAddPlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnAddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlace.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnAddPlace.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btnAddPlace.IconColor = System.Drawing.Color.White;
            this.btnAddPlace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPlace.IconSize = 25;
            this.btnAddPlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlace.Location = new System.Drawing.Point(332, 0);
            this.btnAddPlace.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddPlace.Size = new System.Drawing.Size(185, 43);
            this.btnAddPlace.TabIndex = 2;
            this.btnAddPlace.Text = "新增問事地點";
            this.btnAddPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPlace.UseVisualStyleBackColor = false;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // btnBrowseTables
            // 
            this.btnBrowseTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnBrowseTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBrowseTables.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowseTables.FlatAppearance.BorderSize = 0;
            this.btnBrowseTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnBrowseTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnBrowseTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseTables.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnBrowseTables.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnBrowseTables.IconColor = System.Drawing.Color.White;
            this.btnBrowseTables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowseTables.IconSize = 30;
            this.btnBrowseTables.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBrowseTables.Location = new System.Drawing.Point(166, 0);
            this.btnBrowseTables.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseTables.Name = "btnBrowseTables";
            this.btnBrowseTables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBrowseTables.Size = new System.Drawing.Size(166, 43);
            this.btnBrowseTables.TabIndex = 1;
            this.btnBrowseTables.Text = "瀏覽問事表";
            this.btnBrowseTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseTables.UseVisualStyleBackColor = false;
            this.btnBrowseTables.Click += new System.EventHandler(this.btnBrowseTables_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(78)))));
            this.btnNewTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnNewTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(98)))), ((int)(((byte)(148)))));
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Noto Sans TC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.btnNewTable.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNewTable.IconColor = System.Drawing.Color.White;
            this.btnNewTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewTable.IconSize = 28;
            this.btnNewTable.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNewTable.Location = new System.Drawing.Point(0, 0);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewTable.Size = new System.Drawing.Size(166, 43);
            this.btnNewTable.TabIndex = 0;
            this.btnNewTable.Text = "新增問事表";
            this.btnNewTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTable.UseVisualStyleBackColor = false;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // workDesktop
            // 
            this.workDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workDesktop.Location = new System.Drawing.Point(0, 43);
            this.workDesktop.Name = "workDesktop";
            this.workDesktop.Size = new System.Drawing.Size(1080, 715);
            this.workDesktop.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1080, 758);
            this.Controls.Add(this.workDesktop);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.formBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBar;
        private FontAwesome.Sharp.IconButton btnNewTable;
        private FontAwesome.Sharp.IconButton btnBrowseTables;
        private FontAwesome.Sharp.IconButton btnAddPlace;
        private FontAwesome.Sharp.IconButton btnEditPlace;
        private System.Windows.Forms.Panel workDesktop;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}