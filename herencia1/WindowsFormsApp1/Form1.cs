using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            //comportamiento a mi boton
            //voy a utilizar mi clase sumar
            sumar suma = new sumar();//intanciar un nuevo objeto suma
            //llar al metodo de la clase suma
            textBox_resultado.Text = suma.operar(int.Parse (textBox_valor1.Text),int.Parse(textBox_valor2.Text)).ToString();
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            restar resta = new restar();
            textBox_resultado.Text = resta.operar(int.Parse(textBox_valor1.Text), int.Parse(textBox_valor2.Text)).ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            multiplicar multi = new multiplicar();
            textBox_resultado.Text = multi.operar(int.Parse(textBox_valor1.Text), int.Parse(textBox_valor2.Text)).ToString();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            dividir div = new dividir();
            textBox_resultado.Text = div.operar(int.Parse(textBox_valor1.Text), int.Parse(textBox_valor2.Text)).ToString();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox_valor1.Clear();
            textBox_valor2.Clear();
            textBox_resultado.Clear();
        }
    }
}
