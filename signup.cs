namespace Banking_App
{
    public partial class Signup : Form
    {
        private readonly Dictionary<string, string>  _data = [];

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

        private bool validatePassword()
        {
            var passwd = _data["password"];

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

        private string validation()
        {

            string validationMessage = "";

            if (_data["fullname"].Length < 5)
                validationMessage += "\n - The Full Name must be more than 5 characters.";

            if (_data["email"].Contains('@') == false || _data["email"].Contains('.') == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (this.validatePassword() == false)
                validationMessage += "\n - The password must be between 5 and 10 characters in length, include at least one lowercase and one uppercase character, and must not contain any white spaces.";

            if (
                _data["cnic"].Length > 13 ||
                _data["cnic"].Length < 13 ||
                _data["cnic"].All(char.IsDigit) == false
            )
                validationMessage += "\n - The CNIC must have a length of 13 characters.";


            if (validationMessage == "")
            {
                
                string[] getUserByMail = FileSystemCus.findOne("users", _data["email"]);

                if(getUserByMail.Length != 0)
                    validationMessage += "\n - The User with this email already Exists";

                string[] getUserByCNIC = FileSystemCus.findOne("users", _data["cnic"]);

                if (getUserByCNIC.Length != 0)
                    validationMessage += "\n - The User with this CNIC already Exists";

            }

            return validationMessage.TrimStart('\n');
        }

        private void signup_button_Click(object sender, EventArgs e)
        {

            _data["fullname"] = full_name_input.Text.Trim();
            _data["email"] = email_input.Text.Trim();
            _data["password"] = password_input.Text.Trim();
            _data["cnic"] = cnic_input.Text.Trim();
            _data["balance"] = "0";
            _data["card"] = GlobalCus.generate_number(16);
            _data["expiry"] = GlobalCus.generate_number(2);
            _data["cvc"] = GlobalCus.generate_number(3);

            string validate = validation();

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileSystemCus.writeDataTemp("users", _data);

            MessageBox.Show("Successfully Created Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

    }
}
