
namespace Falcone.Facundo._2D {
    partial class FrmTest {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbInforme
            // 
            this.rtbInforme.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbInforme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rtbInforme.Location = new System.Drawing.Point(506, 15);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.ReadOnly = true;
            this.rtbInforme.Size = new System.Drawing.Size(231, 424);
            this.rtbInforme.TabIndex = 1;
            this.rtbInforme.Text = "";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Black;
            this.btnVender.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.btnVender.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVender.Location = new System.Drawing.Point(11, 278);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(271, 51);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.BackColor = System.Drawing.Color.Black;
            this.btnVerInforme.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerInforme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVerInforme.Location = new System.Drawing.Point(12, 335);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(271, 51);
            this.btnVerInforme.TabIndex = 2;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = false;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(12, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(271, 51);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstStock
            // 
            this.lstStock.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(7, 16);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(269, 238);
            this.lstStock.TabIndex = 5;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.rtbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester App de Facundo Falcone (2ºD)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstStock;
    }
}

