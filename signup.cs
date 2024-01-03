namespace Banking_App
{
    public partial class Signup : Form
    {
        public Signup()
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

            if (passwd.Contains(' '))
                return false;

            return true;
        }


        private string validation(string[] dataRow)
        {
            string validationMessage = "";

            if (dataRow[0].Length < 5)
                validationMessage += "\n - The Full Name must be more than 5 characters.";

            if (dataRow[1].Contains('@') == false || dataRow[1].Contains('.') == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (this.validatePassword(dataRow[2]) == false)
                validationMessage += "\n - The password must be between 5 and 10 characters in length, include at least one lowercase and one uppercase character, and must not contain any white spaces.";

            if (
                dataRow[3].Length > 13 ||
                dataRow[3].Length < 13 ||
                dataRow[3].All(char.IsDigit) == false
            )
                validationMessage += "\n - The CNIC must have a length of 13 characters.";


            if (validationMessage == "")
            {
                
                string[] getUserByMail = FileSystemCus.findOne("users", dataRow[1]);

                if(getUserByMail.Length != 0)
                    validationMessage += "\n - The User with this email already Exists";

                string[] getUserByCNIC = FileSystemCus.findOne("users", dataRow[3]);

                if (getUserByCNIC.Length != 0)
                    validationMessage += "\n - The User with this CNIC already Exists";

            }

            return validationMessage.TrimStart('\n');
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            string[] dataRow = {
                full_name_input.Text.Trim(),
                email_input.Text.Trim(),
                password_input.Text.Trim(),
                cnic_input.Text.Trim(),
                "0",
                GlobalCus.generate_number(16), // Card Number
                GlobalCus.generate_number(2), // Expiry
                GlobalCus.generate_number(3), // CVC
            };

            string validate = validation(dataRow);

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileSystemCus.writeData("users", dataRow);

            MessageBox.Show("Successfully Created Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

    }
}
