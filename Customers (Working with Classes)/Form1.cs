using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers__Working_with_Classes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwCustomers.DataSource = customerManager.GetAll();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            
            customer.ID = Convert.ToInt32(tbxID.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.City = tbxCity.Text;
            customer.Email = tbxEmail.Text;

            customerManager.Add(customer);

            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();

            MessageBox.Show("Basarıyla eklendi.");

            

        }
    }
}
