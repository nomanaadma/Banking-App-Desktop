namespace Banking_App
{
    public partial class WithdrawMoney : DataForm
    {
        public WithdrawMoney(Dictionary<string, string> loggedInUser, DashboardShowD dashboardShowB)
            : base(loggedInUser, dashboardShowB)
        {            
            InitializeComponent();
        }

        private void Withdraw_money_button_Click(object sender, EventArgs e)
        {
            var amount = enter_amount_input.Text.Trim();

            if (amount == "" || amount == "0" || amount.All(char.IsDigit) == false)
            {
                MessageBox.Show("The amount must not be empty and in numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var amountInt = int.Parse(amount);
            var userBalance = int.Parse(user["balance"]);

            if( amountInt > userBalance )
            {
                MessageBox.Show("The amount should not be more than the balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // updating amount to current user and file system
            var newAmount = (userBalance - amountInt).ToString();
            user["balance"] = newAmount;
            
            FileSystemCus.UpdateRow("users", user);


            // adding transaction in file
            FileSystemCus.WriteData("transactions", new Dictionary<string, string>()
            {
                ["from"] = user["id"],
                ["to"] = "none",
                ["amount"] = amount,
                ["date"] = DateTime.Now.ToString()
            });

            MessageBox.Show("Successfully withdrew", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
