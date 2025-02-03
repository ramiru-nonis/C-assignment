namespace NewLibraryManagementApp
{
    partial class BorrowedBooks
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
            dataGridView_borrowedBooks = new DataGridView();
            label1 = new Label();
            Backbutton_borrowBooks = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_borrowedBooks
            // 
            dataGridView_borrowedBooks.BackgroundColor = Color.White;
            dataGridView_borrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_borrowedBooks.Location = new Point(5, 55);
            dataGridView_borrowedBooks.Margin = new Padding(3, 4, 3, 4);
            dataGridView_borrowedBooks.Name = "dataGridView_borrowedBooks";
            dataGridView_borrowedBooks.RowHeadersWidth = 51;
            dataGridView_borrowedBooks.RowTemplate.Height = 24;
            dataGridView_borrowedBooks.Size = new Size(1128, 591);
            dataGridView_borrowedBooks.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(440, 13);
            label1.Name = "label1";
            label1.Size = new Size(244, 41);
            label1.TabIndex = 34;
            label1.Text = "Borrowed Books";
            // 
            // Backbutton_borrowBooks
            // 
            Backbutton_borrowBooks.BackColor = Color.DarkSlateBlue;
            Backbutton_borrowBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Backbutton_borrowBooks.ForeColor = Color.White;
            Backbutton_borrowBooks.Location = new Point(12, 6);
            Backbutton_borrowBooks.Margin = new Padding(3, 4, 3, 4);
            Backbutton_borrowBooks.Name = "Backbutton_borrowBooks";
            Backbutton_borrowBooks.Size = new Size(104, 41);
            Backbutton_borrowBooks.TabIndex = 37;
            Backbutton_borrowBooks.Text = "Back";
            Backbutton_borrowBooks.UseVisualStyleBackColor = false;
            Backbutton_borrowBooks.Click += Backbutton_borrowBooks_Click;
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1141, 655);
            Controls.Add(Backbutton_borrowBooks);
            Controls.Add(dataGridView_borrowedBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BorrowedBooks";
            Text = "BorrowedBooks";
            Load += BorrowedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_borrowedBooks;
        private System.Windows.Forms.Label label1;
        private Button Backbutton_borrowBooks;
    }
}