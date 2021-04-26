using Entities;
using Entities.Classes;
using Entities.Classes.SubClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_DragonBall_Form
{
    public partial class frmVerPersonajes : Form
    {
        Heroe hero;
        Villano villain;

        public frmVerPersonajes()
        {
            InitializeComponent();
        }

        private void frmVerPersonajes_Load(object sender, EventArgs e)
        {
            cmbPersonajeDeLista.DataSource = DragonBallSuper.ListaPersonajes;

        }

        private void cmbPersonajeDeLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((Personaje)cmbPersonajeDeLista.SelectedItem is Heroe)
            {
                btnTransformar.Enabled = true;
                hero = ((Heroe)(cmbPersonajeDeLista.SelectedItem));
                if (hero.Saiyajin)
                {
                    btnAvatar.ImageIndex = 0;
                    lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                }
                //grpCharImage.BackgroundImage = 
            }
            else
            {
                btnTransformar.Enabled = false;
                villain = ((Villano)(cmbPersonajeDeLista.SelectedItem));
                btnAvatar.ImageIndex = 7;
                lblMensaje.Text = $"Power: {villain.PowerLevel}\n{villain.Mensaje}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hero = ((Heroe)(cmbPersonajeDeLista.SelectedItem));
            if ((Personaje)cmbPersonajeDeLista.SelectedItem is Heroe)
            {
                if (hero.Saiyajin)
                {
                    if (btnAvatar.ImageIndex < 6)
                    {
                        hero.Transformarse();
                        lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                        btnAvatar.ImageIndex++;

                    }
                    else
                    {
                        hero.Transformarse();
                        lblMensaje.Text = $"Power: {hero.PowerLevel}\n{hero.Mensaje}";
                        btnAvatar.ImageIndex = 0;
                    }
                }
            }
                
            
        }
    }
}
