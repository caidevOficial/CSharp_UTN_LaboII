using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210717_RSP___alumno
{
    public partial class FrmContador : Form
    {
        FrmCarrera carrera;
        public FrmContador()
        {
            InitializeComponent();
            this.carrera = new FrmCarrera();
        }

        /// <summary>
        /// Recorre la lista de imagenes y las asigna en el Picture Box
        /// al Finalizar llama al FRM de la carrera
        /// </summary>

        private void Contador()
        {
            foreach (Image item in this.imgSemaforo.Images)
            {
                this.pbNumeros.Image = item;
                this.pbNumeros.Refresh();
                Thread.Sleep(2000);
            }

            this.carrera.ShowDialog();
            this.Hide();
            if(this.carrera.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.ShowDialog();
            }
        }


        private void FrmContador_Shown(object sender, EventArgs e)
        {
            //al mostrarse el FORM inicio el conteo
            this.Contador();
        }
    }
}
