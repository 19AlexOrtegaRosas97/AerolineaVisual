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
    public partial class VentanaVuelos : Form
    {
        List<Vuelo> listaVuelos;
        int PosVuElegido;
        Grafo g;

        public VentanaVuelos(ref List<Vuelo> listaVuelos,ref Grafo g)

        {
            this.listaVuelos = listaVuelos;
            this.g = g;
            InitializeComponent();
            buttonAceptar.Enabled = false;
            buttonEliminarVuelo.Enabled = false;
            actualizarListBox(listaVuelos);
            labelAsientosD.Text = "ASIENTOS DISPONBLES: ";
            this.PosVuElegido = -1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ListaBoxVuelos.SelectedIndex;
            buttonAceptar.Enabled = true;
            buttonEliminarVuelo.Enabled = true;
            labelAsientosD.Text = "ASIENTOS DISPONBLES: " + listaVuelos[ind].getADint();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            int ind = ListaBoxVuelos.SelectedIndex;
            string NumeroVuelo = ListaBoxVuelos.SelectedItem.ToString();
            VentanaFormulario VFormulario = new VentanaFormulario(ref listaVuelos, ind,1);
            VFormulario.ShowDialog();

            if (VFormulario.getRegisro())
            {
                this.Close();
            }

        }

        public void actualizarListBox(List<Vuelo> lista)
        {
            ListaBoxVuelos.Items.Clear();

            foreach (Vuelo v in lista)
            {
                ListaBoxVuelos.Items.Add(v +  "      $" + v.costo+ "     " + v.tiempo+" Min");

            }
        }

        private void buttonAddVuelo_Click(object sender, EventArgs e)
        {
            VueloNuevoForm Nvuelo = new VueloNuevoForm(ref listaVuelos,ref g);
            Nvuelo.ShowDialog();
            this.Close();
        }

        public int getposVueloElegido()
        {
           // Vuelo vueloelegido;
            //vueloelegido = ListaBoxVuelos.SelectedItem;
            for (int i = 0; i < listaVuelos.Count(); i++)
            {
                if (listaVuelos[i] == (Vuelo)ListaBoxVuelos.SelectedItem)
                {
                    PosVuElegido = i;
                    return PosVuElegido;
                }
            }
            return -1;
        }

        private void buttonEliminarVuelo_Click(object sender, EventArgs e)
        {
            //PosVuElegido = getposVueloElegido();
            PosVuElegido = ListaBoxVuelos.SelectedIndex;
            char origen;
            char destino;
            origen = listaVuelos[PosVuElegido].getOrigen();
            destino = listaVuelos[PosVuElegido].getDestino();

            if (PosVuElegido != -1)
            {
                listaVuelos.RemoveAt(PosVuElegido);
                actualizarListBox(listaVuelos);
                
            }


            Nodo N = g.getNodoAdy(origen);

            for (int a = 0; a < N.La.Count; a++)
            {
                if (N.La[a].getNodoAd().getCiudad().GetnombreCiudad() == destino)
                {
                    N.La.RemoveAt(a);

                    break;
                }
            }

            bool band1, band2 = true;

            band1 = (N.La.Count == 0);

            foreach (Nodo n in g.listaNodo)
            {
                foreach (Adyacencia a in n.La)
                {
                    if (a.getNodoAd().getCiudad().GetnombreCiudad() == N.getCiudad().GetnombreCiudad())
                    {
                        band2 = false;
                    }
                }

            }

            if (band1 && band2)
            {
                for (int m = 0; m < g.listaNodo.Count; m++)
                {
                    if (g.listaNodo[m].getCiudad().GetnombreCiudad() == N.getCiudad().GetnombreCiudad())
                    {
                        g.listaNodo.RemoveAt(m);
                    }
                }

            }
            N = g.getNodoAdy(destino);

            band2 = true;
            band1 = (N.La.Count == 0);
            foreach (Nodo n in g.listaNodo)
            {
                foreach (Adyacencia a in n.La)
                {
                    if (a.getNodoAd().getCiudad().GetnombreCiudad() == N.getCiudad().GetnombreCiudad())
                    {
                        band2 = false;
                    }
                }

            }
            if (band1 && band2)
            {
                for (int m = 0; m < g.listaNodo.Count; m++)
                {
                    if (g.listaNodo[m].getCiudad().GetnombreCiudad() == N.getCiudad().GetnombreCiudad())
                    {
                        g.listaNodo.RemoveAt(m);
                    }
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Vuelo> listav = new List<Vuelo>();
            bool bandera;
            string aux;

            foreach (Vuelo v in listaVuelos)
            {
                bandera = true;

                for (int i = 0; i < textBoxVuelo.TextLength; i++)
                {
                    aux = v.ToString();
                    if (aux.Length > i)
                    {
                        if (aux[i] != textBoxVuelo.Text[i])
                        {
                            bandera = false;
                        }
                    }
                }

                if (bandera)
                {
                    listav.Add(v);
                }
            }
            actualizarListBox(listav);
        }

        private void buttonGrafo_Click(object sender, EventArgs e)
        {
            
        }

        //ORDENAR
         //public int a;
        
        public int compareTo(Vuelo a,Vuelo b,int opc)
        {
            if (opc == 1)
            {
                if (a.getOrigen() > b.getOrigen())
                    return 1;
                if (a.getOrigen() < b.getOrigen())
                    return -1;
            }
            if (opc == 2)
            {
                if (a.costo > b.costo)
                    return 1;
                if (a.costo < b.costo)
                    return -1;
            }
            if (opc == 3)
            {
                if (a.tiempo > b.tiempo)
                    return 1;
                if (a.tiempo < b.tiempo)
                    return -1;
            }
            return 0;
        }

        private void swap(int i, int j)
        {
            Vuelo aux = new Vuelo();
            aux = this.listaVuelos[i];
            this.listaVuelos[i] = this.listaVuelos[j];
            this.listaVuelos[j] = aux;
        }

        public void quickSort(int inicio, int final,int opc)
        {
            int i = inicio;
            int j = final;
            int medio = (inicio + final) / 2;
            Vuelo pivote = new Vuelo();
            pivote = this.listaVuelos[medio];

            do
            {
                while (compareTo(this.listaVuelos[i],pivote,opc) == -1)
                    i++;
                while (compareTo(this.listaVuelos[j],pivote,opc) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }

            } while (i <= j);

            if (i < final)
                quickSort(i, final,opc);
            if (j > inicio)
                quickSort(inicio, j,opc);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            quickSort(0, listaVuelos.Count-1,1);
            actualizarListBox(listaVuelos);
        }

        private void buttonOcosto_Click(object sender, EventArgs e)
        {
            quickSort(0, listaVuelos.Count - 1, 2);
            actualizarListBox(listaVuelos);
        }

        private void buttonOtiempo_Click(object sender, EventArgs e)
        {
            quickSort(0, listaVuelos.Count - 1, 3);
            actualizarListBox(listaVuelos);
        }
    }
};
