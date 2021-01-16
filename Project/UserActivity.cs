using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace Project
{
    public partial class UserActivity : Form
    {

        User user;
        public UserActivity()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        //Load xml

        private void Show_borrowing_books_Click(object sender, EventArgs e)
        {
            try
            {
                List<ABook> list_borrowed_books = database.listBook.FindAll(item => user.Acc.no_borrowed_books.Contains(item.BookID));
                Get_list_of_Books(list_borrowed_books);
            }
            catch
            {
                MessageBox.Show("Không có sách đang mượn", "Thông Báo", MessageBoxButtons.OK);
            }

            
        }

        private void Search_book_Click(object sender, EventArgs e)
        {
            List<ABook> list_search_books = database.listBook.FindAll(item => item.BookType.Title.Contains(search_text.Text));
            Get_list_of_Books(list_search_books);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (database.users.Any(item => item.ID == ID.Text))
                {
                    Show_borrowing_books.Enabled = true;
                    Borrow_book.Enabled = true;
                    return_Book.Enabled = true;
                    Show_returned_books.Enabled = true;
                    user = database.users.Find(item => item.ID == ID.Text);
                }
            }
            catch
            {
                MessageBox.Show("Không có user trong Database!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Borrow_book_Click(object sender, EventArgs e)
        {
            if(database.listBook.Any(item=>item.BookID==Borrow_Book_ID.Text&&item.Availability==true))
            {
                //Kiểm tra xem sách đã được mượn chưa rồi gán 
                if(!user.Acc.no_borrowed_books.Contains(Borrow_Book_ID.Text)) user.Acc.no_borrowed_books.Add(Borrow_Book_ID.Text);
                database.listBook.Find(item => item.BookID == Borrow_Book_ID.Text).Availability = false;
            }    
        }

        private void return_Book_Click(object sender, EventArgs e)
        {
            if(user.Acc.no_borrowed_books.Contains(return_Book_ID.Text))
            {
                user.Acc.no_borrowed_books.Remove(return_Book_ID.Text);
                user.Acc.no_returned_books.Add(return_Book_ID.Text);
                database.listBook.Find(item => item.BookID == return_Book_ID.Text).Availability = true;
            }    
        }

        private void Show_returned_books_Click(object sender, EventArgs e)
        {
            try
            {
                List<ABook> list_returned_books = database.listBook.FindAll(item => user.Acc.no_returned_books.Contains(item.BookID));
                Get_list_of_Books(list_returned_books);
            }
            catch
            {
                MessageBox.Show("Không có sách đã trả", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Get_list_of_Books(List<ABook> list_of_books)
        {
            dataGridView1.Rows.Clear();
            foreach (ABook book in list_of_books)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = book.BookType.Title;
                row.Cells[1].Value = book.BookType.Author;
                row.Cells[2].Value = book.BookType.ISBN;
                row.Cells[3].Value = book.Status;
                row.Cells[4].Value = book.Availability;
                row.Cells[5].Value = book.BookID;
                dataGridView1.Rows.Add(row);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
