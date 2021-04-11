
namespace Ejercicio_29
{
    partial class ContadorDePalabras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContadorDePalabras));
            this.grpInsertText = new System.Windows.Forms.GroupBox();
            this.richTextWords = new System.Windows.Forms.RichTextBox();
            this.grpShowWords = new System.Windows.Forms.GroupBox();
            this.richTextShow = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpInsertText.SuspendLayout();
            this.grpShowWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInsertText
            // 
            this.grpInsertText.Controls.Add(this.richTextWords);
            this.grpInsertText.Location = new System.Drawing.Point(13, 13);
            this.grpInsertText.Name = "grpInsertText";
            this.grpInsertText.Size = new System.Drawing.Size(742, 192);
            this.grpInsertText.TabIndex = 0;
            this.grpInsertText.TabStop = false;
            this.grpInsertText.Text = "Ingrese Palabras";
            // 
            // richTextWords
            // 
            this.richTextWords.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextWords.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextWords.ForeColor = System.Drawing.Color.Red;
            this.richTextWords.Location = new System.Drawing.Point(13, 21);
            this.richTextWords.Name = "richTextWords";
            this.richTextWords.Size = new System.Drawing.Size(719, 160);
            this.richTextWords.TabIndex = 0;
            this.richTextWords.Text = "";
            // 
            // grpShowWords
            // 
            this.grpShowWords.Controls.Add(this.richTextShow);
            this.grpShowWords.Location = new System.Drawing.Point(13, 239);
            this.grpShowWords.Name = "grpShowWords";
            this.grpShowWords.Size = new System.Drawing.Size(742, 192);
            this.grpShowWords.TabIndex = 1;
            this.grpShowWords.TabStop = false;
            this.grpShowWords.Text = "Cantidad segun Palabras";
            // 
            // richTextShow
            // 
            this.richTextShow.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextShow.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextShow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.richTextShow.Location = new System.Drawing.Point(13, 26);
            this.richTextShow.Name = "richTextShow";
            this.richTextShow.Size = new System.Drawing.Size(719, 160);
            this.richTextShow.TabIndex = 1;
            this.richTextShow.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contar Palabras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContadorDePalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(767, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpShowWords);
            this.Controls.Add(this.grpInsertText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContadorDePalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Palabras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContadorDePalabras_FormClosing);
            this.grpInsertText.ResumeLayout(false);
            this.grpShowWords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInsertText;
        private System.Windows.Forms.RichTextBox richTextWords;
        private System.Windows.Forms.GroupBox grpShowWords;
        private System.Windows.Forms.RichTextBox richTextShow;
        private System.Windows.Forms.Button button1;
    }
}

