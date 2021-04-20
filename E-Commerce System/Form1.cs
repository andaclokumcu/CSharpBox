using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Ürünler";
            string addToCartButtonText = "Sepete Ekle";
            string cartText = "Sepetiniz";
            string removeFromCartButtonText = "Sepetten Çıkar";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[] { "Laptop", "Masaüstü PC", "Klavye" };

            for (int i = 0; i < products.Length; i++)
            {
                lbxProducts.Items.Add(products[i]);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem!=null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle bir eleman seçmelisiniz.");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem!=null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle bir ürün seçmelisiniz.");
            }

            if (lbxCart.Items.Count==0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}
