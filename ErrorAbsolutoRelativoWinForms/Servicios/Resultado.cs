using ErrorAbsolutoRealtivo.core.Funciones;
using ErrorAbsolutoRealtivo.core.Modelo;
using System;

namespace ErrorAbsolutoRealtivo.core
{
    public class ResultadoErrores : Formulas
    {

        // La palabra readonly indica que solo pueden asignar una vez ya sea al declaralos a en el constructor
        //Aquí alamacenamos una instancia de la clase formulas
        private readonly Formulas _formulas;
        private readonly ModeloResultado _resultado;

        //Constructor de la clase
        public ResultadoErrores()
        {
            _formulas = new Formulas();
            _resultado = new ModeloResultado();

        }

        //Como es un meotdo que va a retornar un objeto al final hacemos return new Resultado
        public ModeloResultado CalcularErrores(ModeloValores v)
        {
            //Si los valores que recibimos en el metodo Calcular Errores son null mandamos este mensaje

            if (v == null)
                throw new ArgumentNullException(nameof(v), "No se aceptan valores null, intentalo de nuevo");

            //Creamo un objeto y le damos valores a sus atributos
            // En este caso los atributos reciben v como valor 

            ModeloValores valores = new ModeloValores()
            {
                ValorVerdadero = v.ValorVerdadero,
                ValorAproximado = v.ValorAproximado
            };

            //Accedemos a los metodos a traves de la instancia _formulas y las guardamos en variables
            double errorAbs = _formulas.ErrorAbsoluto(v);
            double errorRel = _formulas.ErrorRelativo(v);

            //Como el metodo es de tipo Objeto Resultado, devolvemos un nuevo Objeto Resultado - new Resultado
            //El objeto resultado tiene atributos que son ErrorAbsoluto y Error Relativo, pues le pasamos el valor
            //que se guardo en las variables de arriba
            return new ModeloResultado
            {

                ErrorAbsoluto = errorAbs,
                ErrorRelativo = errorRel

            };

        }



    }
}
