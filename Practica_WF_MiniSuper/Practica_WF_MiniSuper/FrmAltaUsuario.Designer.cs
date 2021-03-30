
namespace Practica_WF_MiniSuper
{
    partial class FrmAltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuario));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cbxEfectivo = new System.Windows.Forms.CheckBox();
            this.cbxTarjeta = new System.Windows.Forms.CheckBox();
            this.cbxAplicacion = new System.Windows.Forms.CheckBox();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            this.groupBox_TipoPago = new System.Windows.Forms.GroupBox();
            this.optButton_Contado = new System.Windows.Forms.RadioButton();
            this.optButton_Cuotas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            this.pnlFormaPago.SuspendLayout();
            this.groupBox_TipoPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(12, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.Red;
            this.lblApellido.Location = new System.Drawing.Point(12, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.Red;
            this.lblDni.Location = new System.Drawing.Point(13, 69);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(66, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // numDNI
            // 
            this.numDNI.Location = new System.Drawing.Point(66, 69);
            this.numDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDNI.Minimum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(100, 20);
            this.numDNI.TabIndex = 7;
            this.numDNI.Value = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.Location = new System.Drawing.Point(66, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.ForeColor = System.Drawing.Color.Red;
            this.lblFormaPago.Location = new System.Drawing.Point(12, 92);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(79, 13);
            this.lblFormaPago.TabIndex = 9;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // cbxEfectivo
            // 
            this.cbxEfectivo.AutoSize = true;
            this.cbxEfectivo.ForeColor = System.Drawing.Color.Red;
            this.cbxEfectivo.Location = new System.Drawing.Point(3, 6);
            this.cbxEfectivo.Name = "cbxEfectivo";
            this.cbxEfectivo.Size = new System.Drawing.Size(65, 17);
            this.cbxEfectivo.TabIndex = 10;
            this.cbxEfectivo.Text = "Efectivo";
            this.cbxEfectivo.UseVisualStyleBackColor = true;
            this.cbxEfectivo.CheckedChanged += new System.EventHandler(this.cbxEfectivo_CheckedChanged);
            // 
            // cbxTarjeta
            // 
            this.cbxTarjeta.AutoSize = true;
            this.cbxTarjeta.ForeColor = System.Drawing.Color.Red;
            this.cbxTarjeta.Location = new System.Drawing.Point(74, 6);
            this.cbxTarjeta.Name = "cbxTarjeta";
            this.cbxTarjeta.Size = new System.Drawing.Size(59, 17);
            this.cbxTarjeta.TabIndex = 11;
            this.cbxTarjeta.Text = "Tarjeta";
            this.cbxTarjeta.UseVisualStyleBackColor = true;
            // 
            // cbxAplicacion
            // 
            this.cbxAplicacion.AutoSize = true;
            this.cbxAplicacion.ForeColor = System.Drawing.Color.Red;
            this.cbxAplicacion.Location = new System.Drawing.Point(139, 6);
            this.cbxAplicacion.Name = "cbxAplicacion";
            this.cbxAplicacion.Size = new System.Drawing.Size(75, 17);
            this.cbxAplicacion.TabIndex = 12;
            this.cbxAplicacion.Text = "Aplicacion";
            this.cbxAplicacion.UseVisualStyleBackColor = true;
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.Controls.Add(this.cbxTarjeta);
            this.pnlFormaPago.Controls.Add(this.cbxAplicacion);
            this.pnlFormaPago.Controls.Add(this.cbxEfectivo);
            this.pnlFormaPago.Location = new System.Drawing.Point(3, 108);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Size = new System.Drawing.Size(224, 33);
            this.pnlFormaPago.TabIndex = 13;
            // 
            // groupBox_TipoPago
            // 
            this.groupBox_TipoPago.Controls.Add(this.optButton_Cuotas);
            this.groupBox_TipoPago.Controls.Add(this.optButton_Contado);
            this.groupBox_TipoPago.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox_TipoPago.Location = new System.Drawing.Point(9, 146);
            this.groupBox_TipoPago.Name = "groupBox_TipoPago";
            this.groupBox_TipoPago.Size = new System.Drawing.Size(217, 54);
            this.groupBox_TipoPago.TabIndex = 14;
            this.groupBox_TipoPago.TabStop = false;
            this.groupBox_TipoPago.Text = "Tipo Pago";
            // 
            // optButton_Contado
            // 
            this.optButton_Contado.AutoSize = true;
            this.optButton_Contado.ForeColor = System.Drawing.Color.Red;
            this.optButton_Contado.Location = new System.Drawing.Point(7, 19);
            this.optButton_Contado.Name = "optButton_Contado";
            this.optButton_Contado.Size = new System.Drawing.Size(65, 17);
            this.optButton_Contado.TabIndex = 0;
            this.optButton_Contado.TabStop = true;
            this.optButton_Contado.Text = "Contado";
            this.optButton_Contado.UseVisualStyleBackColor = true;
            // 
            // optButton_Cuotas
            // 
            this.optButton_Cuotas.AutoSize = true;
            this.optButton_Cuotas.ForeColor = System.Drawing.Color.Red;
            this.optButton_Cuotas.Location = new System.Drawing.Point(123, 19);
            this.optButton_Cuotas.Name = "optButton_Cuotas";
            this.optButton_Cuotas.Size = new System.Drawing.Size(58, 17);
            this.optButton_Cuotas.TabIndex = 1;
            this.optButton_Cuotas.TabStop = true;
            this.optButton_Cuotas.Text = "Cuotas";
            this.optButton_Cuotas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProvincia);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(11, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provincias";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Cordoba",
            "Mendoza"});
            this.comboBoxProvincia.Location = new System.Drawing.Point(57, 17);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(97, 21);
            this.comboBoxProvincia.TabIndex = 0;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(245, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_TipoPago);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            this.pnlFormaPago.ResumeLayout(false);
            this.pnlFormaPago.PerformLayout();
            this.groupBox_TipoPago.ResumeLayout(false);
            this.groupBox_TipoPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numDNI;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.CheckBox cbxEfectivo;
        private System.Windows.Forms.CheckBox cbxTarjeta;
        private System.Windows.Forms.CheckBox cbxAplicacion;
        private System.Windows.Forms.Panel pnlFormaPago;
        private System.Windows.Forms.GroupBox groupBox_TipoPago;
        private System.Windows.Forms.RadioButton optButton_Cuotas;
        private System.Windows.Forms.RadioButton optButton_Contado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
    }
}