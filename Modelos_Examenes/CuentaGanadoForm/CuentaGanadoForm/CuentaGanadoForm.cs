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

namespace CuentaGanadoForm
{
    public partial class CuentaGanadoForm : Form
    {
        Random rd = new Random();
        private Bar barDeMoe;

        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (barDeMoe.Empleados.Count < numEmpleados.Value)
            {
                //Empleado emple = new Empleado("Mozo", (short)rd.Next(21, 90));
                if (!(barDeMoe + (new Empleado("Mozo", (short)rd.Next(21, 90)))))
                {
                    MessageBox.Show($"No Agregado: {barDeMoe.Empleados.Count}"); // para testear
                }
                else
                {
                    MessageBox.Show($"Agregado: {barDeMoe.Empleados.Count}"); // para testear
                    numEmpleados.Maximum = barDeMoe.Empleados.Count + 1;
                }
            }
        }

        private void numGente_ValueChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInforme info = new frmInforme(barDeMoe);
            info.StartPosition = FormStartPosition.CenterParent;
            info.ShowDialog();
        }

        private void CuentaGanadoForm_Load(object sender, EventArgs e)
        {
            barDeMoe = Bar.GetBar();
            numGente.Maximum = barDeMoe.Empleados.Count * 10;
        }
    }
}
