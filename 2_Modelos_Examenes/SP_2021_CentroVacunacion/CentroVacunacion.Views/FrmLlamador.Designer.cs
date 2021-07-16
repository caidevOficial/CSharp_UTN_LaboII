
namespace Views
{
    partial class FrmLlamador
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
            this.gbxTurnero = new System.Windows.Forms.GroupBox();
            this.lblInfoAdjunta = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.gbxTurnero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTurnero
            // 
            this.gbxTurnero.BackColor = System.Drawing.Color.Black;
            this.gbxTurnero.Controls.Add(this.lblTurno);
            this.gbxTurnero.Controls.Add(this.lblInfoAdjunta);
            this.gbxTurnero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTurnero.Location = new System.Drawing.Point(0, 0);
            this.gbxTurnero.Name = "gbxTurnero";
            this.gbxTurnero.Size = new System.Drawing.Size(866, 240);
            this.gbxTurnero.TabIndex = 0;
            this.gbxTurnero.TabStop = false;
            // 
            // lblInfoAdjunta
            // 
            this.lblInfoAdjunta.AutoSize = true;
            this.lblInfoAdjunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAdjunta.ForeColor = System.Drawing.Color.Red;
            this.lblInfoAdjunta.Location = new System.Drawing.Point(12, 148);
            this.lblInfoAdjunta.Name = "lblInfoAdjunta";
            this.lblInfoAdjunta.Size = new System.Drawing.Size(152, 55);
            this.lblInfoAdjunta.TabIndex = 0;
            this.lblInfoAdjunta.Text = "label1";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurno.Location = new System.Drawing.Point(6, 16);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(153, 108);
            this.lblTurno.TabIndex = 1;
            this.lblTurno.Text = "88";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 240);
            this.Controls.Add(this.gbxTurnero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLlamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLlamador_KeyUp);
            this.gbxTurnero.ResumeLayout(false);
            this.gbxTurnero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTurnero;
        private System.Windows.Forms.Label lblInfoAdjunta;
        private System.Windows.Forms.Label lblTurno;
    }
}