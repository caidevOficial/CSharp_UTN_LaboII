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
using System.Windows.Forms;

namespace WindowsFormsAppTest {
    public partial class FrmMedico : FrmPersonal {
        private Medico medico;

        public override Personal PersonalDelForm => this.medico;

        public FrmMedico() {
            InitializeComponent();
            /// Cargar el cboEspecialidad a partir del enumerado Especialidad
            this.cboEspecialidad.DataSource = Enum.GetValues(typeof(Especialidad));
            /// Establecer 'Pediatra' como valor predeterminado
            this.cboEspecialidad.SelectedIndex = 1;
            this.cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// Sobrescribir método virtual para crear un objeto de tipo Médico.
        protected override void btnAceptar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            int.TryParse(this.txtLegajo.Text, out int legajo);
            medico = new Medico(this.txtApellido.Text, legajo, this.dtpFechaIngreso.Value, (Especialidad)this.cboEspecialidad.SelectedItem);
        }
    }
}
