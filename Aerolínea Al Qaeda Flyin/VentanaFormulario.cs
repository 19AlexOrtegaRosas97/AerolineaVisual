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
    

    public partial class VentanaFormulario : Form
    {
        bool registro;
        List<Vuelo> listaVuelos;
        int ind;
        List<Vuelo> listaVuelosElegidos;
        int Tipo;


        public VentanaFormulario(ref List<Vuelo> listaVuelos,int ind,int Tipo)
        {
            this.listaVuelos = listaVuelos;
            this.ind = ind;
            this.Tipo = Tipo;
            InitializeComponent();
            labelMuestraVuelo.Text = listaVuelos[ind].ToString();
            buConfirmarCompra.Enabled = false;
            textBoxAsiento.Enabled = false;
            labelAdisponibles.Text = "ASIENTOS DISPONIBLES: " + listaVuelos[ind].getADint().ToString();
        }
        public VentanaFormulario(ref List<Vuelo> listaVuelosElegidos,int Tipo)
        {
            this.listaVuelosElegidos = listaVuelosElegidos;
            this.Tipo = Tipo;
            InitializeComponent();
            labelMuestraVuelo.Text = " ";
            buConfirmarCompra.Enabled = false;
            textBoxAsiento.Enabled = false;
            labelAdisponibles.Text = " ";
            

        }

        private void VentanaFormulario_Load(object sender, EventArgs e)
        {

        }

        private void buConfirmarCompra_Click(object sender, EventArgs e)
        {
               
                string _nombre = textBoxNombre.Text;
                string _apellido = textBoxApellido.Text;
                string _asiento = textBoxAsiento.Text;
                string _edad = textBoxEdad.Text;
                string _vuelo = labelMuestraVuelo.Text;


                Pasajero p = new Pasajero(_nombre, _apellido, _edad, _asiento, _vuelo);
                registro = true;
                listaVuelos[ind].asientos[Int32.Parse(textBoxAsiento.Text) - 1] = false;
                textBoxAsiento.Enabled = false;
                listaVuelos[ind].asientosDisponibles--;
                listaVuelos[ind].setPasajero(p);

                Confirmacion Mconfirmacion = new Confirmacion(p, _asiento);
                Mconfirmacion.ShowDialog();

                this.Close();         

        }

        private void buttonAsiento_Click(object sender, EventArgs e)
        {
            VentanaAsientos VAsientos = new VentanaAsientos(ref listaVuelos,ind);
            VAsientos.ShowDialog();
            textBoxAsiento.Text = VAsientos.getAsiento().ToString();
            buConfirmarCompra.Enabled = true;
        }


        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMuestraVuelo_Click(object sender, EventArgs e)
        {

        }

        /*private void buttonAtras_Click_1(object sender, EventArgs e)
        {         
            this.Close();      
        }*/

        public bool getRegisro()
        {
            return registro;
        }

        private void textBoxAsiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
