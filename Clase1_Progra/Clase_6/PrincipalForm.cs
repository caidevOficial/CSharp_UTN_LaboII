using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clase_6
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Saludar_OnClick(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;
            string mensaje = $"Hola {nombre}";
            if (ValidarNombre(nombre))
            {
                
               nombre = nombre.Trim(); //elimina espacios en blanco del principio y del final
                MessageForm mensajeForm = new MessageForm(mensaje);
              
            }
            else {
                DialogResult result = MessageBox.Show("Desea Continuar?","Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.No) {
                    this.Close();
                }
            }
           
            MessageBox.Show($"Hola {nombre}","Saludo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }

        private bool ValidarNombre(string texto) {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
