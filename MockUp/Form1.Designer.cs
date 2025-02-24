namespace MockUp
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
            panel1 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            rECETAToolStripMenuItem = new ToolStripMenuItem();
            fORMULARIOToolStripMenuItem = new ToolStripMenuItem();
            iNICIARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
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
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(231, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 370);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 227);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(104, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 156);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Location = new Point(98, 308);
            button2.Name = "button2";
            button2.Size = new Size(152, 31);
            button2.TabIndex = 1;
            button2.Text = "REGISTRARSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(98, 272);
            button1.Name = "button1";
            button1.Size = new Size(152, 30);
            button1.TabIndex = 0;
            button1.Text = "INICIAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem rECETAToolStripMenuItem;
        private ToolStripMenuItem fORMULARIOToolStripMenuItem;
        private ToolStripMenuItem iNICIARSESIÓNToolStripMenuItem;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
