using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ErrorAbsolutoRealtivo.core.Modelo;
using ErrorAbsolutoRealtivo.core;

namespace ErrorAbsolutoRelativoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularErrores_ValoresCorrectos()
        {

            //Creamos un objeto valores y le damos valores como si fuera directamente desde el front

            ModeloValores v = new ModeloValores
            {
                ValorVerdadero = 2.4,
                ValorAproximado = 4.3
            };

            ResultadoErrores servicio = new ResultadoErrores();

            // Calculamos errores
            ModeloResultado resultado = servicio.CalcularErrores(v);

            //Aquí Verificamos que los resultados sean correctos
            Assert.AreEqual(1.9, resultado.ErrorAbsoluto, 0.0001, "Error absoluto incorrecto");
            Assert.AreEqual(0.7917, resultado.ErrorRelativo, 0.0001, "Error relativo incorrecto");
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentNullException))]
        public void CalcularErrores_ValoresNulos_LanzaExcepcion()
        {
            //Creamos un objeto ResultadoErrores
            ResultadoErrores servicio = new ResultadoErrores();

            //Accedemos al metodo CalcularErrores, tiene que mandarno una expeción
            //Por eso mandamentos argumentos el valor null
            servicio.CalcularErrores(null);
        }

    }

}
