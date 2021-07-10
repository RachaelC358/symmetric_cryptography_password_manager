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


// This page is for user registration.


namespace CarpenterPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Register_Click(object sender, EventArgs e)
        {
            // deny empty text fields
            if (inputUserName.Text == "" && inputPass.Text == "" && inputComPass.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (inputPass.Text == inputComPass.Text)
            {
                // Now create a hash of the entered password and store the hash.
                //covert text box input to string data type to prepare for hashing.
                string userName = inputUserName.Text;
                string passWord = inputPass.Text;

                // Create hash of password, passing userName to generate user specific key.
                string hashedPassWord = encryptAndDecrypt.encryptText(userName, passWord);

                // Store the hash of the password.
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + inputUserName.Text + "','" + hashedPassWord + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                inputPass.Text = "";
                inputComPass.Text = "";
                inputUserName.Text = "";

                MessageBox.Show("Your account has been created successfully.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords do not match. Try again.","Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPass.Text = "";
                inputComPass.Text = "";
                inputPass.Focus();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            inputPass.Text = "";
            inputComPass.Text = "";
            inputUserName.Text = "";
            inputUserName.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // close current registration page and open login page
            new RCPassLogin().Show();
            this.Hide();
        }
    }
}
