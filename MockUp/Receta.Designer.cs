namespace MockUp
{
    partial class Receta
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            rECETAToolStripMenuItem = new ToolStripMenuItem();
            fORMULARIOToolStripMenuItem = new ToolStripMenuItem();
            iNICIARSESIÓNToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 413);
            panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(186, 181);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(423, 212);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(415, 184);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PASOS";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(415, 184);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "INGREDIENTES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.torrijas;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 149);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 57);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 0;
            label1.Text = "RECETA TORRIJAS";
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
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click_1;
            // 
            // rECETAToolStripMenuItem
            // 
            rECETAToolStripMenuItem.Name = "rECETAToolStripMenuItem";
            rECETAToolStripMenuItem.Size = new Size(59, 33);
            rECETAToolStripMenuItem.Text = "RECETA";
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
            // Receta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Receta";
            Text = "Receta";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private Label label1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem rECETAToolStripMenuItem;
        private ToolStripMenuItem fORMULARIOToolStripMenuItem;
        private ToolStripMenuItem iNICIARSESIÓNToolStripMenuItem;
    }
}