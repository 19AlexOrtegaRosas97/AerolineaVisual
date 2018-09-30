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
    public partial class PasajerosForm : Form
    {
        List<Vuelo> listaVuelos= new List<Vuelo>();
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        

        public PasajerosForm(ref List<Vuelo> listaVuelos)
        {
            this.listaVuelos = listaVuelos;
            InitializeComponent();
            buttonEliminarPasajero.Enabled = false;

            foreach (Vuelo v in listaVuelos)
            {
                for (int i = 0; i < v.pasajerosCount(); i++)
                {
                    listaPasajeros.Add(v.getPasajero(i));
                }
            }
            actualizarListView(listaPasajeros);

        }

        private void actualizarListView(List<Pasajero> lp)
        {
            listViewPasajeros.Items.Clear();

            foreach (Pasajero p in lp)
            {
                string[] arregloString = new string[4];
                arregloString[1] = p.getVuelo();
                arregloString[0] = p.getNombre();
                arregloString[2] = p.getEdad();
                arregloString[3] = p.getAsiento();

                ListViewItem item = new ListViewItem(arregloString);
                listViewPasajeros.Items.Add(item);
            }
        }

        private void textBoxBuscarPasajero_TextChanged(object sender, EventArgs e)
        {
            List<Pasajero> ListaPasajeroBuscar = new List<Pasajero>();
            bool bandera;
            string aux;

            foreach (Vuelo v in listaVuelos)
            {
                for (int j = 0; j < v.pasajerosCount(); j++)
                {
                    bandera = true;
                    for (int i = 0; i < textBoxBuscarPasajero.TextLength; i++)
                    {
                        aux = v.getPasajero(j).getNombre();
                        if (aux.Length > i)
                        {
                            if (aux[i] != textBoxBuscarPasajero.Text[i])
                            {
                                bandera = false;
                            }
                        }
                    }

                    if (bandera)
                    {
                        ListaPasajeroBuscar.Add(v.getPasajero(j));
                    }
                }
                
            }
            actualizarListView(ListaPasajeroBuscar);
        }

        private void buttonEliminarPasajero_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(listViewPasajeros.FocusedItem.Text);
           // Console.WriteLine(listViewPasajeros.FocusedItem.SubItems[3].Text);

            string indiceVuelo = listViewPasajeros.FocusedItem.SubItems[1].Text;
            string indiceAsientoPasajero = listViewPasajeros.FocusedItem.SubItems[3].Text;

            for (int i=0 ; i<listaVuelos.Count() ;i++)
            {
                if(listaVuelos[i].getRuta() == indiceVuelo)
                {
                    for(int j=0; j< listaVuelos[i].pasajerosCount();j++)
                    {
                        if (indiceAsientoPasajero == listaVuelos[i].getPasajero(j).getAsiento())
                        {
                            int NA = Int32.Parse(indiceAsientoPasajero);

                            listaVuelos[i].getListaPasajeros().RemoveAt(j);
                            listaVuelos[i].setDisp(NA-1 , true);
                            listaVuelos[i].asientosDisponibles++;
                            listViewPasajeros.SelectedItems[0].Remove();

                        }
                    }
                }
            }
            actualizarListView(listaPasajeros);
            this.Close();
        }

        private void listViewPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminarPasajero.Enabled = true;
        }

        private void PasajerosForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewPasajeros_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listaPasajeros.Count != 0)
            {
                if (e.Column == 0)
                {
                    //MessageBox.Show("nombre");
                    quickSort(0, listaPasajeros.Count - 1, 0);
                }
                if (e.Column == 1)
                {
                    quickSort(0, listaPasajeros.Count - 1, 1);
                }
                if (e.Column == 2)
                {
                    quickSort(0, listaPasajeros.Count - 1, 2);
                }
                if (e.Column == 3)
                {
                    quickSort(0, listaPasajeros.Count - 1, 3);
                }
                actualizarListView(listaPasajeros);
            }
        }

        //ORDENAR
        public int compareTo(Pasajero a, Pasajero b,int opc)
        {
            if (opc == 0)
            {
                if (string.Compare(a.getNombre(), b.getNombre()) == 1)//Mayor a.getNombre() > b.getNombre()       
                    return 1;
                if (string.Compare(b.getNombre(), a.getNombre()) == 1)//MEnor a.getNombre() > b.getNombre()
                    return -1;
            }
            if(opc== 1 )
            {
                if (string.Compare(a.getVuelo(), b.getVuelo()) == 1)       
                    return 1;
                if (string.Compare(b.getVuelo(), a.getVuelo()) == 1)
                    return -1;
            }
            if (opc == 2)
            {
                if (string.Compare(a.getEdad(), b.getEdad()) == 1)
                    return 1;
                if (string.Compare(b.getEdad(), a.getEdad()) == 1)
                    return -1;
            }
            if (opc == 3)
            {
                if (b.getAsientoInt() < a.getAsientoInt())
                    return 1;
                if (b.getAsientoInt() > a.getAsientoInt())
                    return -1;
            }
            return 0;
        }
        private void swapToPasajeros(int i, int j)
        {
            Pasajero aux = new Pasajero();
            aux = this.listaPasajeros[i];
            this.listaPasajeros[i] = this.listaPasajeros[j];
            this.listaPasajeros[j] = aux;
        }
  
        public void quickSort(int inicio, int final,int _opc)
        {
            int i = inicio;
            int j = final;
            int medio = (inicio + final) / 2;
            Pasajero pivote = new Pasajero();
            pivote = listaPasajeros[medio];

            do
            {
                while (compareTo(listaPasajeros[i], pivote,_opc) == -1)
                    i++;
                while (compareTo(listaPasajeros[j], pivote,_opc) == 1)
                    j--;

                if (i <= j)
                {
                    swapToPasajeros(i, j);
                    i++;
                    j--;
                }

            } while (i <= j);

            if (i < final)
                quickSort(i, final,_opc);
            if (j > inicio)
                quickSort(inicio, j,_opc);
        }
    }
}

