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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_61 {
    public partial class frmPersona : Form {

        Persona person;
        public frmPersona() {
            InitializeComponent();
            person = new Persona(String.Empty, String.Empty);
        }

        #region ButtonsEventHandler

        /// <summary>
        /// Event Handler of the button Save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtApellido.Text)) {
                txtNombre.Text = txtNombre.Text.Trim();
                txtApellido.Text = txtApellido.Text.Trim();
                person.Apellido = txtApellido.Text;
                person.Nombre = txtNombre.Text;
                PersonaDAO.Guardar(person);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Event Handler of the button Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e) {
            if (!(lbPersonas.SelectedItem is null)) {
                person.Nombre = txtNombre.Text;
                person.Apellido = txtApellido.Text;
                PersonaDAO.Modificar(person);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Event Handler of the button Delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            int id = 0;
            string[] items;
            if(!(lbPersonas.SelectedItem is null)) {
                items = lbPersonas.SelectedItem.ToString().Split(' ');
                id = Convert.ToInt32(items[0]);
                PersonaDAO.Borrar(id);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Event Handler of the button Read.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e) {
            UpdateListBox();
        }

        /// <summary>
        /// Event Handler of the double clic in the list Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPersonas_DoubleClick(object sender, EventArgs e) {
            string[] items;
            if (!(lbPersonas.SelectedItem is null)) {
                items = lbPersonas.SelectedItem.ToString().Split(' ');
                txtNombre.Text = items[1];
                txtApellido.Text = items[2];
                person.ID = Convert.ToInt32(items[0]);
            }
        }

        /// <summary>
        /// Updates the list Box View.
        /// </summary>
        private void UpdateListBox() {
            string personData;
            this.lbPersonas.Items.Clear();
            foreach (Persona item in PersonaDAO.Leer()) {
                personData = $"{item.ID} {item.Nombre} {item.Apellido}";
                this.lbPersonas.Items.Add(personData);
            }
        }

        #endregion
        
    }
}
