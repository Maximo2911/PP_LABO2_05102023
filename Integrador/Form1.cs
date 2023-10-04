using Entidades;

namespace Integrador
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            // Vincula el manejador de eventos FormClosing
            this.FormClosing += Calculadora_FormClosing;
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en el centro de la pantalla
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numeracion primerOperando = new(Numeracion.ESistema.Decimal, txtPrimerOperador.Text);
            Numeracion segundoOperando = new(Numeracion.ESistema.Decimal, txtSegundoOperador.Text);
            string operador = cmbOperacion.Text;
            Operacion operacion = new(primerOperando, segundoOperando);

            //if(operacion == null )
            //{
            //    operador = "+";
            //}

            if (rdbBinario.Checked)
            {

                int resultado = operacion.OperacionNumeros(primerOperando, segundoOperando, operador[0]);
                Numeracion resultadoOperacion = new(Numeracion.ESistema.Decimal, (double)resultado);
                string retorno = resultadoOperacion.ConvertirA(Numeracion.ESistema.Binario);
                lblResultado.Text = $"Resultado: {retorno}";

            }

            if (rdbDecimal.Checked)
            {
                int longitud = operador.Length;
                int resultado;
                if(longitud == 0)
                {
                    resultado = operacion.OperacionNumeros(primerOperando, segundoOperando, '+');
                }
                else
                {
                    resultado = operacion.OperacionNumeros(primerOperando, segundoOperando, operador[0]);
                }
                lblResultado.Text = $"Resultado: {resultado}";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Text = "";
            txtSegundoOperador.Text = "";
            lblResultado.Text = $"Resultado:";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("Seguro quieres cerrar la Calculadora?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario elige "No", cancela el evento de cierre
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}