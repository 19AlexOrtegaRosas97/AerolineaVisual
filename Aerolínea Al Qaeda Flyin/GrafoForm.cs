using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Aerolínea_Al_Qaeda_Flyin
{
    public partial class GrafoForm : Form
    {
        Grafo g;
        List<Vuelo> listaVuelos;
        List<Vuelo> ListaVuelosKrus = new List<Vuelo>();
        List<Vuelo> ListaVuelosPrim = new List<Vuelo>();
        List<Vuelo> listaVuelosFinal = new List<Vuelo>();
        //List<Vuelo> listaVuelosDikstra = new List<Vuelo>();
        List<DijkstraElementos> listaDikstra = new List<DijkstraElementos>();
        List<Vuelo> finalVuelos = new List<Vuelo>();
        List<string> listaString = new List<string>();
        string ARM;

        public GrafoForm(Grafo G, ref List<Vuelo> listaVuelos)
        {
            this.g = G;
            InitializeComponent();
            this.listaVuelos = listaVuelos;
            buttonEliminarCiudad.Enabled = false;
            buttonDIKSTRA.Enabled = false;
            this.textBoxKrus.Enabled = false;
            this.textBoxPrim.Enabled = false;
            this.buttonPRIMM.Enabled = false;
            ActualizarListboxVuelos(g);
        }

        public void ActualizarListboxVuelos(Grafo g)
        {
            listViewCiudades.Items.Clear();

            foreach (Nodo no in g.listaNodo)
            {
                string[] arregloString = new string[1];
                arregloString[0] = no.getCiudad().GetNombreCiudadString();

                ListViewItem item = new ListViewItem(arregloString);
                listViewCiudades.Items.Add(item);
                buttonEliminarCiudad.Enabled = false;
            }
        }
        private void MostrarGrafo()
        {
            //panel.Refresh();
            Pen pluma = new Pen(Color.Black, 1);
            //panel.CreateGraphics().DrawEllipse(pluma, 25, 25, panel.Height - 50, panel.Height - 50);
            double a = 2 * Math.PI / g.getNodosCount();
            int r = (panel.Width - 50) / 2;

            for (int i = 0; i < g.getNodosCount(); i++)
            {
                int x = Convert.ToInt32(Math.Cos(i * a) * r + r + 15);
                int y = Convert.ToInt32(Math.Sin(i * a) * r + r + 15);

                panel.CreateGraphics().DrawEllipse(pluma, x, y, 20, 20);

                Font formato = new Font("Arial", 16);
                SolidBrush Dibujarletra = new SolidBrush(Color.Tomato);
                StringFormat letra = new StringFormat();
                panel.CreateGraphics().DrawString(g.getnodo(i).getCiudad().GetNombreCiudadString(), formato, Dibujarletra, x - 1, y - 1, letra);
                g.getnodo(i).getCiudad().setxy(x, y);
            }

            foreach (Nodo n in g.listaNodo)
            {
                foreach (Adyacencia A in n.La)
                {
                    Pen plumaAdy = new Pen(Color.LimeGreen, 2);
                    AdjustableArrowCap flecha = new AdjustableArrowCap(5, 5);
                    plumaAdy.CustomStartCap = flecha;
                    panel.CreateGraphics().DrawLine(plumaAdy, A.getNodoAd().getCiudad().x + 10, A.getNodoAd().getCiudad().y + 10, n.getCiudad().x + 15, n.getCiudad().y + 15);
                    Font letras = new Font("Arial", 10);
                    SolidBrush Brocha = new SolidBrush(Color.Blue);
                    StringFormat diseno = new StringFormat();
                    panel.CreateGraphics().DrawString(Convert.ToString(A.getPesoAdy()), letras, Brocha, (A.getNodoAd().getCiudad().x + n.getCiudad().x) / 2, (A.getNodoAd().getCiudad().y + n.getCiudad().y) / 2, diseno);
                }
            }

        }

        private void buttonMostrarGrafo_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            int i = 1;

            if (i == 1)
            {
                MostrarGrafo();
                i = 0;
            }
            else
            {

            }
        }

        private void labelCIUDADES_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char CiudadSeleccionada = Convert.ToChar(listViewCiudades.FocusedItem.SubItems[0].Text);
            //Console.WriteLine(CiudadSeleccionada);
            foreach (Nodo n in g.listaNodo)//Elimino aristas
            {
                if (n.getCiudad().GetnombreCiudad() == CiudadSeleccionada)
                {
                    //Console.WriteLine(CiudadSeleccionada);
                    //Console.WriteLine(n.getCiudad().GetnombreCiudad()+"xd");
                    for (int i = 0; i < n.La.Count(); i++)
                    {
                        n.La.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    for (int i = 0; i < n.La.Count(); i++)
                    {
                        if (n.La[i].getNodoAd().getCiudad().GetnombreCiudad() == CiudadSeleccionada) //Comparo los nodos que tienen a mi nodo a eliminar
                        {
                            n.La.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            for (int x = 0; x < g.listaNodo.Count; x++)
            {
                if (g.listaNodo[x].La.Count == 0)
                {
                    int bandera;
                    bandera = ExisteApuntante(g.listaNodo[x].getCiudad().GetnombreCiudad());
                    if (bandera == 0)
                    {

                    }
                    else
                    {
                        eliminarvuelos(g.listaNodo[x].getCiudad().GetnombreCiudad());
                        g.listaNodo.RemoveAt(x);

                        x--;
                    }

                }

            }

            /*if(g.listaNodo.Count==1)
            {
                g.listaNodo.RemoveAt(0);
             }*/
            ActualizarListboxVuelos(g);
            panel.Refresh();
        }

        public void eliminarvuelos(char x)
        {
            for (int i = 0; i < g.listavuelo.Count; i++)
            {
                if (g.listavuelo[i].getOrigen() == x || g.listavuelo[i].getDestino() == x)
                {
                    g.listavuelo.RemoveAt(i);
                    i--;
                }
            }
        }
        public int ExisteApuntante(char Ciudad)
        {
            for (int x = 0; x < g.listaNodo.Count; x++)
            {
                for (int i = 0; i < g.listaNodo[x].La.Count; i++)
                {
                    if (g.listaNodo[x].La[i].getNodoAd().getCiudad().GetnombreCiudad() == Ciudad)
                        return 0;
                    //break;

                }
            }
            return 1;
        }

        private void listViewCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminarCiudad.Enabled = true;
            buttonPRIMM.Enabled = true;
            buttonDIKSTRA.Enabled = true;

        }

        private void buttonKRUSKALL_Click(object sender, EventArgs e)
        {
            ReiniciarTodo();
            panel.Refresh();
            listViewOD.Items.Clear();
            textBoxPrim.Clear();
            int i = 0;

            foreach (Vuelo n in listaVuelos)
            {
                ListaVuelosKrus.Add(n);
            }
            QuickSort(0, ListaVuelosKrus.Count - 1, 2);
            i = 0;
            foreach (Vuelo n in ListaVuelosKrus)
            {

                //Console.Write(ListaVuelosKrus[i]+ " ");
                // Console.WriteLine(ListaVuelosKrus[i].costo);
                i++;
            }
            inicializaString();
            int I = 0;

            while (listaVuelosFinal.Count < g.listaNodo.Count - 1 && I < ListaVuelosKrus.Count)
            {
                if (I == ListaVuelosKrus.Count + 1)
                {
                    //Console.WriteLine(" Romper");
                    break;
                }

                //Console.WriteLine(ListaVuelosKrus.Count);
                //Console.WriteLine(" " + I);
                ListaVuelosKrus[I].getOrigen(); //V1
                ListaVuelosKrus[I].getDestino(); //V2
                int cc1, cc2;
                cc1 = Busca(ListaVuelosKrus[I].getOrigen().ToString());
                cc2 = Busca(ListaVuelosKrus[I].getDestino().ToString());

                if (cc1 != cc2)
                {
                    fusiona(cc1, cc2);
                    listaVuelosFinal.Add(ListaVuelosKrus[I]);
                    // Console.WriteLine("entro");
                }
                I++;
                //Console.WriteLine("ciclado");
                // Console.Write(listaVuelosFinal.Count);
                // Console.Write(" ");
                //Console.Write(g.listaNodo.Count);
            }

            /* foreach(Vuelo n in listaVuelosFinal)
             {
                 Console.WriteLine(n.getOrigen() + " " + n.getDestino());
             }*/
            Color chido = Color.FromArgb(128, Color.Blue);
            Pen penKruskal = new Pen(chido, 5);

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (i = 0; i < listaVuelosFinal.Count; i++)
            {
                for (int j = 0; j < g.listaNodo.Count; j++)
                {
                    if (listaVuelosFinal[i].getOrigen() == g.listaNodo[j].getCiudad().GetnombreCiudad())
                    {
                        x1 = g.listaNodo[j].getCiudad().x;
                        y1 = g.listaNodo[j].getCiudad().y;
                    }
                    for (int h = 0; h < g.listaNodo[j].La.Count; h++)
                    {
                        if (listaVuelosFinal[i].getDestino() == g.listaNodo[j].La[h].getNodoAd().getCiudad().GetnombreCiudad())
                        {
                            x2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().x;
                            y2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().y;
                        }
                    }
                }
                panel.CreateGraphics().DrawLine(penKruskal, x1 + 15, y1 + 15, x2 + 5, y2 + 10);
            }
            int ARMPRECIO = 0;

            foreach (Vuelo n in listaVuelosFinal)
            {
                string[] arregloString = new string[2];
                arregloString[0] = n.getOrigen().ToString();
                arregloString[1] = n.getDestino().ToString();

                ListViewItem item = new ListViewItem(arregloString);
                listViewOD.Items.Add(item);
                ARMPRECIO = ARMPRECIO + n.costo;
            }
            textBoxKrus.Text = ARMPRECIO.ToString() + " " + "$";
        }

        public void inicializaString()
        {
            int i = 0;
            foreach (Nodo n in g.listaNodo)
            {
                listaString.Add(n.getCiudad().GetNombreCiudadString());
                //Console.WriteLine(listaString[i]);
                i++;
            }
        }
        public void fusiona(int i, int j)
        {
            listaString[i] += listaString[j];
            listaString.RemoveAt(j);
        }

        public int Busca(string x)
        {
            int i = 0;

            foreach (string n in listaString)
            {
                if (n.Contains(x))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void buttonPRIMM_Click(object sender, EventArgs e)
        {
            foreach (string n in listaString)
            {
                Console.WriteLine(n);
            }
            panel.Refresh();
            listViewOD.Items.Clear();
            textBoxKrus.Clear();
            ReiniciarTodo();
            foreach (Vuelo n in listaVuelos)
            {
                ListaVuelosPrim.Add(n);
            }
            QuickSort(0, ListaVuelosPrim.Count() - 1, 1);
            for (int n = 0; n < ListaVuelosPrim.Count; n++)
            {
                Console.WriteLine(ListaVuelosPrim[n].costo);
            }

            ARM = listViewCiudades.FocusedItem.SubItems[0].Text;


            while (ARM.Length < g.listaNodo.Count)
            {
                Vuelo Selecionado = Seleccion();

                if (Selecionado == null)
                {
                    Console.WriteLine(ARM);
                    break;
                }

                if (ARM.Contains(Selecionado.getOrigen()))
                {
                    ARM = ARM + Selecionado.getDestino();
                }
                else
                {
                    ARM = ARM + Selecionado.getOrigen();
                }

                listaVuelosFinal.Add(Selecionado);
            }

            Color chido2 = Color.FromArgb(128, Color.Red);
            Pen penPRIM = new Pen(chido2, 5);

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int i = 0; i < listaVuelosFinal.Count; i++)
            {
                for (int j = 0; j < g.listaNodo.Count; j++)
                {
                    if (listaVuelosFinal[i].getOrigen() == g.listaNodo[j].getCiudad().GetnombreCiudad())
                    {
                        x1 = g.listaNodo[j].getCiudad().x;
                        y1 = g.listaNodo[j].getCiudad().y;
                    }
                    for (int h = 0; h < g.listaNodo[j].La.Count; h++)
                    {
                        if (listaVuelosFinal[i].getDestino() == g.listaNodo[j].La[h].getNodoAd().getCiudad().GetnombreCiudad())
                        {
                            x2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().x;
                            y2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().y;
                        }
                    }
                }
                panel.CreateGraphics().DrawLine(penPRIM, x1 + 15, y1 + 15, x2 + 5, y2 + 10);
            }

            int ResultPrim = 0;
            foreach (Vuelo n in listaVuelosFinal)
            {
                string[] arregloString = new string[2];
                arregloString[0] = n.getOrigen().ToString();
                arregloString[1] = n.getDestino().ToString();

                ListViewItem Item = new ListViewItem(arregloString);
                listViewOD.Items.Add(Item);
                ResultPrim = ResultPrim + n.costo;
            }
            textBoxPrim.Text = ResultPrim.ToString() + " " + "$";
        }

        public Vuelo Seleccion()
        {
            foreach (Vuelo V in ListaVuelosPrim)
            {
                if (ARM.Contains(V.getOrigen()) && ARM.Contains(V.getDestino()) == false)
                {
                    return V;
                }

                if (ARM.Contains(V.getDestino()) && ARM.Contains(V.getOrigen()) == false)
                {
                    return V;
                }
            }
            return null;
        }

        public int compareTo(Vuelo a, Vuelo b, int opc)
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
            aux = ListaVuelosKrus[i];
            ListaVuelosKrus[i] = ListaVuelosKrus[j];
            ListaVuelosKrus[j] = aux;
        }
        public void QuickSort(int inicio, int final, int Opcion)
        {
            int i = inicio;
            int j = final;
            int medio = (inicio + final) / 2;

            if (Opcion == 2)
            {
                int opc = 2;
                Vuelo pivote = new Vuelo();
                pivote = ListaVuelosKrus[medio];
                do
                {
                    while (compareTo(ListaVuelosKrus[i], pivote, opc) == -1)
                        i++;
                    while (compareTo(ListaVuelosKrus[j], pivote, opc) == 1)
                        j--;

                    if (i <= j)
                    {
                        swap(i, j);
                        i++;
                        j--;
                    }

                } while (i <= j);

                if (i < final)
                    QuickSort(i, final, opc);
                if (j > inicio)
                    QuickSort(inicio, j, opc);
            }

            if (Opcion == 1)
            {
                int opc = 2;
                Vuelo pivoteprim = new Vuelo();
                pivoteprim = ListaVuelosPrim[medio];
                do
                {
                    while (compareTo(ListaVuelosPrim[i], pivoteprim, opc) == -1)
                        i++;
                    while (compareTo(ListaVuelosPrim[j], pivoteprim, opc) == 1)
                        j--;

                    if (i <= j)
                    {
                        Vuelo aux = new Vuelo();
                        aux = ListaVuelosPrim[i];
                        ListaVuelosPrim[i] = ListaVuelosPrim[j];
                        ListaVuelosPrim[j] = aux;

                        i++;
                        j--;
                    }

                } while (i <= j);

                if (i < final)
                    QuickSort(i, final, 1);
                if (j > inicio)
                    QuickSort(inicio, j, 1);
            }
        }

        public void ReiniciarTodo()
        {
            for (int i = 0; i < listaVuelosFinal.Count;)
            {
                listaVuelosFinal.RemoveAt(i);

            }
            for (int i = 0; i < ListaVuelosKrus.Count;)
            {
                ListaVuelosKrus.RemoveAt(i);
            }
            for (int i = 0; i < listaString.Count;)
            {
                listaString.RemoveAt(i);
            }
            for (int i = 0; i < listaString.Count;)
            {
                listaString.RemoveAt(i);
            }
            for (int i = 0; i < listaDikstra.Count;)
            {
                listaDikstra.RemoveAt(i);
            }
            for (int i = 0; i < finalVuelos.Count;)
            {
                finalVuelos.RemoveAt(i);
            }
        }

        //EMPEZAMOS HACER EL DIKSTRA

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReiniciarTodo();
            listViewDikstra.Items.Clear();
            listViewRutAS.Items.Clear();
            string Nodoinicial = listViewCiudades.FocusedItem.SubItems[0].Text;

            if (noTieneAdyacentes(Nodoinicial))
            {
                panel.Refresh();
                MessageBox.Show("Ese Nodo no tiene adyacentes no se pueden calcular rutas");
            }
            else
            {

                foreach (Nodo n in g.listaNodo)
                {
                    DijkstraElementos Elemento = new DijkstraElementos(n.getCiudad().GetNombreCiudadString());

                    if (Elemento.actual == Nodoinicial)
                    {
                        Elemento.distancia = 0;
                        Elemento.definitivo = false;
                        Elemento.proveniente = Nodoinicial;
                    }
                    listaDikstra.Add(Elemento);
                }

                int opc = 0;

                while (opc == 0)
                {
                    /* foreach(DijkstraElementos n in listaDikstra)
                     {
                         Console.WriteLine(n.actual + " " + n.definitivo + " " + n.distancia + " " + n.proveniente);
                     }*/

                    int indice = selecciona();

                    if (indice == -1)
                    {
                        int i = 0;
                        foreach (DijkstraElementos n in listaDikstra)
                        {
                            if (n.distancia == 1000000000 && n.definitivo == false)
                            {
                                n.definitivo = true;
                                n.distancia = 0;
                                n.proveniente = n.actual;
                            }

                            Console.WriteLine(listaDikstra[i].actual + " " + listaDikstra[i].proveniente + " " + listaDikstra[i].distancia + " " + listaDikstra[i].definitivo);
                            i++;
                        }
                        // break;
                    }
                    else
                    {
                        listaDikstra[indice].definitivo = true;
                        if (listaDikstra[indice].proveniente != " " && listaDikstra[indice].actual != listaDikstra[indice].proveniente)
                        {

                            Vuelo v = new Vuelo(listaDikstra[indice].proveniente[0], listaDikstra[indice].actual[0], listaDikstra[indice].distancia, 1);
                            finalVuelos.Add(v);
                        }
                        // Console.WriteLine(listaDikstra[indice].proveniente + " " + listaDikstra[indice].actual + " " + Convert.ToString(listaDikstra[indice].distancia));

                        actualiza(listaDikstra[indice]);
                    }

                    if (condicionDefifitivos())
                    {
                        opc = 1;
                    }
                }
                DibujarDijkstra();
                mostrarlistview();
                Rutas(Nodoinicial);
            }
        }

        public void actualiza(DijkstraElementos elemento)
        {
            Nodo auxn = g.returnodo(elemento.actual);

            foreach (Adyacencia a in auxn.La)
            {
                for (int i = 0; i < listaDikstra.Count; i++)
                {
                    if (a.getNodoAd().getCiudad().GetNombreCiudadString() == listaDikstra[i].actual && listaDikstra[i].definitivo == false)
                    {
                        if (a.getPesoAdy() + elemento.distancia < listaDikstra[i].distancia)
                        {
                            listaDikstra[i].proveniente = elemento.actual;
                            //compara[i].definitiva = true;
                            listaDikstra[i].distancia = a.getPesoAdy() + elemento.distancia;
                        }
                    }
                }
            }
        }
        public int selecciona()
        {
            int indice = -1;
            int distancia = 1000000000;

            for (int x = 0; x < listaDikstra.Count; x++)
            {
                if (distancia > listaDikstra[x].distancia && listaDikstra[x].definitivo == false)
                {
                    distancia = listaDikstra[x].distancia;
                    indice = x;
                }

            }
            return indice;
        }

        public bool condicionDefifitivos()
        {
            foreach (DijkstraElementos Elemento in listaDikstra)
            {

                if (Elemento.definitivo == false)
                {
                    return false;
                }
            }
            return true;
        }
        private void textBoxO_TextChanged(object sender, EventArgs e)
        {
            buttonDIKSTRA.Enabled = true;
        }

        public bool noTieneAdyacentes(string _nodo)
        {
            foreach (Nodo n in g.listaNodo)
            {
                if (n.getCiudad().GetnombreCiudad() == _nodo[0])
                {
                    //Console.WriteLine(n.getCiudad().GetnombreCiudad()+"="+ _nodo[0]);
                    if (n.La.Count == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void mostrarlistview()
        {
            foreach (DijkstraElementos n in listaDikstra)
            {
                string[] arregloString = new string[3];
                arregloString[0] = n.actual;
                arregloString[1] = n.proveniente;
                arregloString[2] = n.distancia.ToString();

                ListViewItem item = new ListViewItem(arregloString);
                listViewDikstra.Items.Add(item);
            }
        }
        public void Rutas(string _nodo)
        {  
                foreach (DijkstraElementos e in listaDikstra)
                {
                    if( e.proveniente ==_nodo )
                    {
                        if (e.distancia != 0)
                        {
                            string[] arregloString = new string[1];
                            arregloString[0] = e.proveniente + e.actual;
                            ListViewItem item = new ListViewItem(arregloString);
                            listViewRutAS.Items.Add(item);
                        }
                    }
                    else
                    {
                        if(e.distancia==0)
                        {
                           
                        }
                        else
                        {
                            bool bandera = true;
                            string ruta = e.actual + e.proveniente;
                            string aux= e.proveniente;
                            while (bandera == true)
                            {
                                int pos = Regresamepos(aux);
                                ruta += listaDikstra[pos].proveniente;
                                if(listaDikstra[pos].proveniente==_nodo)
                                {
                                string volteada = "";
                                for (int x = ruta.Length; x > 0; x--)
                                {
                                    volteada = volteada + ruta[x - 1];
                                }
                                string[] arregloString = new string[1];
                                    arregloString[0] = volteada;
                                    ListViewItem item = new ListViewItem(arregloString);
                                    listViewRutAS.Items.Add(item);
                                    bandera = false;
                                }
                                else
                                {
                                    aux = listaDikstra[pos].proveniente;
                                }
                              
                            }
                        }
                    }
                }
        }

        public int Regresamepos(string _aux)
        {
            for(int x=0;x<listaDikstra.Count;x++)
            {
                if(listaDikstra[x].actual ==_aux)
                {
                    return x;
                }
            }
            return -1;
        }

        public void DibujarDijkstra()
        {
            panel.Refresh();
            Color chido2 = Color.FromArgb(128, Color.Purple);
            Pen penPRIM = new Pen(chido2, 5);

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int i = 0; i < finalVuelos.Count; i++)
            {
                for (int j = 0; j < g.listaNodo.Count; j++)
                {
                    if (finalVuelos[i].getOrigen() == g.listaNodo[j].getCiudad().GetnombreCiudad())
                    {
                        x1 = g.listaNodo[j].getCiudad().x;
                        y1 = g.listaNodo[j].getCiudad().y;
                    }
                    for (int h = 0; h < g.listaNodo[j].La.Count; h++)
                    {
                        if (finalVuelos[i].getDestino() == g.listaNodo[j].La[h].getNodoAd().getCiudad().GetnombreCiudad())
                        {
                            x2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().x;
                            y2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().y;
                        }
                    }
                }
                panel.CreateGraphics().DrawLine(penPRIM, x1 + 15, y1 + 15, x2 + 5, y2 + 10);
            }
        }

        private void listViewRutAS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

