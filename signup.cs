using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


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


        private string validation(string[] dataRow)
        {
            string validationMessage = "";

            if (dataRow[0].Length < 5)
                validationMessage += "\n - The Full Name must be more than 5 characters.";

            if (dataRow[1].Contains("@") == false || dataRow[1].Contains(".") == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (this.validatePassword(dataRow[2]) == false)
                validationMessage += "\n - The password must be between 5 and 10 characters in length, include at least one lowercase and one uppercase character, and must not contain any white spaces.";

            if (
                dataRow[3].Length > 13 ||
                dataRow[3].Length < 13 ||
                dataRow[3].All(char.IsDigit) == false
            )
                validationMessage += "\n - The CNIC must have a length of 13 characters.";


            if(validationMessage == "")
            {

                string[] existingConditions = { dataRow[1], dataRow[3] };

                string[] matchingRows = FileSystemCus.findRows("users", existingConditions);

                if (matchingRows.Length > 0)
                    validationMessage += "\n - The User Already Exists";

            }

            return validationMessage;
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            string[] dataRow = {
                full_name_input.Text.Trim(),
                email_input.Text.Trim(),
                password_input.Text.Trim(),
                cnic_input.Text.Trim()
            };

            string validate = this.validation(dataRow);

            if (validate != "")
            {
                MessageBox.Show(validate);
                return;
            }

            FileSystemCus.writeData("users", dataRow);

            MessageBox.Show("Successfully Created Account");
            this.Close();

        }
    }
}
