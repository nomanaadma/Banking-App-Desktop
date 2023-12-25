using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banking_App
{
    public partial class dashboard : Form
    {
        private string[] user;
        private int dynamicNumber = 0;
        private System.Windows.Forms.Timer timer;
        private bool isRecursiveFunctionRunning = false;
        public dashboard(string[] loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            user_label.Text = user[1];
            update_balance( amount_label.Text );
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
    }
}
