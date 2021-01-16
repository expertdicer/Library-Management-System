namespace Project
{
    partial class UserManegement
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
            this.Add_User = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Update_user_info = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_ID = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.DateofBirth = new System.Windows.Forms.DateTimePicker();
            this.Undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_User
            // 
            this.Add_User.Location = new System.Drawing.Point(18, 330);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(141, 43);
            this.Add_User.TabIndex = 0;
            this.Add_User.Text = "Thêm người dùng";
            this.Add_User.UseVisualStyleBackColor = true;
            this.Add_User.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nhập ID";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(326, 297);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
            this.radioButton2.TabIndex = 39;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nhân viên";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(209, 297);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 21);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Học sinh";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(209, 144);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(205, 22);
            this.ID.TabIndex = 37;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(209, 258);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(205, 22);
            this.PhoneNum.TabIndex = 35;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(209, 185);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(205, 22);
            this.Email.TabIndex = 34;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(209, 107);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(205, 22);
            this.Name_txt.TabIndex = 32;
            // 
            // Update_user_info
            // 
            this.Update_user_info.Enabled = false;
            this.Update_user_info.Location = new System.Drawing.Point(261, 330);
            this.Update_user_info.Name = "Update_user_info";
            this.Update_user_info.Size = new System.Drawing.Size(153, 43);
            this.Update_user_info.TabIndex = 31;
            this.Update_user_info.Text = "Cập nhật thông tin";
            this.Update_user_info.UseVisualStyleBackColor = true;
            this.Update_user_info.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(339, 42);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name :";
            // 
            // Search_ID
            // 
            this.Search_ID.Location = new System.Drawing.Point(91, 43);
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(100, 22);
            this.Search_ID.TabIndex = 22;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(209, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 23);
            this.Search.TabIndex = 21;
            this.Search.Text = "Tìm";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DateofBirth
            // 
            this.DateofBirth.Location = new System.Drawing.Point(209, 225);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(205, 22);
            this.DateofBirth.TabIndex = 41;
            // 
            // Undo
            // 
            this.Undo.Enabled = false;
            this.Undo.Location = new System.Drawing.Point(420, 330);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(56, 43);
            this.Undo.TabIndex = 42;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // UserManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 436);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Update_user_info);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add_User);
            this.Name = "UserManegement";
            this.Text = "UserManegement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_User;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Button Update_user_info;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_ID;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DateTimePicker DateofBirth;
        private System.Windows.Forms.Button Undo;
    }
}