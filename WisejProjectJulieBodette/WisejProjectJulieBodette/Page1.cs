using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Wisej.Web;

namespace WisejProjectJulieBodette
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        BindingList<Organization> OrganizationList = new BindingList<Organization>();
        /*
        private void Page1_Load(object sender, EventArgs e)
        {

            OrganizationList.Add(new Organization() { Name = "examplecompany", City = "Cleveland", Street = "101 Example Ave", Country = "USA", Zip = 44142 });
            dataGridView1.DataSource = OrganizationList;//connect the data list to the grid on the UI
        }
        */
        private void button1_Click(object sender, System.EventArgs e)
        {
            Database databaseObject = new Database();
            AlertBox.Show("wow look message");
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            OrganizationList.Add(new Organization() { Name = "examplecompany", City = "Cleveland", Street = "101 Example Ave", Country = "USA", Zip = 44142 });
            dataGridView1.DataSource = OrganizationList;//connect the data list to the grid on the UI
        }
    }
}
