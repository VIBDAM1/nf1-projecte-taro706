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
    public partial class Formulari : Form
    {
        public Formulari()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
            {
                
                MessageBox.Show("Rellena los campos");
                
            }
            else
            {
                MessageBox.Show("Formulario enviado!!");
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox3.Clear();
                
            }
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void rECETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receta receta = new Receta();
            receta.Show();
            this.Hide();
        }

        private void fORMULARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIARSESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
