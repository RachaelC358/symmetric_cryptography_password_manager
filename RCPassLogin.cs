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
    public partial class RCPassLogin : Form
    {
        public RCPassLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '"+inputUserName.Text+"' and password= '"+inputPass.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() = true)
            {
                new passHomePage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is invalid. Try again.","Login has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
