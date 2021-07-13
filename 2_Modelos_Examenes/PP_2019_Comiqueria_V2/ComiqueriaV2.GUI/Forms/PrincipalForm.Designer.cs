namespace ComiqueriaApp
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.richTextBoxVentas = new System.Windows.Forms.RichTextBox();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.richTextBoxDetalle = new System.Windows.Forms.RichTextBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBoxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProductos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxProductos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.Location = new System.Drawing.Point(13, 43);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(426, 225);
            this.listBoxProductos.Sorted = true;
            this.listBoxProductos.TabIndex = 0;
            this.listBoxProductos.SelectedIndexChanged += new System.EventHandler(this.ListBoxProductos_SelectedIndexChanged);
            // 
            // richTextBoxVentas
            // 
            this.richTextBoxVentas.BackColor = System.Drawing.Color.Black;
            this.richTextBoxVentas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBoxVentas.Location = new System.Drawing.Point(13, 290);
            this.richTextBoxVentas.Name = "richTextBoxVentas";
            this.richTextBoxVentas.ReadOnly = true;
            this.richTextBoxVentas.Size = new System.Drawing.Size(746, 128);
            this.richTextBoxVentas.TabIndex = 1;
            this.richTextBoxVentas.Text = "";
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAcciones.Controls.Add(this.btnModificar);
            this.groupBoxAcciones.Controls.Add(this.btnVender);
            this.groupBoxAcciones.Location = new System.Drawing.Point(448, 30);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(311, 97);
            this.groupBoxAcciones.TabIndex = 2;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(20, 34);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // richTextBoxDetalle
            // 
            this.richTextBoxDetalle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxDetalle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.richTextBoxDetalle.Location = new System.Drawing.Point(448, 133);
            this.richTextBoxDetalle.Name = "richTextBoxDetalle";
            this.richTextBoxDetalle.ReadOnly = true;
            this.richTextBoxDetalle.Size = new System.Drawing.Size(311, 135);
            this.richTextBoxDetalle.TabIndex = 3;
            this.richTextBoxDetalle.Text = "";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(12, 274);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(103, 13);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Lista de Ventas: ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(12, 27);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(117, 13);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Lista de Productos:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(113, 34);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 430);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.richTextBoxDetalle);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.richTextBoxVentas);
            this.Controls.Add(this.listBoxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Comiquería";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.groupBoxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.RichTextBox richTextBoxVentas;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.RichTextBox richTextBoxDetalle;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnModificar;
    }
}