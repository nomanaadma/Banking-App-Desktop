using static System.Net.Mime.MediaTypeNames;

namespace Banking_App
{
    public partial class dashboard : Form
    {
        private string[] user;
        private System.Windows.Forms.Timer myTimer;
        private bool isRecursiveFunctionRunning = false;
        public dashboard(string[] loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();

            // Initialize the Timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 1000; // 1 second
            myTimer.Tick += MyTimer_Tick;

            // Start the Timer
            myTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // Check if the recursive function is already running
            if (!isRecursiveFunctionRunning)
            {
                // Set the flag to indicate that the function is now running
                isRecursiveFunctionRunning = true;

                // Your recursive function logic goes here
                RecursiveFunction();

                // Reset the flag after the function completes
                isRecursiveFunctionRunning = false;
            }
        }

        private void RecursiveFunction()
        {
            string[] user_id = { user[0] };
            string[] userRows = FileSystemCus.findRows("users", user_id);
            
            if (userRows.Length == 0)
                return;

            user = userRows[0].Split(',');

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
