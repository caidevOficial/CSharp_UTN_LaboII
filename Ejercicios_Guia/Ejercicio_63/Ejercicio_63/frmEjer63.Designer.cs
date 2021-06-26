
namespace Ejercicio_63 {
    partial class frmEjer63 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjer63));
            this.lblHora = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(389, 34);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Time";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.Black;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtbText.Location = new System.Drawing.Point(10, 46);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(391, 237);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // frmEjer63
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 293);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.lblHora);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEjer63";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 63";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEjer63_FormClosing);
            this.Load += new System.EventHandler(this.frmEjer63_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}

