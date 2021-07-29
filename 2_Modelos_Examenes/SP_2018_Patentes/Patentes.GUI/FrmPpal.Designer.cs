namespace _20181122_SP
{
    partial class FrmPpal
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
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.vistaPatente2 = new Patentes.VistaPatente();
            this.vistaPatente1 = new Patentes.VistaPatente();
            this.btnSql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(146, 148);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(128, 74);
            this.btnTxt.TabIndex = 2;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(12, 148);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(128, 74);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // vistaPatente2
            // 
            this.vistaPatente2.Location = new System.Drawing.Point(146, 12);
            this.vistaPatente2.Name = "vistaPatente2";
            this.vistaPatente2.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente2.TabIndex = 1;
            // 
            // vistaPatente1
            // 
            this.vistaPatente1.Location = new System.Drawing.Point(12, 12);
            this.vistaPatente1.Name = "vistaPatente1";
            this.vistaPatente1.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente1.TabIndex = 0;
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(12, 100);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(262, 42);
            this.btnSql.TabIndex = 4;
            this.btnSql.Text = "SQL";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.vistaPatente2);
            this.Controls.Add(this.vistaPatente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Patentes.VistaPatente vistaPatente1;
        private Patentes.VistaPatente vistaPatente2;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnSql;
    }
}

