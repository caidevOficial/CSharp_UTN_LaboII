
namespace PP_DragonBall_Form
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowCharacters = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpHero = new System.Windows.Forms.GroupBox();
            this.chkSaiyan = new System.Windows.Forms.CheckBox();
            this.grpVillain = new System.Windows.Forms.GroupBox();
            this.chkMaxPower = new System.Windows.Forms.CheckBox();
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAtaques = new System.Windows.Forms.ComboBox();
            this.txtNivelPoder = new System.Windows.Forms.TextBox();
            this.grpPlayerType = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPersonaje = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpHero.SuspendLayout();
            this.grpVillain.SuspendLayout();
            this.grpCommon.SuspendLayout();
            this.grpPlayerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.BackColor = System.Drawing.Color.OrangeRed;
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(32, 36);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(72, 21);
            this.cmbOrigen.TabIndex = 0;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(52, 16);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(32, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Raza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombre.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNombre.Location = new System.Drawing.Point(11, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(72, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnShowCharacters);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.grpHero);
            this.groupBox1.Controls.Add(this.grpVillain);
            this.groupBox1.Controls.Add(this.grpCommon);
            this.groupBox1.Controls.Add(this.grpPlayerType);
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(330, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btnShowCharacters
            // 
            this.btnShowCharacters.BackColor = System.Drawing.Color.Black;
            this.btnShowCharacters.Location = new System.Drawing.Point(168, 318);
            this.btnShowCharacters.Name = "btnShowCharacters";
            this.btnShowCharacters.Size = new System.Drawing.Size(140, 40);
            this.btnShowCharacters.TabIndex = 16;
            this.btnShowCharacters.Text = "Show Characters";
            this.btnShowCharacters.UseVisualStyleBackColor = false;
            this.btnShowCharacters.Click += new System.EventHandler(this.btnShowCharacters_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(168, 272);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 40);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create Character";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpHero
            // 
            this.grpHero.BackColor = System.Drawing.Color.Black;
            this.grpHero.Controls.Add(this.chkSaiyan);
            this.grpHero.ForeColor = System.Drawing.Color.Tomato;
            this.grpHero.Location = new System.Drawing.Point(161, 193);
            this.grpHero.Name = "grpHero";
            this.grpHero.Size = new System.Drawing.Size(147, 68);
            this.grpHero.TabIndex = 14;
            this.grpHero.TabStop = false;
            this.grpHero.Text = "Saiyan Option";
            // 
            // chkSaiyan
            // 
            this.chkSaiyan.AutoSize = true;
            this.chkSaiyan.Location = new System.Drawing.Point(39, 32);
            this.chkSaiyan.Name = "chkSaiyan";
            this.chkSaiyan.Size = new System.Drawing.Size(58, 17);
            this.chkSaiyan.TabIndex = 6;
            this.chkSaiyan.Text = "Saiyan";
            this.chkSaiyan.UseVisualStyleBackColor = true;
            // 
            // grpVillain
            // 
            this.grpVillain.BackColor = System.Drawing.Color.Black;
            this.grpVillain.Controls.Add(this.chkMaxPower);
            this.grpVillain.Controls.Add(this.lblOrigen);
            this.grpVillain.Controls.Add(this.cmbOrigen);
            this.grpVillain.ForeColor = System.Drawing.Color.Tomato;
            this.grpVillain.Location = new System.Drawing.Point(8, 193);
            this.grpVillain.Name = "grpVillain";
            this.grpVillain.Size = new System.Drawing.Size(147, 119);
            this.grpVillain.TabIndex = 13;
            this.grpVillain.TabStop = false;
            this.grpVillain.Text = "Villain Option";
            // 
            // chkMaxPower
            // 
            this.chkMaxPower.AutoSize = true;
            this.chkMaxPower.Location = new System.Drawing.Point(32, 75);
            this.chkMaxPower.Name = "chkMaxPower";
            this.chkMaxPower.Size = new System.Drawing.Size(79, 17);
            this.chkMaxPower.TabIndex = 7;
            this.chkMaxPower.Text = "Max Power";
            this.chkMaxPower.UseVisualStyleBackColor = true;
            // 
            // grpCommon
            // 
            this.grpCommon.BackColor = System.Drawing.Color.Black;
            this.grpCommon.Controls.Add(this.label1);
            this.grpCommon.Controls.Add(this.txtNombre);
            this.grpCommon.Controls.Add(this.label2);
            this.grpCommon.Controls.Add(this.label4);
            this.grpCommon.Controls.Add(this.cmbAtaques);
            this.grpCommon.Controls.Add(this.txtNivelPoder);
            this.grpCommon.ForeColor = System.Drawing.Color.Tomato;
            this.grpCommon.Location = new System.Drawing.Point(9, 102);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Size = new System.Drawing.Size(305, 78);
            this.grpCommon.TabIndex = 12;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "Common";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NivelPoder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ataques";
            // 
            // cmbAtaques
            // 
            this.cmbAtaques.BackColor = System.Drawing.Color.OrangeRed;
            this.cmbAtaques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtaques.FormattingEnabled = true;
            this.cmbAtaques.Location = new System.Drawing.Point(179, 41);
            this.cmbAtaques.Name = "cmbAtaques";
            this.cmbAtaques.Size = new System.Drawing.Size(110, 21);
            this.cmbAtaques.TabIndex = 9;
            // 
            // txtNivelPoder
            // 
            this.txtNivelPoder.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNivelPoder.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtNivelPoder.Location = new System.Drawing.Point(105, 42);
            this.txtNivelPoder.Name = "txtNivelPoder";
            this.txtNivelPoder.Size = new System.Drawing.Size(48, 20);
            this.txtNivelPoder.TabIndex = 5;
            // 
            // grpPlayerType
            // 
            this.grpPlayerType.BackColor = System.Drawing.Color.Black;
            this.grpPlayerType.Controls.Add(this.label3);
            this.grpPlayerType.Controls.Add(this.cmbTipoPersonaje);
            this.grpPlayerType.ForeColor = System.Drawing.Color.Tomato;
            this.grpPlayerType.Location = new System.Drawing.Point(9, 21);
            this.grpPlayerType.Name = "grpPlayerType";
            this.grpPlayerType.Size = new System.Drawing.Size(307, 68);
            this.grpPlayerType.TabIndex = 11;
            this.grpPlayerType.TabStop = false;
            this.grpPlayerType.Text = "Select Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Personaje";
            // 
            // cmbTipoPersonaje
            // 
            this.cmbTipoPersonaje.BackColor = System.Drawing.Color.OrangeRed;
            this.cmbTipoPersonaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersonaje.FormattingEnabled = true;
            this.cmbTipoPersonaje.Items.AddRange(new object[] {
            "Heroe",
            "Villano"});
            this.cmbTipoPersonaje.Location = new System.Drawing.Point(109, 29);
            this.cmbTipoPersonaje.Name = "cmbTipoPersonaje";
            this.cmbTipoPersonaje.Size = new System.Drawing.Size(72, 21);
            this.cmbTipoPersonaje.TabIndex = 7;
            this.cmbTipoPersonaje.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonaje_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 399);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Ball Z";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpHero.ResumeLayout(false);
            this.grpHero.PerformLayout();
            this.grpVillain.ResumeLayout(false);
            this.grpVillain.PerformLayout();
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            this.grpPlayerType.ResumeLayout(false);
            this.grpPlayerType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNivelPoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPlayerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPersonaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAtaques;
        private System.Windows.Forms.CheckBox chkSaiyan;
        private System.Windows.Forms.GroupBox grpCommon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpHero;
        private System.Windows.Forms.GroupBox grpVillain;
        private System.Windows.Forms.CheckBox chkMaxPower;
        private System.Windows.Forms.Button btnShowCharacters;
    }
}

