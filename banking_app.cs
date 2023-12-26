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

    }
}
