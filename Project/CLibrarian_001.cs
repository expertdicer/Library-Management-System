using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public class CLibrarian_001:CPerson_002
    {
        #region Public interface
        public CLibrarian_001() { }
        public CLibrarian_001(string m_string_account, string Name, string Password, string Home, string Email, string Phone, string ID, DateTime DateofBirth)
        {
            this.m_str_account = m_string_account;
            this.m_str_username = Name;
            this.m_str_password = Password;
            this.m_str_home_address = Home;
            this.m_str_email = Email;
            this.m_str_phone_num = Phone;
            this.m_str_id = ID;
            this.DateofBirth = DateofBirth;
        }
        public void check_if_any()
        {

        }

        public static void add_abook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            Database database = Database.GetDatabase();
            ABook book = new ABook(BookID, Status, Availability, BookType);
            database.listBook.Add(book);
        }

        public static void remove_abook(string BookID)
        {
            Database database = Database.GetDatabase();
            if (database.listBook.Any(item => item.BookID == BookID))
            {
                //Dùng cách này mới trỏ tới đúng phần tử cần remove
                database.listBook.Remove(database.listBook.Find(item => item.BookID == BookID));
            }
        }
        public static bool check_Email(string email)
        {
            string regex2 = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex re2 = new Regex(regex2);
            return re2.IsMatch(email);
        }
        #endregion
        #region Data Structure
        #endregion
        #region Members
        private string m_str_account;
        private string m_str_password;
        private string m_str_home_address;
        public string M_str_account 
        {
            get { return m_str_account; }
            set { m_str_account = value; }
        }
        public string M_str_password
        {
            get { return m_str_password; }
            set { m_str_password = value; }
        }
        public string M_str_home_address
        {
            get { return m_str_home_address; }
            set { m_str_home_address = value; }
        }
        #endregion
        #region Private Methods
        #endregion
    }
}