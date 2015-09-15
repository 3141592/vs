namespace Gunter.Roy.Mathematics.GeneticFunction
{
    partial class GeneticFunction
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geneticPolynomiallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxEquation = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 28);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(703, 391);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.calculationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.calculationsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.settingsToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // calculationsToolStripMenuItem1
            // 
            this.calculationsToolStripMenuItem1.Name = "calculationsToolStripMenuItem1";
            this.calculationsToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.calculationsToolStripMenuItem1.Text = "Calculations";
            this.calculationsToolStripMenuItem1.Click += new System.EventHandler(this.calculationsToolStripMenuItem1_Click);
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGraphToolStripMenuItem,
            this.graphItToolStripMenuItem,
            this.geneticPolynomiallToolStripMenuItem});
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.calculationsToolStripMenuItem.Text = "Actions";
            // 
            // newGraphToolStripMenuItem
            // 
            this.newGraphToolStripMenuItem.Name = "newGraphToolStripMenuItem";
            this.newGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newGraphToolStripMenuItem.Text = "New Graph";
            this.newGraphToolStripMenuItem.Click += new System.EventHandler(this.newGraphToolStripMenuItem_Click);
            // 
            // graphItToolStripMenuItem
            // 
            this.graphItToolStripMenuItem.Name = "graphItToolStripMenuItem";
            this.graphItToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.graphItToolStripMenuItem.Text = "Graph It!";
            this.graphItToolStripMenuItem.Click += new System.EventHandler(this.graphItToolStripMenuItem_Click);
            // 
            // geneticPolynomiallToolStripMenuItem
            // 
            this.geneticPolynomiallToolStripMenuItem.Name = "geneticPolynomiallToolStripMenuItem";
            this.geneticPolynomiallToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.geneticPolynomiallToolStripMenuItem.Text = "Genetic Polynomial";
            this.geneticPolynomiallToolStripMenuItem.Click += new System.EventHandler(this.geneticPolynomiallToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxEquation
            // 
            this.textBoxEquation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEquation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEquation.Location = new System.Drawing.Point(157, 2);
            this.textBoxEquation.Name = "textBoxEquation";
            this.textBoxEquation.ReadOnly = true;
            this.textBoxEquation.Size = new System.Drawing.Size(558, 20);
            this.textBoxEquation.TabIndex = 2;
            this.textBoxEquation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEquation_MouseDoubleClick);
            // 
            // GeneticFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 439);
            this.Controls.Add(this.textBoxEquation);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneticFunction";
            this.Text = "Function Grapher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geneticPolynomiallToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxEquation;
    }
}

