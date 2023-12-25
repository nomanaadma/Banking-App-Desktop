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
    }
}
