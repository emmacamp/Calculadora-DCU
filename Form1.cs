using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double numero1 = 0, numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            if (true)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }

            else
            {
                textBox.Text = "0";
            }
        }

        private void AgregarNumero(object sender, EventArgs e)
        {

            var boton = ((Button)sender); ;

            if (textBox.Text == "0")
                textBox.Text = "";

                textBox.Text += boton.Text;

        }

        private void Limpiar()
        {
            textBox.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox.Text);

            if (operador == '+')
            {
                textBox.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }

            else if (operador == '-')
            {
                textBox.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }

            else if (operador == '*')
            {
                textBox.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }

            else if (operador == '/')
            {
                textBox.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(textBox.Text);
            }



        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        private void Operadores(object sender, EventArgs e)
        {

            var boton = ((Button)sender);            
            numero1 = Convert.ToDouble(textBox.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                textBox.Text = numero1.ToString();
            }

            else
            {
                textBox.Text = "0";
            }

        }

    }
}
