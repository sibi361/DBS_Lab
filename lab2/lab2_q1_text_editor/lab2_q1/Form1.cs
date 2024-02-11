using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace lab2_q1
{
    public partial class Form1 : Form
    {
        private float ZOOM_STEP = 0.2F;
        private string ABOUT_TEXT = "Text Editor V0.0.1\n\nCreated with Visual C# on Visual Studio\n\n© 2024 TE, LLC\nAll rights reserved.";
        private string WORD_REGEX = @"\b[\w\.!@#$%^&*()-_+=\[\]\\{}|;:'<>?,./]+\b";

        private string filename = "Untitled.txt";
        private string path = Directory.GetCurrentDirectory();
        private bool fileWasInitiallySaved = false;
        private bool modified = false;

        private bool statusBarShown = true;

        private Font printFont;
        private StreamReader streamToPrint;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateStatusBar()
        {
            string text = textbox.Text;

            int wordCount = Regex.Matches(text, WORD_REGEX)
                       .Cast<Match>()
                       .ToArray().Length;

            characterCounterStatusBar.Text = string.Format("{0} characters", Regex.Replace(text, @"\n", "").Length.ToString());
            wordCountStatusBar.Text = string.Format("{0} words", wordCount);
        }

        private void setPathAndFilename(string filePath)
        {
            if (filePath.IndexOf("\\") != -1)
            {
                String[] fileNameSplit = filePath.Split('\\');

                String[] pathStrings = fileNameSplit.Take(fileNameSplit.Length - 1).ToArray();
                path = string.Join("\\", pathStrings);

                filename = fileNameSplit.Last();
            }

            Text = filename; // window title

            updateStatusBar();
        }

        private bool createNewFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Save Text File";
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.FileName = filename;
            fileDialog.InitialDirectory = path;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                File.WriteAllText(filePath, textbox.Text);

                setPathAndFilename(filePath);

                return true;
            }
            return false;
        }

        private bool saveFile()
        {
            modified = false;
            if (!fileWasInitiallySaved)
            {
                return fileWasInitiallySaved = createNewFile();
            }
            else
            {
                File.WriteAllText(string.Format("{0}\\{1}", path, filename), textbox.Text);
                return true;
            }
        }

        private bool modifiedFileClose()
        {
            if (modified)
            {
                string confirmMessage = "Save file before exiting?";

                DialogResult result = MessageBox.Show(confirmMessage, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    return saveFile();
                else if (result == DialogResult.Cancel)
                    return false;
            }
            return true;
        }

        private void exitApp()
        {
            if (modifiedFileClose())
                Environment.Exit(0);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!modifiedFileClose())
                return;

            textbox.Text = "";

            setPathAndFilename(string.Format("{0}\\{1}", path, "Untitled.txt"));

            fileWasInitiallySaved = false;
            modified = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open Text File";
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.InitialDirectory = path;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                textbox.Text = File.ReadAllText(filePath);

                setPathAndFilename(filePath);

                fileWasInitiallySaved = true;
                modified = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewFile();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height /
               printFont.GetHeight(e.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveFile())
                return;

            PrintDialog pDialog = new PrintDialog();
            pDialog.AllowSomePages = true;
            pDialog.ShowHelp = true;

            streamToPrint = new StreamReader(string.Format("{0}\\{1}", path, filename));
            try
            {
                printFont = textbox.Font;
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler
                   (this.pd_PrintPage);

                pDialog.Document = pd;

                if (pDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            finally
            {
                streamToPrint.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.ForeColor = colorDialog.Color;
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            modified = true;

            updateStatusBar();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.WordWrap = textbox.WordWrap ? false : true;
            wordWrapToolStripMenuItem.CheckState = wordWrapToolStripMenuItem.CheckState == CheckState.Checked
                                                   ? CheckState.Unchecked
                                                   : CheckState.Checked;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ZoomFactor += ZOOM_STEP;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ZoomFactor -= ZOOM_STEP;

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ZoomFactor = 1F;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarShown = statusBarShown ? false : true;
            statusBar.Visible = statusBarShown;

            statusBarToolStripMenuItem.CheckState = statusBarToolStripMenuItem.CheckState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked;

            // textbox.Size = new Size(textbox.Size.Width, statusBarShown ? (textbox.Size.Height + 40) : (textbox.Size.Height - 40));
        }

        private void aboutTextEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ABOUT_TEXT, "About");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitApp();
        }
    }
}
