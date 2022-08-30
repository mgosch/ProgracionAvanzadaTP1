using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Dia { Domingo = 1, Lunes = 2, Martes = 3, Miercoles = 4, Jueves = 5, Viernes = 6, Sabado = 7 }
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

        public static string ObtenerFechaActual()
        {
            string date = DateTime.Now.ToString("dd-MM-yy hh:mm");
            return date;
        }

        // Este es el comentario

        /**
         * Este es un super comentario
         */

        public static string ObtenerDiaSemana(int i)
        {
            Dia dia = (Dia)i;
            return "Hoy es " + dia.ToString();
        }

        public static bool ConvertirABoolean(int a)
        {
            return Convert.ToBoolean(a);
        }

        public static bool BoolParseado(string a)
        {
            return bool.Parse(a);
        }

        public static bool TryParseado(string a)
        {
            return bool.TryParse(a, out bool resultado);
        }

        public static int ConvertDoubleAInt(double a)
        {
            return (int)a;
        }

        public static decimal ConvertIntADecimal(int a)
        {
            return a;
        }

        public static short ConvertIntAShort(int a)
        {
            return (short)a;
        }
    }
}
