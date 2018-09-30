using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea_Al_Qaeda_Flyin
{
    [Serializable]
    public class Vuelo
    {
        char origen;
        char destino;
        public  int tiempo;
        public int costo;
        public int asientosDisponibles = 18;
        string ruta;
        public bool[] asientos = new bool[18];
        public List<Pasajero> listaPasajeros = new List<Pasajero>();
        public List<Vuelo> listaVuelo = new List<Vuelo>();

        public Vuelo()
        {

        }
        public Vuelo(char origen, char destino, int tiempo, int costo) // 
        {

            this.origen = origen;
            this.destino = destino;
            this.tiempo = tiempo;
            this.costo = costo;
            this.asientosDisponibles = 18;
            this.ruta = "SK1" + origen + destino;
            asientos = new bool[18];

            for (int i = 0; i < 18; i++)
                asientos[i] = true;
        }

        public override string ToString()
        {
            return ruta;
        }
        public void setAD(int ind)
        {
            asientosDisponibles--;
            this.asientos[ind] = false;

        }

        public void setDisp(int i, bool x)
        {
            this.asientos[i] = x;
        }
        
        public bool getAD(int ind)
        {
            return asientos[ind];
        }
        public int getADint()
        {
            return asientosDisponibles;
        }

        public int setADint(int ind)
        {
            return asientosDisponibles=ind;
        }

        public Pasajero getPasajero(int i)
        {
            return this.listaPasajeros[i];
        }

        public void setPasajero(Pasajero v)
        { 

            this.listaPasajeros.Add(v);
        }

        public int pasajerosCount()
        {
            return this.listaPasajeros.Count();
        }
        public string getRuta()
        {
            return this.ruta;
        }

        public List<Pasajero> getListaPasajeros()
        {
            return this.listaPasajeros;
        }
        
        public char getOrigen()
        {
            return this.origen;
        }
        public char getDestino()
        {
            return destino;
        }

        public int getVuelosCount()
        {
            return this.listaVuelo.Count();
        }

        public string GetVueloporPos(int x)
        {
            return this.listaVuelo[x].getRuta();
        }

    }
}
