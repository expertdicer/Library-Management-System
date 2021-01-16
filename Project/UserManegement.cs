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
    public partial class UserManegement : Form
    {
        public UserManegement()
        {
            InitializeComponent();
        }
        Database database = Database.GetDatabase();
        User user;
        Memento savedState;

        Memento.Originator originator = new Memento.Originator();
        private void Add_User_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(database.users.Any(item=>item.ID==Search_ID.Text))
            {
                user = database.users.Find(item => item.ID == Search_ID.Text);
                originator.Set(user);
                Name_txt.Text = user.Username;
                ID.Text = user.ID;
                Search_ID.Text = ID.Text;
                Email.Text = user.Email;
                DateofBirth.Value = user.DateofBirth;
                PhoneNum.Text = user.PhoneNum;
                Update_user_info.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
                if (user != null) ID.Text = user.ID;
            }    
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Check = "";
            Facade facade = new Facade(Email.Text, PhoneNum.Text, DateofBirth.Value);
            Check = facade.Check();
            if(Check!="")
            {
                MessageBox.Show(Check);
                return;
            }
            savedState = originator.SaveToMemento();
            user.Username = Name_txt.Text;
            user.ID = ID.Text;
            user.Email = Email.Text;
            user.DateofBirth = DateofBirth.Value;
            user.PhoneNum = PhoneNum.Text;
            Undo.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes)
            {
                database.users.Remove(user);
            }
            
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            originator.RestoreFromMemento(savedState);
            Name_txt.Text = user.Username;
            ID.Text = user.ID;
            Search_ID.Text = ID.Text;
            Email.Text = user.Email;
            DateofBirth.Value = user.DateofBirth;
            PhoneNum.Text = user.PhoneNum;

        }
    }
}
