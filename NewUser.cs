using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewUser : Form
    {
        string[] login = File.ReadAllLines("login.txt");

        public NewUser()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < login.Length; i++)
            {
                string[] loginCredentials = login[i].Split(',');

                if (passwordTB.Text == passwordTB2.Text)
                {

                    //Changes date of birth format to "dd-MM-yyyy" before adding the user's information into "login.txt".
                    dateOfBirthTmPkr.Format = DateTimePickerFormat.Custom;
                    dateOfBirthTmPkr.CustomFormat = "dd-MM-yyyy";
                    File.AppendAllText("login.txt", $"\n{usernameTB.Text},{passwordTB.Text},{userTypeCbB.SelectedItem},{firstNameTB.Text},{lastNameTB.Text},{dateOfBirthTmPkr.Text}");
                    this.Hide();
                    new Login().Show();
                    break;
                }
                MessageBox.Show("Incorrect confirmation password!", "Error", MessageBoxButtons.OK);
                passwordTB2.Text = "";
                break;
            }
        }
    }
}
