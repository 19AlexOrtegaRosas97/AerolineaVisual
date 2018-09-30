namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class PasajerosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasajerosForm));
            this.listViewPasajeros = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVuelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAsiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxBuscarPasajero = new System.Windows.Forms.TextBox();
            this.buttonEliminarPasajero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPasajeros
            // 
            this.listViewPasajeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombre,
            this.columnHeaderVuelo,
            this.columnHeaderEdad,
            this.columnHeaderAsiento});
            this.listViewPasajeros.Location = new System.Drawing.Point(12, 12);
            this.listViewPasajeros.Name = "listViewPasajeros";
            this.listViewPasajeros.Size = new System.Drawing.Size(500, 258);
            this.listViewPasajeros.TabIndex = 0;
            this.listViewPasajeros.UseCompatibleStateImageBehavior = false;
            this.listViewPasajeros.View = System.Windows.Forms.View.Details;
            this.listViewPasajeros.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPasajeros_ColumnClick);
            this.listViewPasajeros.SelectedIndexChanged += new System.EventHandler(this.listViewPasajeros_SelectedIndexChanged);
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "NOMBRE";
            this.columnHeaderNombre.Width = 274;
            // 
            // columnHeaderVuelo
            // 
            this.columnHeaderVuelo.Text = "VUELO";
            this.columnHeaderVuelo.Width = 72;
            // 
            // columnHeaderEdad
            // 
            this.columnHeaderEdad.Text = "EDAD";
            this.columnHeaderEdad.Width = 68;
            // 
            // columnHeaderAsiento
            // 
            this.columnHeaderAsiento.Text = "ASIENTO";
            this.columnHeaderAsiento.Width = 82;
            // 
            // textBoxBuscarPasajero
            // 
            this.textBoxBuscarPasajero.Location = new System.Drawing.Point(542, 12);
            this.textBoxBuscarPasajero.Name = "textBoxBuscarPasajero";
            this.textBoxBuscarPasajero.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscarPasajero.TabIndex = 1;
            this.textBoxBuscarPasajero.TextChanged += new System.EventHandler(this.textBoxBuscarPasajero_TextChanged);
            // 
            // buttonEliminarPasajero
            // 
            this.buttonEliminarPasajero.Location = new System.Drawing.Point(542, 38);
            this.buttonEliminarPasajero.Name = "buttonEliminarPasajero";
            this.buttonEliminarPasajero.Size = new System.Drawing.Size(100, 23);
            this.buttonEliminarPasajero.TabIndex = 2;
            this.buttonEliminarPasajero.Text = "ELIMINAR";
            this.buttonEliminarPasajero.UseVisualStyleBackColor = true;
            this.buttonEliminarPasajero.Click += new System.EventHandler(this.buttonEliminarPasajero_Click);
            // 
            // PasajerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 283);
            this.Controls.Add(this.buttonEliminarPasajero);
            this.Controls.Add(this.textBoxBuscarPasajero);
            this.Controls.Add(this.listViewPasajeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasajerosForm";
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.PasajerosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPasajeros;
        private System.Windows.Forms.ColumnHeader columnHeaderVuelo;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderEdad;
        private System.Windows.Forms.ColumnHeader columnHeaderAsiento;
        private System.Windows.Forms.TextBox textBoxBuscarPasajero;
        private System.Windows.Forms.Button buttonEliminarPasajero;
    }
}