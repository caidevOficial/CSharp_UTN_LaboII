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

using Audio;
using Entidades;
using System;
using System.Windows.Forms;

namespace _20201203 {
    public partial class D10S : Form {

        private Pic estado;
        private GolDelSiglo golDelSiglo;

        /// <summary>
        /// Basic constructor.
        /// </summary>
        public D10S() {
            InitializeComponent();
            golDelSiglo = new GolDelSiglo();
            Relato.Avanzar += MostrarGrafico;
        }

        /// <summary>
        /// Invokes the delegate.
        /// </summary>
        private void InvokeDelegate() {
            AvanceRelato relato = new AvanceRelato(MostrarGrafico);
            this.Invoke(relato);
        }

        /// <summary>
        /// Change the state of the Pic.
        /// </summary>
        private void ChangeState() {
            switch (estado) {
                case Pic.SePrepara:
                    this.picFondo.Visible = false;
                    break;
                case Pic.LaTieneMaradona:
                    pic1.Visible = true;
                    break;
                case Pic.ArrancaConLaPelota:
                    pic1.Visible = false;
                    pic2.Visible = true;
                    break;
                case Pic.DejaElTendal:
                    pic2.Visible = false;
                    pic3.Visible = true;
                    break;
                case Pic.VaATocarPara:
                    pic3.Visible = false;
                    pic4.Visible = true;
                    break;
                case Pic.Gooool:
                    pic4.Visible = false;
                    pic5.Visible = true;
                    break;
                case Pic.Festeja:
                    pic5.Visible = false;
                    this.picFondo.Visible = true;
                    this.picFondo.Visible = true;
                    estado--;
                    break;
            }
        }

        /// <summary>
        /// Muestra el grafico segun corresponda la imagen.
        /// </summary>
        private void MostrarGrafico() {
            if (this.InvokeRequired) {
                this.InvokeDelegate();
            } else {
                this.ChangeState();
                estado++;
            }
        }

        /// <summary>
        /// EventHandler del boton gol del siglo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGolDelSiglo_Click(object sender, EventArgs e) {
            try {
                golDelSiglo.IniciarJugada();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler del form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void D10S_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (!(golDelSiglo is null)) {
                    golDelSiglo.CerrarApp();
                }
                this.Dispose();
            }
        }

        /// <summary>
        /// Event Handler Del Boton Leer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerLog_Click(object sender, EventArgs e) {
            Logger log = new Logger();
            string messageFromTxt;
            string messageFromDB;

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Log.txt";
            if (log.Leer(path, out messageFromTxt) && ConnectionDAO.ReadLog(out messageFromDB)) {
                MessageBox.Show($"\t\tFile\n{messageFromTxt}\n\n\t\tDataBase\n{messageFromDB}");
            }
        }

        /// <summary>
        /// EventHandler Del Boton Guardar Log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarLog_Click(object sender, EventArgs e) {
            Logger log = new Logger();
            string message = $"Se disfruto el gol del siglo a las {DateTime.Now.ToShortTimeString()}";
            if (log.Guardar(message) && ConnectionDAO.InsertLog(message)) {
                MessageBox.Show("Logs guardado en Desktop y en BD", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
