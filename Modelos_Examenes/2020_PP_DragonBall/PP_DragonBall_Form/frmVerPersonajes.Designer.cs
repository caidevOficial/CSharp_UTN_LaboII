
namespace PP_DragonBall_Form
{
    partial class frmVerPersonajes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPersonajes));
            this.grpCharImage = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.imgAvatars = new System.Windows.Forms.ImageList(this.components);
            this.cmbPersonajeDeLista = new System.Windows.Forms.ComboBox();
            this.lblSelectCharacter = new System.Windows.Forms.Label();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.lblTransform = new System.Windows.Forms.Label();
            this.grpCharImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCharImage
            // 
            this.grpCharImage.BackColor = System.Drawing.Color.Transparent;
            this.grpCharImage.Controls.Add(this.lblMensaje);
            this.grpCharImage.Controls.Add(this.btnAvatar);
            this.grpCharImage.ForeColor = System.Drawing.Color.Tomato;
            this.grpCharImage.Location = new System.Drawing.Point(12, 1);
            this.grpCharImage.Name = "grpCharImage";
            this.grpCharImage.Size = new System.Drawing.Size(678, 389);
            this.grpCharImage.TabIndex = 0;
            this.grpCharImage.TabStop = false;
            this.grpCharImage.Text = "Char Avatar";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Black;
            this.lblMensaje.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(275, 298);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(386, 76);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Selecciona Personaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvatar.BackgroundImage")));
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAvatar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvatar.ImageList = this.imgAvatars;
            this.btnAvatar.Location = new System.Drawing.Point(0, 11);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(672, 372);
            this.btnAvatar.TabIndex = 4;
            this.btnAvatar.UseVisualStyleBackColor = false;
            // 
            // imgAvatars
            // 
            this.imgAvatars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAvatars.ImageStream")));
            this.imgAvatars.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAvatars.Images.SetKeyName(0, "SJBASE_0.png");
            this.imgAvatars.Images.SetKeyName(1, "SSJ1-001.png");
            this.imgAvatars.Images.SetKeyName(2, "SSJ2.png");
            this.imgAvatars.Images.SetKeyName(3, "SSJ3.png");
            this.imgAvatars.Images.SetKeyName(4, "SSJG-01.png");
            this.imgAvatars.Images.SetKeyName(5, "SSJGSSJ.png");
            this.imgAvatars.Images.SetKeyName(6, "SSJMNG.png");
            this.imgAvatars.Images.SetKeyName(7, "MAJIN_2.png");
            // 
            // cmbPersonajeDeLista
            // 
            this.cmbPersonajeDeLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonajeDeLista.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonajeDeLista.ForeColor = System.Drawing.Color.Black;
            this.cmbPersonajeDeLista.FormattingEnabled = true;
            this.cmbPersonajeDeLista.Location = new System.Drawing.Point(33, 82);
            this.cmbPersonajeDeLista.Name = "cmbPersonajeDeLista";
            this.cmbPersonajeDeLista.Size = new System.Drawing.Size(176, 43);
            this.cmbPersonajeDeLista.TabIndex = 1;
            this.cmbPersonajeDeLista.SelectedIndexChanged += new System.EventHandler(this.cmbPersonajeDeLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.lblSelectCharacter.AutoSize = true;
            this.lblSelectCharacter.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSelectCharacter.ForeColor = System.Drawing.Color.Tomato;
            this.lblSelectCharacter.Location = new System.Drawing.Point(44, 44);
            this.lblSelectCharacter.Name = "label1";
            this.lblSelectCharacter.Size = new System.Drawing.Size(155, 35);
            this.lblSelectCharacter.TabIndex = 2;
            this.lblSelectCharacter.Text = "Selecciona Personaje";
            // 
            // btnTransformar
            // 
            this.btnTransformar.BackColor = System.Drawing.Color.Black;
            this.btnTransformar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransformar.BackgroundImage")));
            this.btnTransformar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransformar.ForeColor = System.Drawing.Color.Tomato;
            this.btnTransformar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransformar.Location = new System.Drawing.Point(33, 181);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(169, 55);
            this.btnTransformar.TabIndex = 3;
            this.btnTransformar.UseVisualStyleBackColor = false;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // label2
            // 
            this.lblTransform.AutoSize = true;
            this.lblTransform.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTransform.ForeColor = System.Drawing.Color.Tomato;
            this.lblTransform.Location = new System.Drawing.Point(70, 143);
            this.lblTransform.Name = "label2";
            this.lblTransform.Size = new System.Drawing.Size(101, 35);
            this.lblTransform.TabIndex = 4;
            this.lblTransform.Text = "Transformar";
            // 
            // frmVerPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 402);
            this.Controls.Add(this.lblTransform);
            this.Controls.Add(this.btnTransformar);
            this.Controls.Add(this.lblSelectCharacter);
            this.Controls.Add(this.cmbPersonajeDeLista);
            this.Controls.Add(this.grpCharImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avatar Preview";
            this.Load += new System.EventHandler(this.frmVerPersonajes_Load);
            this.grpCharImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCharImage;
        private System.Windows.Forms.ComboBox cmbPersonajeDeLista;
        private System.Windows.Forms.Label lblSelectCharacter;
        private System.Windows.Forms.Button btnTransformar;
        public System.Windows.Forms.ImageList imgAvatars;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTransform;
    }
}