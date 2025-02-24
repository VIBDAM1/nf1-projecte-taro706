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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void rECETAToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void rECETAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Receta receta = new Receta();
            receta.Show();
            this.Hide();
        }

        private void fORMULARIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Formulari formu = new Formulari();
            formu.Show();
            this.Hide();
        }
    }
}
