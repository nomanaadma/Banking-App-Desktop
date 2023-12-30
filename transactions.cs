using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class Transactions : Form
    {
        private string[] user;
        private Dashboard dashboard;
        private int rowLength = 0;
        public Transactions(Dashboard dashboardCl)
        {
            dashboard = dashboardCl;
            user = dashboard.user;

            string[] userTransRows = FileSystemCus.findAll("transactions", user[0]);

            InitializeComponent();
            
            rowLength = userTransRows.Length;

            Array.Reverse(userTransRows);


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Reference");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date");


            foreach (var row in userTransRows)
            {
                string[] rowData = row.Split(",");

                string transAmount = rowData[3];

                bool transferred_by_crUser = false;
                if (rowData[1] == user[0])
                {
                    transAmount = "-" + transAmount;
                    transferred_by_crUser = true;
                }

                string reference = "";
                if (rowData[1] == "none")
                {
                    reference = "Money Deposited";
                }
                else if (rowData[2] == "none")
                {
                    reference = "Money Withdrawed";
                }
                else
                {

                    string otherUserCond = "";

                    // if the transaction is done by current loggedin user to some other user
                    if (transferred_by_crUser)
                    {
                        otherUserCond = rowData[2];
                        reference = "Money Tranfered to: ";
                    }
                    else
                    {
                        otherUserCond = user[0];
                        reference = "Money Tranfered by: ";
                    }

                    string[] userTransdata = FileSystemCus.findOne("users", otherUserCond);

                    reference += userTransdata[2] + " - " + userTransdata[4];

                }


                dataTable.Rows.Add(reference, transAmount, rowData[4]);
            }

            // Bind the DataTable to the DataGridView
            transaction_data.DataSource = dataTable;

            transaction_data.ReadOnly = true; // Make the DataGridView read-only

            transaction_data.RowHeadersVisible = false;

            transaction_data.ScrollBars = ScrollBars.Both;

            transaction_data.CellFormatting += DataGridView1_CellFormatting;

        }

        private void DataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            int targetColumnIndex = 1;

            if (e.ColumnIndex != targetColumnIndex || e.CellStyle == null)
                return;

            if (Convert.ToInt32(e.Value) < 0)
                e.CellStyle.ForeColor = Color.Red;
            else
                e.CellStyle.ForeColor = Color.Green;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
            dashboard.Show();
        }

        private void transactions_Load(object sender, EventArgs e)
        {

            if(rowLength == 0)
                MessageBox.Show("There are no transaction.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
