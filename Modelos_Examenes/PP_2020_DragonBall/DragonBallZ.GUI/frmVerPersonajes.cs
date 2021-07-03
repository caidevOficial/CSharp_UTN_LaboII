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

using Entities;
using Entities.Classes;
using Entities.Classes.SubClasses;
using System;
using System.Windows.Forms;

namespace PP_DragonBall_Form {
    public partial class frmVerPersonajes : Form {
        Heroe hero;
        Villano villain;

        public frmVerPersonajes() {
            InitializeComponent();
        }

        private void frmVerPersonajes_Load(object sender, EventArgs e) {
            cmbPersonajeDeLista.DataSource = DragonBallSuper.ListaPersonajes;

        }

        private void cmbPersonajeDeLista_SelectedIndexChanged(object sender, EventArgs e) {
            if ((Personaje)cmbPersonajeDeLista.SelectedItem is Heroe) {
                btnTransformar.Enabled = true;
                hero = ((Heroe)(cmbPersonajeDeLista.SelectedItem));
                if (hero.Saiyajin) {
                    btnAvatar.ImageIndex = 0;
                    lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                }
            } else {
                villain = ((Villano)(cmbPersonajeDeLista.SelectedItem));
                btnAvatar.ImageIndex = 7;
                lblMensaje.Text = $"Power: {villain.PowerLevel}\n{villain.Mensaje}";
            }
        }

        private void btnTransform_Click(object sender, EventArgs e) {
            if ((Personaje)cmbPersonajeDeLista.SelectedItem is Heroe) {
                if (hero.Saiyajin) {
                    if (btnAvatar.ImageIndex < 6) {
                        hero.Transformarse();
                        lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                        btnAvatar.ImageIndex++;

                    } else {
                        hero.Transformarse();
                        lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                        btnAvatar.ImageIndex = 0;
                    }
                }
            } else {
                string message = villain.Transformarse();
                villain.MaximoPoder = true;
                lblMensaje.Text = $"Power: {villain.PowerLevel}\n{message}";
            }
        }
    }
}
