namespace Disqueria
{
    partial class frmAgregarDisco
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
            this.pbxAgregarDisco = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.cbxFormato = new System.Windows.Forms.ComboBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbCanciones = new System.Windows.Forms.TextBox();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarimg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAgregarDisco
            // 
            this.pbxAgregarDisco.Location = new System.Drawing.Point(473, 58);
            this.pbxAgregarDisco.Name = "pbxAgregarDisco";
            this.pbxAgregarDisco.Size = new System.Drawing.Size(196, 196);
            this.pbxAgregarDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarDisco.TabIndex = 0;
            this.pbxAgregarDisco.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(183, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(46, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(193, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de lanzamiento";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(39, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(200, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de canciones";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(139, 161);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(100, 20);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "Url Imagen";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.Location = new System.Drawing.Point(182, 200);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(57, 20);
            this.lblEstilo.TabIndex = 5;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(161, 234);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(78, 20);
            this.lblFormato.TabIndex = 6;
            this.lblFormato.Text = "Formato";
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(281, 200);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(121, 24);
            this.cbxEstilo.TabIndex = 4;
            // 
            // cbxFormato
            // 
            this.cbxFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormato.FormattingEnabled = true;
            this.cbxFormato.Location = new System.Drawing.Point(281, 230);
            this.cbxFormato.Name = "cbxFormato";
            this.cbxFormato.Size = new System.Drawing.Size(121, 24);
            this.cbxFormato.TabIndex = 5;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(281, 52);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(121, 22);
            this.txbTitulo.TabIndex = 0;
            // 
            // txbCanciones
            // 
            this.txbCanciones.Location = new System.Drawing.Point(281, 125);
            this.txbCanciones.Name = "txbCanciones";
            this.txbCanciones.Size = new System.Drawing.Size(121, 22);
            this.txbCanciones.TabIndex = 2;
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(281, 161);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(121, 22);
            this.txbUrl.TabIndex = 3;
            this.txbUrl.Leave += new System.EventHandler(this.txbUrl_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(199, 285);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 38);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(359, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(281, 91);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnAgregarimg
            // 
            this.btnAgregarimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarimg.Location = new System.Drawing.Point(409, 152);
            this.btnAgregarimg.Name = "btnAgregarimg";
            this.btnAgregarimg.Size = new System.Drawing.Size(36, 30);
            this.btnAgregarimg.TabIndex = 8;
            this.btnAgregarimg.Text = "+";
            this.btnAgregarimg.UseVisualStyleBackColor = true;
            this.btnAgregarimg.Click += new System.EventHandler(this.btnAgregarimg_Click);
            // 
            // frmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(702, 331);
            this.Controls.Add(this.btnAgregarimg);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.txbCanciones);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.cbxFormato);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxAgregarDisco);
            this.Name = "frmAgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.frmAgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAgregarDisco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.ComboBox cbxFormato;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbCanciones;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregarimg;
    }
}