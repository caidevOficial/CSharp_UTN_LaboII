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

namespace ComiqueriaApp
{
    public partial class AgregarProductoForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AgregarProductoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento OnChange del txtPrecio. Cargará el lblError con un string vacío.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Text = String.Empty;
        }

        /// <summary>
        /// Manejador del evento OnClick del btnAgregar. 
        /// Agrega un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string nuevaDescripcion = this.txtDescripcion.Text;
                double nuevoPrecio = Convert.ToDouble(this.txtPrecio.Text);
                int nuevoStock = (int)this.txtStock.Value;
                Producto myProduct = new Producto(nuevaDescripcion, nuevoStock, nuevoPrecio);
                // Punto 4A - Insertar los datos del nuevo producto en la tabla de productos.
                if (ConnectionDAO.InsertData(myProduct)) {
                    MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }

        /// <summary>
        /// Valida los datos ingresados para el nuevo producto.
        /// Cargará el lblError con una descripción del error en caso de que algún dato no sea válido.
        /// </summary>
        /// <returns>true si es válido, false si no lo es.</returns>
        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                this.lblError.Text = "Error. Debe ingresar una descripción.";
                return false;
            }

            double nuevoPrecio;
            if (!Double.TryParse(this.txtPrecio.Text, out nuevoPrecio))
            {
                this.lblError.Text = "Error. Debe ingresar un precio válido.";
                return false;
            }

            if (this.txtStock.Value < 0)
            {
                this.lblError.Text = "Error. El stock debe ser mayor o igual a 0.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Manejador del evento OnClick del btnCancelar. 
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
