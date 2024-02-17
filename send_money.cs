namespace Banking_App
{
    public partial class send_money : Form
    {
        private readonly Dictionary<string, string> user;
        public delegate void DashboardShowD();
        private readonly DashboardShowD dashboardShow;
        private readonly Dictionary<string, string> data = [];

        public send_money(Dictionary<string, string> loggedInUser, DashboardShowD dashboardShowB)
        {
            user = loggedInUser;
            dashboardShow = dashboardShowB;

            InitializeComponent();
        }

        private void Send_by_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            send_type_label.Text = send_by_input.Text;
        }

        private string Validation()
        {
            var validationMessage = "";

            if (data["send_by"].Length == 0)
                validationMessage += "\n - The send by type must be not empty.";


            switch (data["send_by"])
            {
                case "Email":

                    if (data["enter"].Contains('@') == false || data["enter"].Contains('.') == false)
                        validationMessage += "\n - The email must not be empty and in the correct format.";

                    if (data["enter"] == user["email"])
                        validationMessage += "\n - You cannot transfer money to yourself.";

                    break;

                case "CNIC":

                    if (
                        data["enter"].Length > 13 ||
                        data["enter"].Length < 13 ||
                        data["enter"].All(char.IsDigit) == false
                    )
                        validationMessage += "\n - The CNIC must have a length of 13 characters.";

                    if (data["enter"] == user["cnic"])
                        validationMessage += "\n - You cannot transfer money to yourself.";

                    break;

                default:

                    validationMessage += "\n - Something Wrong with the Send Type.";
                    break;

            }

            if (data["amount"].All(char.IsDigit) == false || data["amount"] == "" || data["amount"] == "0")
                validationMessage += "\n - The amount must not be empty and in numbers only.";
            else
            {
                var amount = int.Parse(data["amount"]);
                var balance = int.Parse(user["balance"]);

                if (amount > balance)
                    validationMessage += "\n - The amount must not be more than the balance.";
            }

            return validationMessage.TrimStart('\n');
        }

        private void Send_money_button_Click(object sender, EventArgs e)
        {

            data["send_by"] = send_by_input.Text.Trim();
            data["enter"] = enter_input.Text.Trim();
            data["amount"] = amount_input.Text.Trim();

            var validate = Validation();

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // find the beneficiary user by ID
            var bfUserData = FileSystemCus.FindOne("users", data["enter"]);

            if (bfUserData.Count == 0)
            {
                MessageBox.Show("The User Can't be Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialogConfirmation = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogConfirmation == DialogResult.No)
                return;

            // getting existing balance of the beneficiary user
            var bfUserBalance = int.Parse(bfUserData["balance"]);

            // amount entered in int
            var amount_entered = int.Parse(data["amount"]);

            // updating balance of new user
            bfUserData["balance"] = (bfUserBalance + amount_entered).ToString();
            FileSystemCus.UpdateRow("users", bfUserData);

            // New Amount of Logged in user update
            var currentUserBalance = int.Parse(user["balance"]);
            var newAmount = (currentUserBalance - amount_entered).ToString();
            user["balance"] = newAmount;
            FileSystemCus.UpdateRow("users", user);

            // adding transaction in file
            FileSystemCus.WriteData("transactions", new Dictionary<string, string>()
            {
                ["from"] = user["id"],
                ["to"] = bfUserData["id"],
                ["amount"] = data["amount"],
                ["date"] = DateTime.Now.ToString()
            });

            MessageBox.Show("Amount Transferred Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            dashboardShow();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Close();
            dashboardShow();
        }
    }
}
