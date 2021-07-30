
namespace _20210717_RSP___alumno
{
    partial class FrmContador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContador));
            this.imgSemaforo = new System.Windows.Forms.ImageList(this.components);
            this.pbNumeros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSemaforo
            // 
            this.imgSemaforo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSemaforo.ImageStream")));
            this.imgSemaforo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSemaforo.Images.SetKeyName(0, "semaforo_red.png");
            this.imgSemaforo.Images.SetKeyName(1, "semaforo_yellow.png");
            this.imgSemaforo.Images.SetKeyName(2, "semaforo_green.png");
            this.imgSemaforo.Images.SetKeyName(3, "Bandera-a-cuadros.png");
            // 
            // pbNumeros
            // 
            this.pbNumeros.BackColor = System.Drawing.Color.Transparent;
            this.pbNumeros.Location = new System.Drawing.Point(12, 12);
            this.pbNumeros.Name = "pbNumeros";
            this.pbNumeros.Size = new System.Drawing.Size(255, 128);
            this.pbNumeros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNumeros.TabIndex = 0;
            this.pbNumeros.TabStop = false;
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(275, 156);
            this.ControlBox = false;
            this.Controls.Add(this.pbNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Shown += new System.EventHandler(this.FrmContador_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgSemaforo;
        private System.Windows.Forms.PictureBox pbNumeros;
    }
}