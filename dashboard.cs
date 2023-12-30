using static System.Net.Mime.MediaTypeNames;

namespace Banking_App
{
    public partial class Dashboard : Form
    {
        public string[] user;
        private System.Windows.Forms.Timer updateTimer;
        private bool isUpdateRunning = false;
        public Dashboard(string[] loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();

            updateTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            updateTimer.Tick += updateTimerTick;

            // Start the Timer
            updateTimer.Start();
        }

        private void updateTimerTick(object? sender, EventArgs e)
        {
            // Check if the recursive function is already running
            if (!isUpdateRunning)
            {
                // Set the flag to indicate that the function is now running
                isUpdateRunning = true;

                // Your recursive function logic goes here
                update_balance_r();

                // Reset the flag after the function completes
                isUpdateRunning = false;
            }
        }

        private void update_balance_r()
        {
            string[] userRows = FileSystemCus.findOne("users", user[0]);
            
            if (userRows.Length == 0)
                return;

            user = userRows;

            update_balance(user[5]);

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            user_label.Text = user[1];
            card_value.Text = user[6];
            expiry_value.Text = "02/" + user[7];
            cvc_value.Text = user[8];
            update_balance(user[5]);
        }
        public void update_balance(string amount)
        {
            double amountCr = double.Parse(amount);
            amount_label.Text = $"{amountCr:N0}";
        }

        private void add_money_button_Click(object sender, EventArgs e)
        {
            new add_money(this).Show();
            Hide();
        }

        private void send_money_button_Click(object sender, EventArgs e)
        {
            new send_money(this).Show();
            Hide();
        }

        private void transactions_button_Click(object sender, EventArgs e)
        {
            new Transactions(this).Show();
            Hide();
        }

        private void withdraw_money_button_Click(object sender, EventArgs e)
        {
            new withdraw_money(this).Show();
            Hide();
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
