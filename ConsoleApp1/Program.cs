using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Introduccion1
    {
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static string CortarCadena(string cadena)
        {
            string resultado = cadena.Substring(0, cadena.Length - 4);
            return resultado;
        }

        public static string ObtenerFechaActual()
        {
            string date = DateTime.Now.ToString("dd-MM-yy hh:mm:ss");
            return date;
        }

        // Este es el comentario

        /**
         * Este es un super comentario
         */
    }
}
