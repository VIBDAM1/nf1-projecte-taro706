using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockUp
{
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void fORMULARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iNICIARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void fORMULARIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Formulari formu = new Formulari();
            formu.Show();
            this.Hide();
        }

        private void iNICIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
