using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2_q2
{
    public partial class MoneyTransferForm : Form
    {
        string username, password;
        Double balance;
        List<string> transactions;

        public MoneyTransferForm(string username, string password, Double balance, List<string> transactions)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;
            this.balance = balance;
            this.transactions = transactions;

            unameLbl.Text = String.Format("Welcome {0}", username);
            balanceLbl.Text = String.Format("Current Balance: $ {0}", balance);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1(username, password, balance, transactions);
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            nameField.Clear();
            accnoField.Clear();
            amtField.Clear();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(username, password, balance, transactions);
            dashboardForm.Closed += (s, args) => this.Close();
            dashboardForm.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Double enteredAmt;
            Double.TryParse(amtField.Text, out enteredAmt);

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }


            if (enteredAmt > balance)
            {
                MessageBox.Show("Insufficient balance", "ERROR");
            }
            else
            {
                balance -= enteredAmt;
                balanceLbl.Text = String.Format("Current Balance: $ {0}", balance);
                MessageBox.Show(String.Format("Amount transferred: {0}\nCurrent balance: $ {1}",
                    enteredAmt,
                    balance),
                    "SUCCESS");
                string transactionText = String.Format("$ {0} transferred to benefitiary: {1} [{2}]{3}",
                    enteredAmt,
                    nameField.Text,
                    accnoField.Text,
                    Environment.NewLine);
                transactions.Add(transactionText);
            }
        }
    }
}
