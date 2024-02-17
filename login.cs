namespace Banking_App
{
    public partial class Login : Form
    {
        private readonly Dictionary<string, string> data = [];
        private Dictionary<string, string> user = [];
        
        public Login()
        {
            InitializeComponent();
        }

        private string Validation()
        {
            var validationMessage = "";

            if (data["email"].Contains('@') == false || data["email"].Contains('.') == false)
                validationMessage += "\n - The email must not be empty and in the correct format.";

            if (data["password"].Length <= 0)
                validationMessage += "\n - The password must not be empty.";


            if (validationMessage == "")
            {
                var matchingUser = FileSystemCus.FindOne("users", data["email"]);

                if (matchingUser.Count == 0)
                    validationMessage += "\n - The User with this email doesn't Exists";
                else
                {
                    // if entered password not equal to file password
                    if (matchingUser["password"] != data["password"])
                        validationMessage += "\n - Invalid Password for the user";
                    else
                        user = matchingUser;
                }

            }

            return validationMessage.TrimStart('\n');
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            data["email"] = email_input.Text.Trim();
            data["password"] = password_input.Text.Trim();

            var validate = Validation();

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Dashboard(user).Show();

            Close();

        }

        private void Show_password_input_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_input.Checked)
                password_input.PasswordChar = '\0';
            else
                password_input.PasswordChar = '*';
        }
    }
}
