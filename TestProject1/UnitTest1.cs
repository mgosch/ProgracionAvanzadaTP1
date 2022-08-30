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


    }
}