namespace Presentacion
{
    partial class AboutUs
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
            this.pbxabout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxabout)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxabout
            // 
            this.pbxabout.Location = new System.Drawing.Point(12, 12);
            this.pbxabout.Name = "pbxabout";
            this.pbxabout.Size = new System.Drawing.Size(121, 149);
            this.pbxabout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxabout.TabIndex = 0;
            this.pbxabout.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este es un trabajo para el curso de C# de Maximiliano Sar Fernandez realizado\r\npo" +
    "r Alejandro Spinelli, todos los derechos quedan reservados a los antes \r\nmencion" +
    "ados.\r\n";
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxabout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About us";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxabout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxabout;
        private System.Windows.Forms.Label label1;
    }
}