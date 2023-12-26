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
    public partial class add_money : Form
    {
        private string[] user;
        private dashboard dashboard;

        public add_money(string[] loggedInUser, dashboard dashboard)
        {
            user = loggedInUser;
            this.dashboard = dashboard;
            InitializeComponent();
        }

        private void add_money_button_Click(object sender, EventArgs e)
        {
            string amount = enter_amount_input.Text.Trim();

            // validation of amount input
            if (amount.All(char.IsDigit) == false || amount == "")
            {
                MessageBox.Show("The amount must not be empty and in numbers only.");
                return;
            }

            // updating amount to current user and file system
            string newAmount = (int.Parse(this.user[5]) + int.Parse(amount)).ToString();
            user = dashboard.update_balance(newAmount);
            FileSystemCus.UpdateRow("users", user);

            // adding transaction in file
            string[] transRow = {
                "none",
                user[0],
                amount,
                DateTime.Now.ToString(),
            };
            FileSystemCus.writeData("transactions", transRow);


            MessageBox.Show("Successfully Added.");
            this.Close();
            dashboard.Show();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }

    }
}
