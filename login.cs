using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class login : Form
    {
        private string[] user;
        public login()
        {
            InitializeComponent();
        }

        private string validation(string[] dataRow)
        {
            string validationMessage = "";

            if (dataRow[0].Contains("@") == false || dataRow[0].Contains(".") == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (dataRow[0].Length <= 0)
                validationMessage += "\n - The password must not be empty.";


            if (validationMessage == "")
            {

                string[] existingConditions = { dataRow[0], dataRow[1] };

                string[] matchingRows = FileSystemCus.findRows("users", existingConditions);

                if (matchingRows.Length == 0)
                    validationMessage += "\n - Invalid User or Password";
                else
                    this.user = matchingRows[0].Split(',');

            }

            return validationMessage.TrimStart('\n');
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // temp
            email_input.Text = "nomanaadma@gmail.com";
            password_input.Text = "Admin";
            // temp

            string[] dataRow = {
                email_input.Text.Trim(),
                password_input.Text.Trim(),
            };

            string validate = validation(dataRow);

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new dashboard(user).Show();
            this.Close();

        }

        private void show_password_input_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_input.Checked)
                password_input.PasswordChar = '\0';
            else
                password_input.PasswordChar = '*';
        }
    }
}
