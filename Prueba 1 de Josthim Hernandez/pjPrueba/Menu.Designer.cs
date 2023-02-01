namespace pjPrueba
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prueba1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudDePréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prueba1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prueba1ToolStripMenuItem
            // 
            this.prueba1ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.prueba1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudDePréstamosToolStripMenuItem,
            this.depreciaciónToolStripMenuItem,
            this.totalAPagarToolStripMenuItem});
            this.prueba1ToolStripMenuItem.Name = "prueba1ToolStripMenuItem";
            this.prueba1ToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.prueba1ToolStripMenuItem.Text = " Calculos ( Prueba 1)";
            // 
            // solicitudDePréstamosToolStripMenuItem
            // 
            this.solicitudDePréstamosToolStripMenuItem.Name = "solicitudDePréstamosToolStripMenuItem";
            this.solicitudDePréstamosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.solicitudDePréstamosToolStripMenuItem.Text = "Solicitud de préstamos";
            this.solicitudDePréstamosToolStripMenuItem.Click += new System.EventHandler(this.solicitudDePréstamosToolStripMenuItem_Click);
            // 
            // depreciaciónToolStripMenuItem
            // 
            this.depreciaciónToolStripMenuItem.Name = "depreciaciónToolStripMenuItem";
            this.depreciaciónToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.depreciaciónToolStripMenuItem.Text = "Depreciación en linea recta";
            this.depreciaciónToolStripMenuItem.Click += new System.EventHandler(this.depreciaciónToolStripMenuItem_Click);
            // 
            // totalAPagarToolStripMenuItem
            // 
            this.totalAPagarToolStripMenuItem.Name = "totalAPagarToolStripMenuItem";
            this.totalAPagarToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.totalAPagarToolStripMenuItem.Text = "Total a pagar ( tarjeta o efectivo)";
            this.totalAPagarToolStripMenuItem.Click += new System.EventHandler(this.totalAPagarToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 336);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem prueba1ToolStripMenuItem;
        private ToolStripMenuItem solicitudDePréstamosToolStripMenuItem;
        private ToolStripMenuItem depreciaciónToolStripMenuItem;
        private ToolStripMenuItem totalAPagarToolStripMenuItem;
    }
}