namespace Project
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.Old_Password = new System.Windows.Forms.TextBox();
            this.New_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Pasword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ:";
            // 
            // Old_Password
            // 
            this.Old_Password.Location = new System.Drawing.Point(327, 155);
            this.Old_Password.Name = "Old_Password";
            this.Old_Password.PasswordChar = '*';
            this.Old_Password.Size = new System.Drawing.Size(261, 22);
            this.Old_Password.TabIndex = 1;
            // 
            // New_Password
            // 
            this.New_Password.Location = new System.Drawing.Point(327, 213);
            this.New_Password.Name = "New_Password";
            this.New_Password.PasswordChar = '*';
            this.New_Password.Size = new System.Drawing.Size(261, 22);
            this.New_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // New_Pasword2
            // 
            this.New_Pasword2.Location = new System.Drawing.Point(327, 271);
            this.New_Pasword2.Name = "New_Pasword2";
            this.New_Pasword2.PasswordChar = '*';
            this.New_Pasword2.Size = new System.Drawing.Size(261, 22);
            this.New_Pasword2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(227, 378);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(196, 49);
            this.OK.TabIndex = 6;
            this.OK.Text = "Xác nhận";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.New_Pasword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Old_Password);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Old_Password;
        private System.Windows.Forms.TextBox New_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox New_Pasword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
    }
}