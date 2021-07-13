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

using EntidadesRPP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsAppTest {
    public partial class FrmPrincipal : Form {
        protected Hospital hospital;
        protected List<Personal> egresados;

        public FrmPrincipal() {
            InitializeComponent();

            ///Establecer con su apellido y nombre
            string alumno = "Facundo Falcone";

            MessageBox.Show(alumno);
            this.Text = alumno;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.hospital = "Fiorito";
            this.egresados = new List<Personal>();
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            FrmMedico frm = new FrmMedico();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK) {
                this.hospital += frm.PersonalDelForm;
            }

            this.RefrescarListados();
        }

        private void RefrescarListados() {
            this.lstIngresado.Items.Clear();
            this.lstEgresado.Items.Clear();

            for (int i = 0; i < this.hospital.CantidadPersonal; i++) {
                this.lstIngresado.Items.Add(this.hospital[i].ToString());
            }

            foreach (Personal item in this.egresados) {
                this.lstEgresado.Items.Add(item.ToString());
            }
        }

        private void btnEgresar_Click(object sender, EventArgs e) {
            int i = this.lstIngresado.SelectedIndex;

            if (i > -1) {
                Personal obj = this.hospital[i];

                FrmMedicoEgresado frm = new FrmMedicoEgresado((Medico)obj);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog() == DialogResult.OK) {
                    this.hospital -= obj;
                    this.egresados.Add(frm.PersonalDelForm);

                    this.RefrescarListados();
                }
            }
        }

        private void cboOrdenarEgresados_SelectedIndexChanged(object sender, EventArgs e) {
            int i = this.cboOrdenarEgresados.SelectedIndex;
            Comparison<Personal> comparador = null;
            switch (i) {
                case 0:
                    //this.egresados.OrderBy(x => x.Legajo);
                    comparador = Personal.OrdenarPorLegajoASC;
                    break;
                case 1:
                    //this.egresados.OrderBy(x => x.Legajo*-1);
                    comparador = Personal.OrdenarPorLegajoDESC;
                    break;
                default:
                    break;
            }

            this.egresados.Sort(comparador);

            this.RefrescarListados();
        }

    }
}
