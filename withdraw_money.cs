namespace Banking_App
{
    public partial class withdraw_money : Form
    {
        private string[] user;
        private Dashboard dashboard;
        public withdraw_money(Dashboard dashboardCl)
        {
            dashboard = dashboardCl;
            user = dashboard.user;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            dashboard.Show();
        }

        private void withdraw_money_button_Click(object sender, EventArgs e)
        {
            string amount = enter_amount_input.Text.Trim();

            if (amount == "" || amount == "0" || amount.All(char.IsDigit) == false)
            {
                MessageBox.Show("The amount must not be empty and in numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int amountInt = int.Parse(amount);
            int userBalance = int.Parse(user[5]);

            if( amountInt > userBalance )
            {
                MessageBox.Show("The amount should not be more than the balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // updating amount to current user and file system
            string newAmount = (userBalance - amountInt).ToString();
            user[5] = newAmount;
            FileSystemCus.UpdateRow("users", user);

            // adding transaction in file
            FileSystemCus.writeData("transactions", [
                user[0],
                "none",
                amount,
                DateTime.Now.ToString(),
            ]);

            MessageBox.Show("Successfully withdrew", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
            dashboard.Show();

        }
    }

}
