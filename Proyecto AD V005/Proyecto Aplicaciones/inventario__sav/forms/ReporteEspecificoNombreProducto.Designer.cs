namespace Forms
{
    partial class ReporteEspecificoNombreProducto
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
            this.savDataSetInventario1 = new Forms.SAVDataSetInventario();
            this.iNMPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAVDataSetInventario = new Forms.SAVDataSetInventario();
            this.iN_M_PRODUCTOTableAdapter = new Forms.SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter();
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
            this.fillByNomProductoToolStrip = new System.Windows.Forms.ToolStrip();
            this.descripcionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.descripcionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNomProductoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSetInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAVDataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByNomProductoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // savDataSetInventario1
            // 
            this.savDataSetInventario1.DataSetName = "SAVDataSetInventario";
            this.savDataSetInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNMPRODUCTOBindingSource
            // 
            this.iNMPRODUCTOBindingSource.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource.DataSource = this.sAVDataSetInventario;
            // 
            // sAVDataSetInventario
            // 
            this.sAVDataSetInventario.DataSetName = "SAVDataSetInventario";
            this.sAVDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iN_M_PRODUCTOTableAdapter
            // 
            this.iN_M_PRODUCTOTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.iNMPRODUCTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
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
            // fillByNomProductoToolStrip
            // 
            this.fillByNomProductoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descripcionToolStripLabel,
            this.descripcionToolStripTextBox,
            this.fillByNomProductoToolStripButton});
            this.fillByNomProductoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNomProductoToolStrip.Name = "fillByNomProductoToolStrip";
            this.fillByNomProductoToolStrip.Size = new System.Drawing.Size(559, 25);
            this.fillByNomProductoToolStrip.TabIndex = 1;
            this.fillByNomProductoToolStrip.Text = "fillByNomProductoToolStrip";
            this.fillByNomProductoToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByNomProductoToolStrip_ItemClicked);
            // 
            // descripcionToolStripLabel
            // 
            this.descripcionToolStripLabel.Name = "descripcionToolStripLabel";
            this.descripcionToolStripLabel.Size = new System.Drawing.Size(181, 22);
            this.descripcionToolStripLabel.Text = "Ingrese Descripcion de Producto:";
            this.descripcionToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descripcionToolStripTextBox
            // 
            this.descripcionToolStripTextBox.Name = "descripcionToolStripTextBox";
            this.descripcionToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNomProductoToolStripButton
            // 
            this.fillByNomProductoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNomProductoToolStripButton.Name = "fillByNomProductoToolStripButton";
            this.fillByNomProductoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByNomProductoToolStripButton.Text = "Buscar";
            this.fillByNomProductoToolStripButton.Click += new System.EventHandler(this.fillByNomProductoToolStripButton_Click_1);
            // 
            // ReporteEspecificoNombreProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 193);
            this.Controls.Add(this.fillByNomProductoToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReporteEspecificoNombreProducto";
            this.Text = "Consulta Especifica Nombre de Producto";
            this.Load += new System.EventHandler(this.ReporteEspecificoNombreProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savDataSetInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAVDataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByNomProductoToolStrip.ResumeLayout(false);
            this.fillByNomProductoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAVDataSetInventario savDataSetInventario1;
        private SAVDataSetInventario sAVDataSetInventario;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource;
        private SAVDataSetInventarioTableAdapters.IN_M_PRODUCTOTableAdapter iN_M_PRODUCTOTableAdapter;
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
        private System.Windows.Forms.ToolStrip fillByNomProductoToolStrip;
        private System.Windows.Forms.ToolStripLabel descripcionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox descripcionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNomProductoToolStripButton;
    }
}