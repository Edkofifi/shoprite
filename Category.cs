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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        db dbcon = new db();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }
       
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // update and delete from tbBrand 
            string colname = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category deleted from database.", "POS Shoprite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colname == "Edit")
            {
                CategoryModule Module = new CategoryModule(this);
                Module.lblid.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                Module.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                Module.btnSave.Enabled = false;
                Module.btnUpdate.Enabled = true;
                Module.ShowDialog();
            }
            LoadCategory();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CategoryModule moduleForm = new CategoryModule(this);
            moduleForm.ShowDialog();
        }
    }
}
