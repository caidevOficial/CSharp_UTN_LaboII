
namespace Practica_15_Eventos_Delegados {
    partial class frmDelegado {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelegado));
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstAtendido = new System.Windows.Forms.ListBox();
            this.lstCobrado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCobrar.Location = new System.Drawing.Point(12, 260);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(199, 54);
            this.btnCobrar.TabIndex = 0;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lstIngresado
            // 
            this.lstIngresado.BackColor = System.Drawing.Color.Black;
            this.lstIngresado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(10, 17);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(201, 225);
            this.lstIngresado.TabIndex = 1;
            // 
            // lstAtendido
            // 
            this.lstAtendido.BackColor = System.Drawing.Color.Black;
            this.lstAtendido.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstAtendido.FormattingEnabled = true;
            this.lstAtendido.Location = new System.Drawing.Point(432, 17);
            this.lstAtendido.Name = "lstAtendido";
            this.lstAtendido.Size = new System.Drawing.Size(201, 225);
            this.lstAtendido.TabIndex = 2;
            // 
            // lstCobrado
            // 
            this.lstCobrado.BackColor = System.Drawing.Color.Black;
            this.lstCobrado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstCobrado.FormattingEnabled = true;
            this.lstCobrado.Location = new System.Drawing.Point(221, 17);
            this.lstCobrado.Name = "lstCobrado";
            this.lstCobrado.Size = new System.Drawing.Size(201, 225);
            this.lstCobrado.TabIndex = 3;
            // 
            // frmDelegado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(645, 334);
            this.Controls.Add(this.lstCobrado);
            this.Controls.Add(this.lstAtendido);
            this.Controls.Add(this.lstIngresado);
            this.Controls.Add(this.btnCobrar);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelegado";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDelegado_FormClosing);
            this.Load += new System.EventHandler(this.frmDelegado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.ListBox lstAtendido;
        private System.Windows.Forms.ListBox lstCobrado;
    }
}