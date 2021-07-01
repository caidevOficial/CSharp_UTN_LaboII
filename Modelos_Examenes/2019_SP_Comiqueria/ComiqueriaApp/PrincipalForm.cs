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
using System.Threading;
using System.Windows.Forms;

namespace ComiqueriaApp {
    public partial class PrincipalForm : Form {
        private Comiqueria comiqueria;
        //Utilice este campo para acceder al producto seleccionado actualmente. 
        private Producto productoSeleccionado;
        private Thread timeThread;
        public delegate void DelegadoHora(string dato);
        public event DelegadoHora myEvent;

        #region No modificar este código
        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="comiqueria"></param>
        public PrincipalForm() {
            InitializeComponent();
            this.comiqueria = new Comiqueria();
            this.comiqueria.productosListChanged += ActualizarLista;
        }

        /// <summary>
        /// Manejador del evento Load del formulario. Inicializará los controles del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalForm_Load(object sender, EventArgs e) {
            this.InicializarFechaHora();
            this.ActualizarLista();
        }

        /// <summary>
        /// Actualiza el ListBox de productos y la lista de ventas.
        /// </summary>
        private void ActualizarLista() {
            try {
                this.richTextBoxVentas.Text = this.comiqueria.ListarVentas();
                this.listBoxProductos.DataSource = null;
                this.listBoxProductos.Refresh();
                this.listBoxProductos.DataSource = this.comiqueria.Productos;
                this.listBoxProductos.DisplayMember = "Descripcion";

                if (this.comiqueria.Productos.Count > 0) {
                    this.listBoxProductos.SelectedIndex = 0;
                    this.ActualizarProductoSeleccionado();
                }
            } catch (Exception ex) {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Actualiza el campo ProductoSeleccionado cuando se selecciona otro producto de la lista.
        /// </summary>
        private void ActualizarProductoSeleccionado() {
            try {
                this.productoSeleccionado = (Producto)this.listBoxProductos.SelectedValue;
                if (productoSeleccionado != null) {
                    this.richTextBoxDetalle.Text = this.productoSeleccionado.ToString();
                }
            } catch (Exception ex) {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Manejador del evento SelectedIndexChanged del ListBox de productos. 
        /// Mantendrá el campo "productoSeleccionado" actualizado con el producto seleccionado actualmente por el usuario.
        /// Y actualizará el texto del richTextBox de detalle. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxProductos_SelectedIndexChanged(object sender, EventArgs e) {
            ActualizarProductoSeleccionado();
        }

        /// <summary>
        /// Manejador del evento click del botón vender. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVenderClick(object sender, EventArgs e) {
            try {
                Form ventasForm = new VentasForm(this.comiqueria, productoSeleccionado);
                DialogResult result = ventasForm.ShowDialog();
                if (result == DialogResult.OK) {
                    this.richTextBoxVentas.Text = this.comiqueria.ListarVentas();
                }
            } catch (Exception ex) {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Manejador del evento OnClick del btnModificar.
        /// Abre el ModificarProductoForm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e) {
            ModificarProductoForm form = new ModificarProductoForm(this.productoSeleccionado);
            form.ShowDialog();
        }

        /// <summary>
        /// Manejador del evento OnClick del btnAgregar.
        /// Abre el AgregarProductoForm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e) {
            AgregarProductoForm form = new AgregarProductoForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abre el ExcepcionesForm para mostrar el error al usuario.
        /// </summary>
        /// <param name="ex"></param>
        private void ManejarExcepciones(Exception ex) {
            ExcepcionesForm form = new ExcepcionesForm(ex);
            form.ShowDialog();
        }
        #endregion

        /// <summary>
        /// Manejador del evento OnClick del btnEliminar.
        /// Elimina el producto seleccionado de la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e) {
            try {
                if (!(listBoxProductos.SelectedItem is null)) {
                    DialogResult result = MessageBox.Show("¿Seguro desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes) {
                        // 4B - Realizar una baja física del producto seleccionado en la tabla de productos. 

                        productoSeleccionado = (Producto)listBoxProductos.SelectedItem;
                        ConnectionDAO.DeleteProduct(productoSeleccionado.Codigo);
                    } 
                } else {
                    MessageBox.Show("Ningun Producto Seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Assign the time to the label.
        /// </summary>
        /// <param name="dato">Time in string formato to assign.</param>
        private void AsignarHora(string dato) {
            if (this.lblFechaHora.InvokeRequired) {
                DelegadoHora dh = new DelegadoHora(AsignarHora);
                object[] objs = new object[] { dato };
                this.Invoke(dh, objs);
            } else {
                this.lblFechaHora.Text = dato;
            }
        }

        /// <summary>
        /// Initializes the time.
        /// </summary>
        private void IniciarHora() {
            for (; ; ) {
                myEvent.Invoke(DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// Inicializa el hilo que mantiene actualizada la fecha y la hora.
        /// </summary>
        private void InicializarFechaHora() {
            // Punto 9. Instanciar y correr un nuevo hilo que ejecute un método que actualice el “lblFechaHora” cada 1 segundo con la fecha y la hora actual. 
            if ((timeThread is null)) {
                timeThread = new Thread(IniciarHora);
                myEvent += AsignarHora;
            }
        }

        /// <summary>
        /// EventHandler OF Form Closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea Salir?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (timeThread.IsAlive) {
                    timeThread.Abort();
                }
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }
    }
}
