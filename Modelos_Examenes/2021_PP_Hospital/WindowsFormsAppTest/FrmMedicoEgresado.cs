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


namespace WindowsFormsAppTest {
    public partial class FrmMedicoEgresado : FrmMedico {
        private MedicoEgresado medicoEgresado;

        public override Personal PersonalDelForm => this.medicoEgresado;

        public FrmMedicoEgresado() {
            InitializeComponent();
        }

        /// Implementar sobrecarga del constructor para recibir un médico,
        /// crear un médico egresado y mostrar su contenido (incluyendo el jornal).
        /// 
        public FrmMedicoEgresado(Medico medic) : this() {
            this.medicoEgresado = new MedicoEgresado(medic);
            this.txtApellido.Text = this.medicoEgresado.Apellido;
            this.txtLegajo.Text = this.medicoEgresado.Legajo.ToString();
            this.txtJornal.Text = this.medicoEgresado.Jornal.ToString();
            this.cboEspecialidad.SelectedItem = this.medicoEgresado.Especialidad;
            this.dtpFechaIngreso.Value = this.medicoEgresado.HorarioEntrada;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e) {
            base.btnAceptar_Click(sender, e);
        }
    }
}
