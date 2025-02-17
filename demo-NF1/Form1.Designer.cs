namespace demo_NF1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            recetasToolStripMenuItem = new ToolStripMenuItem();
            recetaToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesionToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1176, 272);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.59539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.40461F));
            tableLayoutPanel1.Size = new Size(1182, 781);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 497);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(407, 109);
            label5.MaximumSize = new Size(390, 0);
            label5.Name = "label5";
            label5.Size = new Size(389, 300);
            label5.TabIndex = 2;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(373, 72);
            label4.Name = "label4";
            label4.Size = new Size(463, 28);
            label4.TabIndex = 1;
            label4.Text = "Descubre recetas faciles y deliciosas para todos.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Introduccion";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1176, 272);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuStrip1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1176, 41);
            panel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { recetasToolStripMenuItem, recetaToolStripMenuItem, formularioToolStripMenuItem, iniciarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 41);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // recetasToolStripMenuItem
            // 
            recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            recetasToolStripMenuItem.Size = new Size(48, 37);
            recetasToolStripMenuItem.Text = "Inicio";
            recetasToolStripMenuItem.Click += recetasToolStripMenuItem_Click;
            // 
            // recetaToolStripMenuItem
            // 
            recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            recetaToolStripMenuItem.Size = new Size(54, 37);
            recetaToolStripMenuItem.Text = "Receta";
            recetaToolStripMenuItem.Click += recetaToolStripMenuItem_Click;
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(77, 37);
            formularioToolStripMenuItem.Text = "Formulario";
            formularioToolStripMenuItem.Click += formularioToolStripMenuItem_Click;
            // 
            // iniciarSesionToolStripMenuItem
            // 
            iniciarSesionToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            iniciarSesionToolStripMenuItem.Image = Properties.Resources.images;
            iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            iniciarSesionToolStripMenuItem.Size = new Size(103, 37);
            iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
            iniciarSesionToolStripMenuItem.Click += iniciarSesionToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(542, 109);
            label3.MaximumSize = new Size(489, 0);
            label3.Name = "label3";
            label3.Size = new Size(481, 84);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(339, 134);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 6;
            label2.Text = "TORRIJAS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1182, 781);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recetasToolStripMenuItem;
        private ToolStripMenuItem recetaToolStripMenuItem;
        private ToolStripMenuItem formularioToolStripMenuItem;
        private ToolStripMenuItem iniciarSesionToolStripMenuItem;
    }
}
