namespace Banking_App
{
    public partial class add_money : Form
    {
        private string[] user;
        private Dashboard dashboard;

        public add_money(Dashboard dashboardCl)
        {
            dashboard = dashboardCl;
            user = dashboard.user;
            InitializeComponent();
        }

        private void add_money_button_Click(object sender, EventArgs e)
        {
            string amount = enter_amount_input.Text.Trim();

            // validation of amount input
            if (amount.All(char.IsDigit) == false || amount == "" || amount == "0")
            {
                MessageBox.Show("The amount must not be empty and in numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // updating amount to current user and file system
            int currentUserBalance = int.Parse(this.user[5]);
            int moneyToAdd = int.Parse(amount);
            string newAmount = (currentUserBalance + moneyToAdd).ToString();
            user[5] = newAmount;
            FileSystemCus.UpdateRow("users", user);

            // adding transaction in file
            FileSystemCus.writeData("transactions", [
                "none",
                user[0],
                amount,
                DateTime.Now.ToString(),
            ]);


            MessageBox.Show("Money Successfully Deposited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            dashboard.Show();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            dashboard.Show();
        }

    }
}
