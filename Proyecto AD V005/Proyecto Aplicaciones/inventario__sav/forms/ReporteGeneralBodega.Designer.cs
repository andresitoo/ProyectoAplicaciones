﻿namespace Forms
{
    partial class ReporteGeneralBodega
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
            this.IN_M_BODEGABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SAVDataSetInventario = new Forms.SAVDataSetInventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IN_M_BODEGATableAdapter = new Forms.SAVDataSetInventarioTableAdapters.IN_M_BODEGATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IN_M_BODEGABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // IN_M_BODEGABindingSource
            // 
            this.IN_M_BODEGABindingSource.DataMember = "IN_M_BODEGA";
            this.IN_M_BODEGABindingSource.DataSource = this.SAVDataSetInventario;
            // 
            // SAVDataSetInventario
            // 
            this.SAVDataSetInventario.DataSetName = "SAVDataSetInventario";
            this.SAVDataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetBodega";
            reportDataSource1.Value = this.IN_M_BODEGABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Forms.ReportGeneralBodega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 332);
            this.reportViewer1.TabIndex = 0;
            // 
            // IN_M_BODEGATableAdapter
            // 
            this.IN_M_BODEGATableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 332);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGeneralBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General Bodega";
            this.Load += new System.EventHandler(this.ReporteGeneralBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IN_M_BODEGABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAVDataSetInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IN_M_BODEGABindingSource;
        private SAVDataSetInventario SAVDataSetInventario;
        private SAVDataSetInventarioTableAdapters.IN_M_BODEGATableAdapter IN_M_BODEGATableAdapter;
    }
}