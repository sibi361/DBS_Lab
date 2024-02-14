using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2_q2
{
    public partial class Form1 : Form
    {
        const string DEFAULT_USERNAME = "sam";
        const string DEFAULT_PASSWORD = "sam";
        const double DEFAULT_BALANCE = 10500;

        string username = DEFAULT_USERNAME;
        string password = DEFAULT_PASSWORD;
        double balance = DEFAULT_BALANCE;
        List<string> transactions;

        public Form1()
        {
            InitializeComponent();

            transactions = new List<string>();

            // for demonstration
            usernameField.Text = "sam";
            passField.Text = "sam";
        }

        public Form1(string username, string password, double balance, List<string> transactions)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.balance = balance;
            this.transactions = transactions;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "" || passField.Text == "")
            {
                MessageBox.Show("All fields are mandatory", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usernameField.Text != username)
            {
                MessageBox.Show(String.Format("Unknown username: {0}", usernameField.Text), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passField.Text != password)
            {
                MessageBox.Show("Incorrect password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passField.Clear();
                return;
            }

            int selectedStartPage = startInDropdown.SelectedIndex;
            if (selectedStartPage == 0)
            {
                this.Hide();
                DashboardForm dashboardFrom = new DashboardForm(username, password, balance, transactions);
                dashboardFrom.Closed += (s, args) => this.Close();
                dashboardFrom.Show();
            }
            else if (selectedStartPage == 1)
            {
                this.Hide();
                MoneyTransferForm moneyTransferForm = new MoneyTransferForm(username, password, balance, transactions);
                moneyTransferForm.Closed += (s, args) => this.Close();
                moneyTransferForm.Show();
            }
            else if (selectedStartPage == 2)
            {
                this.Hide();
                Form2 changePasswordForm = new Form2(username, password, balance, transactions);
                changePasswordForm.Closed += (s, args) => this.Close();
                changePasswordForm.Show();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            usernameField.Clear();
            passField.Clear();
            startInDropdown.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startInDropdown.Items.AddRange(new object[] {
            "Dashboard",
            "Money Transfer",
            "Change Password"
            });
            startInDropdown.SelectedIndex = 0;
        }
    }
}
