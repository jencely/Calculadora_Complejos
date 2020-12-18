using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatematicaNegocio;
namespace Matematica.Test
{
    [TestClass] //metada atributo de la clase (esa clase es una clase de pruebas)
    public class CalculadoraTest
    {
       
           /* [TestMethod]
            public void Suma_dos_numeros()
            {  //preparacion de la prueba
                var primerNumero = 18;
                var segundoNumero = 3.7;
                var esperando = 21.7;

                var miCalculador = new Calculadora();
                var resultado = miCalculador.SumarComplejo(primerNumero, segundoNumero);
                //verificacion de la prueba
                Assert.AreEqual(esperando, resultado);
            }
            [TestMethod]
            public void SumaComplejos()
            {
                var primerComplejo = new Complejo(3, 2);
                var segundoComplejo = new Complejo(1.5, 6);

                var esperandoComplejo = new Complejo(4.5, 8);
                var miCalculador = new Calculadora();
                var resultado = miCalculador.SumarComplejo(primerComplejo, segundoComplejo);

                // Assert.AreEqual(esperandoComplejo.Real, resultado.Real);
                //Assert.AreEqual(esperandoComplejo.Imaginaria, resultado.Imaginaria);
                Assert.IsTrue(esperandoComplejo.Equals(resultado));
            }
            [TestMethod]
            //[ExpectedException(typeof(ArgumentException))]
            public void DividirPorCero()
            {
                var dividendo = 5;
                var divisor = 0;
                var miCalculadora = new Calculadora();
                // _ = miCalculadora.Dividir(dividendo, divisor);

                Assert.ThrowsException<ArgumentException>(() => miCalculadora.DividirComplejo(dividendo, divisor));
            }
            public void DividirDosNumeros()
            {
                var primerNumero = 18;
                var segundoNumero = 3.7;
                var esperando = 3.25;

                var calculadora = new Calculadora();

                var resultado = calculadora.Dividir(primerNumero, segundoNumero);

                Assert.AreEqual(esperando, resultado);
            }*/
            [TestMethod]
        public void SumarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejo = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.SumarComplejo(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
        [TestMethod]
        public void RestarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 3);
            var segundoNumeroComplejo = new Complejo(1, 6);
            var esperadoComplejo = new Complejo(2, -3);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.RestarComplejo(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
        [TestMethod]
        public void MultiplicarComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejo = new Complejo(-7.5, 21);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.MultiplicarComplejo(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejo.X, resultado.X);
            Assert.AreEqual(esperadoComplejo.Y, resultado.Y);
        }
        [TestMethod]
        public void DividirComplejos()
        {
            var primerNumeroComplejo = new Complejo(3, 2);
            var segundoNumeroComplejo = new Complejo(1.5, 6);
            var esperadoComplejoReal = "16,5/38,25";
            var esperadoComplejoImaginaria = "-15/38,25";

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.DividirComplejo(primerNumeroComplejo, segundoNumeroComplejo);

            Assert.AreEqual(esperadoComplejoReal, resultado);
            Assert.AreEqual(esperadoComplejoImaginaria, resultado);
        }
        [TestMethod]
        public void MultiplicacionPorUnEscalar()
        {
            var numeroComplejo = new Complejo(3, 2);
            double numeroEscalar = 5;
            var resultadoEsperado = new Complejo(15, 10);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.MultiplicarComplejoEscalar(numeroComplejo, numeroEscalar);

            Assert.AreEqual(resultadoEsperado.X, resultado.X);
            Assert.AreEqual(resultadoEsperado.Y, resultado.Y);
        }
    }
}