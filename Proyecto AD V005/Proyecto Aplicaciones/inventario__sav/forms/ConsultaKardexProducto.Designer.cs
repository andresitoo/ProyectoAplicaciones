namespace Forms
{
    partial class ConsultaKardexProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iNMPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNMPRODUCTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iNMPRODUCTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iNMPRODUCTOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.sAVDataSetInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAVDataSetInventario = new Forms.SAVDataSetInventario();
            this.sAVDataSetInventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iN_M_PRODUCTOTableAdapter = new Forms.SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAVDataSetInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAVDataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAVDataSetInventarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.iNMPRODUCTOBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // iNMPRODUCTOBindingSource
            // 
            this.iNMPRODUCTOBindingSource.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource.DataSource = this.sAVDataSetInventarioBindingSource;
            // 
            // iNMPRODUCTOBindingSource1
            // 
            this.iNMPRODUCTOBindingSource1.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource1.DataSource = this.sAVDataSetInventarioBindingSource1;
            // 
            // iNMPRODUCTOBindingSource2
            // 
            this.iNMPRODUCTOBindingSource2.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource2.DataSource = this.sAVDataSetInventarioBindingSource1;
            // 
            // iNMPRODUCTOBindingSource3
            // 
            this.iNMPRODUCTOBindingSource3.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource3.DataSource = this.sAVDataSetInventarioBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "fillBy1ToolStrip";
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
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            // 
            // bodegaDataGridViewTextBoxColumn
            // 
            this.bodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega";
            this.bodegaDataGridViewTextBoxColumn.HeaderText = "Bodega";
            this.bodegaDataGridViewTextBoxColumn.Name = "bodegaDataGridViewTextBoxColumn";
            // 
            // perchaDataGridViewTextBoxColumn
            // 
            this.perchaDataGridViewTextBoxColumn.DataPropertyName = "Percha";
            this.perchaDataGridViewTextBoxColumn.HeaderText = "Percha";
            this.perchaDataGridViewTextBoxColumn.Name = "perchaDataGridViewTextBoxColumn";
            // 
            // existenciaActualDataGridViewTextBoxColumn
            // 
            this.existenciaActualDataGridViewTextBoxColumn.DataPropertyName = "Existencia_Actual";
            this.existenciaActualDataGridViewTextBoxColumn.HeaderText = "Existencia_Actual";
            this.existenciaActualDataGridViewTextBoxColumn.Name = "existenciaActualDataGridViewTextBoxColumn";
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Minimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "Stock_Minimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            // 
            // stockMaximoDataGridViewTextBoxColumn
            // 
            this.stockMaximoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Maximo";
            this.stockMaximoDataGridViewTextBoxColumn.HeaderText = "Stock_Maximo";
            this.stockMaximoDataGridViewTextBoxColumn.Name = "stockMaximoDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // sAVDataSetInventarioBindingSource
            // 
            this.sAVDataSetInventarioBindingSource.DataSource = this.sAVDataSetInventario;
            this.sAVDataSetInventarioBindingSource.Position = 0;
            // 
            // sAVDataSetInventario
            // 
            this.sAVDataSetInventario.DataSetName = "SAVDataSetInventario";
            this.sAVDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAVDataSetInventarioBindingSource1
            // 
            this.sAVDataSetInventarioBindingSource1.DataSource = this.sAVDataSetInventario;
            this.sAVDataSetInventarioBindingSource1.Position = 0;
            // 
            // iN_M_PRODUCTOTableAdapter
            // 
            this.iN_M_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaKardexProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaKardexProducto";
            this.Text = "ConsultaKardexProducto";
           
          
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sAVDataSetInventarioBindingSource;
        private SAVDataSetInventario sAVDataSetInventario;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource;
        private SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter iN_M_PRODUCTOTableAdapter;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource1;
        private System.Windows.Forms.BindingSource sAVDataSetInventarioBindingSource1;
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
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource3;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}