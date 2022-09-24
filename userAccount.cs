using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shoprite
{
    public partial class userAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        db dbCon = new db();
        public userAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.myConnection());
        }
        public void Clear()
        {
            txtFullname.Clear();
            txtPassword.Clear();
            txtUser.Clear();
            choRole.Text = "";
            txtUser.Focus();
        }
        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {   
                if (txtPassword.Text != txtRepass.Text)
                {
                    MessageBox.Show("Password did not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("INSERT INTO tbUser(username, name, password, role)VALUES(@username, @name, @password, @role)", cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@name", txtFullname.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                cm.Parameters.AddWithValue("@role", choRole.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User saved succesfully.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
