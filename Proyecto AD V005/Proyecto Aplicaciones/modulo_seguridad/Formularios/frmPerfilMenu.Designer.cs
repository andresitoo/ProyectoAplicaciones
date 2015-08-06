namespace Modulo_Seguridad.Formularios
{
    partial class frmPerfilMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.CmbModulo = new System.Windows.Forms.ComboBox();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lstPerfilMenu = new System.Windows.Forms.ListBox();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.btnIngr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modulo";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(12, 34);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfil.TabIndex = 2;
            // 
            // CmbModulo
            // 
            this.CmbModulo.FormattingEnabled = true;
            this.CmbModulo.Location = new System.Drawing.Point(244, 34);
            this.CmbModulo.Name = "CmbModulo";
            this.CmbModulo.Size = new System.Drawing.Size(121, 21);
            this.CmbModulo.TabIndex = 3;
            this.CmbModulo.SelectedIndexChanged += new System.EventHandler(this.CmbModulo_SelectedIndexChanged);
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.Location = new System.Drawing.Point(12, 73);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(160, 160);
            this.lstMenu.TabIndex = 4;
            // 
            // lstPerfilMenu
            // 
            this.lstPerfilMenu.FormattingEnabled = true;
            this.lstPerfilMenu.Location = new System.Drawing.Point(244, 73);
            this.lstPerfilMenu.Name = "lstPerfilMenu";
            this.lstPerfilMenu.Size = new System.Drawing.Size(163, 160);
            this.lstPerfilMenu.TabIndex = 5;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAñadir.Location = new System.Drawing.Point(191, 115);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(30, 23);
            this.BtnAñadir.TabIndex = 6;
            this.BtnAñadir.Text = "+";
            this.BtnAñadir.UseVisualStyleBackColor = false;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuitar.Location = new System.Drawing.Point(191, 161);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(30, 23);
            this.BtnQuitar.TabIndex = 7;
            this.BtnQuitar.Text = "-";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnIngr
            // 
            this.btnIngr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngr.Location = new System.Drawing.Point(332, 243);
            this.btnIngr.Name = "btnIngr";
            this.btnIngr.Size = new System.Drawing.Size(75, 23);
            this.btnIngr.TabIndex = 8;
            this.btnIngr.Text = "Guardar";
            this.btnIngr.UseVisualStyleBackColor = false;
            this.btnIngr.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPerfilMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(412, 278);
            this.Controls.Add(this.btnIngr);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAñadir);
            this.Controls.Add(this.lstPerfilMenu);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.CmbModulo);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPerfilMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfil Menu";
            this.Load += new System.EventHandler(this.frmPerfilMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ComboBox CmbModulo;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstPerfilMenu;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button btnIngr;
    }
}