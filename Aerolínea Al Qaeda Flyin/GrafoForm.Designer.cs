namespace Aerolínea_Al_Qaeda_Flyin
{
    partial class GrafoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafoForm));
            this.panel = new System.Windows.Forms.Panel();
            this.buttonEliminarCiudad = new System.Windows.Forms.Button();
            this.labelCIUDADES = new System.Windows.Forms.Label();
            this.listViewCiudades = new System.Windows.Forms.ListView();
            this.columnHeaderCiudad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonKRUSKALL = new System.Windows.Forms.Button();
            this.buttonPRIMM = new System.Windows.Forms.Button();
            this.listViewOD = new System.Windows.Forms.ListView();
            this.Origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxKrus = new System.Windows.Forms.TextBox();
            this.textBoxPrim = new System.Windows.Forms.TextBox();
            this.buttonDIKSTRA = new System.Windows.Forms.Button();
            this.listViewDikstra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRutAS = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel.Location = new System.Drawing.Point(31, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 426);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // buttonEliminarCiudad
            // 
            this.buttonEliminarCiudad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarCiudad.Location = new System.Drawing.Point(456, 245);
            this.buttonEliminarCiudad.Name = "buttonEliminarCiudad";
            this.buttonEliminarCiudad.Size = new System.Drawing.Size(79, 23);
            this.buttonEliminarCiudad.TabIndex = 2;
            this.buttonEliminarCiudad.Text = "ELIMINAR";
            this.buttonEliminarCiudad.UseVisualStyleBackColor = false;
            this.buttonEliminarCiudad.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCIUDADES
            // 
            this.labelCIUDADES.AutoSize = true;
            this.labelCIUDADES.Location = new System.Drawing.Point(463, 37);
            this.labelCIUDADES.Name = "labelCIUDADES";
            this.labelCIUDADES.Size = new System.Drawing.Size(62, 13);
            this.labelCIUDADES.TabIndex = 3;
            this.labelCIUDADES.Text = "CIUDADES";
            this.labelCIUDADES.Click += new System.EventHandler(this.labelCIUDADES_Click);
            // 
            // listViewCiudades
            // 
            this.listViewCiudades.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewCiudades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCiudad});
            this.listViewCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCiudades.Location = new System.Drawing.Point(478, 53);
            this.listViewCiudades.Name = "listViewCiudades";
            this.listViewCiudades.Size = new System.Drawing.Size(29, 183);
            this.listViewCiudades.TabIndex = 4;
            this.listViewCiudades.UseCompatibleStateImageBehavior = false;
            this.listViewCiudades.View = System.Windows.Forms.View.List;
            this.listViewCiudades.SelectedIndexChanged += new System.EventHandler(this.listViewCiudades_SelectedIndexChanged);
            // 
            // columnHeaderCiudad
            // 
            this.columnHeaderCiudad.Text = "";
            // 
            // buttonKRUSKALL
            // 
            this.buttonKRUSKALL.Location = new System.Drawing.Point(456, 338);
            this.buttonKRUSKALL.Name = "buttonKRUSKALL";
            this.buttonKRUSKALL.Size = new System.Drawing.Size(79, 38);
            this.buttonKRUSKALL.TabIndex = 5;
            this.buttonKRUSKALL.Text = "KRUSKAL";
            this.buttonKRUSKALL.UseVisualStyleBackColor = true;
            this.buttonKRUSKALL.Click += new System.EventHandler(this.buttonKRUSKALL_Click);
            // 
            // buttonPRIMM
            // 
            this.buttonPRIMM.Location = new System.Drawing.Point(456, 391);
            this.buttonPRIMM.Name = "buttonPRIMM";
            this.buttonPRIMM.Size = new System.Drawing.Size(79, 38);
            this.buttonPRIMM.TabIndex = 6;
            this.buttonPRIMM.Text = "PRIM";
            this.buttonPRIMM.UseVisualStyleBackColor = true;
            this.buttonPRIMM.Click += new System.EventHandler(this.buttonPRIMM_Click);
            // 
            // listViewOD
            // 
            this.listViewOD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewOD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Origen,
            this.Destino});
            this.listViewOD.Location = new System.Drawing.Point(534, 53);
            this.listViewOD.Name = "listViewOD";
            this.listViewOD.Size = new System.Drawing.Size(125, 183);
            this.listViewOD.TabIndex = 7;
            this.listViewOD.UseCompatibleStateImageBehavior = false;
            this.listViewOD.View = System.Windows.Forms.View.Details;
            // 
            // Origen
            // 
            this.Origen.Text = "ORIGEN";
            // 
            // Destino
            // 
            this.Destino.Text = "DESTINO";
            // 
            // textBoxKrus
            // 
            this.textBoxKrus.Location = new System.Drawing.Point(565, 348);
            this.textBoxKrus.Name = "textBoxKrus";
            this.textBoxKrus.Size = new System.Drawing.Size(57, 20);
            this.textBoxKrus.TabIndex = 8;
            // 
            // textBoxPrim
            // 
            this.textBoxPrim.Location = new System.Drawing.Point(565, 401);
            this.textBoxPrim.Name = "textBoxPrim";
            this.textBoxPrim.Size = new System.Drawing.Size(57, 20);
            this.textBoxPrim.TabIndex = 9;
            // 
            // buttonDIKSTRA
            // 
            this.buttonDIKSTRA.Location = new System.Drawing.Point(780, 53);
            this.buttonDIKSTRA.Name = "buttonDIKSTRA";
            this.buttonDIKSTRA.Size = new System.Drawing.Size(86, 38);
            this.buttonDIKSTRA.TabIndex = 14;
            this.buttonDIKSTRA.Text = "DIJKSTRA";
            this.buttonDIKSTRA.UseVisualStyleBackColor = true;
            this.buttonDIKSTRA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listViewDikstra
            // 
            this.listViewDikstra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewDikstra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDikstra.Location = new System.Drawing.Point(706, 97);
            this.listViewDikstra.Name = "listViewDikstra";
            this.listViewDikstra.Size = new System.Drawing.Size(227, 183);
            this.listViewDikstra.TabIndex = 15;
            this.listViewDikstra.UseCompatibleStateImageBehavior = false;
            this.listViewDikstra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ACTUAL";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PROVENIENTE";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DISTANCIA";
            this.columnHeader3.Width = 72;
            // 
            // listViewRutAS
            // 
            this.listViewRutAS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewRutAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewRutAS.Location = new System.Drawing.Point(706, 295);
            this.listViewRutAS.Name = "listViewRutAS";
            this.listViewRutAS.Size = new System.Drawing.Size(125, 183);
            this.listViewRutAS.TabIndex = 16;
            this.listViewRutAS.UseCompatibleStateImageBehavior = false;
            this.listViewRutAS.View = System.Windows.Forms.View.Details;
            this.listViewRutAS.SelectedIndexChanged += new System.EventHandler(this.listViewRutAS_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "           RUTAS";
            this.columnHeader4.Width = 120;
            // 
            // GrafoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 481);
            this.Controls.Add(this.listViewRutAS);
            this.Controls.Add(this.listViewDikstra);
            this.Controls.Add(this.buttonDIKSTRA);
            this.Controls.Add(this.textBoxPrim);
            this.Controls.Add(this.textBoxKrus);
            this.Controls.Add(this.listViewOD);
            this.Controls.Add(this.buttonPRIMM);
            this.Controls.Add(this.buttonKRUSKALL);
            this.Controls.Add(this.listViewCiudades);
            this.Controls.Add(this.labelCIUDADES);
            this.Controls.Add(this.buttonEliminarCiudad);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafoForm";
            this.Text = "GRAFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonEliminarCiudad;
        private System.Windows.Forms.Label labelCIUDADES;
        private System.Windows.Forms.ListView listViewCiudades;
        private System.Windows.Forms.ColumnHeader columnHeaderCiudad;
        private System.Windows.Forms.Button buttonKRUSKALL;
        private System.Windows.Forms.Button buttonPRIMM;
        private System.Windows.Forms.ListView listViewOD;
        private System.Windows.Forms.ColumnHeader Origen;
        private System.Windows.Forms.ColumnHeader Destino;
        private System.Windows.Forms.TextBox textBoxKrus;
        private System.Windows.Forms.TextBox textBoxPrim;
        private System.Windows.Forms.Button buttonDIKSTRA;
        private System.Windows.Forms.ListView listViewDikstra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewRutAS;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}