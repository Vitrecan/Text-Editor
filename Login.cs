using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string[] login = File.ReadAllLines("login.txt");
        bool validCredentials = false;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < login.Length; i++)
            {
                string[] loginCredentials = login[i].Split(',');

                //Checks if username, password is correct, if so then checks their userType.
                if (usernameTB.Text == loginCredentials[0] &&
                    passwordTB.Text == loginCredentials[1] &&
                    loginCredentials[2] == "Edit")
                {
                    validCredentials = true;
                    this.Hide();
                    new TextEditor(usernameTB.Text, "Edit").Show();
                } 
                else if (usernameTB.Text == loginCredentials[0] &&
                    passwordTB.Text == loginCredentials[1] &&
                    loginCredentials[2] == "View")
                {
                    validCredentials = true;
                    this.Hide();
                    new TextEditor(usernameTB.Text, "View").Show();
                }
            }

            //If username and password is incorrect, then reset both and let the user try again.
            if (validCredentials == false)
            {
                MessageBox.Show("Unknown username or password!", "Error", MessageBoxButtons.OK);
                usernameTB.Text = "";
                passwordTB.Text = "";
            }
        }

        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void NewUserBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new NewUser().Show();
        }
    }
}
