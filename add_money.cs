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

        private void add_money_label_Click(object sender, EventArgs e)
        {
            string amount = enter_amount_input.Text.Trim();

            if(amount.All(char.IsDigit) == false)
            {
                MessageBox.Show("Amount Should be in Numbers Only");
                return;
            }

            string newAmount = (int.Parse(this.user[5]) + int.Parse(amount)).ToString();

            user = dashboard.update_balance(newAmount);

            FileSystemCus.UpdateRow("users", user);

            this.Close();
            dashboard.Show();

        }
    }
}
