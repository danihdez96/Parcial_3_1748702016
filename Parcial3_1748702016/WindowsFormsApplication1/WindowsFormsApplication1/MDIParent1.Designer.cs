namespace WindowsFormsApplication1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionEstudianteToolStripMenuItem,
            this.operacionesMatematicasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.informacionToolStripMenuItem.Text = "Ventanas";
            // 
            // informacionEstudianteToolStripMenuItem
            // 
            this.informacionEstudianteToolStripMenuItem.Name = "informacionEstudianteToolStripMenuItem";
            this.informacionEstudianteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.informacionEstudianteToolStripMenuItem.Text = "Informacion estudiante";
            this.informacionEstudianteToolStripMenuItem.Click += new System.EventHandler(this.informacionEstudianteToolStripMenuItem_Click);
            // 
            // operacionesMatematicasToolStripMenuItem
            // 
            this.operacionesMatematicasToolStripMenuItem.Name = "operacionesMatematicasToolStripMenuItem";
            this.operacionesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.operacionesMatematicasToolStripMenuItem.Text = "Operaciones matematicas";
            this.operacionesMatematicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesMatematicasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesMatematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}



