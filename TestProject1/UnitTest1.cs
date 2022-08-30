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
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestMethod2() {            
            // Dado            
            string a = "caramelo";
            string esperado = "cara";
            // Cuando            
            string resultado = Introduccion1.CortarCadena(a);
            // Entonces            
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Dado            
            string esperado = DateTime.Now.ToString("dd-MM-yy hh:mm");
            // Cuando            
            string resultado = Introduccion1.ObtenerFechaActual();
            // Entonces            
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Dado            
            string esperado = "Domingo";
            // Cuando            
            string resultado = Introduccion1.ObtenerDiaSemana(1);
            // Entonces            
            Assert.AreEqual(resultado, esperado);
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
            Assert.AreEqual(resultado, esperado);
        }
    }
}