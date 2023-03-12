using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4._8_REPASO___INVERSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listaNumeros = textBox1.Text.Trim(); //Obtenemos la lista de números ingresada en el textbox
            string[] numeros = listaNumeros.Split(','); //Separamos los números por comas y los almacenamos en un array

            Array.Reverse(numeros); //Invertimos el orden del array

            string numerosInvertidos = string.Join(",", numeros); //Unimos los números invertidos en una cadena separada por comas
            label1.Text = numerosInvertidos; //Mostramos los números invertidos en el label
        }
    }
}
