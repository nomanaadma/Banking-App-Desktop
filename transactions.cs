using System.Data;

namespace Banking_App
{
    public partial class Transactions : DataForm
    {

        private readonly int rowLength = 0;
        public Transactions(Dictionary<string, string> loggedInUser, DashboardShowD dashboardShowB)
            : base(loggedInUser, dashboardShowB)
        {

            var userTransRows = FileSystemCus.FindAll("transactions", user["id"]);

            InitializeComponent();

            rowLength = userTransRows.Count;

            userTransRows.Reverse();

            var dataTable = new DataTable();

            dataTable.Columns.Add("Reference");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date");

            foreach (var rowData in userTransRows)
            {
                var transAmount = rowData["amount"];

                var transferred_by_crUser = false;
                if (rowData["from"] == user["id"])
                {
                    transAmount = "-" + transAmount;
                    transferred_by_crUser = true;
                }

                string? reference;

                if (rowData["from"] == "none")
                    reference = "Money Deposited";
                else if (rowData["to"] == "none")
                    reference = "Money Withdrew";
                else
                {

                    string? otherUserCond;

                    // if the transaction is done by current loggedin user to some other user
                    if (transferred_by_crUser)
                    {
                        otherUserCond = rowData["to"];
                        reference = "Money Tranfered to: ";
                    }
                    else
                    {
                        otherUserCond = user["id"];
                        reference = "Money Tranfered by: ";
                    }

                    var userTransdata = FileSystemCus.FindOne("users", otherUserCond);

                    reference += userTransdata["email"] + " - " + userTransdata["cnic"];

                }

                dataTable.Rows.Add(reference, transAmount, rowData["date"]);
            }

            transaction_data.DataSource = dataTable;

        }
        private void Transaction_data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var targetColumnIndex = 1;

            if (e.ColumnIndex != targetColumnIndex || e.CellStyle == null)
                return;

            if (Convert.ToInt32(e.Value) < 0)
                e.CellStyle.ForeColor = Color.Red;
            else
                e.CellStyle.ForeColor = Color.Green;
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Close();
            dashboardShow();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            if (rowLength == 0)
                MessageBox.Show("There are no transaction.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
