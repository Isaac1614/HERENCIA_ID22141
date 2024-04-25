using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
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
        }
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
