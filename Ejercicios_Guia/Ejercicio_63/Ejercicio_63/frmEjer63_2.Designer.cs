
namespace Ejercicio_63 {
    partial class frmEjer63_2 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjer63_2));
            this.lblHora = new System.Windows.Forms.Label();
            this.btnMainThread = new System.Windows.Forms.Button();
            this.btnCloseMainThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(397, 57);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainThread
            // 
            this.btnMainThread.BackColor = System.Drawing.Color.Black;
            this.btnMainThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainThread.Location = new System.Drawing.Point(10, 163);
            this.btnMainThread.Name = "btnMainThread";
            this.btnMainThread.Size = new System.Drawing.Size(152, 74);
            this.btnMainThread.TabIndex = 1;
            this.btnMainThread.Text = "Using Main Thread";
            this.btnMainThread.UseVisualStyleBackColor = false;
            this.btnMainThread.Click += new System.EventHandler(this.btnMainThread_Click);
            // 
            // btnCloseMainThread
            // 
            this.btnCloseMainThread.BackColor = System.Drawing.Color.Black;
            this.btnCloseMainThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMainThread.Location = new System.Drawing.Point(239, 163);
            this.btnCloseMainThread.Name = "btnCloseMainThread";
            this.btnCloseMainThread.Size = new System.Drawing.Size(152, 74);
            this.btnCloseMainThread.TabIndex = 2;
            this.btnCloseMainThread.Text = "Close Main Thread";
            this.btnCloseMainThread.UseVisualStyleBackColor = false;
            this.btnCloseMainThread.Click += new System.EventHandler(this.btnCloseMainThread_Click);
            // 
            // frmEjer63_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 266);
            this.Controls.Add(this.btnCloseMainThread);
            this.Controls.Add(this.btnMainThread);
            this.Controls.Add(this.lblHora);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEjer63_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 63.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEjer63_2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnMainThread;
        private System.Windows.Forms.Button btnCloseMainThread;
    }
}