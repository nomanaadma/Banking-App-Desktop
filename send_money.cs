using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class send_money : Form
    {
        private string[] user;
        private Dashboard dashboard;
        public send_money(string[] loggedInUser, Dashboard dashboard)
        {
            user = loggedInUser;
            this.dashboard = dashboard;
            InitializeComponent();
        }

        private void send_by_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            send_type_label.Text = send_by_input.Text;
        }

        private string validation(string[] dataRow)
        {
            string validationMessage = "";

            if (dataRow[0].Length == 0)
                validationMessage += "\n - The send by type must be not empty.";


            switch (dataRow[0])
            {
                case "Email":

                    if (dataRow[1].Contains("@") == false || dataRow[1].Contains(".") == false)
                        validationMessage += "\n - The email must not be empty and in the correct format.";

                    if (dataRow[1] == user[2])
                        validationMessage += "\n - You cannot transfer money to yourself.";

                    break;

                case "CNIC":

                    if (
                        dataRow[1].Length > 13 ||
                        dataRow[1].Length < 13 ||
                        dataRow[1].All(char.IsDigit) == false
                    )
                        validationMessage += "\n - The CNIC must have a length of 13 characters.";

                    if (dataRow[1] == user[4])
                        validationMessage += "\n - You cannot transfer money to yourself.";

                    break;

                default:

                    validationMessage += "\n - Something Wrong with the Send Type.";

                    break;

            }

            if (dataRow[2].All(char.IsDigit) == false || dataRow[2] == "" || dataRow[2] == "0")
                validationMessage += "\n - The amount must not be empty and in numbers only.";
            else
            {
                int amount = int.Parse(dataRow[2]);
                int balance = int.Parse(user[5]);

                if (amount > balance)
                    validationMessage += "\n - The amount must not be more than the balance.";
            }

            return validationMessage.TrimStart('\n');
        }

        private void send_money_button_Click(object sender, EventArgs e)
        {

            string[] inputs = {
                send_by_input.Text.Trim(),
                enter_input.Text.Trim(),
                amount_input.Text.Trim()
            };

            string validate = validation(inputs);

            if (validate != "")
            {
                MessageBox.Show(validate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // find the beneficiary user by ID
            string[] findBfUser = { inputs[1] };
            string[] bfUserRow = FileSystemCus.findRows("users", findBfUser);

            if (bfUserRow.Length == 0)
            {
                MessageBox.Show("The User Can't be Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
                return;


            // split row data by , seperated
            string[] bfUserData = bfUserRow[0].Split(",");

            // getting existing balance of the beneficiary user
            int bfUserBalance = int.Parse(bfUserData[5]);

            // amount entered in int
            int amount_entered = int.Parse(inputs[2]);

            // updating balance of new user
            bfUserData[5] = (bfUserBalance + amount_entered).ToString();
            FileSystemCus.UpdateRow("users", bfUserData);

            // New Amount of Logged in user update
            string newAmount = (int.Parse(user[5]) - amount_entered).ToString();
            user[5] = newAmount;
            FileSystemCus.UpdateRow("users", user);

            // adding transaction in file
            string[] transRow = {
                user[0],
                bfUserData[0],
                inputs[2],
                DateTime.Now.ToString(),
            };
            FileSystemCus.writeData("transactions", transRow);

            MessageBox.Show("Amount Transferred Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
