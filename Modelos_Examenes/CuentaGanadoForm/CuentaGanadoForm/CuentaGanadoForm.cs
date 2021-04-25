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

        decimal peopleQtty;
        decimal employeeQtty;
        Bar barDeMoe = new Bar();

        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if(this.employeeQtty <= numEmpleados.Value)
            {
                Random rd = new Random();
                Empleado mulo = new Empleado("Mozo", (short)rd.Next(21,90));
                if (barDeMoe + mulo)
                {
                    numGente.Value = barDeMoe.Empleados.Count;
                    employeeQtty = numEmpleados.Value;
                }
                else
                {
                    numEmpleados.Value = barDeMoe.Empleados.Count;
                }
            }
        }

        private void numGente_ValueChanged(object sender, EventArgs e)
        {

            decimal numeroActual = numGente.Value;
            if (peopleQtty <= numeroActual)
            {
                Gente gente = new Gente(50);
                if (barDeMoe + gente)
                {
                    //
                    peopleQtty = numeroActual;
                }
                else
                {
                    numGente.Value = barDeMoe.Gente.Count;
                }
            }

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInforme info = new frmInforme();
            info.Location = this.Location;
            info.Show();
        }

        private void CuentaGanadoForm_Load(object sender, EventArgs e)
        {
            peopleQtty = numGente.Value;
            employeeQtty = numEmpleados.Value;
        }
    }
}
