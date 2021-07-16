using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CarpenterPass;


// Methods for home page are here including new password storage and password retreival.
namespace CarpenterPass
{
    public partial class passHomePage : Form
    {
        public passHomePage()
        {
            InitializeComponent();
        }

        // Set up connection to database table for passwords to services.
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_passwords.mdb");
        OleDbCommand cmmd = new OleDbCommand();
        OleDbDataAdapter data = new OleDbDataAdapter();
       

        // Validate and store passwords for services.
        private void storePasswordOptionButton_Click(object sender, EventArgs e)
        {
            // deny empty text fields
            if (inputService.Text == "" && inputPass.Text == "" && inputComPass.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (inputPass.Text == inputComPass.Text)
            {
                // Now create a hash of the entered password and store the hash.
                //covert text box input to string data type to prepare for hashing.
                string userName = UserID.usernameID;
                string passWord = inputPass.Text;

                // Create hash of password, passing userName to generate user specific key.
                string hashedPassWord = encryptAndDecrypt.encryptText(userName, passWord);

                // Store the hash of the password.
                conn.Open();
                string register = "INSERT INTO tbl_passwords VALUES ('" + userName + "','" + inputService.Text + "','" + hashedPassWord + "')";
                cmmd = new OleDbCommand(register, conn);
                cmmd.ExecuteNonQuery();
                conn.Close();

                // Clear fields
                inputPass.Text = "";
                inputComPass.Text = "";
                inputService.Text = "";

                MessageBox.Show("Your password has been stored successfully.", "Storage Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match. Try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPass.Text = "";
                inputComPass.Text = "";
                inputPass.Focus();
            }

        }


        // This takes the service option chosen from the drop down menu and puts the 
        // decyrpted password in the text box for viewing.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string q = "SELECT * FROM tbl_passwords WHERE username = '" + UserID.usernameID +"' AND service = '" + comboBox1.Text + "'";
                command.CommandText = q;

                OleDbDataReader r = command.ExecuteReader();

                // Decrypt stored hash of password for display.
                while (r.Read())
                {
                    string encryption = r["password"].ToString();  
                    string decryption = encryptAndDecrypt.decryptText(UserID.usernameID, encryption);
                    textBox1.Text = decryption;
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error  " + E);
            }

        }


        // When the home page opens, the drop down comboBox is loaded with names of services.
        private void passHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string q = "SELECT * FROM tbl_passwords WHERE username= '" + UserID.usernameID + "'";
                command.CommandText = q;

                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r["service"].ToString());
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error  " + E);
            }
        }


        // Checkbox hides or reveals stored password when clicked.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '•';
            }
            else
            {
                textBox1.PasswordChar = '\0';
            }
        }


        // This button refreshes services listed in the drop down comboBox when clicked.
        private void retreivePasswordsOptionButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string q = "SELECT * FROM tbl_passwords WHERE username= '" + UserID.usernameID + "'";
                command.CommandText = q;

                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r["service"].ToString());
                }
                conn.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error  " + E);
            }
        }
        

        // Quit program button closes application
        private void quitProgramOptionButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Go back to the login page.
        private void button1_Click(object sender, EventArgs e)
        {
            new RCPassLogin().Show();
            this.Hide();
        }
    }
}
