﻿namespace NewLibraryManagementApp
{
    partial class ReturnBooks
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
            button1 = new Button();
            dataGridView_returnBooks = new DataGridView();
            label1 = new Label();
            returnBook_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_returnBooks).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 40);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 37;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView_returnBooks
            // 
            dataGridView_returnBooks.BackgroundColor = Color.White;
            dataGridView_returnBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_returnBooks.Location = new Point(30, 139);
            dataGridView_returnBooks.Margin = new Padding(3, 4, 3, 4);
            dataGridView_returnBooks.Name = "dataGridView_returnBooks";
            dataGridView_returnBooks.RowHeadersWidth = 51;
            dataGridView_returnBooks.RowTemplate.Height = 24;
            dataGridView_returnBooks.Size = new Size(1071, 417);
            dataGridView_returnBooks.TabIndex = 35;
            dataGridView_returnBooks.CellContentClick += dataGridView_returnBooks_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(426, 40);
            label1.Name = "label1";
            label1.Size = new Size(211, 41);
            label1.TabIndex = 34;
            label1.Text = "Return Books ";
            // 
            // returnBook_btn
            // 
            returnBook_btn.BackColor = Color.DarkSlateBlue;
            returnBook_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            returnBook_btn.ForeColor = Color.White;
            returnBook_btn.Location = new Point(426, 613);
            returnBook_btn.Name = "returnBook_btn";
            returnBook_btn.Size = new Size(145, 37);
            returnBook_btn.TabIndex = 38;
            returnBook_btn.Text = "Return Book";
            returnBook_btn.UseVisualStyleBackColor = false;
            returnBook_btn.Click += returnBook_btn_Click;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1131, 681);
            Controls.Add(returnBook_btn);
            Controls.Add(button1);
            Controls.Add(dataGridView_returnBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            Load += ReturnBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_returnBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_returnBooks;
        private System.Windows.Forms.Label label1;
        private Button returnBook_btn;
    }
}