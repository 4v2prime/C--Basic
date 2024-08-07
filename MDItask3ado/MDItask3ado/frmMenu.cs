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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder objOrder = new frmOrder(cmbbxType.Text,cmbbxMenu.Text,lblPricemenu.Text);
            objOrder.Show();

        }
        //Maharashtraian  Gujrati  South Indian

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxMenu.Items.Clear();
            if (cmbbxType.SelectedItem.ToString() == "Maharashtraian") { cmbbxMenu.Items.Add("Wada Pav"); cmbbxMenu.Items.Add("Puran Poli"); cmbbxMenu.Items.Add("Bhaji"); }
            else if (cmbbxType.SelectedItem.ToString() == "Gujrati") { cmbbxMenu.Items.Add("Dokhla"); cmbbxMenu.Items.Add("Fafda"); cmbbxMenu.Items.Add("Thepla"); }
            else if (cmbbxType.SelectedItem.ToString() == "South Indian") { cmbbxMenu.Items.Add("Idli"); cmbbxMenu.Items.Add("Dosa"); cmbbxMenu.Items.Add("Utappa"); }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblPricemenu_Click(object sender, EventArgs e)
        {

            
        }

        private void cmbbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbbxMenu.SelectedItem)
            {
                case "Wada Pav":
                    string cost ="15 RS" ;
                    lblPricemenu.Text = cost;
                    break;
                case "Puran Poli":
                    string cost1 = "30 RS";
                    lblPricemenu.Text = cost1;
                    break;
                case "Bhagi":
                    string cost2 = "20 RS";
                    lblPricemenu.Text = cost2;
                    break;
                case "Dokhla":
                    string cost3 = "10 RS";
                    lblPricemenu.Text = cost3;
                    break;
                case "Fafda":
                    string cost4 ="25 RS";
                    lblPricemenu.Text = cost4;
                    break;
                case "Thepla":
                    string cost5 = "45 RS";
                    lblPricemenu.Text = cost5;
                    break;
                case "Idli":
                    string cost6 = "30 RS";
                    lblPricemenu.Text = cost6;
                    break;
                case "Dosa":
                    string cost7 = "25 RS";
                    lblPricemenu.Text = cost7.ToString();
                    break;
                case "Utappa":
                    string cost8 = "50 RS";
                    lblPricemenu.Text = cost8;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
