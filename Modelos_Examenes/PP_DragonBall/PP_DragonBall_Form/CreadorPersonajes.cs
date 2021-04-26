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

using Entities.Classes.SubClasses;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PP_DragonBall_Form
{
    public partial class frmPrincipal : Form
    {

        Heroe hero;
        Villano villain;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbTipoPersonaje.Enabled = true;
            cmbTipoPersonaje.SelectedIndex = 0;
            cmbAtaques.DataSource = Enum.GetValues(typeof(EHabilidades));
            cmbOrigen.DataSource = Enum.GetValues(typeof(EOrigen));
            EHabilidades skills;
            Enum.TryParse<EHabilidades>(cmbAtaques.SelectedValue.ToString(), out skills);
            EOrigen origin;
            Enum.TryParse<EOrigen>(cmbAtaques.SelectedValue.ToString(), out origin);

        }

        private void cmbTipoPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPersonaje.SelectedIndex == 0)
            {
                grpVillain.Enabled = false;
                grpHero.Enabled = true;
            }
            else
            {
                grpVillain.Enabled = true;
                grpHero.Enabled = false;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int powerLevel = 10;
            List<EHabilidades> ataque = new List<EHabilidades>() { (EHabilidades)cmbAtaques.SelectedItem };
            if (cmbTipoPersonaje.SelectedIndex == 0)
            {
                if (!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtNivelPoder.Text))
                {
                    if (int.TryParse(txtNivelPoder.Text, out powerLevel))
                    {
                        hero = new Heroe(txtNombre.Text, powerLevel, ataque, chkSaiyan.Checked);
                        MessageBox.Show($"{hero.InfoPersonaje()}");
                    }
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtNivelPoder.Text))
                {
                    if (int.TryParse(txtNivelPoder.Text, out powerLevel))
                    {
                        villain = new Villano(txtNombre.Text, powerLevel, ataque, (EOrigen)cmbOrigen.SelectedItem, chkMaxPower.Checked);
                        MessageBox.Show($"{villain.InfoPersonaje()}");
                    }
                }
            }
        }
    }
}
