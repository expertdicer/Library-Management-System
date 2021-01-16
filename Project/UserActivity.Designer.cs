namespace Project
{
    partial class UserActivity
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
            this.Show_borrowing_books = new System.Windows.Forms.Button();
            this.Borrow_book = new System.Windows.Forms.Button();
            this.Search_book = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Borrow_Book_ID = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.return_Book_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.return_Book = new System.Windows.Forms.Button();
            this.Show_returned_books = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_borrowing_books
            // 
            this.Show_borrowing_books.Enabled = false;
            this.Show_borrowing_books.Location = new System.Drawing.Point(1003, 149);
            this.Show_borrowing_books.Name = "Show_borrowing_books";
            this.Show_borrowing_books.Size = new System.Drawing.Size(96, 51);
            this.Show_borrowing_books.TabIndex = 1;
            this.Show_borrowing_books.Text = "Sách đang mượn";
            this.Show_borrowing_books.UseVisualStyleBackColor = true;
            this.Show_borrowing_books.Click += new System.EventHandler(this.Show_borrowing_books_Click);
            // 
            // Borrow_book
            // 
            this.Borrow_book.Enabled = false;
            this.Borrow_book.Location = new System.Drawing.Point(266, 345);
            this.Borrow_book.Name = "Borrow_book";
            this.Borrow_book.Size = new System.Drawing.Size(96, 51);
            this.Borrow_book.TabIndex = 2;
            this.Borrow_book.Text = "Mượn sách";
            this.Borrow_book.UseVisualStyleBackColor = true;
            this.Borrow_book.Click += new System.EventHandler(this.Borrow_book_Click);
            // 
            // Search_book
            // 
            this.Search_book.Location = new System.Drawing.Point(485, 79);
            this.Search_book.Name = "Search_book";
            this.Search_book.Size = new System.Drawing.Size(96, 40);
            this.Search_book.TabIndex = 3;
            this.Search_book.Text = "Tìm";
            this.Search_book.UseVisualStyleBackColor = true;
            this.Search_book.Click += new System.EventHandler(this.Search_book_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(93, 79);
            this.search_text.Multiline = true;
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(359, 40);
            this.search_text.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.ISBN,
            this.Status,
            this.Availability,
            this.BookID});
            this.dataGridView1.Location = new System.Drawing.Point(43, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.MinimumWidth = 6;
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Width = 125;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 125;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(200, 34);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(181, 27);
            this.ID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập ID sinh viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book ID:";
            // 
            // Borrow_Book_ID
            // 
            this.Borrow_Book_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow_Book_ID.Location = new System.Drawing.Point(110, 359);
            this.Borrow_Book_ID.Name = "Borrow_Book_ID";
            this.Borrow_Book_ID.Size = new System.Drawing.Size(150, 27);
            this.Borrow_Book_ID.TabIndex = 9;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(412, 25);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(96, 40);
            this.Check.TabIndex = 10;
            this.Check.Text = "Kiểm tra";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // return_Book_ID
            // 
            this.return_Book_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_Book_ID.Location = new System.Drawing.Point(517, 359);
            this.return_Book_ID.Name = "return_Book_ID";
            this.return_Book_ID.Size = new System.Drawing.Size(150, 27);
            this.return_Book_ID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Book ID:";
            // 
            // return_Book
            // 
            this.return_Book.Enabled = false;
            this.return_Book.Location = new System.Drawing.Point(673, 345);
            this.return_Book.Name = "return_Book";
            this.return_Book.Size = new System.Drawing.Size(96, 51);
            this.return_Book.TabIndex = 11;
            this.return_Book.Text = "Trả sách";
            this.return_Book.UseVisualStyleBackColor = true;
            this.return_Book.Click += new System.EventHandler(this.return_Book_Click);
            // 
            // Show_returned_books
            // 
            this.Show_returned_books.Enabled = false;
            this.Show_returned_books.Location = new System.Drawing.Point(1003, 235);
            this.Show_returned_books.Name = "Show_returned_books";
            this.Show_returned_books.Size = new System.Drawing.Size(96, 51);
            this.Show_returned_books.TabIndex = 14;
            this.Show_returned_books.Text = "Sách đã mượn";
            this.Show_returned_books.UseVisualStyleBackColor = true;
            this.Show_returned_books.Click += new System.EventHandler(this.Show_returned_books_Click);
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 397);
            this.Controls.Add(this.Show_returned_books);
            this.Controls.Add(this.return_Book_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.return_Book);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Borrow_Book_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.Search_book);
            this.Controls.Add(this.Borrow_book);
            this.Controls.Add(this.Show_borrowing_books);
            this.Name = "UserActivity";
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Show_borrowing_books;
        private System.Windows.Forms.Button Borrow_book;
        private System.Windows.Forms.Button Search_book;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Borrow_Book_ID;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox return_Book_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button return_Book;
        private System.Windows.Forms.Button Show_returned_books;
    }
}