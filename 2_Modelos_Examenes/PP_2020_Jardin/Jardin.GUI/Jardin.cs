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

namespace PP_Jardin {
    public partial class frmPrincipal : Form {
        Jardin garden;

        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            rtbSalidaDeTest.Text = garden.ToString();
        }

        private void frmJardin_Load(object sender, EventArgs e) {
            this.garden = new Jardin(100);
            bool pudo = this.garden + new Arbusto("Arbusto 1", 10);
            pudo = this.garden + new Arbusto("Arbusto 2", 15);
            pudo = this.garden + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
            pudo = this.garden + new Rosal("Rosa clásica", 25);
            pudo = this.garden + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.garden + new Banano("No carga", 1, "ARG028"))) {
                MessageBox.Show("ERROR", "Error en Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
