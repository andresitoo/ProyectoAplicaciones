namespace Forms
{
    partial class ReporteEspecificoCodigoProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEspecificoCodigoProducto));
            this.SAVDataSetInventario = new Forms.SAVDataSetInventario();
            this.IN_M_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IN_M_PRODUCTOTableAdapter = new Forms.SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNMPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByProductToolStrip = new System.Windows.Forms.ToolStrip();
            this.codigoProductoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codigoProductoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByProductToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_M_PRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).BeginInit();
            this.fillByProductToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SAVDataSetInventario
            // 
            this.SAVDataSetInventario.DataSetName = "SAVDataSetInventario";
            this.SAVDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IN_M_PRODUCTOBindingSource
            // 
            this.IN_M_PRODUCTOBindingSource.DataMember = "IN_M_PRODUCTO";
            this.IN_M_PRODUCTOBindingSource.DataSource = this.SAVDataSetInventario;
            // 
            // IN_M_PRODUCTOTableAdapter
            // 
            this.IN_M_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoDataGridViewTextBoxColumn,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.bodegaDataGridViewTextBoxColumn,
            this.perchaDataGridViewTextBoxColumn,
            this.existenciaActualDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn,
            this.stockMaximoDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNMPRODUCTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Producto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "Codigo_Producto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            this.descripcionProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodegaDataGridViewTextBoxColumn
            // 
            this.bodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega";
            this.bodegaDataGridViewTextBoxColumn.HeaderText = "Bodega";
            this.bodegaDataGridViewTextBoxColumn.Name = "bodegaDataGridViewTextBoxColumn";
            this.bodegaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perchaDataGridViewTextBoxColumn
            // 
            this.perchaDataGridViewTextBoxColumn.DataPropertyName = "Percha";
            this.perchaDataGridViewTextBoxColumn.HeaderText = "Percha";
            this.perchaDataGridViewTextBoxColumn.Name = "perchaDataGridViewTextBoxColumn";
            this.perchaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciaActualDataGridViewTextBoxColumn
            // 
            this.existenciaActualDataGridViewTextBoxColumn.DataPropertyName = "Existencia_Actual";
            this.existenciaActualDataGridViewTextBoxColumn.HeaderText = "Existencia_Actual";
            this.existenciaActualDataGridViewTextBoxColumn.Name = "existenciaActualDataGridViewTextBoxColumn";
            this.existenciaActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Minimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "Stock_Minimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            this.stockMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockMaximoDataGridViewTextBoxColumn
            // 
            this.stockMaximoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Maximo";
            this.stockMaximoDataGridViewTextBoxColumn.HeaderText = "Stock_Maximo";
            this.stockMaximoDataGridViewTextBoxColumn.Name = "stockMaximoDataGridViewTextBoxColumn";
            this.stockMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNMPRODUCTOBindingSource
            // 
            this.iNMPRODUCTOBindingSource.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource.DataSource = this.SAVDataSetInventario;
            // 
            // fillByProductToolStrip
            // 
            this.fillByProductToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoProductoToolStripLabel,
            this.codigoProductoToolStripTextBox,
            this.fillByProductToolStripButton});
            this.fillByProductToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByProductToolStrip.Name = "fillByProductToolStrip";
            this.fillByProductToolStrip.Size = new System.Drawing.Size(512, 25);
            this.fillByProductToolStrip.TabIndex = 1;
            this.fillByProductToolStrip.Text = "fillByProductToolStrip";
            this.fillByProductToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByProductToolStrip_ItemClicked);
            // 
            // codigoProductoToolStripLabel
            // 
            this.codigoProductoToolStripLabel.Name = "codigoProductoToolStripLabel";
            this.codigoProductoToolStripLabel.Size = new System.Drawing.Size(142, 22);
            this.codigoProductoToolStripLabel.Text = "Ingrese Codigo Producto:";
            // 
            // codigoProductoToolStripTextBox
            // 
            this.codigoProductoToolStripTextBox.Name = "codigoProductoToolStripTextBox";
            this.codigoProductoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByProductToolStripButton
            // 
            this.fillByProductToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillByProductToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByProductToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByProductToolStripButton.Image")));
            this.fillByProductToolStripButton.Name = "fillByProductToolStripButton";
            this.fillByProductToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByProductToolStripButton.Text = "Buscar";
            this.fillByProductToolStripButton.Click += new System.EventHandler(this.fillByProductToolStripButton_Click);
            // 
            // ReporteEspecificoCodigoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 235);
            this.Controls.Add(this.fillByProductToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReporteEspecificoCodigoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Especifica por Codigo de Producto";
            this.Load += new System.EventHandler(this.Pueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_M_PRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).EndInit();
            this.fillByProductToolStrip.ResumeLayout(false);
            this.fillByProductToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource IN_M_PRODUCTOBindingSource;
        private SAVDataSetInventario SAVDataSetInventario;
        private SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter IN_M_PRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perchaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource;
        private System.Windows.Forms.ToolStrip fillByProductToolStrip;
        private System.Windows.Forms.ToolStripLabel codigoProductoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codigoProductoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByProductToolStripButton;
    }
}