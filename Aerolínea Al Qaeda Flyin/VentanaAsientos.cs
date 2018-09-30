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
    public partial class VentanaAsientos : Form
    {
        List<Vuelo> listaVuelos;
        int asientoSeleccionado;
        int ind;

        public VentanaAsientos(ref List<Vuelo> listaVuelo, int ind)
        {
            InitializeComponent();
            this.listaVuelos = listaVuelo;
            this.ind = ind;

            inicializarBotones();
        }

        public int getAsiento()
        {
            return asientoSeleccionado;
        }

        private void inicializarBotones()
        {
            if (listaVuelos[ind].getAD(0) == false)
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            else
            {
                button1.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(1) == false)
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
            else
            {
                button2.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(2) == false)
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            else
            {
                button3.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(3) == false)
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                button4.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(4) == false)
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            else
            {
                button5.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(5) == false)
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            else
            {
                button6.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(6) == false)
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            else
            {
                button7.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(7) == false)
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            else
            {
                button8.BackColor = Color.Green;
            }

            if (listaVuelos[ind].getAD(8) == false)
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            else
            {
                button9.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(9) == false)
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(10) == false)
            {
                button11.BackColor = Color.Red;
                button11.Enabled = false;
            }
            else
            {
                button11.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(11) == false)
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }
            else
            {
                button12.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(12) == false)
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }
            else
            {
                button13.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(13) == false)
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }
            else
            {
                button14.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(14) == false)
            {
                button15.BackColor = Color.Red;
                button15.Enabled = false;
            }
            else
            {
                button15.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(15) == false)
            {
                button16.BackColor = Color.Red;
                button16.Enabled = false;
            }
            else
            {
                button16.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(16) == false)
            {
                button17.BackColor = Color.Red;
                button17.Enabled = false;
            }
            else
            {
                button17.BackColor = Color.Green;
            }
            if (listaVuelos[ind].getAD(17) == false)
            {
                button18.BackColor = Color.Red;
                button18.Enabled = false;
            }
            else
            {
                button18.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 1;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 3;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 2;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 4;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 5;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 7;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 6;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 8;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 9;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 10;
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 11;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 12;
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 13;
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 14;
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 15;
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 16;
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 17;
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            asientoSeleccionado = 18;
            this.Close();
        }
    }
}
