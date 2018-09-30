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
    public partial class Confirmacion : Form
    {
        public bool vRegistro;
        Pasajero p;
        string asiento;
        List<Pasajero> listaP;
        string _costo;

        public Confirmacion(Pasajero pa, string asiento)
        {
            this.asiento = asiento;
            this.p = pa;
            InitializeComponent();
            labelasientoConf.Text = "ASIENTO: " + asiento;
            labelEdad.Text = "EDAD: " + pa.getEdad();
            labelVueloVconfirmacion.Text = "VUELO: " + pa.getVuelo();
            labelNombreVconfi.Text = "NOMBRE: " + pa.getNombre();
        }
        public Confirmacion(ref List<Pasajero> listaP,string _costo)
        {
            string Asientos = "";
            string Vuelo = "";

            for (int x=0;x < listaP.Count;x++)
            {
                if(x==listaP.Count-1)
                {
                    Vuelo += listaP[x].vuelo;
                    Asientos += listaP[x].getAsientoInt().ToString();
                }
                else
                {
                    Vuelo += listaP[x].vuelo + " , ";
                    Asientos += listaP[x].getAsientoInt().ToString() + " , ";
                }
                
            }

            this.listaP = listaP;
            this._costo = _costo;
            InitializeComponent();
            labelasientoConf.Text = "ASIENTO: " + Asientos;
            labelEdad.Text = "EDAD: " + listaP[0].getEdad();
            labelVueloVconfirmacion.Text = "VUELO: " + Vuelo;
            labelNombreVconfi.Text = "NOMBRE: " + listaP[0].getNombre();
            labelcosto.Text = "COSTO: " + _costo;
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            vRegistro = true;
            this.Close();
        }
       public bool getRegistro()
        {
            return vRegistro;
        }

    }
}
