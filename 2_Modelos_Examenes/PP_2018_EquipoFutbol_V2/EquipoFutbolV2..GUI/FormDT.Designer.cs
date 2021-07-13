
namespace PP_EquipoFutbol_V2
{
    partial class FormDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDT));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.numExp = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(17, 104);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(20, 135);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(7, 163);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(62, 13);
            this.lblExperiencia.TabIndex = 4;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(105, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(76, 102);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(105, 20);
            this.numEdad.TabIndex = 7;
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(76, 131);
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(105, 20);
            this.numDni.TabIndex = 8;
            // 
            // numExp
            // 
            this.numExp.Location = new System.Drawing.Point(76, 161);
            this.numExp.Name = "numExp";
            this.numExp.Size = new System.Drawing.Size(105, 20);
            this.numExp.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(20, 197);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(92, 53);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(133, 197);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(92, 53);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 268);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numExp);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.NumericUpDown numExp;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}

