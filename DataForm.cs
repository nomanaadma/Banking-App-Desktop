namespace Banking_App
{
    public partial class DataForm(Dictionary<string, string> loggedInUser, DataForm.DashboardShowD dashboardShowB) : Form
    {
        protected readonly Dictionary<string, string> user = loggedInUser;
        public delegate void DashboardShowD();
        protected readonly DashboardShowD dashboardShow = dashboardShowB;
    }
}
