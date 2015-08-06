namespace Forms
{
    partial class ReporteGeneralTipoProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IN_R_TIPO_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SAVDataSetInventario = new Forms.SAVDataSetInventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IN_R_TIPO_PRODUCTOTableAdapter = new Forms.SAVDataSetInventarioTableAdapters.IN_R_TIPO_PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IN_R_TIPO_PRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // IN_R_TIPO_PRODUCTOBindingSource
            // 
            this.IN_R_TIPO_PRODUCTOBindingSource.DataMember = "IN_R_TIPO_PRODUCTO";
            this.IN_R_TIPO_PRODUCTOBindingSource.DataSource = this.SAVDataSetInventario;
            // 
            // SAVDataSetInventario
            // 
            this.SAVDataSetInventario.DataSetName = "SAVDataSetInventario";
            this.SAVDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTipoProducto";
            reportDataSource1.Value = this.IN_R_TIPO_PRODUCTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Forms.ReportGeneralTipoProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(517, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // IN_R_TIPO_PRODUCTOTableAdapter
            // 
            this.IN_R_TIPO_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 353);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGeneralTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General Tipo Producto";
            this.Load += new System.EventHandler(this.ReporteGeneralTipoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IN_R_TIPO_PRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IN_R_TIPO_PRODUCTOBindingSource;
        private SAVDataSetInventario SAVDataSetInventario;
        private SAVDataSetInventarioTableAdapters.IN_R_TIPO_PRODUCTOTableAdapter IN_R_TIPO_PRODUCTOTableAdapter;
    }
}