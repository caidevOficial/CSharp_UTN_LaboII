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

namespace PP_Receta
{

    public partial class FrmReceta : Form
    {
        Receta receta;

        public FrmReceta()
        {
            InitializeComponent();
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            this.receta = new Receta(45); 
            bool pudo = this.receta + new Rucula("Eruca sativa", 10); 
            pudo = this.receta + new Rucula("Diplotaxis muralis", 15); 
            pudo = this.receta + new QuesoAzul("Roquefort", 3, QuesoAzul.Procedencia.Francia); 
            pudo = this.receta + new QuesoAzul("Clásico", 5); 
            pudo = this.receta + new Pera("Dulce", 12, "Williams"); 
            if (this.receta + new Pera("Seca", 1, "Blanquilla")) 
            {
                MessageBox.Show("Error", "Error de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine("ERROR!"); 
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = receta.ToString();
        }
    }
}
