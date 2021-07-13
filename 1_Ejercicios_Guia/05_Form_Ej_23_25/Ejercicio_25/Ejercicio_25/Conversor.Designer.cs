
namespace Ejercicio_25 {
    partial class Conversor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.grpBoxResult = new System.Windows.Forms.GroupBox();
            this.lblDecToBin = new System.Windows.Forms.Label();
            this.lblBinToDec = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.grpBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnBinToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinToDec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBinToDec.Location = new System.Drawing.Point(288, 47);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(140, 53);
            this.btnBinToDec.TabIndex = 1;
            this.btnBinToDec.Text = ">";
            this.btnBinToDec.UseVisualStyleBackColor = false;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDecToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecToBin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDecToBin.Location = new System.Drawing.Point(288, 136);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(140, 53);
            this.btnDecToBin.TabIndex = 3;
            this.btnDecToBin.Text = ">";
            this.btnDecToBin.UseVisualStyleBackColor = false;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.txtResultadoBin);
            this.grpBoxResult.Controls.Add(this.txtResultadoDec);
            this.grpBoxResult.Location = new System.Drawing.Point(449, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(280, 216);
            this.grpBoxResult.TabIndex = 2;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Convertions";
            // 
            // lblDecToBin
            // 
            this.lblDecToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecToBin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDecToBin.Location = new System.Drawing.Point(5, 147);
            this.lblDecToBin.Name = "lblDecToBin";
            this.lblDecToBin.Size = new System.Drawing.Size(133, 33);
            this.lblDecToBin.TabIndex = 3;
            this.lblDecToBin.Text = "Dec To Bin";
            // 
            // lblBinToDec
            // 
            this.lblBinToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinToDec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBinToDec.Location = new System.Drawing.Point(5, 61);
            this.lblBinToDec.Name = "lblBinToDec";
            this.lblBinToDec.Size = new System.Drawing.Size(133, 30);
            this.lblBinToDec.TabIndex = 4;
            this.lblBinToDec.Text = "Bin To Dec";
            // 
            // txtBinario
            // 
            this.txtBinario.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBinario.Location = new System.Drawing.Point(151, 58);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(116, 35);
            this.txtBinario.TabIndex = 0;
            this.txtBinario.MouseLeave += new System.EventHandler(this.txtBinario_MouseLeave);
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDecimal.Location = new System.Drawing.Point(151, 147);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(116, 35);
            this.txtDecimal.TabIndex = 2;
            this.txtDecimal.MouseLeave += new System.EventHandler(this.txtDecimal_MouseLeave);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtResultadoBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtResultadoBin.Location = new System.Drawing.Point(21, 132);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(240, 35);
            this.txtResultadoBin.TabIndex = 8;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtResultadoDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoDec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtResultadoDec.Location = new System.Drawing.Point(21, 43);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(240, 35);
            this.txtResultadoDec.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(750, 240);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblBinToDec);
            this.Controls.Add(this.lblDecToBin);
            this.Controls.Add(this.grpBoxResult);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversor Numérico";
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.GroupBox grpBoxResult;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
    }
}

