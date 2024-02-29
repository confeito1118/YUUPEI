namespace YUUPEI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userAdd = new Button();
            excel = new Button();
            userDataView = new DataGridView();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            ユーザ追加AToolStripMenuItem = new ToolStripMenuItem();
            閉じるWToolStripMenuItem = new ToolStripMenuItem();
            name_kan_sei = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            tell = new DataGridViewTextBoxColumn();
            detail = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)userDataView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // userAdd
            // 
            userAdd.Location = new Point(53, 60);
            userAdd.Name = "userAdd";
            userAdd.Size = new Size(94, 29);
            userAdd.TabIndex = 0;
            userAdd.Text = "追加";
            userAdd.UseVisualStyleBackColor = true;
            userAdd.Click += userAdd_Click;
            // 
            // excel
            // 
            excel.Location = new Point(153, 60);
            excel.Name = "excel";
            excel.Size = new Size(94, 29);
            excel.TabIndex = 1;
            excel.Text = "button1";
            excel.UseVisualStyleBackColor = true;
            excel.Click += excel_Click;
            // 
            // userDataView
            // 
            userDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataView.Columns.AddRange(new DataGridViewColumn[] { name_kan_sei, adress, tell, detail });
            userDataView.Location = new Point(53, 125);
            userDataView.Name = "userDataView";
            userDataView.RowHeadersWidth = 51;
            userDataView.Size = new Size(1104, 377);
            userDataView.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1216, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ユーザ追加AToolStripMenuItem, 閉じるWToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 24);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ユーザ追加AToolStripMenuItem
            // 
            ユーザ追加AToolStripMenuItem.Name = "ユーザ追加AToolStripMenuItem";
            ユーザ追加AToolStripMenuItem.Size = new Size(176, 26);
            ユーザ追加AToolStripMenuItem.Text = "ユーザ追加(&A)";
            ユーザ追加AToolStripMenuItem.Click += ユーザ追加AToolStripMenuItem_Click;
            // 
            // 閉じるWToolStripMenuItem
            // 
            閉じるWToolStripMenuItem.Name = "閉じるWToolStripMenuItem";
            閉じるWToolStripMenuItem.Size = new Size(176, 26);
            閉じるWToolStripMenuItem.Text = "閉じる(&W)";
            // 
            // name_kan_sei
            // 
            name_kan_sei.HeaderText = "氏名";
            name_kan_sei.MinimumWidth = 6;
            name_kan_sei.Name = "name_kan_sei";
            name_kan_sei.ReadOnly = true;
            name_kan_sei.Width = 125;
            // 
            // adress
            // 
            adress.HeaderText = "住所";
            adress.MinimumWidth = 6;
            adress.Name = "adress";
            adress.Width = 200;
            // 
            // tell
            // 
            tell.HeaderText = "電話";
            tell.MinimumWidth = 6;
            tell.Name = "tell";
            tell.ReadOnly = true;
            tell.Width = 200;
            // 
            // detail
            // 
            detail.HeaderText = "詳細";
            detail.MinimumWidth = 6;
            detail.Name = "detail";
            detail.Text = "詳細";
            detail.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 536);
            Controls.Add(userDataView);
            Controls.Add(excel);
            Controls.Add(userAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userDataView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button userAdd;
        private Button excel;
        private DataGridView userDataView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem ユーザ追加AToolStripMenuItem;
        private ToolStripMenuItem 閉じるWToolStripMenuItem;
        private DataGridViewTextBoxColumn name_kan_sei;
        private DataGridViewTextBoxColumn adress;
        private DataGridViewTextBoxColumn tell;
        private DataGridViewButtonColumn detail;
    }
}
