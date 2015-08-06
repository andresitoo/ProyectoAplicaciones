using ModuloFacturacion;
namespace ModuloFacturacion
{
    partial class frmMDI_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI_Principal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tss_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_Fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_cambiar_User = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opt_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Solicitud_Pedido = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_orden_Compra = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opt_EntregaPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Devolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Cotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_user,
            this.tss_lbl_Fecha});
            this.statusStrip.Location = new System.Drawing.Point(0, 342);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(818, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tss_user
            // 
            this.tss_user.Name = "tss_user";
            this.tss_user.Size = new System.Drawing.Size(42, 17);
            this.tss_user.Text = "Estado";
            // 
            // tss_lbl_Fecha
            // 
            this.tss_lbl_Fecha.Name = "tss_lbl_Fecha";
            this.tss_lbl_Fecha.Size = new System.Drawing.Size(54, 17);
            this.tss_lbl_Fecha.Text = "lbl_fecha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Usuario,
            this.menu_Procesos,
            this.menu_mantenimiento,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Usuario
            // 
            this.menu_Usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_cambiar_User,
            this.toolStripSeparator1,
            this.opt_Salir});
            this.menu_Usuario.Name = "menu_Usuario";
            this.menu_Usuario.Size = new System.Drawing.Size(59, 20);
            this.menu_Usuario.Text = "&Usuario";
            // 
            // opt_cambiar_User
            // 
            this.opt_cambiar_User.Name = "opt_cambiar_User";
            this.opt_cambiar_User.Size = new System.Drawing.Size(171, 22);
            this.opt_cambiar_User.Text = "&Cambiar Usuario...";
            this.opt_cambiar_User.Click += new System.EventHandler(this.opt_cambiar_User_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // opt_Salir
            // 
            this.opt_Salir.Name = "opt_Salir";
            this.opt_Salir.Size = new System.Drawing.Size(171, 22);
            this.opt_Salir.Text = "&Salir";
            this.opt_Salir.Click += new System.EventHandler(this.opt_Salir_Click);
            // 
            // menu_Procesos
            // 
            this.menu_Procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_Solicitud_Pedido,
            this.opt_orden_Compra,
            this.toolStripSeparator2,
            this.opt_EntregaPedido,
            this.opt_Devolucion,
            this.opt_Cotizacion});
            this.menu_Procesos.Name = "menu_Procesos";
            this.menu_Procesos.Size = new System.Drawing.Size(66, 20);
            this.menu_Procesos.Text = "&Procesos";
            // 
            // opt_Solicitud_Pedido
            // 
            this.opt_Solicitud_Pedido.Name = "opt_Solicitud_Pedido";
            this.opt_Solicitud_Pedido.Size = new System.Drawing.Size(176, 22);
            this.opt_Solicitud_Pedido.Text = "&Solicitud de Pedido";
            this.opt_Solicitud_Pedido.Click += new System.EventHandler(this.opt_Solicitud_Pedido_Click);
            // 
            // opt_orden_Compra
            // 
            this.opt_orden_Compra.Name = "opt_orden_Compra";
            this.opt_orden_Compra.Size = new System.Drawing.Size(176, 22);
            this.opt_orden_Compra.Text = "&Orden de Compra";
            this.opt_orden_Compra.Click += new System.EventHandler(this.opt_orden_Compra_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // opt_EntregaPedido
            // 
            this.opt_EntregaPedido.Name = "opt_EntregaPedido";
            this.opt_EntregaPedido.Size = new System.Drawing.Size(176, 22);
            this.opt_EntregaPedido.Text = "&Entrega de Pedido";
            this.opt_EntregaPedido.Click += new System.EventHandler(this.opt_EntregaPedido_Click);
            // 
            // opt_Devolucion
            // 
            this.opt_Devolucion.Name = "opt_Devolucion";
            this.opt_Devolucion.Size = new System.Drawing.Size(176, 22);
            this.opt_Devolucion.Text = "&Devolucion";
            this.opt_Devolucion.Click += new System.EventHandler(this.opt_Devolucion_Click);
            // 
            // opt_Cotizacion
            // 
            this.opt_Cotizacion.Name = "opt_Cotizacion";
            this.opt_Cotizacion.Size = new System.Drawing.Size(176, 22);
            this.opt_Cotizacion.Text = "&Cotizacion";
            this.opt_Cotizacion.Click += new System.EventHandler(this.opt_Cotizacion_Click);
            // 
            // menu_mantenimiento
            // 
            this.menu_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_Proveedor});
            this.menu_mantenimiento.Name = "menu_mantenimiento";
            this.menu_mantenimiento.Size = new System.Drawing.Size(101, 20);
            this.menu_mantenimiento.Text = "&Mantenimiento";
            // 
            // opt_Proveedor
            // 
            this.opt_Proveedor.Name = "opt_Proveedor";
            this.opt_Proveedor.Size = new System.Drawing.Size(128, 22);
            this.opt_Proveedor.Text = "&Proveedor";
            this.opt_Proveedor.Click += new System.EventHandler(this.opt_Proveedor_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasGeneralesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // consultasGeneralesToolStripMenuItem
            // 
            this.consultasGeneralesToolStripMenuItem.Name = "consultasGeneralesToolStripMenuItem";
            this.consultasGeneralesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultasGeneralesToolStripMenuItem.Text = "&Consultas Generales";
            this.consultasGeneralesToolStripMenuItem.Click += new System.EventHandler(this.consultasGeneralesToolStripMenuItem_Click);
            // 
            // frmMDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ModuloFacturacion.Properties.Resources.FondoCompras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 364);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMDI_Principal";
            this.Text = "Sistema de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Principal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tss_user;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_Fecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Usuario;
        private System.Windows.Forms.ToolStripMenuItem opt_cambiar_User;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opt_Salir;
        private System.Windows.Forms.ToolStripMenuItem menu_Procesos;
        private System.Windows.Forms.ToolStripMenuItem opt_Solicitud_Pedido;
        private System.Windows.Forms.ToolStripMenuItem opt_orden_Compra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opt_EntregaPedido;
        private System.Windows.Forms.ToolStripMenuItem opt_Devolucion;
        private System.Windows.Forms.ToolStripMenuItem opt_Cotizacion;
        private System.Windows.Forms.ToolStripMenuItem menu_mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem opt_Proveedor;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasGeneralesToolStripMenuItem;
    }
}



