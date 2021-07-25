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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Exceptions;
using Extension;
using System.IO;
using Interfaces;
using System.Threading;

namespace SP.LABII._2021 {
    //Agregar manejo de excepciones en TODOS los lugares críticos!!!

    public partial class FrmSP : Form {
        private Zapato zapato;
        private Fosforo fosforo;
        private Remedio remedio;

        private Caja<Zapato> c_zapatos;
        private Caja<Fosforo> c_fosforos;
        private Caja<Remedio> c_remedios;

        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;
        private Thread myThread;

        public FrmSP() {
            InitializeComponent();

            this.dt = new DataTable("almacen");
            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        //Cambiar por su apellido y nombre
        private void FrmSP_Load(object sender, EventArgs e) {
            this.Text = "Falcone Facundo";
            MessageBox.Show(this.Text);
        }

        //Crear, en un class library, las siguientes clases:
        //Zapato-> tipo:string (público); marca:string; (público); precio:float (público); 
        //ToString():string (polimorfismo; reutilizar código) (mostrar TODOS los valores).
        //Fosforo-> tipo:string (público); marca:string; (público); precio:float (público); 
        //ToString():string (polimorfismo; reutilizar código) (mostrar TODOS los valores).
        //Remedio-> tipo:string (público); marca:string; (público); precio:float (público); 
        //ToString():string (polimorfismo; reutilizar código) (mostrar TODOS los valores).
        private void btnPunto1_Click(object sender, EventArgs e) {
            //Crear una instancia de cada clase e inicializar los atributos del form zapato, fosforo y remedio. 
            this.zapato = new Zapato("Náutico", "Kickers", 500);
            this.fosforo = new Fosforo("Madera", "3 patitos", 65);
            this.remedio = new Remedio("Aspirina", "Bayer", 100);

            MessageBox.Show(this.zapato.ToString());
            MessageBox.Show(this.fosforo.ToString());
            MessageBox.Show(this.remedio.ToString());
        }

        //Crear, en class library, la clase Caja<T> 
        //atributos: capacidad:int y elementos:List<T> (TODOS protegidos)        
        //Propiedades:
        //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
        //PrecioTotal:(sólo lectura) retorna el precio total de la caja (la suma de los precios de sus elementos).
        //Constructor
        //Caja(), Caja(int); 
        //El constructor por default es el único que se encargará de inicializar la lista.
        //Métodos:
        //ToString: Mostrará en formato de tipo string: 
        //el tipo de caja, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
        //de todos los elementos contenidos en la misma. Reutilizar código.
        //Sobrecarga de operadores:
        //(+) Será el encargado de agregar elementos a la caja, 
        //siempre y cuando no supere la capacidad máxima de la misma.
        private void btnPunto2_Click(object sender, EventArgs e) {
            try {
                this.c_zapatos = new Caja<Zapato>(3);
                this.c_fosforos = new Caja<Fosforo>(3);
                this.c_remedios = new Caja<Remedio>(2);

                this.c_zapatos += new Zapato("Mocasín", "Moscato", 850); ;
                this.c_zapatos += new Zapato("Charol", "Carlota", 600); ;
                this.c_zapatos += this.zapato;

                this.c_fosforos += this.fosforo;
                this.c_fosforos += new Fosforo("Cera", "Cerúmen", 50);

                this.c_remedios += this.remedio;
                this.c_remedios += this.remedio;

                MessageBox.Show(this.c_zapatos.ToString());
                MessageBox.Show(this.c_fosforos.ToString());
                MessageBox.Show(this.c_remedios.ToString());

            } catch (CajaLlenaException exe) {
                MessageBox.Show(exe.InformarNovedad());
            } catch (Exception ex) {
                //Agregar, para la clase CajaLlenaException, un método de extensión (InformarNovedad():string)
                //que retorne el mensaje de error
                MessageBox.Show(ex.Message);
            }
        }

        //Agregar un elemento a la caja de zapatos, al superar la cantidad máxima, 
        //lanzará un CajaLlenaException (diseñarla), cuyo mensaje explicará lo sucedido.
        private void btnPunto3_Click(object sender, EventArgs e) {
            try {
                this.c_zapatos += this.zapato;
            } catch (CajaLlenaException ex) {
                //Agregar, para la clase CajaLlenaException, un método de extensión (InformarNovedad():string)
                //que retorne el mensaje de error
                MessageBox.Show(ex.InformarNovedad());
            }
        }

        //Si el precio total de la caja supera los 120 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase caja. 
        //Adaptar la sobrecarga del operador +, para que lance el evento, según lo solicitado.
        //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total de la caja (en un nuevo renglón). 
        //Se deben acumular los mensajes. 
        //El archivo se guardará con el nombre 'facturas.log' en la carpeta 'Mis documentos' del cliente.
        //El manejador de eventos (c_fosforos_EventoPrecio) invocará al método (de clase) 
        //ImprimirFactura (se alojará en la clase Facturadora), que retorna un booleano 
        //indicando si se pudo escribir o no.
        private void btnPunto4_Click(object sender, EventArgs e) {
            try {
                //Asociar manejador de eventos (c_fosforos_EventoPrecio) aquí
                EventDelegatePrice myDelegate = new EventDelegatePrice(c_fosforos_EventoPrecio);
                this.c_fosforos.EventoPrecio += myDelegate;
                this.c_fosforos += new Fosforo("Madera", "Fragata", 60);
            } catch (Exception ex) {
                //Agregar, para la clase CajaLlenaException, un método de extensión (InformarNovedad():string)
                //que retorne el mensaje de error
                MessageBox.Show(ex.Message);
            }
        }

        private void c_fosforos_EventoPrecio(object sender, EventArgs e) {
            
            bool todoOK = Facturadora.ImprimirFactura(this.c_fosforos.PrecioTotal);

            if (todoOK) {
                MessageBox.Show("Factura impresa correctamente!!!");
            } else {
                MessageBox.Show("No se pudo imprimir la factura!!!");
            }
        }

        //Configurar el OpenFileDialog, para poder seleccionar el log de facturas
        private void btnVerLog_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            //titulo -> 'Abrir archivo de facturas'
            open.Title = "Abrir archivo de facturas";
            //directorio por defecto -> Mis documentos
            open.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";
            //tipo de archivo (filtro) -> .log
            open.Filter = "log files(*.log)|*.log";
            //extensión por defecto -> .log
            open.AddExtension = true;
            open.DefaultExt = ".log";
            //nombre de archivo (defecto) -> facturas
            open.FileName = "facturas";
            DialogResult rta = open.ShowDialog();//Reemplazar por la llamada al método correspondiente del OpenFileDialog
            string fullPath = $"{open.FileName}";

            if (rta == DialogResult.OK) {
                //leer el archivo seleccionado por el cliente y mostrarlo en txtVisorFacturas
                this.txtVisorFacturas.Text = Facturadora.ReadLog(fullPath);
            }
        }

        //Crear las interfaces (en class library): 
        //#.-ISerializa -> Xml() : bool
        //              -> Path{ get; } : string
        //#.-IDeserializa -> Xml(out zapato) : bool
        //Implementar (implícitamente) ISerializa zapato
        //Implementar (explícitamente) IDeserializa en zapato
        //El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con su apellido.nombre.zapato.xml
        //Ejemplo: Alumno Juan Pérez -> perez.juan.zapato.xml
        private void btnPunto5_Click(object sender, EventArgs e) {
            Zapato aux = null;

            if (this.zapato.Xml()) {
                MessageBox.Show("Zapato serializado OK");
            } else {
                MessageBox.Show("Zapato NO serializado");
            }

            if (((IDeserializa)this.zapato).Xml(out aux)) {
                MessageBox.Show("Zapato deserializado OK");
                MessageBox.Show(aux.ToString());
            } else {
                MessageBox.Show("Zapato NO deserializado");
            }
        }

        //Obtener de la base de datos (sp_lab_II_2021) el listado de elementos:
        //Tabla - elementos { id(autoincremental - numérico) - marca(cadena) - precio(numérico) - tipo(cadena) }.
        private void btnPunto6_Click(object sender, EventArgs e) {
            //Configurar el SqlConnection
            string conn = "Server =  localhost; Database = sp_lab_II_2021; Trusted_Connection = true; ";
            this.cn = new SqlConnection(conn);
            //Configurar el SqlDataAdapter (y su selectCommand)                        
            this.da = new SqlDataAdapter();
            string select = "SELECT * FROM elementos";
            this.da.SelectCommand = new SqlCommand(select, this.cn);

            this.da.Fill(this.dt);
            this.dataGridView1.DataSource = this.dt;
        }

        //Agregar en el dataTable los elementos del formulario (zapato, fosforo y remedio).
        private void btnPunto7_Click(object sender, EventArgs e) {
            //Configurar el insertCommand del SqlDataAdapter y sus parámetros
            string insert = "INSERT INTO elementos VALUES(@Marca, @Precio, @Tipo)";
            this.da.InsertCommand = new SqlCommand(insert, this.cn);
            this.da.InsertCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50, "marca");
            this.da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Real, 5, "precio");
            this.da.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "tipo");

            //Agregar los elementos del formulario al dataTable (crear filas)
            DataRow f1 = this.dt.NewRow();
            DataRow f2 = this.dt.NewRow();
            DataRow f3 = this.dt.NewRow();

            f1[1] = fosforo.Marca;
            f1[2] = fosforo.Precio;
            f1[3] = fosforo.Tipo;

            f2[1] = zapato.Marca;
            f2[2] = zapato.Precio;
            f2[3] = zapato.Tipo;

            f3[1] = remedio.Marca;
            f3[2] = remedio.Precio;
            f3[3] = remedio.Tipo;

            this.dt.Rows.Add(f1);
            this.dt.Rows.Add(f2);
            this.dt.Rows.Add(f3);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dt;

        }

        //Eliminar del dataTable el primer registro
        private void btnPunto8_Click(object sender, EventArgs e) {
            //Configurar el deleteCommand del SqlDataAdapter y sus parámetros

            //Borrar el primer registro del dataTable (borrado físico NO)
        }

        //Modificar del dataTable el último registro, cambiarlo por: marca:JohnFoos; precio:720
        private void btnPunto9_Click(object sender, EventArgs e) {
            //Configurar el updateCommand del SqlDataAdapter y sus parámetros

            //Modificar el último registro del dataTable
        }

        //Sincronizar los cambios (sufridos en el dataTable) con la base de datos
        private void btnPunto10_Click(object sender, EventArgs e) {
            try {
                //Sincronizar el SqlDataAdapter con la BD

                MessageBox.Show("Datos sincronizados!!!");
            } catch (Exception ex) {
                MessageBox.Show("No se ha sincronizado!!!\n" + ex.Message);
            }
        }

        //Threads
        //Iniciar un nuevo hilo que ejecute los manejadores de eventos de los botones del formulario
        //(FrmSP_Load, btnPunto1_Click, y btnPunto2_Click)
        private void btnHilos_Click(object sender, EventArgs e) {
            myThread = new Thread(ProbarTodo);
            myThread.Start();
        }

        private void ProbarTodo()//para el thread
        {
        }

        /// <summary>
        /// EventHandler form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSP_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes) {
                if (!(myThread is null) && myThread.IsAlive) {
                    myThread.Abort();
                }
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }

    }
}
