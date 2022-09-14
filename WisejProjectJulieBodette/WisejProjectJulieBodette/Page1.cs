using System.Collections.Generic;
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            Database databaseObject = new Database();
            AlertBox.Show("wow look message");
        }
    }
}
