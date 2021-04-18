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

namespace Ejercicio_40_Forms
{
    public partial class frmLlamador : Form
    {
        Centralita myCentral;

        #region Builder

        /// <summary>
        /// Builds the entity, initialize it's components and updates it's attribute.
        /// </summary>
        /// <param name="frmMenuCentralita"></param>
        public frmLlamador(Centralita frmMenuCentralita)
        {
            myCentral = frmMenuCentralita;
            InitializeComponent();
            cmbFranja.Enabled = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the centralita of this form.
        /// </summary>
        public Centralita FrmLlamadorCentralita
        {
            get => myCentral;
        }

        #endregion

        #region CallButton

        /// <summary>
        /// Creates a call and add it in the Centralita.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            float duration;
            float billing;
            if (!String.IsNullOrWhiteSpace(txtNroDestino.Text) && !String.IsNullOrWhiteSpace(txtNroOrigen.Text))
            {
                duration = randomNumber.Next(1, 51);
                if (txtNroDestino.Text.StartsWith("#"))
                {
                    Provincial myProvinceCall = new Provincial(duration, txtNroOrigen.Text, txtNroDestino.Text, (Provincial.Franja)cmbFranja.SelectedIndex);
                    myCentral = myCentral + myProvinceCall;
                    MessageBox.Show("Llamada Provincial Generada con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    billing = (float)(randomNumber.NextDouble() + randomNumber.Next(0,5) + 0.5);
                    Local myLocalCall = new Local(txtNroOrigen.Text, txtNroDestino.Text, duration, billing);
                    myCentral = myCentral + myLocalCall;
                    MessageBox.Show("Llamada Local Generada con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                btnLimpiar_Click(sender, e);
            }
        }

        #endregion

        #region DialButtons

        /// <summary>
        /// Add in the txtNroDestino the number 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        /// <summary>
        /// Add in the txtNroDestino the number 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        /// <summary>
        /// Add in the txtNroDestino an Asterisk. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsterisc_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        /// <summary>
        /// Add in the txtNroDestino a Hashtag and enable the combo box. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHashtag_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
                // Carga
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                // Lectura
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        #endregion

        #region CleanEvent

        /// <summary>
        /// Cleans the data of the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = String.Empty;
            txtNroOrigen.Text = String.Empty;
            cmbFranja.SelectedIndex = -1;
            cmbFranja.Enabled = false;
        }

        #endregion

        #region CloseEvents

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// It asks the user if he wants to close the form, if he clicks on '' YES '', 
        /// it closes, if not, he returns to the execution of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the CallerForm?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                frmMenu.myCentralita = FrmLlamadorCentralita;
                Dispose();
            }
        }

        #endregion

    }
}
