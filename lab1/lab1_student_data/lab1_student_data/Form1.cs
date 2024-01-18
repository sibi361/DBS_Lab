using System;
using System.Windows.Forms;

namespace lab1_student_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAllFields()
        {
            nameField.Clear();
            regField.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            dobPicker.ResetText();
            branchPicker.SelectedIndex = -1;
            cbMarksCard1.Checked = false;
            cbMarksCard2.Checked = false;
            cbAdarCardXerox.Checked = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void showErrorPopup(string msg)
        {
            MessageBox.Show(msg, "ERROR");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text.Length == 0)
                showErrorPopup("Name field is empty");
            else if (regField.Text == "2")
                showErrorPopup("Registration number NOT filled");
            else if (!radioMale.Checked && !radioFemale.Checked)
                showErrorPopup("Student gender NOT specified");
            else if (branchPicker.SelectedIndex == -1)
                showErrorPopup("Student branch NOT selected");
            else if (dobPicker.Value.Date == new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                showErrorPopup("Date of birth NOT filled");
            else if (!cbMarksCard1.Checked)
                showErrorPopup("Class X Marks Card NOT submitted");
            else if (!cbMarksCard2.Checked)
                showErrorPopup("Class XII Marks Card NOT submitted");
            else if (!cbAdarCardXerox.Checked)
                showErrorPopup("Aadhaar Card Xerox NOT submitted");
            else
            {
                string gender = radioMale.Checked ? "Male" : "Female";

                string confirmMessage = string.Format("Please confirm these details:\nName: {0}\nRegistration no: {1}\nGender: {2}\nDate of birth: {3}\nBranch: {4}",
                       nameField.Text,
                       regField.Text,
                       gender,
                       dobPicker.Text,
                       branchPicker.Text
                   );

                if (MessageBox.Show(confirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    records.Text += string.Format("{0}{1}\t{2}\t\t{3}\t{4}\t{5}",
                        Environment.NewLine,
                        nameField.Text,
                        regField.Text,
                        gender,
                        dobPicker.Text,
                        branchPicker.Text
                    );
                    MessageBox.Show(string.Format("Student record created for registration number: {0}", regField.Text),
                        "SUCCESS");
                    clearAllFields();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            branchPicker.Items.AddRange(new object[] {
            "Aeronautical",
            "Automobile",
            "Biotechnology",
            "Computer Science",
            "Data Science",
            "Electronics and Communication",
            "Electrical and Electronics",
            "Information Technology",
            "Industrial",
            "Mechanical",
            "Mechatronics"});
        }
    }
}
