using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aerolínea_Al_Qaeda_Flyin
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Vuelo> listaVuelos;

            listaVuelos = new List<Vuelo>();
            //LEER
            if (File.Exists("ArchivoVuelo.bin"))
            {
                using (Stream stream = File.Open("ArchivoVuelo.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    listaVuelos = (List<Vuelo>)bformatter.Deserialize(stream);
                }

            }
            else
            {
                //Declaro mis objetos de vuelo con informacion 
                Vuelo v1 = new Vuelo('A', 'B', 50, 600);
                Vuelo v2 = new Vuelo('A', 'F', 90, 1050);
                Vuelo v3 = new Vuelo('A', 'G', 80, 1150);
                Vuelo v4 = new Vuelo('B', 'A', 50, 600);
                Vuelo v5 = new Vuelo('B', 'C', 40, 750);
                Vuelo v6 = new Vuelo('B', 'D', 60, 650);
                Vuelo v7 = new Vuelo('B', 'E', 70, 1850);
                Vuelo v8 = new Vuelo('C', 'B', 35, 800);
                Vuelo v9 = new Vuelo('C', 'E', 50, 850);
                Vuelo v10 = new Vuelo('E', 'C', 45, 750);
                Vuelo v11 = new Vuelo('E', 'G', 80, 1150);
                Vuelo v12 = new Vuelo('E', 'L', 60, 1650);
                Vuelo v13 = new Vuelo('E', 'D', 35, 700);
                Vuelo v14 = new Vuelo('D', 'E', 45, 900);
                Vuelo v15 = new Vuelo('D', 'B', 55, 700);
                Vuelo v16 = new Vuelo('F', 'B', 66, 800);
                Vuelo v17 = new Vuelo('F', 'L', 140, 2850);
                Vuelo v18 = new Vuelo('G', 'A', 95, 1250);
                Vuelo v19 = new Vuelo('G', 'E', 75, 1175);
                Vuelo v20 = new Vuelo('G', 'L', 135, 2675);
                Vuelo v21 = new Vuelo('G', 'J', 60, 1400);
                Vuelo v22 = new Vuelo('G', 'H', 25, 450);
                Vuelo v23 = new Vuelo('H', 'G', 30, 350);
                Vuelo v24 = new Vuelo('H', 'I', 35, 400);
                Vuelo v25 = new Vuelo('I', 'H', 30, 400);
                Vuelo v26 = new Vuelo('I', 'K', 35, 400);
                Vuelo v27 = new Vuelo('K', 'I', 35, 400);
                Vuelo v28 = new Vuelo('K', 'J', 25, 300);
                Vuelo v29 = new Vuelo('J', 'L', 40, 750);
                Vuelo v30 = new Vuelo('J', 'M', 70, 1450);
                Vuelo v31 = new Vuelo('L', 'M', 40, 650);
                Vuelo v32 = new Vuelo('L', 'K', 70, 700);
                Vuelo v33 = new Vuelo('L', 'E', 60, 1550);
                Vuelo v34 = new Vuelo('M', 'L', 40, 700);
                //Agrego mis objetos de vuelos a la lista
                listaVuelos.Add(v1);
                listaVuelos.Add(v2);
                listaVuelos.Add(v3);
                listaVuelos.Add(v4);
                listaVuelos.Add(v5);
                listaVuelos.Add(v6);
                listaVuelos.Add(v7);
                listaVuelos.Add(v8);
                listaVuelos.Add(v9);
                listaVuelos.Add(v10);
                listaVuelos.Add(v11);
                listaVuelos.Add(v12);
                listaVuelos.Add(v13);
                listaVuelos.Add(v14);
                listaVuelos.Add(v15);
                listaVuelos.Add(v16);
                listaVuelos.Add(v17);
                listaVuelos.Add(v18);
                listaVuelos.Add(v19);
                listaVuelos.Add(v20);
                listaVuelos.Add(v21);
                listaVuelos.Add(v22);
                listaVuelos.Add(v23);
                listaVuelos.Add(v24);
                listaVuelos.Add(v25);
                listaVuelos.Add(v26);
                listaVuelos.Add(v27);
                listaVuelos.Add(v28);
                listaVuelos.Add(v29);
                listaVuelos.Add(v30);
                listaVuelos.Add(v31);
                listaVuelos.Add(v32);
                listaVuelos.Add(v33);
                listaVuelos.Add(v34);
            }
     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Grafo g = new Grafo(ref listaVuelos);
            VentanaInicio VInicio = new VentanaInicio(ref listaVuelos, ref g);
            VInicio.ShowDialog();
            //Application.Run(new VentanaInicio());

            

            //escritura
            using (Stream stream = File.Open("ArchivoVuelo.bin", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, listaVuelos);
            }
        }
    }
}
