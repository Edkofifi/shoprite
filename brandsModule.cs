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

namespace Mall_Shoprite
{
    public partial class brandsModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        db db = new db();
        brand brand;
        
        public brandsModule(brand br)   // bransModule(brand br)
        {
            InitializeComponent();  
            cn = new SqlConnection(db.connection());
            brand =  br;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // insert brand name to the brand table
            try
            {  
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cmd.Parameters.AddWithValue("@brand", brandText.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand saved succesfully.");
                    Clear();
                    brand.LoadBrand();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            brandText.Clear();
            updateBtn.Enabled = false;
            saveBtn.Enabled = true;
            brand.Focus();
        }

        private void brandsModule_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // update name of brand
            if (MessageBox.Show("Are you sure you want to update this brand?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE Id LIKE'" + lblid.Text + "'", cn);
                cmd.Parameters.AddWithValue("@brand", brandText.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand updated", "POS");
                Clear();
                this.Dispose();  // to close this form after updating it.
            }


        }
    }

}
