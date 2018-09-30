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
    public partial class VueloNuevoForm : Form
    {
        List<Vuelo> listavuelos = new List<Vuelo>();
        public Grafo g;
        public VueloNuevoForm(ref List<Vuelo> listavuelo, ref Grafo g)
        {
            InitializeComponent();
            this.listavuelos = listavuelo;
            buttonAGREGARV.Enabled = false;
            this.g = g;
        }
        private void textBoxOrigen_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCosto.Text == " " || textBoxDestino.Text == " " || textBoxOrigen.Text == " " || textBoxTiempo.Text == " " || textBoxOrigen.Text == "" || textBoxDestino.Text == "" || textBoxOrigen.Text == "a" || textBoxOrigen.Text == "b" || textBoxOrigen.Text == "c" || textBoxOrigen.Text == "d" || textBoxOrigen.Text == "e" || textBoxOrigen.Text == "f" || textBoxOrigen.Text == "g" || textBoxOrigen.Text == "h" || textBoxOrigen.Text == "i" || textBoxOrigen.Text == "j" || textBoxOrigen.Text == "k" || textBoxOrigen.Text == "l" || textBoxOrigen.Text == "m" || textBoxOrigen.Text == "n" || textBoxOrigen.Text == "o" || textBoxOrigen.Text == "p" || textBoxOrigen.Text == "q" || textBoxOrigen.Text == "r" || textBoxOrigen.Text == "s" || textBoxOrigen.Text == "t" || textBoxOrigen.Text == "u" || textBoxOrigen.Text == "v" || textBoxOrigen.Text == "w" || textBoxOrigen.Text == "x" || textBoxOrigen.Text == "y" || textBoxOrigen.Text == "z" || textBoxOrigen.Text == "ñ" || textBoxDestino.Text == "a" || textBoxDestino.Text == "b" || textBoxDestino.Text == "c" || textBoxDestino.Text == "d" || textBoxDestino.Text == "e" || textBoxDestino.Text == "f" || textBoxDestino.Text == "g" || textBoxDestino.Text == "h" || textBoxDestino.Text == "i" || textBoxDestino.Text == "j" || textBoxDestino.Text == "k" || textBoxDestino.Text == "l" || textBoxDestino.Text == "m" || textBoxDestino.Text == "n" || textBoxDestino.Text == "o" || textBoxDestino.Text == "p" || textBoxDestino.Text == "q" || textBoxDestino.Text == "r" || textBoxDestino.Text == "s" || textBoxDestino.Text == "t" || textBoxDestino.Text == "u" || textBoxDestino.Text == "v" || textBoxDestino.Text == "w" || textBoxDestino.Text == "x" || textBoxDestino.Text == "y" || textBoxDestino.Text == "z" || textBoxDestino.Text == "ñ" || textBoxCosto.Text == "" || textBoxTiempo.Text == "")
            {
                buttonAGREGARV.Enabled = false;
            }
            else
            {
                buttonAGREGARV.Enabled = true;
            }
        }

        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCosto.Text == " " || textBoxDestino.Text == " " || textBoxOrigen.Text == " " || textBoxTiempo.Text == " " || textBoxOrigen.Text == "" || textBoxDestino.Text == "" || textBoxOrigen.Text == "a" || textBoxOrigen.Text == "b" || textBoxOrigen.Text == "c" || textBoxOrigen.Text == "d" || textBoxOrigen.Text == "e" || textBoxOrigen.Text == "f" || textBoxOrigen.Text == "g" || textBoxOrigen.Text == "h" || textBoxOrigen.Text == "i" || textBoxOrigen.Text == "j" || textBoxOrigen.Text == "k" || textBoxOrigen.Text == "l" || textBoxOrigen.Text == "m" || textBoxOrigen.Text == "n" || textBoxOrigen.Text == "o" || textBoxOrigen.Text == "p" || textBoxOrigen.Text == "q" || textBoxOrigen.Text == "r" || textBoxOrigen.Text == "s" || textBoxOrigen.Text == "t" || textBoxOrigen.Text == "u" || textBoxOrigen.Text == "v" || textBoxOrigen.Text == "w" || textBoxOrigen.Text == "x" || textBoxOrigen.Text == "y" || textBoxOrigen.Text == "z" || textBoxOrigen.Text == "ñ" || textBoxDestino.Text == "a" || textBoxDestino.Text == "b" || textBoxDestino.Text == "c" || textBoxDestino.Text == "d" || textBoxDestino.Text == "e" || textBoxDestino.Text == "f" || textBoxDestino.Text == "g" || textBoxDestino.Text == "h" || textBoxDestino.Text == "i" || textBoxDestino.Text == "j" || textBoxDestino.Text == "k" || textBoxDestino.Text == "l" || textBoxDestino.Text == "m" || textBoxDestino.Text == "n" || textBoxDestino.Text == "o" || textBoxDestino.Text == "p" || textBoxDestino.Text == "q" || textBoxDestino.Text == "r" || textBoxDestino.Text == "s" || textBoxDestino.Text == "t" || textBoxDestino.Text == "u" || textBoxDestino.Text == "v" || textBoxDestino.Text == "w" || textBoxDestino.Text == "x" || textBoxDestino.Text == "y" || textBoxDestino.Text == "z" || textBoxDestino.Text == "ñ" || textBoxCosto.Text == "" || textBoxTiempo.Text == "")
            {
                buttonAGREGARV.Enabled = false;
            }
            else
            {
                buttonAGREGARV.Enabled = true;
            }
        }

        private void textBoxCosto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCosto.Text == " " || textBoxDestino.Text == " " || textBoxOrigen.Text == " " || textBoxTiempo.Text == " " || textBoxOrigen.Text == "" || textBoxDestino.Text == "" || textBoxCosto.Text == "" || textBoxTiempo.Text == "")
            {
                buttonAGREGARV.Enabled = false;
            }
            else
            {
                buttonAGREGARV.Enabled = true;
            }
        }

        private void textBoxTiempo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCosto.Text == " " || textBoxDestino.Text == " " || textBoxOrigen.Text == " " || textBoxTiempo.Text == " " || textBoxOrigen.Text == "" || textBoxDestino.Text == "" || textBoxCosto.Text == "" || textBoxTiempo.Text == "")
            {
                buttonAGREGARV.Enabled = false;
            }
            else
            {
                buttonAGREGARV.Enabled = true;
            }
        }

        private void textBoxCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)
                || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)
                || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool ValidarVueloNoRepetido()
        {
            if (textBoxOrigen.Text == textBoxDestino.Text)
            {
                return false;
            }

            for (int i = 0; i < listavuelos.Count(); i++)
            {
                if (listavuelos[i].getOrigen().ToString() == textBoxOrigen.Text && listavuelos[i].getDestino().ToString() == textBoxDestino.Text)
                {
                    return false;
                }
            }

            return true;
        }

        private void buttonAGREGARV_Click(object sender, EventArgs e)
        {
            if (textBoxCosto.Text == " " || textBoxDestino.Text == " " || textBoxOrigen.Text == " " || textBoxTiempo.Text == " " || textBoxOrigen.Text == "" || textBoxDestino.Text == "" || textBoxOrigen.Text == "a" || textBoxOrigen.Text == "b" || textBoxOrigen.Text == "c" || textBoxOrigen.Text == "d" || textBoxOrigen.Text == "e" || textBoxOrigen.Text == "f" || textBoxOrigen.Text == "g" || textBoxOrigen.Text == "h" || textBoxOrigen.Text == "i" || textBoxOrigen.Text == "j" || textBoxOrigen.Text == "k" || textBoxOrigen.Text == "l" || textBoxOrigen.Text == "m" || textBoxOrigen.Text == "n" || textBoxOrigen.Text == "o" || textBoxOrigen.Text == "p" || textBoxOrigen.Text == "q" || textBoxOrigen.Text == "r" || textBoxOrigen.Text == "s" || textBoxOrigen.Text == "t" || textBoxOrigen.Text == "u" || textBoxOrigen.Text == "v" || textBoxOrigen.Text == "w" || textBoxOrigen.Text == "x" || textBoxOrigen.Text == "y" || textBoxOrigen.Text == "z" || textBoxOrigen.Text == "ñ" || textBoxDestino.Text == "a" || textBoxDestino.Text == "b" || textBoxDestino.Text == "c" || textBoxDestino.Text == "d" || textBoxDestino.Text == "e" || textBoxDestino.Text == "f" || textBoxDestino.Text == "g" || textBoxDestino.Text == "h" || textBoxDestino.Text == "i" || textBoxDestino.Text == "j" || textBoxDestino.Text == "k" || textBoxDestino.Text == "l" || textBoxDestino.Text == "m" || textBoxDestino.Text == "n" || textBoxDestino.Text == "o" || textBoxDestino.Text == "p" || textBoxDestino.Text == "q" || textBoxDestino.Text == "r" || textBoxDestino.Text == "s" || textBoxDestino.Text == "t" || textBoxDestino.Text == "u" || textBoxDestino.Text == "v" || textBoxDestino.Text == "w" || textBoxDestino.Text == "x" || textBoxDestino.Text == "y" || textBoxDestino.Text == "z" || textBoxDestino.Text == "ñ" || textBoxCosto.Text == "" || textBoxTiempo.Text == "")
            {
                MessageBox.Show("ALGUN DATO ES INCORRECTO FAVOR DE INRODUCIRLO BIEN, DE LA A-Z EN MAYUSCULAS");
            }
            else
            {
                
                if (!ValidarVueloNoRepetido())
                {
                    MessageBox.Show("EL VUELO YA EXISTE :(");
                    return;
                }
                else
                { 
                    int banderaOrigen=0;
                    int banderaDestino = 0;
                    
                    //Grafo g=new Grafo(ref listavuelos); 
                    Vuelo v = new Vuelo(Convert.ToChar(textBoxOrigen.Text), Convert.ToChar(textBoxDestino.Text), Convert.ToInt32(textBoxTiempo.Text), Convert.ToInt32(textBoxCosto.Text));
                    //SI NO SE ENCUENTRAN LOS VUELOS
                    if(g.CompararNodo(v.getOrigen()))
                    {
                        banderaOrigen = 1;
                        
                    }

                    if (g.CompararNodo(v.getDestino()))
                    {
                        banderaDestino = 1;
                    }

                    if (banderaOrigen == 1)
                    {
                        Ciudad cD = new Ciudad(v.getOrigen());
                        Nodo nO = new Nodo(cD);
                        // g.listaNodo.Add(nO);
                        g.SetNodo(nO);

                    }
                    else
                    {
                    }

                    if(banderaDestino==1)
                    {
                        Ciudad cO = new Ciudad(v.getDestino());
                        Nodo nD = new Nodo(cO);
                        // g.listaNodo.Add(nD);
                        g.SetNodo(nD);
                    }
                       

                        

                        Nodo a = g.getNodoAdy(v.getOrigen());
                        Nodo b = g.getNodoAdy(v.getDestino());
                        Adyacencia Adyacente = new Adyacencia(b, v.costo,v.tiempo);
                        a.setAdyacencia(Adyacente);
                        listavuelos.Add(v);

                        MessageBox.Show("VUELO AGREGADO CON EXITO!");
                       this.Close();
                    
                }
            }
        }

    }
}
