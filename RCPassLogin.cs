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


// Login page takes for input and encryption hash of input password to stored encrypted password.
namespace CarpenterPass
{
    public partial class RCPassLogin : Form
    {
        public RCPassLogin()
        {
            InitializeComponent();
        }

        // Connect with database table storing usernames and encrypted master passwords.
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        // Login button checks if login information is correct and completes login or displays ERROR.
        private void Register_Click(object sender, EventArgs e)
        {
            // Convert textbox input to hash and compare the new hashed password to the stored hash.
            //covert text box input to string data type to prepare for hashing.
            string userName = inputUserName.Text;
            string passWord = inputPass.Text;

            // Create hash of password, passing userName to generate user specific key.
            string hashedPassWord = encryptAndDecrypt.encryptText(userName, passWord);

            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '"+inputUserName.Text+"' and password= '"+hashedPassWord+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                // Set the userID to the current username so it can be used on the home page.
                UserID.usernameID = userName;
                new passHomePage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is invalid. Try again.","Login has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputUserName.Text = "";
                inputPass.Text = "";
                inputUserName.Focus();
            }

        }


        // Button press clears text fields.
        private void button2_Click(object sender, EventArgs e)
        {
            inputUserName.Text = "";
            inputPass.Text = "";
            inputUserName.Focus();
        }


        // Go back to registration page button.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void RCPassLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
