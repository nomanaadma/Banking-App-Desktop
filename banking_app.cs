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
            new Signup().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void atm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, this is a custom message box!", "Custom MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void banking_app_Load(object sender, EventArgs e)
        {

        }
    }
}
