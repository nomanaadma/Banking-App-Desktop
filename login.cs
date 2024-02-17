namespace Banking_App
{
    public partial class Login : Form
    {
        public readonly Dictionary<string, string> _data = [];
        private List<string> user = [];

        public Login()
        {
            InitializeComponent();
        }

        private string validation()
        {
            string validationMessage = "";

            if (_data["email"].Contains('@') == false || _data["email"].Contains('.') == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (_data["password"].Length <= 0)
                validationMessage += "\n - The password must not be empty.";


            if (validationMessage == "")
            {
                var matchingUser = FileSystemCus.findOneTemp("users", _data["email"]);

                if (matchingUser.Count == 0)
                    validationMessage += "\n - The User with this email doesn't Exists";
                else
                {
                    // if entered password not equal to file password
                    if (matchingUser[3] != _data["password"])
                        validationMessage += "\n - Invalid Password for the user";
                    else
                        user = matchingUser;
                }

            }

            return validationMessage.TrimStart('\n');
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
            _data["email"] = email_input.Text.Trim();
            _data["password"] = password_input.Text.Trim();

            string validate = validation();

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            email_label.Text = user[3];

            // new Dashboard(user).Show();

            Close();

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
