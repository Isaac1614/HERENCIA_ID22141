using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //clase principal o clase papa que guarda los metodos de lectura
    /*de valores almacenados de valores en variables*/
    class operacion
    {
        //declaracion de variables
        //tipo de acceso //tipo de dato // nombre de dato
        protected int valor1;
        protected int valor2;
        protected int resultado;
        /*los metodos que se ponen son las funciones son las funciones de obtener el valor
         de la caja de texto dentro de la variable indicada*/
        public int Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
    //creamos nuestra clase hijo que usura los metodos de crear datos
    class sumar:operacion//los : dan permiso de usuar lo que tiene operacion 
    {
        //las clases hijas tambien pueden tener sus prpias clases y metodo pueden tener variables independientes
        //declarar las variables luego los atributo y al final los metodos
        //
        public int operar(int v1,int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class restar : operacion//los : dan permiso de usuar lo que tiene operacion 
    {
        //las clases hijas tambien pueden tener sus prpias clases y metodo pueden tener variables independientes
        //declarar las variables luego los atributo y al final los metodos
        //
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class multiplicar : operacion//los : dan permiso de usuar lo que tiene operacion 
    {
        //las clases hijas tambien pueden tener sus prpias clases y metodo pueden tener variables independientes
        //declarar las variables luego los atributo y al final los metodos
        //
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class dividir : operacion//los : dan permiso de usuar lo que tiene operacion 
    {
        //las clases hijas tambien pueden tener sus prpias clases y metodo pueden tener variables independientes
        //declarar las variables luego los atributo y al final los metodos
        //
        public double operar(double v1, double v2)
        {
            double valor1 = v1;
            double valor2 = v2;
            double resultado;
            return resultado = valor1/ valor2;
        }
    }
    //constructor valor 1
    //COMENTARIO DE GUARDADO 
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
