using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2_q2
{
    public partial class Form2 : Form
    {
        string username, password;
        double balance;
        List<string> transactions;

        public Form2(string username, string password, double balance, List<string> transactions)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;
            this.balance = balance;
            this.transactions = transactions;
        }

        private void goBackToLogin()
        {
            this.Hide();
            Form1 loginForm = new Form1(username, password, balance, transactions);
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (passField.Text == "" || confirmPassField.Text == "")
            {
                MessageBox.Show("All fields are mandatory", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passField.Text != confirmPassField.Text)
            {
                MessageBox.Show("Passwords do not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passField.Text == password)
            {
                MessageBox.Show("Given new password is same as existing password.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                password = passField.Text;
                MessageBox.Show("Password changed successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goBackToLogin();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            goBackToLogin();
        }
    }
}
