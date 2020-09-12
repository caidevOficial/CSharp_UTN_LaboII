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
    public partial class MessageForm : Form
    {
        //private string mensaje;
        public MessageForm(string mensaje)
        {
            InitializeComponent();
            
            this.labelSaludo.Text = mensaje;
            
        }
        public string Mensaje {
            get{
                return this.labelSaludo.Text;
            }
            set{
                this.Text.Trim(); // revisar
               this.labelSaludo.Text = value;
            }
        }

       
    }
}
