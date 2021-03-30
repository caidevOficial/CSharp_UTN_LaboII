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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewUser;

namespace Practica_WF_MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario user;

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string[] formasPago = new string[1];
            foreach (Control miControl in this.pnlFormaPago.Controls)
            {
                if(miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasPago, formasPago.Length + 1);
                    formasPago[formasPago.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            string tipoPago = String.Empty;
            foreach (Control miControl in this.groupBox_TipoPago.Controls)
            {
                if(miControl is RadioButton && ((RadioButton)miControl).Checked)
                {
                    tipoPago = miControl.Text;
                }
            }

            // para llenar el combo
            //this.comboBoxProvincia.DataSource = asignarle la coleccion

            string provincia = String.Empty;
            if(this.comboBoxProvincia.SelectedIndex == -1)
            {
                if(this.comboBoxProvincia.Text != String.Empty)
                {
                    provincia = this.comboBoxProvincia.Text;
                }
            }
            else
            {
                provincia = this.comboBoxProvincia.SelectedItem.ToString();
            }

            string name = this.txtNombre.Text;
            string surname = this.txtApellido.Text;
            decimal.TryParse(this.numDNI.Value.ToString(), out decimal dni);
            user = new Usuario(name, surname, dni.ToString(), formasPago, tipoPago, provincia);
            this.Close();
        }

        private void cbxEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.groupBox1.Visible = true;
                this.groupBox_TipoPago.Visible = true;
            }
            else
            {
                this.groupBox1.Visible = false;
                this.groupBox_TipoPago.Visible = false;
            }
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAceptar.Enabled = true;
        }
    }
}
