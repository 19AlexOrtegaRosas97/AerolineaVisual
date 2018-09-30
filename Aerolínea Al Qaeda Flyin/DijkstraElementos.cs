using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea_Al_Qaeda_Flyin
{
    public class DijkstraElementos
    {
        public string proveniente;
        public bool definitivo;
        public int distancia;
        public string actual;

        public DijkstraElementos(string _nombre)
        {
           this.proveniente= " ";
            definitivo = false;
            actual =_nombre;
            distancia = 1000000000;

        }
    } 
}
