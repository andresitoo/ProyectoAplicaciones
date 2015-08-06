namespace Forms
{
    partial class FrmConsultaGeneral_Producto
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
            this.dgbProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbProducto
            // 
            this.dgbProducto.AllowUserToAddRows = false;
            this.dgbProducto.AllowUserToDeleteRows = false;
            this.dgbProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbProducto.Location = new System.Drawing.Point(0, 0);
            this.dgbProducto.Name = "dgbProducto";
            this.dgbProducto.ReadOnly = true;
            this.dgbProducto.Size = new System.Drawing.Size(616, 262);
            this.dgbProducto.TabIndex = 0;
            this.dgbProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbProducto_CellContentClick);
            // 
            // FrmConsultaGeneral_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.dgbProducto);
            this.Name = "FrmConsultaGeneral_Producto";
            this.Text = "FrmConsultaGeneral_Producto";
            this.Load += new System.EventHandler(this.FrmConsultaGeneral_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
    }
}