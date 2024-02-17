using UITimer = System.Windows.Forms.Timer;

namespace Banking_App
{
    public partial class Dashboard : Form
    {
        private Dictionary<string, string> user;
        private readonly UITimer updateTimer;
        private bool isUpdateRunning = false;
        public Dashboard(Dictionary<string, string> loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();

            updateTimer = new UITimer
            {
                Interval = 1000
            };

            updateTimer.Tick += UpdateTimerTick;

            updateTimer.Start();
        }

        private void UpdateTimerTick(object? sender, EventArgs e)
        {
            if (isUpdateRunning)
                return;

            isUpdateRunning = true;
            Update_balance_r();
            isUpdateRunning = false;

        }

        private void Update_balance_r()
        {
            var userRows = FileSystemCus.FindOneTemp("users", user["id"]);
            
            if (userRows.Count == 0)
                return;

            user = userRows;

            Update_balance(user["balance"]);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            user_label.Text = user["full_name"];
            card_value.Text = user["card_number"];
            expiry_value.Text = "02/" + user["expiry"];
            cvc_value.Text = user["cvc"];
            Update_balance(user["balance"]);
        }
        public void Update_balance(string amount)
        {
            var amountCr = double.Parse(amount);
            amount_label.Text = $"{amountCr:N0}";
        }

        private void Add_money_button_Click(object sender, EventArgs e)
        {
            new add_money(user, Show).Show();
            Hide();
        }

        private void Send_money_button_Click(object sender, EventArgs e)
        {
            new send_money(user, Show).Show();
            Hide();
        }

        private void Transactions_button_Click(object sender, EventArgs e)
        {
            new Transactions(user, Show).Show();
            Hide();
        }

        private void Withdraw_money_button_Click(object sender, EventArgs e)
        {
            new withdraw_money(user, Show).Show();
            Hide();
        }

    }
}
