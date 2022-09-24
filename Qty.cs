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

namespace POS_Shoprite
{
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        db dbCon = new db();
        SqlDataReader dr;
        private string pcode; 
        private double price;
        private String transno;
        private int qty;
        Attendant attendant;  

        public Qty(Attendant attendt)
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.myConnection());
            attendant = attendt;
        }
         
        private void Qty_Load(object sender, EventArgs e)
        {
              
        }

        public void ProductDetails(string pcode, double price, string transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCart(transno, pcode, price, qty, sdate, attendant) VALUES(@transno, @pcode, @price, @qty, @sdate, @attendant)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@attendant", attendant.lblUser);
                cm.ExecuteNonQuery();
                cn.Close();   
                attendant.LoadCart();
                this.Dispose();
            }

        }





        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {

        }

       
    }
}
