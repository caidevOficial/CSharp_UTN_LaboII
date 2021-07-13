
namespace Practica_WF_MiniSuper
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblDireccion.Location = new System.Drawing.Point(31, 18);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(161, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Bienvenidos al Mini Super de C#";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Red;
            this.btnNuevoCliente.Location = new System.Drawing.Point(34, 45);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(158, 35);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.MouseLeave += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(13, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DisplayMember = "Usuarios";
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.ForeColor = System.Drawing.Color.Chartreuse;
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(21, 18);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(149, 21);
            this.comboBoxUsuarios.TabIndex = 0;
            this.comboBoxUsuarios.ValueMember = "Usuarios";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(217, 165);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.lblDireccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Super";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
    }
}

