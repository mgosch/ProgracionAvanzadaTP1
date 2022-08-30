using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Introduccion1

    {
        static void Main(string[] args)
        {
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static string CortarCadena(string cadena)
        {
            string resultado = cadena.Substring(0, cadena.Length - 4);
            return resultado;
        }
    }
}
