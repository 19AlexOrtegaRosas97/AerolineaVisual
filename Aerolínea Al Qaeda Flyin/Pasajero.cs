using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea_Al_Qaeda_Flyin
{
    [Serializable]
    public class Pasajero
    {
        string nombre;
        string apellido;
        string asiento;
        string edad;
        public string vuelo;
        int Asientoint;

        public Pasajero(string nombre,string apellido, string edad,string asiento, string vuelo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.vuelo = vuelo;
            this.asiento = asiento;
            this.Asientoint = Int32.Parse(asiento);
        }
        public Pasajero()
        {

        }
        public string getNombre()
        {
            return nombre + " " + apellido;
        }
        public int getAsientoInt()
        {
            return Asientoint;
        }
        public string getAsiento()
        {
            return (asiento).ToString();
        }
        public string getEdad()
        {
            return edad;
        }
        public string getVuelo()
        {
            return vuelo;
        }
    }
}
