namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class VentanaFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFormulario));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxAsiento = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.buConfirmarCompra = new System.Windows.Forms.Button();
            this.buttonAsiento = new System.Windows.Forms.Button();
            this.labelMuestraVuelo = new System.Windows.Forms.Label();
            this.labelAdisponibles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Location = new System.Drawing.Point(79, 56);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(154, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApellido.Location = new System.Drawing.Point(79, 111);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(154, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEdad.Location = new System.Drawing.Point(188, 156);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(45, 20);
            this.textBoxEdad.TabIndex = 2;
            // 
            // textBoxAsiento
            // 
            this.textBoxAsiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAsiento.Location = new System.Drawing.Point(188, 206);
            this.textBoxAsiento.Name = "textBoxAsiento";
            this.textBoxAsiento.Size = new System.Drawing.Size(45, 20);
            this.textBoxAsiento.TabIndex = 3;
            this.textBoxAsiento.TextChanged += new System.EventHandler(this.textBoxAsiento_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(118, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(81, 19);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(108, 89);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(101, 19);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "APELLIDOS";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(141, 160);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(43, 16);
            this.labelEdad.TabIndex = 6;
            this.labelEdad.Text = "EDAD";
            // 
            // buConfirmarCompra
            // 
            this.buConfirmarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buConfirmarCompra.Location = new System.Drawing.Point(154, 335);
            this.buConfirmarCompra.Name = "buConfirmarCompra";
            this.buConfirmarCompra.Size = new System.Drawing.Size(152, 45);
            this.buConfirmarCompra.TabIndex = 8;
            this.buConfirmarCompra.Text = "CONFIRMAR COMPRA";
            this.buConfirmarCompra.UseVisualStyleBackColor = true;
            this.buConfirmarCompra.Click += new System.EventHandler(this.buConfirmarCompra_Click);
            // 
            // buttonAsiento
            // 
            this.buttonAsiento.Location = new System.Drawing.Point(112, 201);
            this.buttonAsiento.Name = "buttonAsiento";
            this.buttonAsiento.Size = new System.Drawing.Size(75, 25);
            this.buttonAsiento.TabIndex = 9;
            this.buttonAsiento.Text = "ASIENTO";
            this.buttonAsiento.UseVisualStyleBackColor = true;
            this.buttonAsiento.Click += new System.EventHandler(this.buttonAsiento_Click);
            // 
            // labelMuestraVuelo
            // 
            this.labelMuestraVuelo.AutoSize = true;
            this.labelMuestraVuelo.Location = new System.Drawing.Point(22, 13);
            this.labelMuestraVuelo.Name = "labelMuestraVuelo";
            this.labelMuestraVuelo.Size = new System.Drawing.Size(46, 13);
            this.labelMuestraVuelo.TabIndex = 10;
            this.labelMuestraVuelo.Text = "VUELO:";
            this.labelMuestraVuelo.Click += new System.EventHandler(this.labelMuestraVuelo_Click);
            // 
            // labelAdisponibles
            // 
            this.labelAdisponibles.AutoSize = true;
            this.labelAdisponibles.Location = new System.Drawing.Point(112, 243);
            this.labelAdisponibles.Name = "labelAdisponibles";
            this.labelAdisponibles.Size = new System.Drawing.Size(35, 13);
            this.labelAdisponibles.TabIndex = 11;
            this.labelAdisponibles.Text = "label1";
            // 
            // VentanaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 392);
            this.Controls.Add(this.labelAdisponibles);
            this.Controls.Add(this.labelMuestraVuelo);
            this.Controls.Add(this.buttonAsiento);
            this.Controls.Add(this.buConfirmarCompra);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxAsiento);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaFormulario";
            this.Text = "FORMULARIO";
            this.Load += new System.EventHandler(this.VentanaFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxAsiento;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Button buConfirmarCompra;
        private System.Windows.Forms.Button buttonAsiento;
        private System.Windows.Forms.Label labelMuestraVuelo;
        private System.Windows.Forms.Label labelAdisponibles;
    }
}