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


// This page is for the user registration form.
namespace CarpenterPass
{
    // This class will be used to identify the user later, on the home page.
    static class UserID
    {
        public static string usernameID;
    }

    // functions for registration form here
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Set up connection to microsoft access table for users and passwords.
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmmd = new OleDbCommand();
        OleDbDataAdapter data = new OleDbDataAdapter();


        // Registration button code is here.
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
                conn.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + inputUserName.Text + "','" + hashedPassWord + "')";
                cmmd = new OleDbCommand(register, conn);
                cmmd.ExecuteNonQuery();
                conn.Close();

                // clear fields
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

        // clear fields
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
