namespace Ejemplo2
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbtWizzard = new System.Windows.Forms.RadioButton();
            this.rbtMaggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbpTipo = new System.Windows.Forms.GroupBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(154, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(142, 568);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(142, 457);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(286, 105);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(49, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(154, 136);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(154, 163);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(46, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(198, 31);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Perfil Persona";
            // 
            // rbtWizzard
            // 
            this.rbtWizzard.AutoSize = true;
            this.rbtWizzard.Checked = true;
            this.rbtWizzard.Location = new System.Drawing.Point(11, 19);
            this.rbtWizzard.Name = "rbtWizzard";
            this.rbtWizzard.Size = new System.Drawing.Size(63, 17);
            this.rbtWizzard.TabIndex = 8;
            this.rbtWizzard.TabStop = true;
            this.rbtWizzard.Text = "Wizzard";
            this.rbtWizzard.UseVisualStyleBackColor = true;
            // 
            // rbtMaggle
            // 
            this.rbtMaggle.AutoSize = true;
            this.rbtMaggle.Location = new System.Drawing.Point(144, 19);
            this.rbtMaggle.Name = "rbtMaggle";
            this.rbtMaggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMaggle.TabIndex = 9;
            this.rbtMaggle.Text = "Muggle";
            this.rbtMaggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(274, 19);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 10;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbpTipo
            // 
            this.gbpTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbpTipo.Controls.Add(this.rbtSquibs);
            this.gbpTipo.Controls.Add(this.rbtWizzard);
            this.gbpTipo.Controls.Add(this.rbtMaggle);
            this.gbpTipo.Location = new System.Drawing.Point(63, 197);
            this.gbpTipo.Name = "gbpTipo";
            this.gbpTipo.Size = new System.Drawing.Size(358, 51);
            this.gbpTipo.TabIndex = 3;
            this.gbpTipo.TabStop = false;
            this.gbpTipo.Text = "Tipo";
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(60, 268);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(75, 13);
            this.lblColorFavorito.TabIndex = 12;
            this.lblColorFavorito.Text = "Color Favorito ";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(142, 268);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(241, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFavorito.Location = new System.Drawing.Point(154, 315);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(229, 20);
            this.numNumeroFavorito.TabIndex = 5;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(60, 317);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(91, 13);
            this.lblNumeroFavorito.TabIndex = 15;
            this.lblNumeroFavorito.Text = "Numero Favorito: ";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(63, 412);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(120, 39);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 728);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.gbpTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(1117, 818);
            this.MinimumSize = new System.Drawing.Size(555, 767);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbpTipo.ResumeLayout(false);
            this.gbpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbtWizzard;
        private System.Windows.Forms.RadioButton rbtMaggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbpTipo;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

