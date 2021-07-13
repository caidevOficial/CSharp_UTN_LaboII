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

using Models;
using System;
using System.Windows.Forms;

namespace Ejercicio_68 {
    public partial class frmPersona : Form {

        private Persona persona;

        public frmPersona() {
            InitializeComponent();
        }

        /// <summary>
        /// Notifies all the changes.
        /// </summary>
        /// <param name="cambio">Change occurred.</param>
        public static void NotificarCambio(string cambio) {
            MessageBox.Show($"{cambio}");
        }

        /// <summary>
        /// EventHandler of Button 'Crear'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e) {
            if (persona is null) {
                btnCrear.Text = "Actualizar";
                persona = new Persona();
                persona.EventoString += NotificarCambio;
            }
            persona.Apellido = txtApellido.Text;
            persona.Nombre = txtNombre.Text;
        }
    }
}
