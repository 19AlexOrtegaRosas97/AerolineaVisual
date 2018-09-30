namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
            this.buttonVUELOS = new System.Windows.Forms.Button();
            this.buttonPasajeros = new System.Windows.Forms.Button();
            this.buttonGrafo = new System.Windows.Forms.Button();
            this.buttonVI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVUELOS
            // 
            this.buttonVUELOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVUELOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonVUELOS.Location = new System.Drawing.Point(27, 210);
            this.buttonVUELOS.Name = "buttonVUELOS";
            this.buttonVUELOS.Size = new System.Drawing.Size(137, 48);
            this.buttonVUELOS.TabIndex = 0;
            this.buttonVUELOS.Text = "VUELOS";
            this.buttonVUELOS.UseVisualStyleBackColor = true;
            this.buttonVUELOS.Click += new System.EventHandler(this.buttonVUELOS_Click);
            // 
            // buttonPasajeros
            // 
            this.buttonPasajeros.Location = new System.Drawing.Point(374, 210);
            this.buttonPasajeros.Name = "buttonPasajeros";
            this.buttonPasajeros.Size = new System.Drawing.Size(137, 48);
            this.buttonPasajeros.TabIndex = 1;
            this.buttonPasajeros.Text = "PASAJEROS";
            this.buttonPasajeros.UseVisualStyleBackColor = true;
            this.buttonPasajeros.Click += new System.EventHandler(this.buttonPasajeros_Click);
            // 
            // buttonGrafo
            // 
            this.buttonGrafo.Location = new System.Drawing.Point(175, 263);
            this.buttonGrafo.Name = "buttonGrafo";
            this.buttonGrafo.Size = new System.Drawing.Size(172, 48);
            this.buttonGrafo.TabIndex = 2;
            this.buttonGrafo.Text = "GRAFO";
            this.buttonGrafo.UseVisualStyleBackColor = true;
            this.buttonGrafo.Click += new System.EventHandler(this.buttonGrafo_Click);
            // 
            // buttonVI
            // 
            this.buttonVI.Location = new System.Drawing.Point(175, 209);
            this.buttonVI.Name = "buttonVI";
            this.buttonVI.Size = new System.Drawing.Size(172, 48);
            this.buttonVI.TabIndex = 3;
            this.buttonVI.Text = "VUELO INTELIGENTE";
            this.buttonVI.UseVisualStyleBackColor = true;
            this.buttonVI.Click += new System.EventHandler(this.buttonVI_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.buttonVI);
            this.Controls.Add(this.buttonGrafo);
            this.Controls.Add(this.buttonPasajeros);
            this.Controls.Add(this.buttonVUELOS);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaInicio";
            this.Text = "Ventana Principal : Al Qaeda Flying ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVUELOS;
        private System.Windows.Forms.Button buttonPasajeros;
        private System.Windows.Forms.Button buttonGrafo;
        private System.Windows.Forms.Button buttonVI;
    }
}

