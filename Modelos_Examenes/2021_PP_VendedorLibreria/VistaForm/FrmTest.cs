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

using Entidades;
using System;
using System.Windows.Forms;

namespace Falcone.Facundo._2D {
    public partial class FrmTest : Form {

        Vendedor elSujetoDeLasHistorietas;

        public FrmTest() {
            elSujetoDeLasHistorietas = new Vendedor("Jeff Albertson");
            InitializeComponent();
        }

        #region LoadEvent

        /// <summary>
        /// Hardcodea informacion al abrir el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_Load(object sender, EventArgs e) {

            // Instanciar objetos para el listBox
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            // Agrego al listBox
            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);

            // Cargo ventas para testear el richText
            //bool pudo = elTipoDelComic + p1;
            //pudo = elTipoDelComic + p2;
            //pudo = elTipoDelComic + p3;
            //pudo = elTipoDelComic + p4;
            //pudo = elTipoDelComic + p5;

        }

        #endregion

        #region CloseEvents

        /// <summary>
        /// Cierra el formulario preguntandole al usuario si evidentemetne quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Cierra el formulario preguntandole al usuario si evidentemetne quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea Salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }

        #endregion

        #region ButtonsEvents

        /// <summary>
        /// Carga en el rich text box la info de las ventas del vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerInforme_Click(object sender, EventArgs e) {
            rtbInforme.Text = Vendedor.InformeDeVentas(elSujetoDeLasHistorietas);
        }

        /// <summary>
        /// Realiza una venta nueva en caso de haber stock del producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e) {
            if(!(lstStock.SelectedItem is null)) {
                Publicacion nuevaVenta = (Publicacion)lstStock.SelectedItem;
                if (nuevaVenta.HayStock && elSujetoDeLasHistorietas + nuevaVenta) {
                    MessageBox.Show($"Venta Exitosa de {nuevaVenta.ToString()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("Out Of Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Selecciona un item para vender", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
