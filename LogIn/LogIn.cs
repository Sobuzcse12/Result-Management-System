using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogIn
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            pw_txt.PasswordChar = '*';
            pw_txt.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (user_name_txt.Text == "" && pw_txt.Text=="")
            {
                MessageBox.Show("Sorry! Enter your User Name And Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.user_name_txt.Focus();    
            }

            else if (user_name_txt.Text == "abc" && pw_txt.Text == "123")
            {
                MessageBox.Show("Ueser Name and Password Correct!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home fr = new Home();
                fr.Show();
                this.Hide();
            }
            else

                MessageBox.Show("invalid User Name and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.user_name_txt.Focus();
        }
       
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You really want to Close the program?","Exit",MessageBoxButtons.YesNo );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialog == DialogResult.No)
                  {
                      e.Cancel = true;

                  }
                 
        }

        private void pw_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = login_bt;
        }
    }
}
