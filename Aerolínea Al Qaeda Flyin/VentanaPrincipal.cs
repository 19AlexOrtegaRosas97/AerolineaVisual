using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolínea_Al_Qaeda_Flyin
{
    
    public partial class VentanaInicio : Form
    {
       

        List<Vuelo> listaVuelos = new List<Vuelo>();
        Grafo G;

        public VentanaInicio(ref List<Vuelo> listaVuelos,ref Grafo g)
        {
            this.G = g;
            InitializeComponent();
            this.listaVuelos = listaVuelos;        
        }
        public Grafo dameGrafo()
        {
            return G;
        }

        private void buttonVUELOS_Click(object sender, EventArgs e)
        {
            VentanaVuelos Vvuelos = new VentanaVuelos(ref listaVuelos,ref G);
            Vvuelos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            PasajerosForm VentanaPasajero = new PasajerosForm(ref listaVuelos);
            VentanaPasajero.ShowDialog();
        }

        private void buttonGrafo_Click(object sender, EventArgs e)
        {
            Grafo grafin = dameGrafo();
            GrafoForm ventanaGrafo = new GrafoForm(grafin, ref listaVuelos);
            ventanaGrafo.ShowDialog();
        }

        private void buttonVI_Click(object sender, EventArgs e)
        {
            Grafo grafin = dameGrafo();
            VueloInteligenteForm Vuelosinteligentes = new VueloInteligenteForm(ref listaVuelos, ref grafin);
            Vuelosinteligentes.ShowDialog();


        }
    }
}
