namespace Banking_App
{
    public partial class banking_app : Form
    {
        public banking_app()
        {
            InitializeComponent();
        }

        private void banking_app_Load(object sender, EventArgs e)
        {

        }

        private void go_to_Click(object sender, EventArgs e)
        {
            new another_form().Show();
            // this.Hide();
        }
    }
}
