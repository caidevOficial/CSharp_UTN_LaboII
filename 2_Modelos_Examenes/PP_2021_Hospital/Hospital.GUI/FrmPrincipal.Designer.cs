/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace WindowsFormsAppTest
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Ingresado = new System.Windows.Forms.GroupBox();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrdenarEgresados = new System.Windows.Forms.ComboBox();
            this.lstEgresado = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Ingresado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Ingresado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 373);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 0;
            // 
            // Ingresado
            // 
            this.Ingresado.Controls.Add(this.btnEgresar);
            this.Ingresado.Controls.Add(this.btnIngresar);
            this.Ingresado.Controls.Add(this.lstIngresado);
            this.Ingresado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ingresado.ForeColor = System.Drawing.Color.Lime;
            this.Ingresado.Location = new System.Drawing.Point(0, 0);
            this.Ingresado.Name = "Ingresado";
            this.Ingresado.Size = new System.Drawing.Size(467, 373);
            this.Ingresado.TabIndex = 1;
            this.Ingresado.TabStop = false;
            this.Ingresado.Text = "Ingresado";
            // 
            // btnEgresar
            // 
            this.btnEgresar.BackColor = System.Drawing.Color.Black;
            this.btnEgresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEgresar.Location = new System.Drawing.Point(329, 311);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(127, 49);
            this.btnEgresar.TabIndex = 3;
            this.btnEgresar.Text = "Egresar";
            this.btnEgresar.UseVisualStyleBackColor = false;
            this.btnEgresar.Click += new System.EventHandler(this.btnEgresar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnIngresar.Location = new System.Drawing.Point(9, 311);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 49);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lstIngresado
            // 
            this.lstIngresado.BackColor = System.Drawing.Color.Black;
            this.lstIngresado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(3, 19);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(453, 264);
            this.lstIngresado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboOrdenarEgresados);
            this.groupBox2.Controls.Add(this.lstEgresado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egresado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ordenar por:";
            // 
            // cboOrdenarEgresados
            // 
            this.cboOrdenarEgresados.BackColor = System.Drawing.Color.Black;
            this.cboOrdenarEgresados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenarEgresados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrdenarEgresados.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboOrdenarEgresados.FormattingEnabled = true;
            this.cboOrdenarEgresados.Items.AddRange(new object[] {
            "Legajo ascendente",
            "Legajo descendente"});
            this.cboOrdenarEgresados.Location = new System.Drawing.Point(6, 327);
            this.cboOrdenarEgresados.Name = "cboOrdenarEgresados";
            this.cboOrdenarEgresados.Size = new System.Drawing.Size(194, 21);
            this.cboOrdenarEgresados.TabIndex = 1;
            this.cboOrdenarEgresados.SelectedIndexChanged += new System.EventHandler(this.cboOrdenarEgresados_SelectedIndexChanged);
            // 
            // lstEgresado
            // 
            this.lstEgresado.BackColor = System.Drawing.Color.Black;
            this.lstEgresado.ForeColor = System.Drawing.Color.Tomato;
            this.lstEgresado.FormattingEnabled = true;
            this.lstEgresado.Location = new System.Drawing.Point(6, 19);
            this.lstEgresado.Name = "lstEgresado";
            this.lstEgresado.Size = new System.Drawing.Size(617, 264);
            this.lstEgresado.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1132, 404);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Ingresado.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Ingresado;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOrdenarEgresados;
        private System.Windows.Forms.ListBox lstEgresado;
    }
}

