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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            // deny empty text fields
            if (inputUserName.Text == "" && inputPass.Text == "" && inputComPass.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (inputPass.Text == inputComPass.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + inputUserName.Text + "','" + inputPass.Text + "')";
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

        private void inputPass_TextChanged(object sender, EventArgs e)
        {

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
            new RCPassLogin().Show();
            this.Hide();
        }
    }
}
