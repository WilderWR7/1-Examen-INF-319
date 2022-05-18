using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int valor, valor1,resultado;
        string signo;
        public Form1()
        {
            InitializeComponent();
            valor = 0;
            valor1 = 0;
            signo = "";
            resultado = 0; 

        }
        //numeros
        private void button2_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
            textBox4.Text = valor.ToString();
        }
        //elimina el ultimo numero
        private void button17_Click(object sender, EventArgs e)
        {
            textBox4.Text = valor.ToString().Substring(0,valor.ToString().Length -1 );
            if (textBox4.Text.Length == 0)
            {
                valor = 0;
                textBox4.Text = valor.ToString();
            }
            else {
                valor = Convert.ToInt32(textBox4.Text);                   
            }
        }
        //btn suma
        private void button12_Click(object sender, EventArgs e)
        {
            signo = "+";
            if (resultado != 0)
            {
                valor1 = resultado;
            }
            else
            {
                valor1 = valor;
            }
            valor = 0;
            textBox4.Text = valor.ToString();
        }
        //btn resta
        private void button11_Click(object sender, EventArgs e)
        {
            signo = "-";
            if (resultado != 0)
            {
                valor1 = resultado;
            }
            else
            {
                valor1 = valor;
            }
            valor = 0;
            textBox4.Text = valor.ToString();
        }
        //btn division
        private void button13_Click(object sender, EventArgs e)
        {
            signo = "/";
            if (resultado != 0)
            {
                valor1 = resultado;
            }
            else
            {
                valor1 = valor;
            }
            valor = 0;
            textBox4.Text = valor.ToString();
        }
        //btn multiplicacion
        private void button15_Click(object sender, EventArgs e)
        {
            signo = "*";
            if (resultado != 0)
            {
                valor1 = resultado;
            }
            else
            {
                valor1 = valor;
            }
            valor = 0;
            textBox4.Text = valor.ToString();
        }
        //btn resultado
        private void button16_Click(object sender, EventArgs e)
        {
            switch (signo)
            { 
                case "+":
                    resultado = valor1 + valor; 
                    textBox4.Text = (resultado).ToString();
                    
                break;
                case "-":
                resultado = valor1 - valor; 
                textBox4.Text = (resultado).ToString();
                break;
                case "*":
                resultado = valor1 * valor;
                textBox4.Text = (resultado).ToString();
                break;
                case "/":
                resultado = valor1 / valor;
                textBox4.Text = (resultado).ToString();
                break;
            }
        }
        //btn DEL
        private void button1_Click_1(object sender, EventArgs e)
        {
            valor = 0;
            valor1 = 0;
            resultado = 0;
            textBox4.Text = "0";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

    }
}
    