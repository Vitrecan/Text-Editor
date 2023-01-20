using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TextEditor : Form
    {
        string file;

        public TextEditor(string username, string userType)
        {
            //Adds the user's username to the Tool Strip Label.
            InitializeComponent();
            usernameTSL.Text = $"User Name: " + username;

            //Disables the editing screen if the user's userType is "View".
            if (userType == "View")
            {
                richTextBox1.Enabled = false;
                newTSMI.Enabled = false;
                saveTSMI.Enabled = false;
                saveAsTSMI.Enabled = false;
                newTSBtn.Enabled = false;
                saveTSBtn.Enabled = false;
                saveAsTSBtn.Enabled = false;
                cutTSMI.Enabled = false;
                copyTSMI.Enabled = false;
                pasteTSMI.Enabled = false;
                cutLeftTSBtn.Enabled = false;
                copyLeftTSBtn.Enabled = false;
                pasteLeftTSBtn.Enabled = false;
                fontSizeTSCB.Enabled = false;
            }
        }

        //Clears the text editor.
        private void NewTSMI_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Prompts the user to pick a file to open.
                if ((_ = openFileDialog.OpenFile()) != null)
                {
                    string fileName = openFileDialog.FileName;
                    string text = File.ReadAllText(fileName);
                    richTextBox1.Text = text;
                }
            }
        }

        //Save current rtf file.
        private void SaveTSMI_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file, richTextBox1.Rtf);
        }

        private void SaveAsTSMI_Click(object sender, EventArgs e)
        {
            //Forces user to save file as an "rtf".
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog.FileName;

                using (FileStream fileStream = new FileStream(file, FileMode.Create))
                {
                    byte[] data = new UTF8Encoding().GetBytes(richTextBox1.Text);
                    fileStream.Write(data, 0, data.Length);
                    fileStream.Flush();
                }
            }
        }

        private void LogoutTSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void CutTSMI_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyTSMI_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteTSMI_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void AboutTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some Text Editor v2", "About", MessageBoxButtons.OK);
        }

        private void NewTSBtn_Click(object sender, EventArgs e)
        {
            file = "";
            richTextBox1.Text = "";
        }

        private void OpenTSBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((_ = openFileDialog.OpenFile()) != null)
                {
                    string fileName = openFileDialog.FileName;
                    string text = File.ReadAllText(fileName);
                    richTextBox1.Text = text;
                }
            }
        }

        private void SaveTSBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file, richTextBox1.Rtf);
        }

        private void SaveAsTSBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog.FileName;

                using (FileStream fileStream = new FileStream(file, FileMode.Create))
                {
                    byte[] data = new UTF8Encoding().GetBytes(richTextBox1.Text);
                    fileStream.Write(data, 0, data.Length);
                    fileStream.Flush();
                }
            }
        }

        private void BoldTSBtn_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;

            if (font != null)
            {
                richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Bold);
            }
        }

        private void ItalicTSBtn_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;

            if (font != null)
            {
                richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Italic);
            }
        }

        private void UnderlineTSBtn_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;

            if (font != null)
            {
                richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Underline);
            }
        }

        private void fontSizeTSCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(((ToolStripComboBox)sender).Text);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize);
        }

        private void CutLeftTSBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyLeftTSBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteLeftTSBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
