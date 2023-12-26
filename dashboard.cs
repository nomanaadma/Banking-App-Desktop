namespace Banking_App
{
    public partial class dashboard : Form
    {
        private string[] user;
        private System.Windows.Forms.Timer timer;
        public dashboard(string[] loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            user_label.Text = user[1];
            card_value.Text = user[6];
            expiry_value.Text = "02/" + user[7];
            cvc_value.Text = user[8];
            update_balance(user[5]);
        }
        public string[] update_balance(string amount)
        {
            user[5] = amount;
            double amountCr = double.Parse(amount);
            amount_label.Text = $"{amountCr:N0}";
            return user;
        }

        private void add_money_button_Click(object sender, EventArgs e)
        {
            new add_money(user, this).Show();
            this.Hide();

        }

        private void send_money_button_Click(object sender, EventArgs e)
        {
            new send_money(user, this).Show();
            this.Hide();
        }

        private void transactions_button_Click(object sender, EventArgs e)
        {
            new transactions(user, this).Show();
            this.Hide();
        }

        private void withdraw_money_button_Click(object sender, EventArgs e)
        {
            new withdraw_money(user, this).Show();
            this.Hide();
        }

        private void card_value_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(card_value.Text);
        }

        private void expiry_value_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(expiry_value.Text);
        }

        private void cvc_value_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cvc_value.Text);
        }

    }
}
