using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ADOsqldemo2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save objSave= new Save();
            objSave.Show();
            objSave.MdiParent = this;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelete objdel= new frmDelete();
            objdel.Show();
            objdel.MdiParent = this;

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate objUpdate = new frmUpdate();
            objUpdate.MdiParent = this;
            objUpdate.Show();
        }
    }
}
