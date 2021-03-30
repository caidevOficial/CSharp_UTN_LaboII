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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper;

namespace Practica_WF_MiniSuper
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Location = this.Location;
            // Solo te deja interactuar con esa ventana - manera modal
            if(frmAltaUsuario.ShowDialog() == DialogResult.OK)
            {
                // Agrego el usuario a la lista
                MiniSuper.MiniSuper.AddUsuarios(frmAltaUsuario.GetUsuario());
            }

            // listo los usuarios del market
            comboBoxUsuarios.DataSource = null;
            comboBoxUsuarios.DataSource = MiniSuper.MiniSuper.GetUsuarios();
        }

        /// <summary>
        /// Aca se maneja el contexto previo al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si cancela el alert, no sale del form.
            if(MessageBox.Show("Seguro que desea Salir?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
            
        }
    }
}
