namespace Forms
{
    partial class frmTransferenciaBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferenciaBodega));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultaPorCriterio = new System.Windows.Forms.Button();
            this.txtCodigoMovimientoInventario = new System.Windows.Forms.TextBox();
            this.ccbCodigo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBodegaOrigen = new System.Windows.Forms.ComboBox();
            this.cbxResponsable = new System.Windows.Forms.ComboBox();
            this.cbxBodegaDestino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstadoProducto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMovimientoInventario = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoInventario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultaPorCriterio);
            this.groupBox1.Controls.Add(this.txtCodigoMovimientoInventario);
            this.groupBox1.Controls.Add(this.ccbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 59);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo a Consultar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConsultaPorCriterio
            // 
            this.btnConsultaPorCriterio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaPorCriterio.BackgroundImage")));
            this.btnConsultaPorCriterio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultaPorCriterio.Location = new System.Drawing.Point(249, 26);
            this.btnConsultaPorCriterio.Name = "btnConsultaPorCriterio";
            this.btnConsultaPorCriterio.Size = new System.Drawing.Size(26, 22);
            this.btnConsultaPorCriterio.TabIndex = 22;
            this.btnConsultaPorCriterio.Text = "...";
            this.btnConsultaPorCriterio.UseVisualStyleBackColor = true;
            this.btnConsultaPorCriterio.Click += new System.EventHandler(this.btnConsultaPorCriterio_Click);
            // 
            // txtCodigoMovimientoInventario
            // 
            this.txtCodigoMovimientoInventario.Enabled = false;
            this.txtCodigoMovimientoInventario.Location = new System.Drawing.Point(91, 28);
            this.txtCodigoMovimientoInventario.Name = "txtCodigoMovimientoInventario";
            this.txtCodigoMovimientoInventario.Size = new System.Drawing.Size(152, 20);
            this.txtCodigoMovimientoInventario.TabIndex = 1;
            // 
            // ccbCodigo
            // 
            this.ccbCodigo.AutoSize = true;
            this.ccbCodigo.Location = new System.Drawing.Point(15, 30);
            this.ccbCodigo.Name = "ccbCodigo";
            this.ccbCodigo.Size = new System.Drawing.Size(59, 17);
            this.ccbCodigo.TabIndex = 0;
            this.ccbCodigo.Text = "Codigo";
            this.ccbCodigo.UseVisualStyleBackColor = true;
            this.ccbCodigo.CheckedChanged += new System.EventHandler(this.ccbCodigo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Responsable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Bodega Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Bodega Origen";
            // 
            // cbxBodegaOrigen
            // 
            this.cbxBodegaOrigen.FormattingEnabled = true;
            this.cbxBodegaOrigen.Location = new System.Drawing.Point(102, 13);
            this.cbxBodegaOrigen.Name = "cbxBodegaOrigen";
            this.cbxBodegaOrigen.Size = new System.Drawing.Size(135, 21);
            this.cbxBodegaOrigen.TabIndex = 106;
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.FormattingEnabled = true;
            this.cbxResponsable.Location = new System.Drawing.Point(102, 67);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Size = new System.Drawing.Size(135, 21);
            this.cbxResponsable.TabIndex = 107;
            // 
            // cbxBodegaDestino
            // 
            this.cbxBodegaDestino.FormattingEnabled = true;
            this.cbxBodegaDestino.Location = new System.Drawing.Point(102, 40);
            this.cbxBodegaDestino.Name = "cbxBodegaDestino";
            this.cbxBodegaDestino.Size = new System.Drawing.Size(135, 21);
            this.cbxBodegaDestino.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Motivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Estado";
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.FormattingEnabled = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(323, 67);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(135, 21);
            this.cbxEstadoProducto.TabIndex = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMovimientoInventario);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 159);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            // 
            // dgvMovimientoInventario
            // 
            this.dgvMovimientoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientoInventario.Location = new System.Drawing.Point(3, 16);
            this.dgvMovimientoInventario.Name = "dgvMovimientoInventario";
            this.dgvMovimientoInventario.Size = new System.Drawing.Size(462, 140);
            this.dgvMovimientoInventario.TabIndex = 0;
            this.dgvMovimientoInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientoInventario_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMotivo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbxEstadoProducto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbxBodegaOrigen);
            this.groupBox3.Controls.Add(this.cbxResponsable);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxBodegaDestino);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 100);
            this.groupBox3.TabIndex = 117;
            this.groupBox3.TabStop = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(323, 13);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(135, 43);
            this.txtMotivo.TabIndex = 116;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click_1);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmTransferenciaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(489, 379);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransferenciaBodega";
            this.Text = "Movimiento de Inventario de Bodega a Bodega";
            this.Load += new System.EventHandler(this.frmTransferenciaBodega_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTransferenciaBodega_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoInventario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoMovimientoInventario;
        private System.Windows.Forms.CheckBox ccbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBodegaOrigen;
        private System.Windows.Forms.ComboBox cbxResponsable;
        private System.Windows.Forms.ComboBox cbxBodegaDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEstadoProducto;
        private System.Windows.Forms.Button btnConsultaPorCriterio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMovimientoInventario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}