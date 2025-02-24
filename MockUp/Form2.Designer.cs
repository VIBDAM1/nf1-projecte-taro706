namespace MockUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
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
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 413);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(203, 215);
            label4.MaximumSize = new Size(420, 220);
            label4.Name = "label4";
            label4.Size = new Size(420, 189);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 171);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 2;
            label3.Text = "INTRODUCCIÓN";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.torrijas;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 149);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 23);
            label2.MaximumSize = new Size(240, 110);
            label2.Name = "label2";
            label2.Size = new Size(239, 110);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 64);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "TORRIJAS";
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
            rECETAToolStripMenuItem.Click += rECETAToolStripMenuItem_Click_1;
            // 
            // fORMULARIOToolStripMenuItem
            // 
            fORMULARIOToolStripMenuItem.Name = "fORMULARIOToolStripMenuItem";
            fORMULARIOToolStripMenuItem.Size = new Size(93, 33);
            fORMULARIOToolStripMenuItem.Text = "FORMULARIO";
            fORMULARIOToolStripMenuItem.Click += fORMULARIOToolStripMenuItem_Click_1;
            // 
            // iNICIARSESIÓNToolStripMenuItem
            // 
            iNICIARSESIÓNToolStripMenuItem.Name = "iNICIARSESIÓNToolStripMenuItem";
            iNICIARSESIÓNToolStripMenuItem.Size = new Size(102, 33);
            iNICIARSESIÓNToolStripMenuItem.Text = "INICIAR SESIÓN";
            iNICIARSESIÓNToolStripMenuItem.Click += iNICIARSESIÓNToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem rECETAToolStripMenuItem;
        private ToolStripMenuItem fORMULARIOToolStripMenuItem;
        private ToolStripMenuItem iNICIARSESIÓNToolStripMenuItem;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}