namespace Modulo_Seguridad
{
    partial class MDISeguridad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDISeguridad));
            this.MenSeguridad = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenSeguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenSeguridad
            // 
            this.MenSeguridad.BackColor = System.Drawing.Color.AliceBlue;
            this.MenSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenSeguridad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.manteToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.MenSeguridad.Location = new System.Drawing.Point(0, 0);
            this.MenSeguridad.Name = "MenSeguridad";
            this.MenSeguridad.Size = new System.Drawing.Size(920, 24);
            this.MenSeguridad.TabIndex = 0;
            this.MenSeguridad.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.archivoToolStripMenuItem.Text = "&Inicio";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cambioClaveToolStripMenuItem
            // 
            this.cambioClaveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cambioClaveToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cambioClaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambioClaveToolStripMenuItem.Image")));
            this.cambioClaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cambioClaveToolStripMenuItem.Name = "cambioClaveToolStripMenuItem";
            this.cambioClaveToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.cambioClaveToolStripMenuItem.Text = "&Cambio Clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // manteToolStripMenuItem
            // 
            this.manteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolToolStripMenuItem});
            this.manteToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.manteToolStripMenuItem.Name = "manteToolStripMenuItem";
            this.manteToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.manteToolStripMenuItem.Text = "&Mantenimiento";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilUsuarioToolStripMenuItem,
            this.perfilMenuToolStripMenuItem});
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // perfilUsuarioToolStripMenuItem
            // 
            this.perfilUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.perfilUsuarioToolStripMenuItem.Name = "perfilUsuarioToolStripMenuItem";
            this.perfilUsuarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.perfilUsuarioToolStripMenuItem.Text = "Perfil &Usuario";
            this.perfilUsuarioToolStripMenuItem.Click += new System.EventHandler(this.perfilUsuarioToolStripMenuItem_Click);
            // 
            // perfilMenuToolStripMenuItem
            // 
            this.perfilMenuToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.perfilMenuToolStripMenuItem.Name = "perfilMenuToolStripMenuItem";
            this.perfilMenuToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.perfilMenuToolStripMenuItem.Text = "Perfil &Menu";
            this.perfilMenuToolStripMenuItem.Click += new System.EventHandler(this.perfilMenuToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rolToolStripMenuItem.Image")));
            this.rolToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.rolToolStripMenuItem.Text = "&Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // MDISeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 384);
            this.Controls.Add(this.MenSeguridad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenSeguridad;
            this.MaximizeBox = false;
            this.Name = "MDISeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modulo Seguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDISeguridad_Load);
            this.MenSeguridad.ResumeLayout(false);
            this.MenSeguridad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenSeguridad;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
    }
}

