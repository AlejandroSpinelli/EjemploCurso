namespace Presentacion
{
    partial class frmCambioPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioPass));
            this.lblActual = new System.Windows.Forms.Label();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblRepita = new System.Windows.Forms.Label();
            this.tbxActual = new System.Windows.Forms.TextBox();
            this.tbxNueva = new System.Windows.Forms.TextBox();
            this.tbxRepita = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblErrorActual = new System.Windows.Forms.Label();
            this.lblErrorNueva = new System.Windows.Forms.Label();
            this.cbmostrar1 = new System.Windows.Forms.CheckBox();
            this.cbmostrar2 = new System.Windows.Forms.CheckBox();
            this.cbmostrar3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.Location = new System.Drawing.Point(12, 28);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(145, 17);
            this.lblActual.TabIndex = 0;
            this.lblActual.Text = "Contraseña actual:";
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(12, 76);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(145, 17);
            this.lblNueva.TabIndex = 1;
            this.lblNueva.Text = "Contraseña nueva:";
            // 
            // lblRepita
            // 
            this.lblRepita.AutoSize = true;
            this.lblRepita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepita.Location = new System.Drawing.Point(12, 113);
            this.lblRepita.Name = "lblRepita";
            this.lblRepita.Size = new System.Drawing.Size(146, 17);
            this.lblRepita.TabIndex = 2;
            this.lblRepita.Text = "Repita contraseña:";
            // 
            // tbxActual
            // 
            this.tbxActual.Location = new System.Drawing.Point(163, 25);
            this.tbxActual.Name = "tbxActual";
            this.tbxActual.Size = new System.Drawing.Size(206, 20);
            this.tbxActual.TabIndex = 3;
            this.tbxActual.UseSystemPasswordChar = true;
            this.tbxActual.Leave += new System.EventHandler(this.tbxActual_Leave);
            // 
            // tbxNueva
            // 
            this.tbxNueva.Location = new System.Drawing.Point(163, 73);
            this.tbxNueva.Name = "tbxNueva";
            this.tbxNueva.Size = new System.Drawing.Size(206, 20);
            this.tbxNueva.TabIndex = 4;
            this.tbxNueva.UseSystemPasswordChar = true;
            this.tbxNueva.Leave += new System.EventHandler(this.tbxNueva_Leave);
            // 
            // tbxRepita
            // 
            this.tbxRepita.Location = new System.Drawing.Point(163, 110);
            this.tbxRepita.Name = "tbxRepita";
            this.tbxRepita.Size = new System.Drawing.Size(206, 20);
            this.tbxRepita.TabIndex = 5;
            this.tbxRepita.UseSystemPasswordChar = true;
            this.tbxRepita.TextChanged += new System.EventHandler(this.tbxRepita_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(113, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 29);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(218, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblErrorActual
            // 
            this.lblErrorActual.AutoSize = true;
            this.lblErrorActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorActual.ForeColor = System.Drawing.Color.Red;
            this.lblErrorActual.Location = new System.Drawing.Point(160, 48);
            this.lblErrorActual.Name = "lblErrorActual";
            this.lblErrorActual.Size = new System.Drawing.Size(236, 13);
            this.lblErrorActual.TabIndex = 8;
            this.lblErrorActual.Text = "*La contraseña actual no es la correcta!";
            this.lblErrorActual.Visible = false;
            // 
            // lblErrorNueva
            // 
            this.lblErrorNueva.AutoSize = true;
            this.lblErrorNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNueva.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNueva.Location = new System.Drawing.Point(160, 133);
            this.lblErrorNueva.Name = "lblErrorNueva";
            this.lblErrorNueva.Size = new System.Drawing.Size(186, 26);
            this.lblErrorNueva.TabIndex = 9;
            this.lblErrorNueva.Text = "*Las contraseñas no coinciden!\r\n\r\n";
            this.lblErrorNueva.Visible = false;
            // 
            // cbmostrar1
            // 
            this.cbmostrar1.AutoSize = true;
            this.cbmostrar1.Location = new System.Drawing.Point(375, 27);
            this.cbmostrar1.Name = "cbmostrar1";
            this.cbmostrar1.Size = new System.Drawing.Size(61, 17);
            this.cbmostrar1.TabIndex = 10;
            this.cbmostrar1.Text = "Mostrar";
            this.cbmostrar1.UseVisualStyleBackColor = true;
            this.cbmostrar1.CheckedChanged += new System.EventHandler(this.cbmostrar1_CheckedChanged);
            // 
            // cbmostrar2
            // 
            this.cbmostrar2.AutoSize = true;
            this.cbmostrar2.Location = new System.Drawing.Point(375, 76);
            this.cbmostrar2.Name = "cbmostrar2";
            this.cbmostrar2.Size = new System.Drawing.Size(61, 17);
            this.cbmostrar2.TabIndex = 11;
            this.cbmostrar2.Text = "Mostrar";
            this.cbmostrar2.UseVisualStyleBackColor = true;
            this.cbmostrar2.CheckedChanged += new System.EventHandler(this.cbmostrar2_CheckedChanged);
            // 
            // cbmostrar3
            // 
            this.cbmostrar3.AutoSize = true;
            this.cbmostrar3.Location = new System.Drawing.Point(375, 114);
            this.cbmostrar3.Name = "cbmostrar3";
            this.cbmostrar3.Size = new System.Drawing.Size(61, 17);
            this.cbmostrar3.TabIndex = 12;
            this.cbmostrar3.Text = "Mostrar";
            this.cbmostrar3.UseVisualStyleBackColor = true;
            this.cbmostrar3.CheckedChanged += new System.EventHandler(this.cbmostrar3_CheckedChanged);
            // 
            // frmCambioPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 216);
            this.Controls.Add(this.cbmostrar3);
            this.Controls.Add(this.cbmostrar2);
            this.Controls.Add(this.cbmostrar1);
            this.Controls.Add(this.lblErrorNueva);
            this.Controls.Add(this.lblErrorActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxRepita);
            this.Controls.Add(this.tbxNueva);
            this.Controls.Add(this.tbxActual);
            this.Controls.Add(this.lblRepita);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.lblActual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 255);
            this.MinimumSize = new System.Drawing.Size(460, 255);
            this.Name = "frmCambioPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambioPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblRepita;
        private System.Windows.Forms.TextBox tbxActual;
        private System.Windows.Forms.TextBox tbxNueva;
        private System.Windows.Forms.TextBox tbxRepita;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblErrorActual;
        private System.Windows.Forms.Label lblErrorNueva;
        private System.Windows.Forms.CheckBox cbmostrar1;
        private System.Windows.Forms.CheckBox cbmostrar2;
        private System.Windows.Forms.CheckBox cbmostrar3;
    }
}