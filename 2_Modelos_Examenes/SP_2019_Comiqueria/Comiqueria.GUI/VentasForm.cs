using ComiqueriaLogic;
using System;
using System.Windows.Forms;

namespace ComiqueriaApp {
    public partial class VentasForm : Form {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="comiqueria">Instancia de la comiqueria.</param>
        /// <param name="productoSeleccionado">Producto seleccionado por el usuario en el PrincipalForm.</param>
        public VentasForm(Comiqueria comiqueria, Producto productoSeleccionado) {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
        }

        /// <summary>
        /// Manejador del evento OnLoad del formulario.
        /// Inicializará los controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasForm_Load(object sender, EventArgs e) {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            ActualizarPrecio();
        }

        /// <summary>
        /// Manejador del evento OnChanged del numericUpDownCantidad.
        /// Actualizará el lblPrecioFinal de acuerdo a la cantidad seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCantidadChanged(object sender, EventArgs e) {
            ActualizarPrecio();
        }

        /// <summary>
        /// Actualiza el lblPrecioFinal de acuerdo a la cantidad seleccionada del producto.
        /// </summary>
        private void ActualizarPrecio() {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSeleccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", nuevoPrecioFinal);
        }

        /// <summary>
        /// Manejador del evento OnClick del btnVender.
        /// Confirma y genera la venta del producto. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVenderClick(object sender, EventArgs e) {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);

            if (productoSeleccionado.Stock >= cantidadSeleccionada) {
                this.comiqueria.Vender(this.productoSeleccionado, cantidadSeleccionada);
                //productoSeleccionado.Stock -= cantidadSeleccionada;
                ConnectionDAO.UpdateData(productoSeleccionado);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("La cantidad indicada supera el stock disponible. Por favor, disminuya la cantidad.", "Stock Superado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manejador del evento click del botón cancelar.
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelarClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}
