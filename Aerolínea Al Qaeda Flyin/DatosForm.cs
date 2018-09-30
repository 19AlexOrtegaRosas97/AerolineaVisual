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
    public partial class FORMULARIO : Form
    {
        bool registro;
        List<Vuelo> listaVuelos;
        List<Vuelo> listaVuelosElegidos;
        string _costo;

        public FORMULARIO(ref List<Vuelo> listaVuelos, ref List<Vuelo> listaVuelosElegidos,string _costo)
        {
            this.listaVuelosElegidos = listaVuelosElegidos;
            this.listaVuelos = listaVuelos;
            this._costo = _costo;
            InitializeComponent();
            buConfirmarCompra.Enabled = false;
            
        }

        private void buConfirmarCompra_Click(object sender, EventArgs e)
        {
           
            string _nombre = textBoxNombre.Text;
            string _apellido = textBoxApellido.Text;
            //string _asiento = textBoxAsiento.Text;
            string _edad = textBoxEdad.Text;
            List<Pasajero> listapasajeroVuelo = new List<Pasajero>();

            for (int x = 0; x < listaVuelosElegidos.Count; x++)
            {
                for (int i = 0; i < listaVuelos.Count; i++)
                {
                    if (listaVuelosElegidos[x].getOrigen() == listaVuelos[i].getOrigen() && listaVuelosElegidos[x].getDestino() == listaVuelos[i].getDestino())
                    {
                        VentanaAsientos VAsientos = new VentanaAsientos(ref listaVuelos, i);
                        VAsientos.ShowDialog();
                        int _asiento = VAsientos.getAsiento();
                        //Console.WriteLine("entro papuuuuu");

                        Pasajero p = new Pasajero(_nombre, _apellido, _edad, _asiento.ToString(), listaVuelos[i].getRuta());
                        registro = true;
                        listaVuelos[i].asientos[_asiento - 1] = false;
                        listaVuelos[i].asientosDisponibles--;
                        listaVuelos[i].setPasajero(p);
                        listapasajeroVuelo.Add(p);
                    }
                }
            }

            this.Close();
            Confirmacion Mconfirmacion = new Confirmacion(ref listapasajeroVuelo,_costo);
            Mconfirmacion.ShowDialog();
        }
        public bool getRegisro()
        {
            return registro;
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            buConfirmarCompra.Enabled = true;
        }
    }
}
