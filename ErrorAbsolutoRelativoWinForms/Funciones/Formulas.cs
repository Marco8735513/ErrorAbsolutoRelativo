using ErrorAbsolutoRealtivo.core.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAbsolutoRealtivo.core.Funciones
{
    public class Formulas
    {
        // Recordemos que el error absoluto es igual al valor verdadero menos el valor aproximado
        //Las dos funciones aquí reciben un parametro de tipo objeto
        //Quiere decir cuando le pasemos argumento a la función, no importa el orden de los argumentos
        //Por que el modelo dice que valor es que cosa y no la función.
        public double ErrorAbsoluto(ModeloValores v)
        {

            //Math.Abs es para que el resultado siempre sea positivo, devuelve el valor absoluto de un numero
            return Math.Abs(v.ValorVerdadero - v.ValorAproximado);

        }

        // Y pues el error relativo es igual al valor verdadero menos el valor aproximado entre el valor verdadero
        public double ErrorRelativo(ModeloValores vr)
        {
            return (Math.Abs(vr.ValorVerdadero - vr.ValorAproximado) / Math.Abs(vr.ValorVerdadero));
        }

    }
}
