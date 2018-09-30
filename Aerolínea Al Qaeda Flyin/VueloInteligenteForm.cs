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
    public partial class VueloInteligenteForm : Form
    {
        List<Vuelo> listaVuelos;
        Grafo g;
        List<Vuelo> ListaDikstraOD = new List<Vuelo>();
        List<DijkstraElementos> listaDikstra = new List<DijkstraElementos>();
        List<Vuelo> finalVuelos = new List<Vuelo>();
        
        

        public VueloInteligenteForm(ref List<Vuelo> listaVuelos, ref Grafo g)
        {
            this.g = g;
            InitializeComponent();
            this.listaVuelos = listaVuelos;
            textBoxTotal.Enabled = false;
            buttonCotizar.Enabled = false;
            buttonSold.Enabled = false;
            radioButtonTiempo.Checked = false;
            radioButtonCOSTO.Checked = false;
            
        }

        private void MostrarGrafo()
        {
            //panel.Refresh();
            Pen pluma = new Pen(Color.Black, 1);
            //panel.CreateGraphics().DrawEllipse(pluma, 25, 25, panel.Height - 50, panel.Height - 50);
            double a = 2 * Math.PI / g.getNodosCount();
            int r = (panel2.Width - 50) / 2;

            for (int i = 0; i < g.getNodosCount(); i++)
            {
                int x = Convert.ToInt32(Math.Cos(i * a) * r + r + 15);
                int y = Convert.ToInt32(Math.Sin(i * a) * r + r + 15);

                panel2.CreateGraphics().DrawEllipse(pluma, x, y, 20, 20);

                Font formato = new Font("Arial", 16);
                SolidBrush Dibujarletra = new SolidBrush(Color.Tomato);
                StringFormat letra = new StringFormat();
                panel2.CreateGraphics().DrawString(g.getnodo(i).getCiudad().GetNombreCiudadString(), formato, Dibujarletra, x - 1, y - 1, letra);
                g.getnodo(i).getCiudad().setxy(x, y);
            }

            foreach (Nodo n in g.listaNodo)
            {
                foreach (Adyacencia A in n.La)
                {
                    Pen plumaAdy = new Pen(Color.LimeGreen, 2);
                    AdjustableArrowCap flecha = new AdjustableArrowCap(5, 5);
                    plumaAdy.CustomStartCap = flecha;
                    panel2.CreateGraphics().DrawLine(plumaAdy, A.getNodoAd().getCiudad().x + 10, A.getNodoAd().getCiudad().y + 10, n.getCiudad().x + 15, n.getCiudad().y + 15);
                    Font letras = new Font("Arial", 10);
                    SolidBrush Brocha = new SolidBrush(Color.Blue);
                    StringFormat diseno = new StringFormat();
                    panel2.CreateGraphics().DrawString(Convert.ToString(A.getPesoAdy()), letras, Brocha, (A.getNodoAd().getCiudad().x + n.getCiudad().x) / 2, (A.getNodoAd().getCiudad().y + n.getCiudad().y) / 2, diseno);
                }
            }

        }

        private void VueloInteligenteForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            MostrarGrafo();
        }
        public void ReiniciarTodo()
        {
            for (int i = 0; i < listaDikstra.Count;)
            {
                listaDikstra.RemoveAt(i);
            }
            for (int i = 0; i < finalVuelos.Count;)
            {
                finalVuelos.RemoveAt(i);
            }
            for (int i = 0; i < ListaDikstraOD.Count;)
            {
                ListaDikstraOD.RemoveAt(i);
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
                        if (radioButtonCOSTO.Checked == true)
                        {
                            //Console.WriteLine(" entro costo");
                            if (a.getPesoAdy() + elemento.distancia < listaDikstra[i].distancia)
                            {
                                listaDikstra[i].proveniente = elemento.actual;
                                //compara[i].definitiva = true;
                                listaDikstra[i].distancia = a.getPesoAdy() + elemento.distancia;

                            }
                        }
                        if (radioButtonTiempo.Checked == true)
                        {
                            //Console.WriteLine(" entro time");
                            if (a.getTiempoAdy() + elemento.distancia < listaDikstra[i].distancia)
                            {
                                listaDikstra[i].proveniente = elemento.actual;
                                //compara[i].definitiva = true;
                                listaDikstra[i].distancia = a.getTiempoAdy() + elemento.distancia;
                            }
                        }

                    }
                }
            }
        }
        public int selecciona()
        {
            int indice = -1;
            int _distancia = 1000000000;

            for (int x = 0; x < listaDikstra.Count; x++)
            {
                if (_distancia > listaDikstra[x].distancia && listaDikstra[x].definitivo == false)
                {
                    _distancia = listaDikstra[x].distancia;
                    indice = x;
                }

            }
            return indice;
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

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            ReiniciarTodo();
            textBoxTotal.Clear();
            listViewRutAS.Items.Clear();
            
            string Nodoinicial = textBoxOrigen.Text;
            string NodoFinal = textBoxDestino.Text;

            if (noTieneAdyacentes(Nodoinicial))
            {
                MessageBox.Show("Ese Nodo no tiene adyacentes no se pueden calcular rutas");
            }
            else
            {

                foreach (Nodo n in g.listaNodo)
                {
                    DijkstraElementos Elemento = new DijkstraElementos(n.getCiudad().GetNombreCiudadString());

                    if (Elemento.actual == Nodoinicial)
                    {
                        //Console.WriteLine("sI ENTRO PAPU");
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

                            //Console.WriteLine(listaDikstra[i].actual + " " + listaDikstra[i].proveniente + " " + listaDikstra[i].distancia + " " + listaDikstra[i].definitivo);
                            i++;
                        }
                        // break;
                    }
                    else
                    {
                        listaDikstra[indice].definitivo = true;
                        if (listaDikstra[indice].proveniente != " " && listaDikstra[indice].actual != listaDikstra[indice].proveniente)
                        {
                            Vuelo v = new Vuelo(listaDikstra[indice].proveniente[0], listaDikstra[indice].actual[0], dAMETIEMPO(listaDikstra[indice].proveniente, listaDikstra[indice].actual), dAMECOSTO(listaDikstra[indice].proveniente, listaDikstra[indice].actual));
                            finalVuelos.Add(v);

                            if (v.getDestino() == NodoFinal[0])
                            {
                                Console.WriteLine("entro");
                                foreach (Vuelo n in finalVuelos)
                                {
                                    Console.WriteLine(n.getOrigen() + " " + n.getDestino() + " " + n.tiempo + " " + n.costo);
                                }
                               // Console.WriteLine("elementos dijkstar");
                               /* foreach (DijkstraElementos n in listaDikstra)
                                {
                                    Console.WriteLine(n.actual + " " + n.definitivo + " " + n.proveniente+ " " + n.distancia);
                                }*/
                                break;
                            }
                        }
                        // Console.WriteLine(listaDikstra[indice].proveniente + " " + listaDikstra[indice].actual + " " + Convert.ToString(listaDikstra[indice].distancia));

                        actualiza(listaDikstra[indice]);
                    }

                    if (condicionDefifitivos())
                    {
                        opc = 1;
                    }
                }
                bool banderaVacio = false;

                EscojeVuelos2_O(Nodoinicial[0], NodoFinal[0]);
                foreach(DijkstraElementos n in listaDikstra)
                {
                   // Console.WriteLine(n.actual + " " + n.definitivo + " " + n.distancia + " " + n.proveniente);
                    if (n.actual==NodoFinal && n.distancia==0)
                    {
                            banderaVacio = true;
                    }
                }

                if (banderaVacio != true)
                {
                    AcListview();
                    buttonSold.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Existe Ruta Para llegar al Destino "+NodoFinal);
                    
                }
            }
            DibujarOD();
        }
        public void AcListview()
        {
            int Total = 0;
            listViewRutAS.Items.Clear();

            if(radioButtonTiempo.Checked==true)
            {
                foreach (Vuelo n in ListaDikstraOD)
                {
                    string[] arregloString = new string[2];
                    arregloString[0] = n.getOrigen() + " -> " + n.getDestino();
                    arregloString[1] = n.tiempo.ToString();

                    ListViewItem item = new ListViewItem(arregloString);
                    listViewRutAS.Items.Add(item);
                    Total += n.tiempo;
                }
                textBoxTotal.Text = Total.ToString() + " Min";
            }
            if (radioButtonCOSTO.Checked == true)
            {
                foreach (Vuelo n in ListaDikstraOD)
                {
                    string[] arregloString = new string[2];
                    arregloString[0] = n.getOrigen() + " -> " + n.getDestino();
                    arregloString[1] = n.costo.ToString();

                    ListViewItem item = new ListViewItem(arregloString);
                    listViewRutAS.Items.Add(item);
                    Total += n.costo;
                }
                textBoxTotal.Text = Total.ToString() + " $";
            }
        }
        
        public int dAMECOSTO(string _origen, string _destino)
        {
            foreach (Vuelo n in listaVuelos)
            {
                if (n.getOrigen() == _origen[0] && n.getDestino() == _destino[0])
                {
                    return n.costo;
                }
            }
            return -1;
        }
        public int dAMETIEMPO(string  _origen, string _destino)
        {
            foreach (Vuelo n in listaVuelos)
            {
                if (n.getOrigen() == _origen[0] && n.getDestino() == _destino[0])
                {
                    return n.tiempo;
                }
            }
            return -1;
        }

        public void EscojeVuelos(char _origen, char _destino)
        {
            bool banderaO = false, banderaD = false;

            for (int i = finalVuelos.Count - 1; i >= 0; i--)
            {

                if (finalVuelos[i].getOrigen() == _origen || finalVuelos[i].getOrigen() == _origen)
                {
                    banderaO = true;
                }
                if (finalVuelos[i].getDestino() == _destino || finalVuelos[i].getDestino() == _destino)
                {
                    banderaD = true;
                }

                if (banderaO != true || banderaD != true)
                {
                    ListaDikstraOD.Add(finalVuelos[i]);
                }

                if (banderaO == true && banderaD == true)
                {
                    ListaDikstraOD.Add(finalVuelos[i]);
                    Console.WriteLine(" elegidos LDO");
                    foreach (Vuelo n in ListaDikstraOD)
                    {
                        Console.WriteLine(n.getOrigen() + " " + n.getDestino() + " " + n.tiempo + " " + n.costo);
                    }
                    break;
                }

            }

        }

        public void EscojeVuelos2_O(char _origen, char _destino)
        {
            char actual=_destino;

            for (int i = finalVuelos.Count - 1; i >= 0; i--)
            {

                if (finalVuelos[i].getDestino()==actual)
                {
                    if(finalVuelos[i].getOrigen()==_origen)
                    {
                        ListaDikstraOD.Add(finalVuelos[i]);
                        break;
                    }
                    else
                    {
                        ListaDikstraOD.Add(finalVuelos[i]);
                        actual = finalVuelos[i].getOrigen();
                    }
                }

            }

        }

        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {
            buttonCotizar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _costol = textBoxTotal.Text;

            FORMULARIO Ventanita = new FORMULARIO(ref listaVuelos,ref ListaDikstraOD,_costol);
            Ventanita.ShowDialog();
            if(Ventanita.getRegisro())
            {
                this.Close();
            }
        }

        public void DibujarOD()
        {
            panel2.Refresh();
            Color chido2 = Color.FromArgb(128, Color.Red);
            Pen pen = new Pen(chido2, 5);

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int i = 0; i < ListaDikstraOD.Count ; i++)
            {
                for (int j = 0; j < g.listaNodo.Count; j++)
                {
                    if (ListaDikstraOD[i].getOrigen() == g.listaNodo[j].getCiudad().GetnombreCiudad())
                    {
                        x1 = g.listaNodo[j].getCiudad().x;
                        y1 = g.listaNodo[j].getCiudad().y;
                    }
                    for (int h = 0; h < g.listaNodo[j].La.Count; h++)
                    {
                        if (ListaDikstraOD[i].getDestino() == g.listaNodo[j].La[h].getNodoAd().getCiudad().GetnombreCiudad())
                        {
                            x2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().x;
                            y2 = g.listaNodo[j].La[h].getNodoAd().getCiudad().y;
                        }
                    }
                }
                panel2.CreateGraphics().DrawLine(pen, x1 + 15, y1 + 15, x2 + 5, y2 + 10);
            }
        }
        public int Regresamepos(string _aux)
        {
            for (int x = 0; x < listaDikstra.Count; x++)
            {
                if (listaDikstra[x].actual == _aux)
                {
                    return x;
                }
            }
            return -1;
        }
    }
}
