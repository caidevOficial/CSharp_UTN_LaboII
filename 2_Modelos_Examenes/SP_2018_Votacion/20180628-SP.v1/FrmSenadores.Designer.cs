namespace _20180628_SP.v1
{
    partial class FrmSenadores
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
            this.gpbSenado = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEsperando = new System.Windows.Forms.Label();
            this.lblEsperandoLabel = new System.Windows.Forms.Label();
            this.lblAbstenciones = new System.Windows.Forms.Label();
            this.lblNegativo = new System.Windows.Forms.Label();
            this.lblAfirmativo = new System.Windows.Forms.Label();
            this.lblAbstencionesLabel = new System.Windows.Forms.Label();
            this.lblNegativoLabel = new System.Windows.Forms.Label();
            this.lblAfirmativoLabel = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtLeyNombre = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSenado
            // 
            this.gpbSenado.ForeColor = System.Drawing.Color.White;
            this.gpbSenado.Location = new System.Drawing.Point(12, 35);
            this.gpbSenado.Name = "gpbSenado";
            this.gpbSenado.Size = new System.Drawing.Size(641, 209);
            this.gpbSenado.TabIndex = 0;
            this.gpbSenado.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEsperando);
            this.groupBox2.Controls.Add(this.lblEsperandoLabel);
            this.groupBox2.Controls.Add(this.lblAbstenciones);
            this.groupBox2.Controls.Add(this.lblNegativo);
            this.groupBox2.Controls.Add(this.lblAfirmativo);
            this.groupBox2.Controls.Add(this.lblAbstencionesLabel);
            this.groupBox2.Controls.Add(this.lblNegativoLabel);
            this.groupBox2.Controls.Add(this.lblAfirmativoLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblEsperando
            // 
            this.lblEsperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperando.ForeColor = System.Drawing.Color.White;
            this.lblEsperando.Location = new System.Drawing.Point(370, 146);
            this.lblEsperando.Name = "lblEsperando";
            this.lblEsperando.Size = new System.Drawing.Size(80, 31);
            this.lblEsperando.TabIndex = 7;
            this.lblEsperando.Text = "0";
            this.lblEsperando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsperandoLabel
            // 
            this.lblEsperandoLabel.AutoSize = true;
            this.lblEsperandoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperandoLabel.ForeColor = System.Drawing.Color.White;
            this.lblEsperandoLabel.Location = new System.Drawing.Point(7, 146);
            this.lblEsperandoLabel.Name = "lblEsperandoLabel";
            this.lblEsperandoLabel.Size = new System.Drawing.Size(194, 31);
            this.lblEsperandoLabel.TabIndex = 6;
            this.lblEsperandoLabel.Text = "ESPERANDO";
            // 
            // lblAbstenciones
            // 
            this.lblAbstenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstenciones.ForeColor = System.Drawing.Color.Yellow;
            this.lblAbstenciones.Location = new System.Drawing.Point(370, 106);
            this.lblAbstenciones.Name = "lblAbstenciones";
            this.lblAbstenciones.Size = new System.Drawing.Size(80, 31);
            this.lblAbstenciones.TabIndex = 5;
            this.lblAbstenciones.Text = "0";
            this.lblAbstenciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNegativo
            // 
            this.lblNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegativo.ForeColor = System.Drawing.Color.Red;
            this.lblNegativo.Location = new System.Drawing.Point(370, 65);
            this.lblNegativo.Name = "lblNegativo";
            this.lblNegativo.Size = new System.Drawing.Size(80, 31);
            this.lblNegativo.TabIndex = 4;
            this.lblNegativo.Text = "0";
            this.lblNegativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfirmativo
            // 
            this.lblAfirmativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfirmativo.ForeColor = System.Drawing.Color.Lime;
            this.lblAfirmativo.Location = new System.Drawing.Point(370, 23);
            this.lblAfirmativo.Name = "lblAfirmativo";
            this.lblAfirmativo.Size = new System.Drawing.Size(80, 31);
            this.lblAfirmativo.TabIndex = 3;
            this.lblAfirmativo.Text = "0";
            this.lblAfirmativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbstencionesLabel
            // 
            this.lblAbstencionesLabel.AutoSize = true;
            this.lblAbstencionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstencionesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lblAbstencionesLabel.Location = new System.Drawing.Point(7, 106);
            this.lblAbstencionesLabel.Name = "lblAbstencionesLabel";
            this.lblAbstencionesLabel.Size = new System.Drawing.Size(240, 31);
            this.lblAbstencionesLabel.TabIndex = 2;
            this.lblAbstencionesLabel.Text = "ABSTENCIONES";
            // 
            // lblNegativoLabel
            // 
            this.lblNegativoLabel.AutoSize = true;
            this.lblNegativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegativoLabel.ForeColor = System.Drawing.Color.Red;
            this.lblNegativoLabel.Location = new System.Drawing.Point(7, 65);
            this.lblNegativoLabel.Name = "lblNegativoLabel";
            this.lblNegativoLabel.Size = new System.Drawing.Size(182, 31);
            this.lblNegativoLabel.TabIndex = 1;
            this.lblNegativoLabel.Text = "NEGATIVOS";
            // 
            // lblAfirmativoLabel
            // 
            this.lblAfirmativoLabel.AutoSize = true;
            this.lblAfirmativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfirmativoLabel.ForeColor = System.Drawing.Color.Lime;
            this.lblAfirmativoLabel.Location = new System.Drawing.Point(7, 23);
            this.lblAfirmativoLabel.Name = "lblAfirmativoLabel";
            this.lblAfirmativoLabel.Size = new System.Drawing.Size(210, 31);
            this.lblAfirmativoLabel.TabIndex = 0;
            this.lblAfirmativoLabel.Text = "AFIRMATIVOS";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(506, 408);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(147, 36);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "&Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtLeyNombre
            // 
            this.txtLeyNombre.Location = new System.Drawing.Point(25, 12);
            this.txtLeyNombre.Name = "txtLeyNombre";
            this.txtLeyNombre.Size = new System.Drawing.Size(616, 20);
            this.txtLeyNombre.TabIndex = 4;
            this.txtLeyNombre.Text = "Nombre de la Ley";
            // 
            // FrmSenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 456);
            this.Controls.Add(this.txtLeyNombre);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbSenado);
            this.MaximizeBox = false;
            this.Name = "FrmSenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre Apellido 2ºC";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSenado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAbstenciones;
        private System.Windows.Forms.Label lblNegativo;
        private System.Windows.Forms.Label lblAfirmativo;
        private System.Windows.Forms.Label lblAbstencionesLabel;
        private System.Windows.Forms.Label lblNegativoLabel;
        private System.Windows.Forms.Label lblAfirmativoLabel;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lblEsperando;
        private System.Windows.Forms.Label lblEsperandoLabel;
        private System.Windows.Forms.TextBox txtLeyNombre;
    }
}