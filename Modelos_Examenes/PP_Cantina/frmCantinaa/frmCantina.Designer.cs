
namespace frmCantinaa
{
    partial class frmCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantina));
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra1 = new ControlCantina.Barra();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbCerveza.ForeColor = System.Drawing.Color.Red;
            this.rbCerveza.Location = new System.Drawing.Point(8, 362);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(86, 39);
            this.rbCerveza.TabIndex = 1;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbAgua.ForeColor = System.Drawing.Color.Red;
            this.rbAgua.Location = new System.Drawing.Point(8, 399);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(68, 39);
            this.rbAgua.TabIndex = 2;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(145, 335);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(254, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Botella Tipo";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(260, 334);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(89, 21);
            this.cmbBotellaTipo.TabIndex = 6;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.BackColor = System.Drawing.SystemColors.MenuText;
            this.nudCapacidad.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.nudCapacidad.ForeColor = System.Drawing.Color.Red;
            this.nudCapacidad.Location = new System.Drawing.Point(151, 399);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(62, 40);
            this.nudCapacidad.TabIndex = 7;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudContenido
            // 
            this.nudContenido.BackColor = System.Drawing.SystemColors.MenuText;
            this.nudContenido.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.nudContenido.ForeColor = System.Drawing.Color.Red;
            this.nudContenido.Location = new System.Drawing.Point(271, 399);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(58, 40);
            this.nudContenido.TabIndex = 8;
            this.nudContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(254, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(145, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Red;
            this.btnAgregar.Location = new System.Drawing.Point(379, 361);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 40);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(16, 16);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(581, 278);
            this.barra1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(438, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // frmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudContenido);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.rbCerveza);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno Facu Falcone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCantina_FormClosing);
            this.Load += new System.EventHandler(this.frmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

