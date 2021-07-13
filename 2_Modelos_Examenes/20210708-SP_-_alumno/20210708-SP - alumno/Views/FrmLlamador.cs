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

namespace Views
{
    public partial class FrmLlamador : Form
    {
        public FrmLlamador(List<Paciente> pacientes)
        {
            InitializeComponent();
        }

        private void FrmLlamador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
        }
    }
}
