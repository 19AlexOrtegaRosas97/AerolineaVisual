namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class Confirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion));
            this.buttonFin = new System.Windows.Forms.Button();
            this.labelVueloVconfirmacion = new System.Windows.Forms.Label();
            this.labelNombreVconfi = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelasientoConf = new System.Windows.Forms.Label();
            this.labelcosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(191, 181);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(96, 48);
            this.buttonFin.TabIndex = 0;
            this.buttonFin.Text = "FINALIZAR";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // labelVueloVconfirmacion
            // 
            this.labelVueloVconfirmacion.AutoSize = true;
            this.labelVueloVconfirmacion.Location = new System.Drawing.Point(12, 18);
            this.labelVueloVconfirmacion.Name = "labelVueloVconfirmacion";
            this.labelVueloVconfirmacion.Size = new System.Drawing.Size(35, 13);
            this.labelVueloVconfirmacion.TabIndex = 1;
            this.labelVueloVconfirmacion.Text = "label1";
            // 
            // labelNombreVconfi
            // 
            this.labelNombreVconfi.AutoSize = true;
            this.labelNombreVconfi.Location = new System.Drawing.Point(12, 95);
            this.labelNombreVconfi.Name = "labelNombreVconfi";
            this.labelNombreVconfi.Size = new System.Drawing.Size(35, 13);
            this.labelNombreVconfi.TabIndex = 2;
            this.labelNombreVconfi.Text = "label1";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(12, 142);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 3;
            this.labelEdad.Text = "label2";
            // 
            // labelasientoConf
            // 
            this.labelasientoConf.AutoSize = true;
            this.labelasientoConf.Location = new System.Drawing.Point(12, 51);
            this.labelasientoConf.Name = "labelasientoConf";
            this.labelasientoConf.Size = new System.Drawing.Size(35, 13);
            this.labelasientoConf.TabIndex = 4;
            this.labelasientoConf.Text = "label3";
            // 
            // labelcosto
            // 
            this.labelcosto.AutoSize = true;
            this.labelcosto.Location = new System.Drawing.Point(12, 181);
            this.labelcosto.Name = "labelcosto";
            this.labelcosto.Size = new System.Drawing.Size(35, 13);
            this.labelcosto.TabIndex = 5;
            this.labelcosto.Text = "labelc";
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 239);
            this.Controls.Add(this.labelcosto);
            this.Controls.Add(this.labelasientoConf);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombreVconfi);
            this.Controls.Add(this.labelVueloVconfirmacion);
            this.Controls.Add(this.buttonFin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Label labelVueloVconfirmacion;
        private System.Windows.Forms.Label labelNombreVconfi;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelasientoConf;
        private System.Windows.Forms.Label labelcosto;
    }
}