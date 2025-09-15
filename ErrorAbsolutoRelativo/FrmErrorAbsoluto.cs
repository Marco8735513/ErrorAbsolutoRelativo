using ErrorAbsolutoRealtivo.core;
using ErrorAbsolutoRealtivo.core.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorAbsolutoRelativo
{
    public partial class FrmErrorAbsoluto: Form
    {
        public FrmErrorAbsoluto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {


                double valorVerdadero = double.Parse(txtValorVerdadero.Text);
                double valorAproximado = double.Parse(txtValorAproximado.Text);

                // Validar que sean números
                bool exito1 = double.TryParse(txtValorVerdadero.Text, out valorVerdadero);
                bool exito2 = double.TryParse(txtValorAproximado.Text, out valorAproximado);

                if (!exito1 || !exito2)
                {
                    MessageBox.Show("Por favor ingrese solo números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModeloValores v = new ModeloValores
                {
                    ValorVerdadero = valorVerdadero,
                    ValorAproximado = valorAproximado
                };

                ResultadoErrores servicio = new ResultadoErrores();

                //Aquí es para mostar valores
                //resultado es un objeto de tipo Resultado que tiene como valor el calculo de los errores, que reciben como parametoro
                // el objeto v de tipo Valores
                ModeloResultado resultado = servicio.CalcularErrores(v);

                //Modifican el label para mostrar el resultado
                lblErrorAbsoluto.Text = resultado.ErrorAbsoluto.ToString();
                lblErrorRelativo.Text = resultado.ErrorRelativo.ToString();

            }
            catch (FormatException)
            {
                // Si el usuario escribió letras o algo no convertible a número
                MessageBox.Show("Por favor ingrese solo números válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (Exception ex)
            {
                // Captura cualquier otro error inesperado
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
