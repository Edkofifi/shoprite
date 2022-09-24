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
    
    public partial class Attendant : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        db dbCon = new db();
        SqlDataReader dr;
        int qty;
        string id;
        string price;
        string stitle = " POS ";
        public Attendant()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.myConnection());
            GetTranNo();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        
        #region button
        private void btnTrans_Click(object sender, EventArgs e)
        {
            GetTranNo();
        }

        private void btnSettlePay_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LookUpProduct lookup = new LookUpProduct(this);
            lookup.LoadProduct();
            lookup.ShowDialog();

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
        #endregion button

        public void LoadCart()  
        {
            int i= 0;
            double total = 0; 
            dgvAttendant.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc,c.price, c.qty, c.total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode = p.pcode WHERE c.transno LIKE @transno and c.status LIKE  'Pending' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++; 
                total += Convert.ToDouble(dr["total"].ToString());
                cm.Parameters.AddWithValue("@transno", lblTrasNo.Text);
                dgvAttendant.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));   
            }
            dr.Close();
            cn.Close();
            lblSalesTotal.Text = total.ToString("#,##0.00");
            GetCartTotal();       
        }

        public void GetCartTotal()
        {
            double sales = double.Parse(lblSalesTotal.Text);
            lblDisplayTotal.Text = sales.ToString("#,#00.00"); 
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno = sdate + "1001";
                lblTrasNo.Text = transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart where transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTrasNo.Text = sdate + (count + 1);

                }
                else
                {
                    transno = sdate + "1001";
                    lblTrasNo.Text = transno;


                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAttendant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtBarcode.Text == String.Empty) return;
                else
                {
                    string _pcode;
                    double _price;
                    int _qty; 
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tbProduct WHERE barcode LIKE '" + txtBarcode.Text + "'",cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                        AddToCart(_pcode, _price, _qty);
                        dr.Close();
                        cn.Close();





                    }

                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void AddToCart(string _pcode, double _price, int _qty)
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCart(transno, pcode, price, qty, sdate, attendant)VALUES(@transno, @pcode, @price, @qty, @sdate, @attendant)", cn);
                cm.Parameters.AddWithValue("@transno", lblTrasNo.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@proce", _price);
                cm.Parameters.AddWithValue("@qty",_qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@attendant", lblUser.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                LoadCart();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
} 
