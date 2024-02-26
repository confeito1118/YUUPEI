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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(excel);
            Controls.Add(userAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button userAdd;
        private Button excel;
    }
}
