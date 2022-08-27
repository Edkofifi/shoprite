using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Mall_Shoprite
{
    public partial class shoprite : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        db db = new db();

        public shoprite()
        {
            InitializeComponent();
            customizeDesign();
            cn = new SqlConnection(db.connection());
            cn.Open();
            MessageBox.Show("Database is connected.");
        }
        #region panelSlide
        private void customizeDesign()
        {
            subProductPanel.Visible = false;
            subStockPanel.Visible = false;
        }
         
        private void hidesubmenu()
        {
            if (subProductPanel.Visible ==true)
                subProductPanel.Visible = false;
            if (subStockPanel.Visible ==true)
                subStockPanel.Visible=false;
        }
        
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible=false;
        }    


        private void categoryBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(subProductPanel);
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void productListBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(subStockPanel);
        }

        private void adjustStockBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void addStockBtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        #endregion panelSlide

        private void subProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void middlepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
