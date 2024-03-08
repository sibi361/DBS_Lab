using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

// install Oracle ManagedDataAccess ODAC19.21Xcopy_x64
// and fulfill the prerequisite tasks 1 and 2 given on lines 20 and 25 respecitively before running this program

namespace lab_8_data_access_vc
{
    public partial class Form1 : Form
    {
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();

            // 1 Uncomment the below line
            //db_init();
        }

        private void db_init()
        {
            // 2 Feed in proper credentials i.e. connection string to an Oracle SQL Database below
            const String oradb = "Data Source=1.2.3.4:1521/serviceName;User ID=uid1234;Password=pass1234";

            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private DataTable db_execute(String cmd)
        {
            OracleCommand comm;
            DataSet ds;
            OracleDataAdapter da;
            DataTable dt;

            comm = new OracleCommand();
            comm.CommandText = cmd;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "lorem");
            dt = ds.Tables["lorem"];
            return dt;
        }

        private void clearTable()
        {
            while (outputTable.Controls.Count > 0)
            {
                outputTable.Controls[0].Dispose();
            }
        }

        private void fillTable(DataTable dt)
        {
            DataRow dr;

            outputTable.ColumnCount = dt.Columns.Count;
            outputTable.RowCount = dt.Rows.Count;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                TextBox cell = new TextBox();
                cell.ReadOnly = true;
                cell.Text = dt.Columns[i].ColumnName;
                cell.Size = new Size(250, 30);
                outputTable.Controls.Add(cell, i, 0);
                outputTable.ColumnStyles.Add(new ColumnStyle());
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    TextBox cell = new TextBox();
                    cell.ReadOnly = true;
                    cell.Text = dr[dt.Columns[j].ColumnName].ToString();
                    cell.Size = new Size(250, 30);
                    outputTable.Controls.Add(cell, j, i + 1);
                    outputTable.RowStyles.Add(new RowStyle());
                }
            }
        }

        private void fetchAllRows(String tableName)
        {
            DataTable dt;

            try
            {
                dt = db_execute(String.Format("SELECT * FROM {0}", tableName));

                fillTable(dt);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(string.Format("SQL database connection ERROR:\n{0}", exception));
            }
        }

        private void fetchAllRows(String table1Name, String table1KeyColumn, String table2Name, String table2KeyColumn)
        {
            DataTable dt;

            try
            {
                dt = db_execute(String.Format("SELECT * FROM {0} INNER JOIN {2} ON {0}.{1}={2}.{3}",
                                table1Name, table1KeyColumn, table2Name, table2KeyColumn));
                fillTable(dt);
            }
            catch (OracleException exception)
            {
                MessageBox.Show(string.Format("SQL command ERROR:\n{0}", exception));
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show(string.Format("SQL command did not return any data:\n{0}", exception));
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(string.Format("SQL database connection ERROR:\n{0}", exception));
            }
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            clearTable();
            fetchAllRows("student");
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            clearTable();
            fetchAllRows("course");
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            clearTable();
            fetchAllRows("text");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTable();
        }

        private void studentEnrollBtn_Click(object sender, EventArgs e)
        {
            clearTable();
            fetchAllRows("student", "regno", "enroll", "regno");
        }

        private void courseBookAdoptionBtn_Click(object sender, EventArgs e)
        {
            clearTable();
            fetchAllRows("course", "course#", "book_adoption", "course#");
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            DataTable dt;

            if (executeField.Text.Length == 0)
            {
                MessageBox.Show("SQL command cannot be empty");
                return;
            }

            try
            {
                dt = db_execute(executeField.Text); clearTable();
                fillTable(dt);
            }
            catch (OracleException exception)
            {
                MessageBox.Show(string.Format("SQL command ERROR:\n{0}", exception));
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show(string.Format("SQL command did not return any data:\n{0}", exception));
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(string.Format("SQL database connection ERROR:\n{0}", exception));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (System.NullReferenceException)
            { }
            finally
            {
                Environment.Exit(0);
            }
        }
    }
}
