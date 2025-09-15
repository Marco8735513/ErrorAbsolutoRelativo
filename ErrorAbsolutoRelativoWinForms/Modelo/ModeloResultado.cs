using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAbsolutoRealtivo.core.Modelo
{
    public class ModeloResultado
    {
        //Aquí declaramos como queremos que sean nuestros resultados, para despues darle el valor dado de un procedimiento
        public double ErrorAbsoluto { get; set; }

        public double ErrorRelativo { get; set; }

    }
}
