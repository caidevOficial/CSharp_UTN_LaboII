
namespace CuentaGanadoForm
{
    partial class CuentaGanadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaGanadoForm));
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.numEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numGente = new System.Windows.Forms.NumericUpDown();
            this.btnInformes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(22, 21);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(141, 59);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.Location = new System.Drawing.Point(38, 85);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(88, 59);
            this.lblGente.TabIndex = 1;
            this.lblGente.Text = "Gente";
            // 
            // numEmpleados
            // 
            this.numEmpleados.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmpleados.Location = new System.Drawing.Point(193, 22);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.ReadOnly = true;
            this.numEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numEmpleados.Size = new System.Drawing.Size(120, 57);
            this.numEmpleados.TabIndex = 2;
            this.numEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEmpleados.ValueChanged += new System.EventHandler(this.numEmpleados_ValueChanged);
            // 
            // numGente
            // 
            this.numGente.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGente.Location = new System.Drawing.Point(193, 85);
            this.numGente.Name = "numGente";
            this.numGente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numGente.Size = new System.Drawing.Size(120, 57);
            this.numGente.TabIndex = 3;
            this.numGente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGente.ValueChanged += new System.EventHandler(this.numGente_ValueChanged);
            // 
            // btnInformes
            // 
            this.btnInformes.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Location = new System.Drawing.Point(193, 148);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(120, 63);
            this.btnInformes.TabIndex = 4;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // CuentaGanadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(349, 228);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.numGente);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentaGanadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Facu";
            this.Load += new System.EventHandler(this.CuentaGanadoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.NumericUpDown numEmpleados;
        private System.Windows.Forms.NumericUpDown numGente;
        private System.Windows.Forms.Button btnInformes;
    }
}

