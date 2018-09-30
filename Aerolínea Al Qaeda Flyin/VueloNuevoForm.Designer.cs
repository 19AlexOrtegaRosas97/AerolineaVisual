namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class VueloNuevoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueloNuevoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAGREGARV = new System.Windows.Forms.Button();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo $ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo (Min):";
            // 
            // buttonAGREGARV
            // 
            this.buttonAGREGARV.Location = new System.Drawing.Point(169, 168);
            this.buttonAGREGARV.Name = "buttonAGREGARV";
            this.buttonAGREGARV.Size = new System.Drawing.Size(119, 31);
            this.buttonAGREGARV.TabIndex = 4;
            this.buttonAGREGARV.Text = "AGREGAR";
            this.buttonAGREGARV.UseVisualStyleBackColor = true;
            this.buttonAGREGARV.Click += new System.EventHandler(this.buttonAGREGARV_Click);
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(107, 30);
            this.textBoxOrigen.MaxLength = 1;
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(58, 20);
            this.textBoxOrigen.TabIndex = 5;
            this.textBoxOrigen.TextChanged += new System.EventHandler(this.textBoxOrigen_TextChanged);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(107, 64);
            this.textBoxDestino.MaxLength = 1;
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(58, 20);
            this.textBoxDestino.TabIndex = 6;
            this.textBoxDestino.TextChanged += new System.EventHandler(this.textBoxDestino_TextChanged);
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(107, 95);
            this.textBoxCosto.MaxLength = 5;
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(58, 20);
            this.textBoxCosto.TabIndex = 7;
            this.textBoxCosto.TextChanged += new System.EventHandler(this.textBoxCosto_TextChanged);
            this.textBoxCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCosto_KeyPress);
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(124, 132);
            this.textBoxTiempo.MaxLength = 5;
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(58, 20);
            this.textBoxTiempo.TabIndex = 8;
            this.textBoxTiempo.TextChanged += new System.EventHandler(this.textBoxTiempo_TextChanged);
            this.textBoxTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempo_KeyPress);
            // 
            // VueloNuevoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 211);
            this.Controls.Add(this.textBoxTiempo);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.buttonAGREGARV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueloNuevoForm";
            this.Text = "Agregar Vuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAGREGARV;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxTiempo;
    }
}