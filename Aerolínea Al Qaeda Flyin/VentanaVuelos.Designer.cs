namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class VentanaVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaVuelos));
            this.ListaBoxVuelos = new System.Windows.Forms.ListBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelAsientosD = new System.Windows.Forms.Label();
            this.buttonAddVuelo = new System.Windows.Forms.Button();
            this.buttonEliminarVuelo = new System.Windows.Forms.Button();
            this.textBoxVuelo = new System.Windows.Forms.TextBox();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonOcosto = new System.Windows.Forms.Button();
            this.buttonOtiempo = new System.Windows.Forms.Button();
            this.labeloRDENAMIENTO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaBoxVuelos
            // 
            this.ListaBoxVuelos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListaBoxVuelos.FormattingEnabled = true;
            this.ListaBoxVuelos.Location = new System.Drawing.Point(36, 23);
            this.ListaBoxVuelos.Name = "ListaBoxVuelos";
            this.ListaBoxVuelos.Size = new System.Drawing.Size(183, 212);
            this.ListaBoxVuelos.TabIndex = 0;
            this.ListaBoxVuelos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(255, 227);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(139, 28);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "COMPRAR VUELO";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelAsientosD
            // 
            this.labelAsientosD.AutoSize = true;
            this.labelAsientosD.Location = new System.Drawing.Point(273, 9);
            this.labelAsientosD.Name = "labelAsientosD";
            this.labelAsientosD.Size = new System.Drawing.Size(35, 13);
            this.labelAsientosD.TabIndex = 2;
            this.labelAsientosD.Text = "label1";
            // 
            // buttonAddVuelo
            // 
            this.buttonAddVuelo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddVuelo.Location = new System.Drawing.Point(276, 89);
            this.buttonAddVuelo.Name = "buttonAddVuelo";
            this.buttonAddVuelo.Size = new System.Drawing.Size(108, 42);
            this.buttonAddVuelo.TabIndex = 3;
            this.buttonAddVuelo.Text = "NUEVO VUELO";
            this.buttonAddVuelo.UseVisualStyleBackColor = false;
            this.buttonAddVuelo.Click += new System.EventHandler(this.buttonAddVuelo_Click);
            // 
            // buttonEliminarVuelo
            // 
            this.buttonEliminarVuelo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEliminarVuelo.Location = new System.Drawing.Point(276, 156);
            this.buttonEliminarVuelo.Name = "buttonEliminarVuelo";
            this.buttonEliminarVuelo.Size = new System.Drawing.Size(108, 42);
            this.buttonEliminarVuelo.TabIndex = 4;
            this.buttonEliminarVuelo.Text = "ELIMINAR VUELO";
            this.buttonEliminarVuelo.UseVisualStyleBackColor = false;
            this.buttonEliminarVuelo.Click += new System.EventHandler(this.buttonEliminarVuelo_Click);
            // 
            // textBoxVuelo
            // 
            this.textBoxVuelo.Location = new System.Drawing.Point(276, 45);
            this.textBoxVuelo.Name = "textBoxVuelo";
            this.textBoxVuelo.Size = new System.Drawing.Size(108, 20);
            this.textBoxVuelo.TabIndex = 5;
            this.textBoxVuelo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(36, 258);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(70, 23);
            this.buttonOrdenar.TabIndex = 6;
            this.buttonOrdenar.Text = "NOMBRE";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonOcosto
            // 
            this.buttonOcosto.Location = new System.Drawing.Point(144, 258);
            this.buttonOcosto.Name = "buttonOcosto";
            this.buttonOcosto.Size = new System.Drawing.Size(75, 23);
            this.buttonOcosto.TabIndex = 7;
            this.buttonOcosto.Text = "COSTO";
            this.buttonOcosto.UseVisualStyleBackColor = true;
            this.buttonOcosto.Click += new System.EventHandler(this.buttonOcosto_Click);
            // 
            // buttonOtiempo
            // 
            this.buttonOtiempo.Location = new System.Drawing.Point(83, 287);
            this.buttonOtiempo.Name = "buttonOtiempo";
            this.buttonOtiempo.Size = new System.Drawing.Size(75, 23);
            this.buttonOtiempo.TabIndex = 8;
            this.buttonOtiempo.Text = "TIEMPO";
            this.buttonOtiempo.UseVisualStyleBackColor = true;
            this.buttonOtiempo.Click += new System.EventHandler(this.buttonOtiempo_Click);
            // 
            // labeloRDENAMIENTO
            // 
            this.labeloRDENAMIENTO.AutoSize = true;
            this.labeloRDENAMIENTO.Location = new System.Drawing.Point(71, 242);
            this.labeloRDENAMIENTO.Name = "labeloRDENAMIENTO";
            this.labeloRDENAMIENTO.Size = new System.Drawing.Size(102, 13);
            this.labeloRDENAMIENTO.TabIndex = 9;
            this.labeloRDENAMIENTO.Text = "ORDENAMIENTOS";
            // 
            // VentanaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(this.labeloRDENAMIENTO);
            this.Controls.Add(this.buttonOtiempo);
            this.Controls.Add(this.buttonOcosto);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.textBoxVuelo);
            this.Controls.Add(this.buttonEliminarVuelo);
            this.Controls.Add(this.buttonAddVuelo);
            this.Controls.Add(this.labelAsientosD);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.ListaBoxVuelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaVuelos";
            this.Text = "Vuelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaBoxVuelos;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelAsientosD;
        private System.Windows.Forms.Button buttonAddVuelo;
        private System.Windows.Forms.Button buttonEliminarVuelo;
        private System.Windows.Forms.TextBox textBoxVuelo;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonOcosto;
        private System.Windows.Forms.Button buttonOtiempo;
        private System.Windows.Forms.Label labeloRDENAMIENTO;
    }
}