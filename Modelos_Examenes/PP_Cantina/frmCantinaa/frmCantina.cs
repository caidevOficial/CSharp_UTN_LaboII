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

namespace frmCantinaa
{
    public partial class frmCantina : Form
    {
        public frmCantina()
        {
            InitializeComponent();
        }

        private void frmCantina_Load(object sender, EventArgs e)
        {
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            this.barra1.SetCantina = Cantina.GetCantina(10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtMarca.Text))
            {
                if (rbAgua.Checked)
                {
                    Agua dasani = new Agua((int)nudCapacidad.Value, txtMarca.Text, (int)nudContenido.Value);
                    this.barra1.AgregarBotella(dasani);
                    //MessageBox.Show("Agua Agregada!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cerveza andes = new Cerveza((int)nudCapacidad.Value, txtMarca.Text, (Botella.Tipo)cmbBotellaTipo.SelectedIndex, (int)nudContenido.Value);
                    this.barra1.AgregarBotella(andes);
                    //MessageBox.Show("Birrita Agregada!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCantina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ya te vas?", "Heeey!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }
    }
}
