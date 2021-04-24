using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        VetManager vetManager = new VetManager();
       
        private void Form1_Load(object sender, EventArgs e)

        {
           
            lbxProduct.Items.Add("Köpek Maması");
            lbxProduct.Items.Add("Kedi Maması");
            lbxProduct.Items.Add("Kuş Maması");
            lbxProduct.Items.Add("Hamster Maması");
            lbxProduct.Items.Add("Balık Yemi");


            dgrwVet.DataSource = vetManager.GetAll();
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Vet vet = new Vet();

            if (lbxProduct.SelectedItem != null)
            {
                vet.ID = Convert.ToInt32(tbxID.Text);
                vet.AnimalName = tbxAnimalName.Text;
                vet.PersonalName = tbxPersonalName.Text;
                vet.ProductName = lbxProduct.Text;
                vetManager.Add(vet);
            }
            else
            {
                MessageBox.Show("Öncelikle ürün seçmelisiniz.");
            }

            dgrwVet.DataSource = null;
            dgrwVet.DataSource = vetManager.GetAll();


                
            

        }
    }
}
