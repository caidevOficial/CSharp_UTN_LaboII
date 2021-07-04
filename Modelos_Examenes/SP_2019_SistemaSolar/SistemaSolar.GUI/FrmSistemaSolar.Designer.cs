namespace _20191121_SP
{
    partial class FrmSistemaSolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaSolar));
            this.picSol = new System.Windows.Forms.PictureBox();
            this.btnSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).BeginInit();
            this.SuspendLayout();
            // 
            // picSol
            // 
            this.picSol.Image = ((System.Drawing.Image)(resources.GetObject("picSol.Image")));
            this.picSol.Location = new System.Drawing.Point(257, 267);
            this.picSol.Name = "picSol";
            this.picSol.Size = new System.Drawing.Size(128, 128);
            this.picSol.TabIndex = 0;
            this.picSol.TabStop = false;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(547, 585);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(104, 44);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "&Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // FrmSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 641);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.picSol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSistemaSolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Solar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSistemaSolar_FormClosing);
            this.Load += new System.EventHandler(this.FrmSistemaSolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSol;
        private System.Windows.Forms.Button btnSimular;
    }
}

