using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDItask3ado
{
    public partial class frmOrder : Form
    {
        public frmOrder(string type,string dish,string cost)
        {
            InitializeComponent();
            this.Text = type;
            lbldish.Text = dish;
            lblcost.Text = cost;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is Confirmed. Thnak You for business.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu objMenu2 = new frmMenu();
            objMenu2.Show();
        }
    }
}
