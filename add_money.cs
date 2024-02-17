namespace Banking_App
{
    public partial class add_money : Form
    {
        
        private readonly Dictionary<string, string> user;
        public delegate void DashboardShowD();
        private readonly DashboardShowD dashboardShow;

        public add_money(Dictionary<string, string> loggedInUser, DashboardShowD dashboardShowB)
        {

            user = loggedInUser;
            dashboardShow = dashboardShowB;

            InitializeComponent();

        }

        private void Add_money_button_Click(object sender, EventArgs e)
        {
            var amount = enter_amount_input.Text.Trim();

            // validation of amount input
            if (amount.All(char.IsDigit) == false || amount == "" || amount == "0")
            {
                MessageBox.Show("The amount must not be empty and in numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // updating amount to current user and file system
            var currentUserBalance = int.Parse(user["balance"]);
            var moneyToAdd = int.Parse(amount);
            var newAmount = (currentUserBalance + moneyToAdd).ToString();
            user["balance"] = newAmount;

            FileSystemCus.UpdateRowTemp("users", user);

            // adding transaction in file
            FileSystemCus.WriteDataTemp("transactions", new Dictionary<string, string>()
            {
                ["from"] = "none",
                ["to"] = user["id"],
                ["amount"] = amount,
                ["date"] = DateTime.Now.ToString()
            });


            MessageBox.Show("Money Successfully Deposited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
