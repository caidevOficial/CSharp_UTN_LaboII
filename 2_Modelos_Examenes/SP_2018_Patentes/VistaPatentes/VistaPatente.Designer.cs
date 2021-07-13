namespace Patentes
{
    partial class VistaPatente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPatente));
            this.fondosPatente = new System.Windows.Forms.ImageList(this.components);
            this.picPatente = new System.Windows.Forms.PictureBox();
            this.lblPatenteNro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // fondosPatente
            // 
            this.fondosPatente.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fondosPatente.ImageStream")));
            this.fondosPatente.TransparentColor = System.Drawing.Color.Transparent;
            this.fondosPatente.Images.SetKeyName(0, "patente_128x48_vieja.png");
            this.fondosPatente.Images.SetKeyName(1, "patente_128x48_argentina.png");
            this.fondosPatente.Images.SetKeyName(2, "patente_128x48_brasil.png");
            this.fondosPatente.Images.SetKeyName(3, "patente_128x48_paraguay.png");
            this.fondosPatente.Images.SetKeyName(4, "patente_128x48_uruguay.png");
            // 
            // picPatente
            // 
            this.picPatente.Location = new System.Drawing.Point(0, 0);
            this.picPatente.Name = "picPatente";
            this.picPatente.Size = new System.Drawing.Size(128, 48);
            this.picPatente.TabIndex = 0;
            this.picPatente.TabStop = false;
            // 
            // lblPatenteNro
            // 
            this.lblPatenteNro.BackColor = System.Drawing.Color.White;
            this.lblPatenteNro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatenteNro.Location = new System.Drawing.Point(1, 16);
            this.lblPatenteNro.Name = "lblPatenteNro";
            this.lblPatenteNro.Size = new System.Drawing.Size(127, 23);
            this.lblPatenteNro.TabIndex = 1;
            this.lblPatenteNro.Text = "VACIO";
            this.lblPatenteNro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VistaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPatenteNro);
            this.Controls.Add(this.picPatente);
            this.Name = "VistaPatente";
            this.Size = new System.Drawing.Size(128, 48);
            ((System.ComponentModel.ISupportInitialize)(this.picPatente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList fondosPatente;
        private System.Windows.Forms.PictureBox picPatente;
        private System.Windows.Forms.Label lblPatenteNro;
    }
}
