namespace Banking_App
{
    public partial class BankingApp : Form
    {
        public BankingApp()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            new Signup().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }

    }
}
