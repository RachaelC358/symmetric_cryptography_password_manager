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

namespace CarpenterPass
{
    public partial class passHomePage : Form
    {
        public passHomePage()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_passwords.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
                con.Open();
                string register = "INSERT INTO tbl_passwords VALUES ('" + userName + "','" + inputService.Text + "','" + hashedPassWord + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string q = "SELECT password FROM tbl_passwords WHERE username= '" + UserID.usernameID +" AND service = '" + comboBox1.Text + "'";
                command.CommandText = q;

                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    string decyptedPassword = r["password"].ToString();
                }
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error  " + E);
            }

        }

        private void passHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string q = "SELECT * FROM tbl_passwords WHERE username= '" + UserID.usernameID + "'";
                command.CommandText = q;

                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r["service"].ToString());
                }
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error  " + E);
            }
        }
    }
}
