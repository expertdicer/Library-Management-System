using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            String check = "";
            if (LoginForm.user.M_str_password != Old_Password.Text) check += "Sai mật khẩu cũ!\n";
            if (!User.CheckPassword(New_Password.Text)) check += "Password phải có ít nhất 8 kí tự, có số và có kí tự viết hoa!\n";
            if (New_Password.Text != New_Pasword2.Text) check += "Sai mật khẩu nhập lại!";
            if(check!="")
            {
                MessageBox.Show(check);
                return;
            }
            //Nếu mật khẩu thỏa mãn thì mới đến bước dưới
            LoginForm.user.M_str_password = New_Password.Text;
        }
    }
}
