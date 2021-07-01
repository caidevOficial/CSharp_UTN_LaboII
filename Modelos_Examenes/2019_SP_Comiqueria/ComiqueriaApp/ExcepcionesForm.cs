using System;
using System.Text;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class ExcepcionesForm : Form
    {
        private Exception exception;

        public ExcepcionesForm(Exception exception)
        {
            InitializeComponent();
            this.exception = exception;
            if(this.exception.InnerException == null)
            {
                this.btnDetalles.Enabled = false;
            }
        }

        private void ExcepcionesForm_Load(object sender, EventArgs e)
        {
            this.lblMessage.Text = exception.Message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Exception innerException = this.exception.InnerException;
            while(innerException != null)
            {
                sb.AppendLine(innerException.Message);
                innerException = innerException.InnerException;
            }

            MessageBox.Show(sb.ToString(), "Detalle de Error", MessageBoxButtons.OK);
        }
    }
}
