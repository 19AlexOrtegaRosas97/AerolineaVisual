using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea_Al_Qaeda_Flyin
{
    public class Grafo
    {
        public List<Nodo> listaNodo;
        public List<Vuelo> listavuelo;
        //int x, y;

        public Grafo(ref List<Vuelo> Lv)
        {
            this.listaNodo = new List<Nodo>();
            this.listavuelo = Lv;

            foreach (Vuelo v in Lv)
            {
                bool banderaO = true;
                bool banderaD = true;

                foreach (Nodo n in listaNodo)
                {
                    if (v.getOrigen() == n.getCiudad().nombreCiudad)
                        banderaO = false;
                    if (v.getDestino() == n.getCiudad().nombreCiudad)
                        banderaD = false;
                }
                if (banderaO)
                {
                    Ciudad c = new Ciudad(v.getOrigen());
                    Nodo n = new Nodo(c);
                    listaNodo.Add(n);
                }
                if (banderaD)
                {
                    Ciudad c = new Ciudad(v.getDestino());
                    Nodo n = new Nodo(c);
                    listaNodo.Add(n);
                }
            }

            foreach (Nodo nod in listaNodo)
            {
                foreach (Vuelo V in Lv)
                {
                    if (nod.getCiudad().nombreCiudad == V.getOrigen())
                    {
                        foreach (Nodo Nod in listaNodo)
                        {
                            if (Nod.getCiudad().nombreCiudad == V.getDestino())
                            {
                                Adyacencia AuxAdyacencia = new Adyacencia(Nod, V.costo,V.tiempo);

                                nod.setAdyacencia(AuxAdyacencia);

                            }
                        }
                    }
                }
            }
            foreach (Nodo n in listaNodo)
            {
                Console.WriteLine(n.getCiudad().nombreCiudad);
                foreach (Adyacencia _A in n.La)
                {
                    Console.Write("-->" + _A.getNodoAd().getCiudad().nombreCiudad);

                }
                Console.WriteLine();
            }

        }
        //metodos grafo

        public int getNodosCount()
        {
            return listaNodo.Count();
        }
        public Nodo getnodo(int i)
        {
            return listaNodo[i];
        }

        public Nodo returnodo(string buscado)
        {
            foreach (Nodo n in listaNodo)
            {
                if (n.getCiudad().GetNombreCiudadString() == buscado)
                {
                    return n;
                }
            }
            return null;
        }
        public void SetNodo(Nodo n)
        {
            listaNodo.Add(n);
        }
        public bool CompararNodo(char _nodoNew)
        {
            foreach(Nodo n in listaNodo)
            {
                if(n.getCiudad().GetnombreCiudad()==_nodoNew)
                {
                    return false;
                }
            }
            return true;
        }
        public Nodo getNodoAdy(char buscado)
        {
            foreach (Nodo n in listaNodo)
            {
                if (n.getCiudad().GetnombreCiudad() == buscado)
                {
                    return n;
                }
            }
            return null;
        }
    }
    //CLASE NODO
    public class Nodo
    {
         public List<Adyacencia> La=new List<Adyacencia>();
         Ciudad C;

        public Nodo(Ciudad c)
        {
            this.C = c;
        }

        public Ciudad getCiudad()
        {
            return C;
        }
        public void setAdyacencia(Adyacencia a)
        {
            La.Add(a);
        }
        public Adyacencia getadyacencia(int i)
        {
            return La[i];
        }
    }
    //CLASE CIUDAD
    public class Ciudad
    {
        public char nombreCiudad;
        public string NomCiudadString;
        public  int x;
        public int y;

        public Ciudad(char nom)
        {
            this.nombreCiudad = nom;

        }
        public string GetNombreCiudadString()
        {
            string Ciudad;
            Ciudad = this.nombreCiudad.ToString();
            return Ciudad;
        }
        public char GetnombreCiudad()
        {
            return nombreCiudad;
        }
        public void setxy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //CLASE ADYACENCIA
    public class Adyacencia
    {
        int peso;
        int tiempo;
        Nodo n;
        public Adyacencia(Nodo n,int peso,int tiempo)
        {
            this.n = n;
            this.peso = peso;
            this.tiempo = tiempo;
        }

        public Nodo getNodoAd()
        {
            return n;
        }
        public int getPesoAdy()
        {
            return peso;
        }
        public int getTiempoAdy()
        {
            return tiempo;
        }
    }
}
  
