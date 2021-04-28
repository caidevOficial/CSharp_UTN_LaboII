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

using Temperaturas;
using System;
using System.Windows.Forms;

namespace Ejercicio_24 {
    public partial class Temperatures : Form {
        public Temperatures() {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            grpTemperatures.Enabled = false;
        }

        /// <summary>
        /// Shows an error message with its icon and setted messages.
        /// </summary>
        /// <param name="errorMessage">Large string with the description of the message.</param>
        /// <param name="typeError">Short string with the tipe of the mesage.</param>
        private static void MessageError(string errorMessage, string typeError) {
            MessageBox.Show(errorMessage, typeError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Buttons_Actions

        /// <summary>
        /// Converts the Temperature from F to C and K.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertF_Click(object sender, EventArgs e) {
            if (Double.TryParse(txtFahrenheit.Text, out double grades)) {
                Fahrenheit tempF = new Fahrenheit(grades);
                txtFtoF.Text = tempF.GetAmount().ToString() + "°F";
                txtFtoC.Text = ((Celsius)tempF).GetAmount().ToString() + "°C";
                txtFtoK.Text = ((Kelvin)tempF).GetAmount().ToString() + "°K";
            } else {
                MessageBox.Show("Olvidaste colocar la temperatura a convertir!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Converts the Temperature from C to F and K.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertC_Click(object sender, EventArgs e) {
            if (Double.TryParse(txtCelsius.Text, out double grades)) {
                Celsius tempC = new Celsius(grades);
                txtCtoF.Text = ((Fahrenheit)tempC).GetAmount().ToString() + "°F";
                txtCtoC.Text = tempC.GetAmount().ToString() + "°C";
                txtCtoK.Text = ((Kelvin)tempC).GetAmount().ToString() + "°K";
            } else {
                MessageBox.Show("Olvidaste colocar la temperatura a convertir!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Converts the Temperature from K to C and F.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertK_Click(object sender, EventArgs e) {
            if (Double.TryParse(txtKelvin.Text, out double grades)) {
                Kelvin tempK = new Kelvin(grades);
                txtKtoF.Text = ((Fahrenheit)tempK).GetAmount().ToString() + "°F";
                txtKtoC.Text = ((Celsius)tempK).GetAmount().ToString() + "°C";
                txtKtoK.Text = tempK.GetAmount().ToString() + "°K";
            } else {
                MessageBox.Show("Olvidaste colocar la temperatura a convertir!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region MouseLeave

        /// <summary>
        /// When the mouse leaves the box, if the values in it is wrong, shows an Error Message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFahrenheit_MouseLeave(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(txtFahrenheit.Text) || !Double.TryParse(txtFahrenheit.Text, out double temperature)) {
                txtFahrenheit.Focus();
                MessageError("Temperatura invalida!", "Error: Fahrenheit");
            }
        }

        /// <summary>
        /// When the mouse leaves the box, if the values in it is wrong, shows an Error Message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCelsius_MouseLeave(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(txtCelsius.Text) || !Double.TryParse(txtCelsius.Text, out double temperature)) {
                txtCelsius.Focus();
                MessageError("Temperatura invalida!", "Error: Celsius");
            }
        }

        /// <summary>
        /// When the mouse leaves the box, if the values in it is wrong, shows an Error Message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKelvin_MouseLeave(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(txtKelvin.Text) || !Double.TryParse(txtKelvin.Text, out double temperature)) {
                txtKelvin.Focus();
                MessageError("Temperatura invalida!", "Error: Kelvin");
            }
        }

        #endregion
    }
}
