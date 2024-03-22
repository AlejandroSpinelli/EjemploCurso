namespace Presentacion
{
    partial class frmMisFav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisFav));
            this.dgvFavoritos = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbxFav = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFav)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFavoritos
            // 
            this.dgvFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavoritos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFavoritos.Location = new System.Drawing.Point(12, 14);
            this.dgvFavoritos.Name = "dgvFavoritos";
            this.dgvFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavoritos.Size = new System.Drawing.Size(616, 156);
            this.dgvFavoritos.TabIndex = 0;
            this.dgvFavoritos.SelectionChanged += new System.EventHandler(this.dgvFavoritos_SelectionChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(634, 174);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(68, 28);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(708, 174);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pbxFav
            // 
            this.pbxFav.Location = new System.Drawing.Point(634, 14);
            this.pbxFav.Name = "pbxFav";
            this.pbxFav.Size = new System.Drawing.Size(153, 156);
            this.pbxFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFav.TabIndex = 3;
            this.pbxFav.TabStop = false;
            // 
            // frmMisFav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 210);
            this.Controls.Add(this.pbxFav);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.dgvFavoritos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 249);
            this.MinimumSize = new System.Drawing.Size(815, 249);
            this.Name = "frmMisFav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMisFav";
            this.Load += new System.EventHandler(this.frmMisFav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFavoritos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbxFav;
    }
}