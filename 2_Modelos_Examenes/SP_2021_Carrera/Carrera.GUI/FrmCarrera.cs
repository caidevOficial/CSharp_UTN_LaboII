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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace _20210717_RSP___alumno {

    public partial class FrmCarrera : Form {

        private Carrera carrera;
        private Thread thread;
        private AutoF1 v1;
        private AutoF1 v2;


        public FrmCarrera() {
            InitializeComponent();
            this.pcbAutoUno.Image = this.imgListAutos.Images[0];
            this.pcbAutoDos.Image = this.imgListAutos.Images[0];
        }

        private void InitializeAutosYCarrera() {
            Random random = new Random();
            this.v1 = new AutoF1("Ferrari", random.Next(5, 20), this.pcbAutoUno.Location.X);
            Thread.Sleep(2000);//pongo un sleep para el random
            this.v2 = new AutoF1("Renault", random.Next(5, 20), this.pcbAutoDos.Location.X);

            this.carrera = new Carrera(this.Size.Width); //instancion la carrera y le envio el maximo del form

            //Agrego vehiculos a la carrera
            this.carrera += v1;
            this.carrera += v2;

        }

        private void FrmCarrera_Shown(object sender, EventArgs e) {
            //Alumno:Instanciar Hilo secundario
            thread = new Thread(this.carrera.IniciarCarrera);
            thread.Start();
        }

        /// <summary>
        /// Dibuja el avance de los autos
        /// </summary>
        private void AvanzarAuto() {
            //Alumno:Metodo que maneja el evento InformarAvance
            if(this.InvokeRequired) {
                this.pcbAutoUno.BeginInvoke(
                    (MethodInvoker)delegate {
                        this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
                        this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);
                    });
            } else {
                this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
                this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);
            }
            Thread.Sleep(500);
        }

        /// <summary>
        /// Metodo donde se agregaran los manejadores al evento de carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCarrera_Load(object sender, EventArgs e) {
            this.InitializeAutosYCarrera();
            //Alumno:Metodo donde se agregaran los manejadores al evento de carrera
            this.carrera.InformarAvance += AvanzarAuto;
            this.carrera.InformarLlegada += ImprimirMensaje;

        }

        /// <summary>
        /// Imprime los mensajes de llegada
        /// </summary>
        /// <param name="mensaje"></param>
        private void ImprimirMensaje(string mensaje) {
            //Alumno:Metodo que maneja el evento InformarLlegada
            MessageBox.Show(mensaje, "Llegadas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        /// <summary>
        /// EventHandler form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCarrera_FormClosing(object sender, FormClosingEventArgs e) {
            //Alumno:serializar carrera
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\carrera.xml";
            GestorDeArchivos gestor = new GestorDeArchivos(path);
            this.DialogResult = DialogResult.OK; //Establezco el resultado en OK para finalizar el primer FORM
            try {
                if(!(this.thread is null) && this.thread.IsAlive) {
                    this.thread.Abort();
                }
                this.carrera.InformarAvance -= AvanzarAuto;
                this.carrera.InformarLlegada -= ImprimirMensaje;
                gestor.Guardar(this.carrera);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
