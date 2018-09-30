namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class VueloInteligenteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueloInteligenteForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.listViewRutAS = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.labeltOTAL = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonSold = new System.Windows.Forms.Button();
            this.radioButtonCOSTO = new System.Windows.Forms.RadioButton();
            this.radioButtonTiempo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 426);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORIGEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESTINO";
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(461, 25);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(52, 20);
            this.textBoxOrigen.TabIndex = 3;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(550, 25);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(52, 20);
            this.textBoxDestino.TabIndex = 4;
            this.textBoxDestino.TextChanged += new System.EventHandler(this.textBoxDestino_TextChanged);
            // 
            // listViewRutAS
            // 
            this.listViewRutAS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewRutAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRutAS.Location = new System.Drawing.Point(442, 51);
            this.listViewRutAS.Name = "listViewRutAS";
            this.listViewRutAS.Size = new System.Drawing.Size(182, 183);
            this.listViewRutAS.TabIndex = 17;
            this.listViewRutAS.UseCompatibleStateImageBehavior = false;
            this.listViewRutAS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "           VUELOS";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "COSTO";
            this.columnHeader5.Width = 67;
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Location = new System.Drawing.Point(442, 311);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(182, 31);
            this.buttonCotizar.TabIndex = 18;
            this.buttonCotizar.Text = "COTIZAR";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // labeltOTAL
            // 
            this.labeltOTAL.AutoSize = true;
            this.labeltOTAL.Location = new System.Drawing.Point(442, 241);
            this.labeltOTAL.Name = "labeltOTAL";
            this.labeltOTAL.Size = new System.Drawing.Size(88, 13);
            this.labeltOTAL.TabIndex = 19;
            this.labeltOTAL.Text = "COSTO TOTAL: ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(526, 238);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(60, 20);
            this.textBoxTotal.TabIndex = 20;
            // 
            // buttonSold
            // 
            this.buttonSold.Location = new System.Drawing.Point(442, 360);
            this.buttonSold.Name = "buttonSold";
            this.buttonSold.Size = new System.Drawing.Size(182, 31);
            this.buttonSold.TabIndex = 21;
            this.buttonSold.Text = "COMPRAR";
            this.buttonSold.UseVisualStyleBackColor = true;
            this.buttonSold.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonCOSTO
            // 
            this.radioButtonCOSTO.AutoSize = true;
            this.radioButtonCOSTO.Location = new System.Drawing.Point(461, 269);
            this.radioButtonCOSTO.Name = "radioButtonCOSTO";
            this.radioButtonCOSTO.Size = new System.Drawing.Size(62, 17);
            this.radioButtonCOSTO.TabIndex = 22;
            this.radioButtonCOSTO.TabStop = true;
            this.radioButtonCOSTO.Text = "COSTO";
            this.radioButtonCOSTO.UseVisualStyleBackColor = true;
            // 
            // radioButtonTiempo
            // 
            this.radioButtonTiempo.AutoSize = true;
            this.radioButtonTiempo.Location = new System.Drawing.Point(550, 269);
            this.radioButtonTiempo.Name = "radioButtonTiempo";
            this.radioButtonTiempo.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTiempo.TabIndex = 23;
            this.radioButtonTiempo.TabStop = true;
            this.radioButtonTiempo.Text = "TIEMPO";
            this.radioButtonTiempo.UseVisualStyleBackColor = true;
            // 
            // VueloInteligenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 427);
            this.Controls.Add(this.radioButtonTiempo);
            this.Controls.Add(this.radioButtonCOSTO);
            this.Controls.Add(this.buttonSold);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labeltOTAL);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.listViewRutAS);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueloInteligenteForm";
            this.Text = "Vuelo Inteligente";
            this.Load += new System.EventHandler(this.VueloInteligenteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.ListView listViewRutAS;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.Label labeltOTAL;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonSold;
        private System.Windows.Forms.RadioButton radioButtonCOSTO;
        private System.Windows.Forms.RadioButton radioButtonTiempo;
    }
}