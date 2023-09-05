using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FrazierPawTracks.Database;

namespace FrazierPawTracks
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            passwordTB.PasswordChar = '*';

            this.AcceptButton = loginButton;
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTB.Text;
            string inputPassword = passwordTB.Text;

            string dbFilePath = Path.Combine(Application.StartupPath, "Database", "pawtracks.db");

            using (SQLiteHelper dbHelper = new SQLiteHelper(dbFilePath))
            {
                dbHelper.OpenConnection();

                string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, dbHelper.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", inputUsername);
                    cmd.Parameters.AddWithValue("@password", inputPassword);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        this.Hide(); // Hide the LoginPage
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog(); // Open the MainForm

                        this.Close(); // Close the LoginPage once MainForm is closed
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
        }


    }
}
