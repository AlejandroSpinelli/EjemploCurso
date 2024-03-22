namespace Presentacion
{
    partial class frmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.chbMostrar = new System.Windows.Forms.CheckBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.pbxback = new System.Windows.Forms.PictureBox();
            this.pbxfront = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfront)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(36, 179);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(9, 212);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(91, 17);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(82, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 25);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(191, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 25);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(106, 176);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(185, 20);
            this.txbUser.TabIndex = 4;
            this.txbUser.Leave += new System.EventHandler(this.txbUser_Leave);
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(106, 209);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(185, 20);
            this.txbContraseña.TabIndex = 5;
            this.txbContraseña.UseSystemPasswordChar = true;
            // 
            // chbMostrar
            // 
            this.chbMostrar.AutoSize = true;
            this.chbMostrar.Location = new System.Drawing.Point(298, 212);
            this.chbMostrar.Name = "chbMostrar";
            this.chbMostrar.Size = new System.Drawing.Size(61, 17);
            this.chbMostrar.TabIndex = 6;
            this.chbMostrar.Text = "Mostrar";
            this.chbMostrar.UseVisualStyleBackColor = true;
            this.chbMostrar.CheckedChanged += new System.EventHandler(this.chbMostrar_CheckedChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(60, 245);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(245, 13);
            this.lblerror.TabIndex = 7;
            this.lblerror.Text = "El usuario y\\o la contraseña son invalidos";
            this.lblerror.Visible = false;
            // 
            // pbxback
            // 
            this.pbxback.Location = new System.Drawing.Point(119, 24);
            this.pbxback.Name = "pbxback";
            this.pbxback.Size = new System.Drawing.Size(130, 130);
            this.pbxback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxback.TabIndex = 8;
            this.pbxback.TabStop = false;
            // 
            // pbxfront
            // 
            this.pbxfront.Location = new System.Drawing.Point(119, 24);
            this.pbxfront.Name = "pbxfront";
            this.pbxfront.Size = new System.Drawing.Size(130, 130);
            this.pbxfront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxfront.TabIndex = 9;
            this.pbxfront.TabStop = false;
            this.pbxfront.Visible = false;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 327);
            this.Controls.Add(this.pbxfront);
            this.Controls.Add(this.pbxback);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.chbMostrar);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 366);
            this.MinimumSize = new System.Drawing.Size(383, 366);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngreso";
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfront)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.CheckBox chbMostrar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox pbxback;
        private System.Windows.Forms.PictureBox pbxfront;
    }
}