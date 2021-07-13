namespace ComiqueriaApp
{
    partial class AltaProductoForm
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
            this.groupBoxAltaProducto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBoxTipoProducto = new System.Windows.Forms.GroupBox();
            this.radioButtonComic = new System.Windows.Forms.RadioButton();
            this.radioButtonFigura = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.groupBoxTipoComic = new System.Windows.Forms.GroupBox();
            this.radioButtonOriental = new System.Windows.Forms.RadioButton();
            this.radioButtonOccidental = new System.Windows.Forms.RadioButton();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxAltaProducto.SuspendLayout();
            this.groupBoxTipoProducto.SuspendLayout();
            this.groupBoxTipoComic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAltaProducto
            // 
            this.groupBoxAltaProducto.Controls.Add(this.txtAutor);
            this.groupBoxAltaProducto.Controls.Add(this.lblAutor);
            this.groupBoxAltaProducto.Controls.Add(this.numStock);
            this.groupBoxAltaProducto.Controls.Add(this.numPrecio);
            this.groupBoxAltaProducto.Controls.Add(this.groupBoxTipoComic);
            this.groupBoxAltaProducto.Controls.Add(this.txtAltura);
            this.groupBoxAltaProducto.Controls.Add(this.lblAltura);
            this.groupBoxAltaProducto.Controls.Add(this.groupBoxTipoProducto);
            this.groupBoxAltaProducto.Controls.Add(this.lblStock);
            this.groupBoxAltaProducto.Controls.Add(this.label2);
            this.groupBoxAltaProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxAltaProducto.Controls.Add(this.lblDescripcion);
            this.groupBoxAltaProducto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAltaProducto.Name = "groupBoxAltaProducto";
            this.groupBoxAltaProducto.Size = new System.Drawing.Size(423, 355);
            this.groupBoxAltaProducto.TabIndex = 2;
            this.groupBoxAltaProducto.TabStop = false;
            this.groupBoxAltaProducto.Text = "Alta Producto";
            this.groupBoxAltaProducto.Enter += new System.EventHandler(this.GroupBoxAltaProducto_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio Unitario:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(10, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(385, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 20);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(7, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            this.lblStock.Click += new System.EventHandler(this.Label3_Click);
            // 
            // groupBoxTipoProducto
            // 
            this.groupBoxTipoProducto.Controls.Add(this.radioButtonFigura);
            this.groupBoxTipoProducto.Controls.Add(this.radioButtonComic);
            this.groupBoxTipoProducto.Location = new System.Drawing.Point(10, 175);
            this.groupBoxTipoProducto.Name = "groupBoxTipoProducto";
            this.groupBoxTipoProducto.Size = new System.Drawing.Size(385, 56);
            this.groupBoxTipoProducto.TabIndex = 6;
            this.groupBoxTipoProducto.TabStop = false;
            this.groupBoxTipoProducto.Text = "Tipo Producto";
            // 
            // radioButtonComic
            // 
            this.radioButtonComic.AutoSize = true;
            this.radioButtonComic.Location = new System.Drawing.Point(7, 20);
            this.radioButtonComic.Name = "radioButtonComic";
            this.radioButtonComic.Size = new System.Drawing.Size(54, 17);
            this.radioButtonComic.TabIndex = 0;
            this.radioButtonComic.TabStop = true;
            this.radioButtonComic.Text = "Comic";
            this.radioButtonComic.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigura
            // 
            this.radioButtonFigura.AutoSize = true;
            this.radioButtonFigura.Location = new System.Drawing.Point(98, 20);
            this.radioButtonFigura.Name = "radioButtonFigura";
            this.radioButtonFigura.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFigura.TabIndex = 1;
            this.radioButtonFigura.TabStop = true;
            this.radioButtonFigura.Text = "Figura";
            this.radioButtonFigura.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(10, 255);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(385, 20);
            this.txtAltura.TabIndex = 8;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(7, 238);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura:";
            // 
            // groupBoxTipoComic
            // 
            this.groupBoxTipoComic.Controls.Add(this.radioButtonOriental);
            this.groupBoxTipoComic.Controls.Add(this.radioButtonOccidental);
            this.groupBoxTipoComic.Location = new System.Drawing.Point(10, 281);
            this.groupBoxTipoComic.Name = "groupBoxTipoComic";
            this.groupBoxTipoComic.Size = new System.Drawing.Size(385, 56);
            this.groupBoxTipoComic.TabIndex = 7;
            this.groupBoxTipoComic.TabStop = false;
            this.groupBoxTipoComic.Text = "Tipo Comic";
            // 
            // radioButtonOriental
            // 
            this.radioButtonOriental.AutoSize = true;
            this.radioButtonOriental.Location = new System.Drawing.Point(98, 20);
            this.radioButtonOriental.Name = "radioButtonOriental";
            this.radioButtonOriental.Size = new System.Drawing.Size(61, 17);
            this.radioButtonOriental.TabIndex = 1;
            this.radioButtonOriental.TabStop = true;
            this.radioButtonOriental.Text = "Oriental";
            this.radioButtonOriental.UseVisualStyleBackColor = true;
            // 
            // radioButtonOccidental
            // 
            this.radioButtonOccidental.AutoSize = true;
            this.radioButtonOccidental.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOccidental.Name = "radioButtonOccidental";
            this.radioButtonOccidental.Size = new System.Drawing.Size(76, 17);
            this.radioButtonOccidental.TabIndex = 0;
            this.radioButtonOccidental.TabStop = true;
            this.radioButtonOccidental.Text = "Occidental";
            this.radioButtonOccidental.UseVisualStyleBackColor = true;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(10, 87);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 20);
            this.numPrecio.TabIndex = 9;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(10, 137);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(120, 20);
            this.numStock.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(10, 256);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(385, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(7, 239);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 11;
            this.lblAutor.Text = "Autor:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(12, 372);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(174, 41);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(261, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 425);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxAltaProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaProductoForm";
            this.ShowIcon = false;
            this.Text = "Alta Producto";
            this.groupBoxAltaProducto.ResumeLayout(false);
            this.groupBoxAltaProducto.PerformLayout();
            this.groupBoxTipoProducto.ResumeLayout(false);
            this.groupBoxTipoProducto.PerformLayout();
            this.groupBoxTipoComic.ResumeLayout(false);
            this.groupBoxTipoComic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAltaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBoxTipoProducto;
        private System.Windows.Forms.RadioButton radioButtonFigura;
        private System.Windows.Forms.RadioButton radioButtonComic;
        private System.Windows.Forms.GroupBox groupBoxTipoComic;
        private System.Windows.Forms.RadioButton radioButtonOriental;
        private System.Windows.Forms.RadioButton radioButtonOccidental;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}