using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Dado
            int a = 5;
            int b = 7;
            int esperado = 12;

            // Cuando
            int resultado = Introduccion1.Sumar(a, b) ;

            // Entonces
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod2() {            
            // Dado            
            string a = "caramelo";
            string esperado = "cara";
            // Cuando            
            string resultado = Introduccion1.CortarCadena(a);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Dado            
            string esperado = DateTime.Now.ToString("dd-MM-yy hh:mm");
            // Cuando            
            string resultado = Introduccion1.ObtenerFechaActual();
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Dado            
            string esperado = "Hoy es Domingo";
            // Cuando            
            string resultado = Introduccion1.ObtenerDiaSemana(1);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_5()
        {
            // Dado
            int verdadero = 1;
            bool esperado = true;
            // Cuando
            bool resultado = Introduccion1.ConvertirABoolean(verdadero);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_5_1()
        {
            // Dado
            int falso = 0;
            bool esperado = false;
            // Cuando
            bool resultado = Introduccion1.ConvertirABoolean(falso);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_6()
        {
            // Dado
            string falso = "false";
            bool esperado = false;
            // Cuando
            bool resultado = Introduccion1.BoolParseado(falso);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_6_1()
        {
            // Dado
            string verdadero = "true";
            bool esperado = true;
            // Cuando
            bool resultado = Introduccion1.BoolParseado(verdadero);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_7()
        {
            // Dado
            string falso = "falsete";
            bool esperado = false;
            // Cuando
            bool resultado = Introduccion1.TryParseado(falso);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_7_1()
        {
            // Dado
            string falso = "false";
            bool esperado = true;
            // Cuando
            bool resultado = Introduccion1.TryParseado(falso);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_8()
        {
            // Dado
            var number = 344.4;
            int esperado = 344;
            // Cuando
            int resultado = Introduccion1.ConvertDoubleAInt(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

       [TestMethod]
        public void TestMethod_8_1()
        {
            // Dado
            var number = 10;
            decimal esperado = 10;
            // Cuando
            decimal resultado = Introduccion1.ConvertIntADecimal(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

       [TestMethod]
        public void TestMethod_8_2()
        {
            // Dado
            int number = 443444;
            short esperado = -15308;
            // Cuando
            short resultado = Introduccion1.ConvertIntAShort(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestMethod_9()
        {
            // Dado
            Color miColor = Color.Azul;
            string esperado = "Este es Azul";
            // Cuando
            string resultado = Introduccion1.SwitchColor(miColor);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestMethod_10()
        {
            // Dado
            int number = 59;
            string esperado = "Es mayor a 10";
            // Cuando
            string resultado = Introduccion1.MayorQue10(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void TestMethod_10_1()
        {
            // Dado
            int number = 5;
            string esperado = "Error";
            // Cuando
            string resultado = Introduccion1.MayorQue10(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void TestMethod_11()
        {
            // Dado
            int number = 8;
            string esperado = "Este es ahora el valor de 53";
            // Cuando
            string resultado = Introduccion1.WhileIncrementar(number);
            // Entonces            
            Assert.AreEqual(esperado, resultado);
        }
    }
}