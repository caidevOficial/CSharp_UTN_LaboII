
namespace _20210717_RSP___alumno
{
    partial class FrmCarrera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrera));
            this.imgListAutos = new System.Windows.Forms.ImageList(this.components);
            this.pcbAutoUno = new System.Windows.Forms.PictureBox();
            this.pcbAutoDos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoDos)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListAutos
            // 
            this.imgListAutos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListAutos.ImageStream")));
            this.imgListAutos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListAutos.Images.SetKeyName(0, "auto_1.png");
            // 
            // pcbAutoUno
            // 
            this.pcbAutoUno.BackColor = System.Drawing.Color.Transparent;
            this.pcbAutoUno.Location = new System.Drawing.Point(12, 24);
            this.pcbAutoUno.Name = "pcbAutoUno";
            this.pcbAutoUno.Size = new System.Drawing.Size(128, 64);
            this.pcbAutoUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbAutoUno.TabIndex = 0;
            this.pcbAutoUno.TabStop = false;
            // 
            // pcbAutoDos
            // 
            this.pcbAutoDos.BackColor = System.Drawing.Color.Transparent;
            this.pcbAutoDos.Location = new System.Drawing.Point(12, 109);
            this.pcbAutoDos.Name = "pcbAutoDos";
            this.pcbAutoDos.Size = new System.Drawing.Size(128, 64);
            this.pcbAutoDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbAutoDos.TabIndex = 1;
            this.pcbAutoDos.TabStop = false;
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 204);
            this.Controls.Add(this.pcbAutoDos);
            this.Controls.Add(this.pcbAutoUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galvez";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarrera_FormClosing);
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            this.Shown += new System.EventHandler(this.FrmCarrera_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoDos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgListAutos;
        private System.Windows.Forms.PictureBox pcbAutoUno;
        private System.Windows.Forms.PictureBox pcbAutoDos;
    }
}

