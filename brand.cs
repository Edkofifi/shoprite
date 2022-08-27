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
    public partial class brand : Form 
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        db db = new db();
        SqlDataReader dr;
        public brand()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
            LoadBrand();
        }

        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbBrand ORDER BY brand", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(dr[i].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // update and delete from tbBrand 
            string colname = dgvBrand.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        cn.Open();
                        cmd = new SqlCommand("DELETE FROM tbBrand WHERE Id LIKE '" + dgvBrand[1, e.RowIndex].Value.ToString() + "', cn ");
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Brand deleted from database.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else if (colname == "Edit")
            {
                brandsModule brandModule = new brandsModule(this);
                brandModule.lblid.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.brandText.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.saveBtn.Enabled = false;
                brandModule.updateBtn.Enabled = true;  
                brandModule.ShowDialog();
            }
            LoadBrand();
        }

         private void addBrandBtn_Click(object sender, EventArgs e)
        {
            brandsModule moduleForm = new brandsModule(this);
            moduleForm.ShowDialog();
        }
    }
}
 