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

using Currency;
using System;
using System.Windows.Forms;

namespace Ejercicio_23
{
    public partial class Conversor : Form
    {
        private bool locked;
        private bool lockedOK;
        public Conversor()
        {
            InitializeComponent();
            locked = false;
            lockedOK = false;
            btnConvertEuro.Enabled = false;
            btnConvertDolar.Enabled = false;
            btnConvertPeso.Enabled = false;
        }

        /// <summary>
        /// Toggles the lock / unlock state of the button and boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtBoxEuro.Text)) && !(String.IsNullOrWhiteSpace(txtBoxPeso.Text)) && !locked)
            {
                btnCotizacion.ImageIndex = 1; //Unlocked
                txtBoxPeso.Enabled = false;
                txtBoxEuro.Enabled = false;

                btnConvertEuro.Enabled = true;
                btnConvertDolar.Enabled = true;
                btnConvertPeso.Enabled = true;
                groupBoxCurrency.Enabled = true;
                lockedOK = true;
            }
            else
            {
                btnCotizacion.ImageIndex = 0; //Locked
                txtBoxPeso.Enabled = true;
                txtBoxEuro.Enabled = true;
                btnConvertEuro.Enabled = false;
                btnConvertDolar.Enabled = false;
                btnConvertPeso.Enabled = false;
                groupBoxCurrency.Enabled = false;
                lockedOK = false;
            }
            locked = !locked;
        }

        private static void MessageError(string errorMessage, string typeError)
        {
            MessageBox.Show(errorMessage, typeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// At the beggining of the app, it charges the dolar's cotization and blocks its txtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Conversor_Load(object sender, EventArgs e)
        {
            txtBoxDolar.Text = Dolar.GetCotizacion().ToString();
            txtBoxDolar.Enabled = false;
            groupBoxConvertions.Enabled = false;
            groupBoxCurrency.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            
            if(!lockedOK)
            {
                MessageError("You need to complete al the cotizations boxes", "Error");
            }
            else
            {
                
                if (Double.TryParse(txtEuro.Text, out double equivalentEuro))
                {
                    Euro myEuro = new Euro(equivalentEuro);
                    txtEuroAEuro.Text = myEuro.GetCantidad().ToString();
                    txtEuroADolar.Text = ((Dolar)myEuro).GetCantidad().ToString();
                    txtEuroAPeso.Text = ((Peso)myEuro).GetCantidad().ToString();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (!lockedOK)
            {
                MessageError("You need to complete al the cotizations boxes", "Error");
            }
            else
            {
                if (Double.TryParse(txtDolar.Text, out double equivalentDolar))
                {
                    Dolar myDolar = new Dolar(equivalentDolar);
                    txtDolarADolar.Text = myDolar.GetCantidad().ToString();
                    txtDolarAEuro.Text = ((Euro)myDolar).GetCantidad().ToString();
                    txtDolarAPeso.Text = ((Peso)myDolar).GetCantidad().ToString();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (!lockedOK)
            {
                MessageError("You need to complete al the cotizations boxes", "Error");
            }
            else
            {
                if (Double.TryParse(txtPeso.Text, out double equivalentPeso))
                {
                    Peso myPeso = new Peso(equivalentPeso);
                    txtPesosAEuro.Text = ((Euro)myPeso).GetCantidad().ToString();
                    txtPesosADolar.Text = ((Dolar)myPeso).GetCantidad().ToString();
                    txtPesosAPesos.Text = myPeso.GetCantidad().ToString();
                }
            }
        }

        /// <summary>
        /// Checks that the box isn't empty or null, then tries to convert its content to Double-type and sets the cotizacion of Euro, Otherwise sets the cotization in 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxEuro_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxEuro.Text) && Double.TryParse(txtBoxEuro.Text, out double equivalentEuro))
            {
                Euro.SetCotizacion(equivalentEuro);
            }
            else
            {
                txtBoxEuro.Focus();
                MessageError("Monto en Euros Invalido", "Error");
            }
        }

        /// <summary>
        /// Checks that the box isn't empty or null, then tries to convert its content to Double-type and sets the cotizacion of Peso, Otherwise sets the cotization in 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPeso_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxPeso.Text) && Double.TryParse(txtBoxPeso.Text, out double equivalentPeso))
            {
                Peso.SetCotizacion(equivalentPeso);
            }
            else
            {
                txtBoxPeso.Focus();
                MessageError("Monto en Pesos Invalido", "Error");
            }
        }
    }
}
