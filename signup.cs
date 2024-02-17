namespace Banking_App
{
    public partial class Signup : Form
    {
        private readonly Dictionary<string, string>  data = [];

        public Signup()
        {
            InitializeComponent();
        }
        private void Show_password_input_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_input.Checked)
                password_input.PasswordChar = '\0';
            else
                password_input.PasswordChar = '*';
        }

        private bool ValidatePassword()
        {
            var passwd = data["password"];

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

        private string Validation()
        {

            var validationMessage = "";

            if (data["fullname"].Length < 5)
                validationMessage += "\n - The Full Name must be more than 5 characters.";

            if (data["email"].Contains('@') == false || data["email"].Contains('.') == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (ValidatePassword() == false)
                validationMessage += "\n - The password must be between 5 and 10 characters in length, include at least one lowercase and one uppercase character, and must not contain any white spaces.";

            if (
                data["cnic"].Length > 13 ||
                data["cnic"].Length < 13 ||
                data["cnic"].All(char.IsDigit) == false
            )
                validationMessage += "\n - The CNIC must have a length of 13 characters.";


            if (validationMessage == "")
            {
                
                var getUserByMail = FileSystemCus.FindOne("users", data["email"]);

                if(getUserByMail.Count != 0)
                    validationMessage += "\n - The User with this email already Exists";

                var getUserByCNIC = FileSystemCus.FindOne("users", data["cnic"]);

                if (getUserByCNIC.Count != 0)
                    validationMessage += "\n - The User with this CNIC already Exists";

            }

            return validationMessage.TrimStart('\n');
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {

            data["fullname"] = full_name_input.Text.Trim();
            data["email"] = email_input.Text.Trim();
            data["password"] = password_input.Text.Trim();
            data["cnic"] = cnic_input.Text.Trim();
            data["balance"] = "0";
            data["card"] = GlobalCus.GenerateNumber(16);
            data["expiry"] = GlobalCus.GenerateNumber(2);
            data["cvc"] = GlobalCus.GenerateNumber(3);

            var validate = Validation();

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileSystemCus.WriteData("users", data);

            MessageBox.Show("Successfully Created Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

    }
}
