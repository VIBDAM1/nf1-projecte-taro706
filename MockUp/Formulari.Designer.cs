namespace MockUp
{
    partial class Formulari
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
            panel4 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            rECETAToolStripMenuItem = new ToolStripMenuItem();
            fORMULARIOToolStripMenuItem = new ToolStripMenuItem();
            iNICIARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 413);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSalmon;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(249, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 207);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Location = new Point(96, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "ENVIA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(14, 105);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 13;
            label5.Text = "Alérgenos ";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(14, 76);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 10;
            label3.Text = "Correu electronic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(14, 47);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 9;
            label2.Text = "Nom i Cognoms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 47);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO CONTACTO";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 37);
            panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, rECETAToolStripMenuItem, fORMULARIOToolStripMenuItem, iNICIARSESIÓNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(54, 33);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // rECETAToolStripMenuItem
            // 
            rECETAToolStripMenuItem.Name = "rECETAToolStripMenuItem";
            rECETAToolStripMenuItem.Size = new Size(59, 33);
            rECETAToolStripMenuItem.Text = "RECETA";
            rECETAToolStripMenuItem.Click += rECETAToolStripMenuItem_Click;
            // 
            // fORMULARIOToolStripMenuItem
            // 
            fORMULARIOToolStripMenuItem.Name = "fORMULARIOToolStripMenuItem";
            fORMULARIOToolStripMenuItem.Size = new Size(93, 33);
            fORMULARIOToolStripMenuItem.Text = "FORMULARIO";
            fORMULARIOToolStripMenuItem.Click += fORMULARIOToolStripMenuItem_Click;
            // 
            // iNICIARSESIÓNToolStripMenuItem
            // 
            iNICIARSESIÓNToolStripMenuItem.Name = "iNICIARSESIÓNToolStripMenuItem";
            iNICIARSESIÓNToolStripMenuItem.Size = new Size(102, 33);
            iNICIARSESIÓNToolStripMenuItem.Text = "INICIAR SESIÓN";
            iNICIARSESIÓNToolStripMenuItem.Click += iNICIARSESIÓNToolStripMenuItem_Click;
            // 
            // Formulari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Formulari";
            Text = "Formulari";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem rECETAToolStripMenuItem;
        private ToolStripMenuItem fORMULARIOToolStripMenuItem;
        private ToolStripMenuItem iNICIARSESIÓNToolStripMenuItem;
        private Panel panel4;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}