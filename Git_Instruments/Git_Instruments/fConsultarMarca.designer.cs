namespace MenuInstrumento
{
    partial class fConsultarMarca
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.txtListaMarcas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marca:";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(58, 20);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(121, 21);
            this.cmbMarcas.TabIndex = 24;
            this.cmbMarcas.SelectedIndexChanged += new System.EventHandler(this.cmbMarcas_SelectedIndexChanged);
            // 
            // txtListaMarcas
            // 
            this.txtListaMarcas.Location = new System.Drawing.Point(15, 91);
            this.txtListaMarcas.Multiline = true;
            this.txtListaMarcas.Name = "txtListaMarcas";
            this.txtListaMarcas.Size = new System.Drawing.Size(269, 166);
            this.txtListaMarcas.TabIndex = 25;
            // 
            // fConsultarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(296, 269);
            this.Controls.Add(this.txtListaMarcas);
            this.Controls.Add(this.cmbMarcas);
            this.Controls.Add(this.label3);
            this.Name = "fConsultarMarca";
            this.Text = "Consultar por Marca";
            this.Load += new System.EventHandler(this.fConsultarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.TextBox txtListaMarcas;
    }
}