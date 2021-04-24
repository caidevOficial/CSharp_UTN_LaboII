
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class CuentaGanadoForm : Form
    {
        

        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        
        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numGente_ValueChanged(object sender, EventArgs e)
        {
            //if(numGente.Value > )
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInforme info = new frmInforme();
            info.Location = this.Location;
            info.Show();
        }
    }
}
