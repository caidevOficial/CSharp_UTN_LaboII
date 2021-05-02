
namespace Ejercicio_40_Forms
{
    partial class frmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrar));
            this.grpText = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.richTextBox);
            this.grpText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpText.Location = new System.Drawing.Point(12, 12);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(289, 247);
            this.grpText.TabIndex = 0;
            this.grpText.TabStop = false;
            this.grpText.Text = "Info";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox.Location = new System.Drawing.Point(6, 19);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(277, 218);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(317, 272);
            this.Controls.Add(this.grpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centralita Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMostrar_FormClosing);
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            this.grpText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}