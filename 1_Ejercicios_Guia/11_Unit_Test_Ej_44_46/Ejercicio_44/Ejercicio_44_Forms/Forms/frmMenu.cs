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

using CentralitaHerencia;
using System;
using System.Windows.Forms;

namespace Ejercicio_40_Forms {
    public partial class frmMenu : Form {

        public static Centralita myCentralita;

        #region Builder

        /// <summary>
        /// Builds the entity and initializaes it's components.
        /// </summary>
        public frmMenu() {
            myCentralita = new Centralita("CentralitApp");
            InitializeComponent();
        }

        #endregion

        #region CloseEvents

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show($"Do you want to quit the CentralitApp?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            } else {
                Dispose();
            }
        }

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to quit the CentralitApp?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Dispose();
                Close();
            }
        }

        #endregion

        #region CallsGenerator

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarLlamada_Click(object sender, EventArgs e) {
            frmLlamador callForm = new frmLlamador(myCentralita);
            callForm.Location = this.Location;
            callForm.ShowDialog();
        }

        #endregion

        #region Billings

        /// <summary>
        /// Calculates and shows the total billings in another form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturacionTotal_Click(object sender, EventArgs e) {
            frmMostrar showForm = new frmMostrar(myCentralita);
            showForm.SetCallType = Llamada.TipoLlamada.Todas;

            showForm.Location = this.Location;
            showForm.ShowDialog();

        }

        /// <summary>
        /// Calculates and shows the Local billings in another form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturacionLocal_Click(object sender, EventArgs e) {
            frmMostrar showForm = new frmMostrar(myCentralita);
            showForm.SetCallType = Llamada.TipoLlamada.Local;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

        /// <summary>
        /// Calculates and shows the Provincial billings in another form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturacionProvincial_Click(object sender, EventArgs e) {
            frmMostrar showForm = new frmMostrar(myCentralita);
            showForm.SetCallType = Llamada.TipoLlamada.Provincial;

            showForm.Location = this.Location;
            showForm.ShowDialog();
        }

        #endregion

    }
}
