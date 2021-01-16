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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        public static CLibrarian_001 user;
        private void login(object sender, EventArgs e)
        {
            string username = UserID.Text;
            string password = Password.Text;
            if (database.librarians.Any(item => item.M_str_account == username && item.M_str_password == password))
            {
                LoginForm.user = database.librarians.Find(item => item.M_str_account == username);
                open_start_page();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
        private void open_start_page()
        {
            this.Hide();
            var start_page = new StartPage();
            start_page.Closed += (s, args) => this.Show();
            start_page.Show();
        }
        private void open_register(object sender, EventArgs e) 
        {
            this.Hide();
            var registerForm = new AdmRegister();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.Show();
        }           
    }
}
