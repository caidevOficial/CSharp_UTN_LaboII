/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using ComiqueriaLogic;
using System;
using System.Windows.Forms;

namespace ComiqueriaApp {
    public partial class ModificarProductoForm : Form {

        #region Attributes

        private Producto miProducto;

        #endregion

        #region Builders

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        private ModificarProductoForm() {
            InitializeComponent();
            lblError.Text = String.Empty;
        }

        /// <summary>
        /// Constructor que recibe un producto
        /// </summary>
        /// <param name="p"></param>
        public ModificarProductoForm(Producto p)
            : this() {
            miProducto = p;
            txtPrecioActual.Text = (Math.Round(miProducto.Precio, 2)).ToString();
            lblDescripcion.Text = miProducto.Descripcion;
        }

        #endregion

        #region EventButtons

        /// <summary>
        /// Manejador de evento click de boton Modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e) {
            if (!double.TryParse(txtNuevoPrecio.Text, out double newPrice)) {
                lblError.Text = "Error. Debe ingresar un precio válido.";
            } else {

                if (MessageBox.Show("Modificar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    miProducto.Precio = Math.Round(newPrice, 2);
                    PrincipalForm.productoSeleccionado = miProducto;
                    this.DialogResult = DialogResult.OK;
                    btnCancelar_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Manejador de evento clic de boton cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region EventChanged

        /// <summary>
        /// Manejador de evento OnTextChanged de txtNuevoPrecio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e) {
            lblError.Text = String.Empty;
        }

        #endregion
    }
}
