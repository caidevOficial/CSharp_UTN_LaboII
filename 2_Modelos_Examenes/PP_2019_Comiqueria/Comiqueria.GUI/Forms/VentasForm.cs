﻿/*
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
    public partial class VentasForm : Form {

        private Comiqueria thisComiqueria;
        private Producto selectedProd;

        public VentasForm() {
            InitializeComponent();
        }

        public VentasForm(Comiqueria c, Producto p)
            : this() {
            this.thisComiqueria = c;
            this.selectedProd = p;
        }

        private void VentasForm_Load(object sender, EventArgs e) {
            lblDescripcion.Text = selectedProd.Descripcion;
            this.UpdatePrice();
        }

        private void UpdatePrice() {
            double finalPrice = Venta.CalcularPrecioFinal(selectedProd.Precio, (int)numCantidad.Value);
            lblPrecio.Text = $"Precio: ${Math.Round(finalPrice, 2)}";
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e) {
            this.UpdatePrice();
        }

        private void btnVender_Click(object sender, EventArgs e) {
            if ((int)numCantidad.Value <= selectedProd.Stock) {
                thisComiqueria.Vender(selectedProd, (int)numCantidad.Value);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show($"Venta Exitosa de {selectedProd.Descripcion}", "Cash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            } else {
                MessageBox.Show("Stock Limit Exceeded", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Seguro que desea cancelar?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
