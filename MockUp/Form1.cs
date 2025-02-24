namespace MockUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Tania" && this.textBox2.Text == "1234")
            {
                MessageBox.Show("Inicion sesiada");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Intenta otra vez");
                    }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrado!");
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
            Formulari formu = new Formulari();
            formu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         

        }
    }
}
