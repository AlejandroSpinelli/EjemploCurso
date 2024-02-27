namespace Disqueria
{
    partial class Info
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(148, 57);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(527, 54);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Este es un programa diseñado por Alejandro Spinelli con C# para la\r\nacademia de M" +
    "aximiliano Sar Fernandez y todos los derechos estan \r\nreservados a los antes men" +
    "cionados.\r\n";
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(42, 38);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(100, 100);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 1;
            this.pbxFoto.TabStop = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 175);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.lblinfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.PictureBox pbxFoto;
    }
}