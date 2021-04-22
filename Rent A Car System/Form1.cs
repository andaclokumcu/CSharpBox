using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
           

            List<string> cars = new List<string>() {"Fiat", "Toyota", "Renault", "Ford", "Honda"};

            foreach (var car in cars)
            {
                lbxCars.Items.Add(car);
            }

            List<string> colors = new List<string>() {"Kırmızı", "Siyah", "Beyaz", "Lacivert", "Gri"};

            foreach (var color in colors)
            {
                lbxColors.Items.Add(color);
            }


        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
          

            if (lbxCars.SelectedItem!=null)
            {
                lbxCart.Items.Add(lbxCars.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncekikle bir araba seçmelisiniz.");
            }

            
            

         }

        private void btnAddToCart2_Click(object sender, EventArgs e)
        {
            if (lbxColors.SelectedItem!=null)
            {
                lbxCart.Items.Add(lbxColors.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle bir renk seçmelisiniz.");
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
                MessageBox.Show("Öncelikle bir üren seçmelisiniz.");
            }
        }

        
    }
}
