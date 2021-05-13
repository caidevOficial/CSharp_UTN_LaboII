
namespace ComiqueriaApp {
    partial class FrmFactura {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.lblNombreComiqueria = new System.Windows.Forms.Label();
            this.lblHeaderDateInit = new System.Windows.Forms.Label();
            this.lblHeaderDueDate = new System.Windows.Forms.Label();
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.lblticketDueDate = new System.Windows.Forms.Label();
            this.lblticketDate = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeaderSubtotal = new System.Windows.Forms.Label();
            this.lblHeaderIVA = new System.Windows.Forms.Label();
            this.lblHeaderProducto = new System.Windows.Forms.Label();
            this.lblHeaderPTotal = new System.Windows.Forms.Label();
            this.lblHeaderCantidad = new System.Windows.Forms.Label();
            this.lblHeaderPUnit = new System.Windows.Forms.Label();
            this.lblFacturaType = new System.Windows.Forms.Label();
            this.grpFechas.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreComiqueria
            // 
            this.lblNombreComiqueria.AutoSize = true;
            this.lblNombreComiqueria.BackColor = System.Drawing.Color.Black;
            this.lblNombreComiqueria.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComiqueria.ForeColor = System.Drawing.Color.White;
            this.lblNombreComiqueria.Location = new System.Drawing.Point(12, 9);
            this.lblNombreComiqueria.Name = "lblNombreComiqueria";
            this.lblNombreComiqueria.Size = new System.Drawing.Size(198, 38);
            this.lblNombreComiqueria.TabIndex = 0;
            this.lblNombreComiqueria.Text = "La Comiquería";
            // 
            // lblHeaderDateInit
            // 
            this.lblHeaderDateInit.AutoSize = true;
            this.lblHeaderDateInit.BackColor = System.Drawing.Color.Black;
            this.lblHeaderDateInit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDateInit.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDateInit.Location = new System.Drawing.Point(6, 27);
            this.lblHeaderDateInit.Name = "lblHeaderDateInit";
            this.lblHeaderDateInit.Size = new System.Drawing.Size(73, 19);
            this.lblHeaderDateInit.TabIndex = 1;
            this.lblHeaderDateInit.Text = "Generado:";
            // 
            // lblHeaderDueDate
            // 
            this.lblHeaderDueDate.AutoSize = true;
            this.lblHeaderDueDate.BackColor = System.Drawing.Color.Black;
            this.lblHeaderDueDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDueDate.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDueDate.Location = new System.Drawing.Point(6, 60);
            this.lblHeaderDueDate.Name = "lblHeaderDueDate";
            this.lblHeaderDueDate.Size = new System.Drawing.Size(90, 19);
            this.lblHeaderDueDate.TabIndex = 2;
            this.lblHeaderDueDate.Text = "Vencimiento:";
            // 
            // grpFechas
            // 
            this.grpFechas.Controls.Add(this.lblticketDueDate);
            this.grpFechas.Controls.Add(this.lblticketDate);
            this.grpFechas.Controls.Add(this.lblHeaderDueDate);
            this.grpFechas.Controls.Add(this.lblHeaderDateInit);
            this.grpFechas.Location = new System.Drawing.Point(399, 9);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(271, 110);
            this.grpFechas.TabIndex = 3;
            this.grpFechas.TabStop = false;
            // 
            // lblticketDueDate
            // 
            this.lblticketDueDate.AutoSize = true;
            this.lblticketDueDate.BackColor = System.Drawing.Color.Black;
            this.lblticketDueDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketDueDate.ForeColor = System.Drawing.Color.White;
            this.lblticketDueDate.Location = new System.Drawing.Point(96, 60);
            this.lblticketDueDate.Name = "lblticketDueDate";
            this.lblticketDueDate.Size = new System.Drawing.Size(98, 19);
            this.lblticketDueDate.TabIndex = 4;
            this.lblticketDueDate.Text = "ticketDueDate";
            // 
            // lblticketDate
            // 
            this.lblticketDate.AutoSize = true;
            this.lblticketDate.BackColor = System.Drawing.Color.Black;
            this.lblticketDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketDate.ForeColor = System.Drawing.Color.White;
            this.lblticketDate.Location = new System.Drawing.Point(85, 27);
            this.lblticketDate.Name = "lblticketDate";
            this.lblticketDate.Size = new System.Drawing.Size(75, 19);
            this.lblticketDate.TabIndex = 3;
            this.lblticketDate.Text = "ticketDate";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.lblProductName);
            this.grpDetalles.Controls.Add(this.lblTotalPrice);
            this.grpDetalles.Controls.Add(this.lblIVA);
            this.grpDetalles.Controls.Add(this.lblUnitPrice);
            this.grpDetalles.Controls.Add(this.lblAmount);
            this.grpDetalles.Controls.Add(this.lblSubtotal);
            this.grpDetalles.Controls.Add(this.groupBox1);
            this.grpDetalles.ForeColor = System.Drawing.Color.White;
            this.grpDetalles.Location = new System.Drawing.Point(24, 178);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(646, 193);
            this.grpDetalles.TabIndex = 4;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Black;
            this.lblProductName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(12, 67);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(174, 19);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "productName";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(563, 67);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(70, 19);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "totalPrice";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Black;
            this.lblIVA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.White;
            this.lblIVA.Location = new System.Drawing.Point(489, 67);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(26, 19);
            this.lblIVA.TabIndex = 9;
            this.lblIVA.Text = "iva";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(283, 67);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 19);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "unitPrice";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Black;
            this.lblAmount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(221, 67);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 19);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "amount";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Black;
            this.lblSubtotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(371, 67);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(63, 19);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.lblHeaderSubtotal);
            this.groupBox1.Controls.Add(this.lblHeaderIVA);
            this.groupBox1.Controls.Add(this.lblHeaderProducto);
            this.groupBox1.Controls.Add(this.lblHeaderPTotal);
            this.groupBox1.Controls.Add(this.lblHeaderCantidad);
            this.groupBox1.Controls.Add(this.lblHeaderPUnit);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 34);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblHeaderSubtotal
            // 
            this.lblHeaderSubtotal.AutoSize = true;
            this.lblHeaderSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderSubtotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblHeaderSubtotal.Location = new System.Drawing.Point(361, 9);
            this.lblHeaderSubtotal.Name = "lblHeaderSubtotal";
            this.lblHeaderSubtotal.Size = new System.Drawing.Size(63, 19);
            this.lblHeaderSubtotal.TabIndex = 5;
            this.lblHeaderSubtotal.Text = "Subtotal";
            // 
            // lblHeaderIVA
            // 
            this.lblHeaderIVA.AutoSize = true;
            this.lblHeaderIVA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderIVA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderIVA.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIVA.Location = new System.Drawing.Point(460, 9);
            this.lblHeaderIVA.Name = "lblHeaderIVA";
            this.lblHeaderIVA.Size = new System.Drawing.Size(68, 19);
            this.lblHeaderIVA.TabIndex = 4;
            this.lblHeaderIVA.Text = "IVA 21%";
            this.lblHeaderIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderProducto
            // 
            this.lblHeaderProducto.AutoSize = true;
            this.lblHeaderProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderProducto.ForeColor = System.Drawing.Color.White;
            this.lblHeaderProducto.Location = new System.Drawing.Point(6, 9);
            this.lblHeaderProducto.Name = "lblHeaderProducto";
            this.lblHeaderProducto.Size = new System.Drawing.Size(64, 19);
            this.lblHeaderProducto.TabIndex = 0;
            this.lblHeaderProducto.Text = "Producto";
            // 
            // lblHeaderPTotal
            // 
            this.lblHeaderPTotal.AutoSize = true;
            this.lblHeaderPTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderPTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPTotal.ForeColor = System.Drawing.Color.White;
            this.lblHeaderPTotal.Location = new System.Drawing.Point(540, 9);
            this.lblHeaderPTotal.Name = "lblHeaderPTotal";
            this.lblHeaderPTotal.Size = new System.Drawing.Size(86, 19);
            this.lblHeaderPTotal.TabIndex = 3;
            this.lblHeaderPTotal.Text = "Precio Total";
            // 
            // lblHeaderCantidad
            // 
            this.lblHeaderCantidad.AutoSize = true;
            this.lblHeaderCantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderCantidad.ForeColor = System.Drawing.Color.White;
            this.lblHeaderCantidad.Location = new System.Drawing.Point(209, 9);
            this.lblHeaderCantidad.Name = "lblHeaderCantidad";
            this.lblHeaderCantidad.Size = new System.Drawing.Size(37, 19);
            this.lblHeaderCantidad.TabIndex = 1;
            this.lblHeaderCantidad.Text = "Cant";
            // 
            // lblHeaderPUnit
            // 
            this.lblHeaderPUnit.AutoSize = true;
            this.lblHeaderPUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderPUnit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPUnit.ForeColor = System.Drawing.Color.White;
            this.lblHeaderPUnit.Location = new System.Drawing.Point(265, 9);
            this.lblHeaderPUnit.Name = "lblHeaderPUnit";
            this.lblHeaderPUnit.Size = new System.Drawing.Size(80, 19);
            this.lblHeaderPUnit.TabIndex = 2;
            this.lblHeaderPUnit.Text = "Precio Unit";
            // 
            // lblFacturaType
            // 
            this.lblFacturaType.AutoSize = true;
            this.lblFacturaType.BackColor = System.Drawing.Color.Black;
            this.lblFacturaType.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaType.ForeColor = System.Drawing.Color.White;
            this.lblFacturaType.Location = new System.Drawing.Point(215, 54);
            this.lblFacturaType.Name = "lblFacturaType";
            this.lblFacturaType.Size = new System.Drawing.Size(149, 38);
            this.lblFacturaType.TabIndex = 6;
            this.lblFacturaType.Text = "Factura X";
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(696, 384);
            this.Controls.Add(this.lblFacturaType);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpFechas);
            this.Controls.Add(this.lblNombreComiqueria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreComiqueria;
        private System.Windows.Forms.Label lblHeaderDateInit;
        private System.Windows.Forms.Label lblHeaderDueDate;
        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHeaderProducto;
        private System.Windows.Forms.Label lblHeaderPTotal;
        private System.Windows.Forms.Label lblHeaderCantidad;
        private System.Windows.Forms.Label lblHeaderPUnit;
        private System.Windows.Forms.Label lblticketDueDate;
        private System.Windows.Forms.Label lblticketDate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblHeaderSubtotal;
        private System.Windows.Forms.Label lblHeaderIVA;
        private System.Windows.Forms.Label lblFacturaType;
    }
}