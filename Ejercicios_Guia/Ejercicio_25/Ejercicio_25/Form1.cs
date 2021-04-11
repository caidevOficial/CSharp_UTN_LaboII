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

using System;
using System.Windows.Forms;
using Number;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpBoxResult.Enabled = false;
        }

        /// <summary>
        /// Shows an error message with its icon and setted messages.
        /// </summary>
        /// <param name="errorMessage">Large string with the description of the message.</param>
        /// <param name="typeError">Short string with the tipe of the mesage.</param>
        private static void MessageError(string errorMessage, string typeError)
        {
            MessageBox.Show(errorMessage, typeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// On mouse leave, send a message if the Binary number is in invalid format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBinario_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBinario.Text))
            {
                MessageError("Valor invalido, por favor modifiquelo.", "Error: Binary");
                txtBinario.Focus();
            }
        }

        /// <summary>
        /// On mouse leave, send a message if the Decimal number is in invalid format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDecimal_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDecimal.Text))
            {
                MessageError("Valor invalido, por favor modifiquelo.", "Error: Decimal");
                txtBinario.Focus();
            }
        }

        /// <summary>
        /// On press button, tryes to convert a binary to a decimal number, then shows it in the txtResultadoDec.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBinario.Text))
            {
                NumeroBinario binaryNumber = (NumeroBinario)txtBinario.Text;
                txtResultadoDec.Text = ((NumeroDecimal)binaryNumber).GetDecimalNumber().ToString();
            }
            else
            {
                MessageBox.Show("Error while trying to convert the Binary to Decimal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// On press button, tryes to convert a Decimal to a Binary number, then shows it in the txtResultadoBin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtDecimal.Text) && Double.TryParse(txtDecimal.Text, out Double value))
            {
                NumeroDecimal decimalNumber = (NumeroDecimal)value;
                txtResultadoBin.Text = ((NumeroBinario)decimalNumber).GetBinaryNumber();
            }
            else
            {
                MessageBox.Show("Error while trying to convert the Decimal to Binary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
