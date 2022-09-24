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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        db dbCon = new db();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;


        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.myConnection());

        }

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * from tbUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtName.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Your account is not activated. Can't login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_role == "Attendant")
                    {
                        MessageBox.Show("Welcome " + _name + "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtName.Clear();
                        txtPassword.Clear();
                        this.Hide();
                        Attendant attendant = new Attendant();
                        attendant.lblUser.Text = _username;
                        attendant.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtName.Clear();
                        txtPassword.Clear();
                        this.Hide();
                        mainForm main = new mainForm();
                        main.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
