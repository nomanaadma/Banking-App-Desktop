namespace Banking_App
{
    public partial class banking_app : Form
    {
        public banking_app()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            new signup().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            new login().Show();
        }

        private void atm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, this is a custom message box!", "Custom MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
