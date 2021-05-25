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

namespace Ejercicio_55_Forms {
    public partial class frmMostrar : Form {

        private Llamada.TipoLlamada callType;
        private Centralita myCentral;

        #region Builders

        /// <summary>
        /// Builds the entity and initialize it's components.
        /// </summary>
        public frmMostrar() {
            InitializeComponent();
        }

        /// <summary>
        /// Builds the entity and shows in the form the info about the billings 
        /// of the Phone company.
        /// </summary>
        /// <param name="frmMenuCentralita"></param>
        public frmMostrar(Centralita frmMenuCentralita) : this() {
            myCentral = frmMenuCentralita;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Set: Sets the type of the call.
        /// </summary>
        public Llamada.TipoLlamada SetCallType {
            set {
                callType = value;
            }
        }

        #endregion

        #region LoadEvents

        /// <summary>
        /// Loads the form and shows the info that need to show.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrar_Load(object sender, EventArgs e) {
            if (callType is Llamada.TipoLlamada.Local) {
                richTextBox.Text = "Local: $ " + (Math.Round(myCentral.GananciasPorLocal, 2)).ToString();
            } else if (callType is Llamada.TipoLlamada.Provincial) {
                richTextBox.Text = "Prov: $ " + (Math.Round(myCentral.GananciasPorProvincial, 2)).ToString();
            } else {
                richTextBox.Text = "All: $ " + (Math.Round(myCentral.GananciasPorTotal, 2)).ToString();
            }
        }

        #endregion

        #region CloseEvents

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrar_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit the Billing Screen?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            } else {
                this.Dispose();
            }
        }

        #endregion

    }
}
