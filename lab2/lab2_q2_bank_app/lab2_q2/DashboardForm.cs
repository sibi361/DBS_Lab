using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2_q2
{
    public partial class DashboardForm : Form
    {
        string username, password;
        Double balance;
        List<string> transactions;

        public DashboardForm(string username, string password, Double balance, List<string> transactions)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;
            this.balance = balance;
            this.transactions = transactions;

            unameLbl.Text = String.Format("Welcome {0}", username);
            balanceLbl.Text = String.Format("Current Balance: $ {0}", balance);

            transactionsBox.Text = "\n";
            transactions.ForEach(transaction =>
            {
                transactionsBox.Text += transaction;
            });
        }

        private void mTransferBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoneyTransferForm moneyTransferForm = new MoneyTransferForm(username, password, balance, transactions);
            moneyTransferForm.Closed += (s, args) => this.Close();
            moneyTransferForm.Show();
        }

        private void chngPassBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 changePasswordForm = new Form2(username, password, balance, transactions);
            changePasswordForm.Closed += (s, args) => this.Close();
            changePasswordForm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1(username, password, balance, transactions);
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
