namespace demo_NF1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            recetasToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 651);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(332, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 568);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 318);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "nombre";
            // 
            // button2
            // 
            button2.BackColor = Color.PowderBlue;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(194, 410);
            button2.Name = "button2";
            button2.Size = new Size(210, 31);
            button2.TabIndex = 2;
            button2.Text = "REGISTRARSE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(194, 371);
            button1.Name = "button1";
            button1.Size = new Size(210, 33);
            button1.TabIndex = 1;
            button1.Text = "INICIAR SESION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.Location = new Point(212, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 196);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 33);
            panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, recetasToolStripMenuItem, formularioToolStripMenuItem, iniciarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1216, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // recetasToolStripMenuItem
            // 
            recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            recetasToolStripMenuItem.Size = new Size(59, 20);
            recetasToolStripMenuItem.Text = "Recetas";
            recetasToolStripMenuItem.Click += recetasToolStripMenuItem_Click;
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(77, 20);
            formularioToolStripMenuItem.Text = "Formulario";
            formularioToolStripMenuItem.Click += formularioToolStripMenuItem_Click;
            // 
            // iniciarSesionToolStripMenuItem
            // 
            iniciarSesionToolStripMenuItem.Image = Properties.Resources.images;
            iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            iniciarSesionToolStripMenuItem.Size = new Size(103, 20);
            iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 651);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem recetasToolStripMenuItem;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem formularioToolStripMenuItem;
        private ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}