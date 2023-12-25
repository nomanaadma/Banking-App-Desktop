using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banking_App
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        private void show_password_input_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_input.Checked)
                password_input.PasswordChar = '\0';
            else
                password_input.PasswordChar = '*';
        }

        private bool validatePassword(string passwd)
        {
            if (passwd.Length < 5 || passwd.Length > 10)
                return false;

            if (!passwd.Any(char.IsUpper))
                return false;

            if (!passwd.Any(char.IsLower))
                return false;

            if (passwd.Contains(" "))
                return false;

            return true;
        }


        private string validation()
        {
            string validationMessage = "";

            if (full_name_input.TextLength < 5)
                validationMessage += "\n - The Full Name must be more than 5 characters.";

            if (email_input.Text.Contains("@") == false || email_input.Text.Contains(".") == false)
                validationMessage += "\n - The email must be in the correct format.";

            if (this.validatePassword(password_input.Text) == false)
                validationMessage += "\n - The password must be between 5 and 10 characters in length, include at least one lowercase and one uppercase character, and should not contain any white spaces.";

            if ( 
                cnic_input.Text.Length > 13 ||
                cnic_input.Text.Length < 13 ||
                cnic_input.Text.All(char.IsDigit) == false
            )
                validationMessage += "\n - The CNIC must have a length of 13 characters.";
            
            return validationMessage;
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            string validate = this.validation();

            if (validate != "")
            {
                MessageBox.Show(validate);
                return;
            }

            string[] dataRow = { 
                full_name_input.Text.Trim(), 
                email_input.Text.Trim(), 
                password_input.Text.Trim(), 
                cnic_input.Text.Trim() 
            };

            FileSystemCus.writeData("users", dataRow);

            MessageBox.Show("Successfully Created Account");
            this.Close();

        }
    }
}
