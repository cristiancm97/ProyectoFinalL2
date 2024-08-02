namespace capaPresentacion
{
    partial class CP_Libro
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbMinimizarLibro = new System.Windows.Forms.PictureBox();
            this.pbCerrarLibro = new System.Windows.Forms.PictureBox();
            this.lblHeaderGenero = new System.Windows.Forms.Label();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.lblTitutoListadoLibro = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.pbLogoLibro = new System.Windows.Forms.PictureBox();
            this.btnMenuLibro = new System.Windows.Forms.Button();
            this.btnLogoutLibro = new System.Windows.Forms.Button();
            this.lblTituloFormularioLibro = new System.Windows.Forms.Label();
            this.btnFormDatosLibro = new System.Windows.Forms.Button();
            this.lblGeneroLibro = new System.Windows.Forms.Label();
            this.tbAnioLibro = new System.Windows.Forms.TextBox();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.lblAnioLibro = new System.Windows.Forms.Label();
            this.tbTituloLibro = new System.Windows.Forms.TextBox();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.cbGeneroLibro = new System.Windows.Forms.ComboBox();
            this.cbAutorLibro = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.pbMinimizarLibro);
            this.pnlHeader.Controls.Add(this.pbCerrarLibro);
            this.pnlHeader.Controls.Add(this.lblHeaderGenero);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // pbMinimizarLibro
            // 
            this.pbMinimizarLibro.Image = global::capaPresentacion.Properties.Resources.MINIMIZAR_SB;
            this.pbMinimizarLibro.Location = new System.Drawing.Point(1122, 9);
            this.pbMinimizarLibro.Name = "pbMinimizarLibro";
            this.pbMinimizarLibro.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizarLibro.TabIndex = 2;
            this.pbMinimizarLibro.TabStop = false;
            this.pbMinimizarLibro.Click += new System.EventHandler(this.pbMinimizarLibro_Click);
            // 
            // pbCerrarLibro
            // 
            this.pbCerrarLibro.Image = global::capaPresentacion.Properties.Resources.CERRAR_SB;
            this.pbCerrarLibro.Location = new System.Drawing.Point(1158, 9);
            this.pbCerrarLibro.Name = "pbCerrarLibro";
            this.pbCerrarLibro.Size = new System.Drawing.Size(30, 30);
            this.pbCerrarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarLibro.TabIndex = 1;
            this.pbCerrarLibro.TabStop = false;
            this.pbCerrarLibro.Click += new System.EventHandler(this.pbCerrarLibro_Click);
            // 
            // lblHeaderGenero
            // 
            this.lblHeaderGenero.AutoSize = true;
            this.lblHeaderGenero.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderGenero.ForeColor = System.Drawing.Color.White;
            this.lblHeaderGenero.Location = new System.Drawing.Point(12, 9);
            this.lblHeaderGenero.Name = "lblHeaderGenero";
            this.lblHeaderGenero.Size = new System.Drawing.Size(195, 28);
            this.lblHeaderGenero.TabIndex = 0;
            this.lblHeaderGenero.Text = "Gestion de Libros";
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLibro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLibro.Location = new System.Drawing.Point(884, 445);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarLibro.TabIndex = 33;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLibro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLibro.ForeColor = System.Drawing.Color.White;
            this.btnEditarLibro.Location = new System.Drawing.Point(730, 445);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Size = new System.Drawing.Size(120, 30);
            this.btnEditarLibro.TabIndex = 32;
            this.btnEditarLibro.Text = "Editar";
            this.btnEditarLibro.UseVisualStyleBackColor = false;
            // 
            // lblTitutoListadoLibro
            // 
            this.lblTitutoListadoLibro.AutoSize = true;
            this.lblTitutoListadoLibro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutoListadoLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitutoListadoLibro.Location = new System.Drawing.Point(495, 75);
            this.lblTitutoListadoLibro.Name = "lblTitutoListadoLibro";
            this.lblTitutoListadoLibro.Size = new System.Drawing.Size(175, 26);
            this.lblTitutoListadoLibro.TabIndex = 31;
            this.lblTitutoListadoLibro.Text = "Listado de Libros";
            this.lblTitutoListadoLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(419, 119);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.Size = new System.Drawing.Size(732, 305);
            this.dgvLibro.TabIndex = 30;
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDivisor.Location = new System.Drawing.Point(369, 75);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(5, 400);
            this.pnlDivisor.TabIndex = 29;
            // 
            // pbLogoLibro
            // 
            this.pbLogoLibro.Image = global::capaPresentacion.Properties.Resources.LOGO_BLANCO;
            this.pbLogoLibro.Location = new System.Drawing.Point(196, 413);
            this.pbLogoLibro.Name = "pbLogoLibro";
            this.pbLogoLibro.Size = new System.Drawing.Size(150, 75);
            this.pbLogoLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoLibro.TabIndex = 36;
            this.pbLogoLibro.TabStop = false;
            // 
            // btnMenuLibro
            // 
            this.btnMenuLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenuLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLibro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLibro.ForeColor = System.Drawing.Color.White;
            this.btnMenuLibro.Location = new System.Drawing.Point(29, 413);
            this.btnMenuLibro.Name = "btnMenuLibro";
            this.btnMenuLibro.Size = new System.Drawing.Size(120, 30);
            this.btnMenuLibro.TabIndex = 35;
            this.btnMenuLibro.Text = "Menu";
            this.btnMenuLibro.UseVisualStyleBackColor = false;
            this.btnMenuLibro.Click += new System.EventHandler(this.btnMenuLibro_Click);
            // 
            // btnLogoutLibro
            // 
            this.btnLogoutLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogoutLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutLibro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutLibro.ForeColor = System.Drawing.Color.White;
            this.btnLogoutLibro.Location = new System.Drawing.Point(29, 458);
            this.btnLogoutLibro.Name = "btnLogoutLibro";
            this.btnLogoutLibro.Size = new System.Drawing.Size(120, 30);
            this.btnLogoutLibro.TabIndex = 34;
            this.btnLogoutLibro.Text = "Cerrar Sesión";
            this.btnLogoutLibro.UseVisualStyleBackColor = false;
            this.btnLogoutLibro.Click += new System.EventHandler(this.btnLogoutLibro_Click);
            // 
            // lblTituloFormularioLibro
            // 
            this.lblTituloFormularioLibro.AutoSize = true;
            this.lblTituloFormularioLibro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormularioLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloFormularioLibro.Location = new System.Drawing.Point(78, 75);
            this.lblTituloFormularioLibro.Name = "lblTituloFormularioLibro";
            this.lblTituloFormularioLibro.Size = new System.Drawing.Size(158, 26);
            this.lblTituloFormularioLibro.TabIndex = 37;
            this.lblTituloFormularioLibro.Text = "Datos del Libro";
            this.lblTituloFormularioLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormDatosLibro
            // 
            this.btnFormDatosLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFormDatosLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormDatosLibro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDatosLibro.ForeColor = System.Drawing.Color.White;
            this.btnFormDatosLibro.Location = new System.Drawing.Point(45, 330);
            this.btnFormDatosLibro.Name = "btnFormDatosLibro";
            this.btnFormDatosLibro.Size = new System.Drawing.Size(275, 40);
            this.btnFormDatosLibro.TabIndex = 41;
            this.btnFormDatosLibro.Text = "Enviar datos";
            this.btnFormDatosLibro.UseVisualStyleBackColor = false;
            // 
            // lblGeneroLibro
            // 
            this.lblGeneroLibro.AutoSize = true;
            this.lblGeneroLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGeneroLibro.Location = new System.Drawing.Point(50, 262);
            this.lblGeneroLibro.Name = "lblGeneroLibro";
            this.lblGeneroLibro.Size = new System.Drawing.Size(54, 19);
            this.lblGeneroLibro.TabIndex = 48;
            this.lblGeneroLibro.Text = "Genero";
            // 
            // tbAnioLibro
            // 
            this.tbAnioLibro.Location = new System.Drawing.Point(35, 237);
            this.tbAnioLibro.Name = "tbAnioLibro";
            this.tbAnioLibro.Size = new System.Drawing.Size(300, 20);
            this.tbAnioLibro.TabIndex = 47;
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAutorLibro.Location = new System.Drawing.Point(50, 162);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(44, 19);
            this.lblAutorLibro.TabIndex = 46;
            this.lblAutorLibro.Text = "Autor";
            // 
            // lblAnioLibro
            // 
            this.lblAnioLibro.AutoSize = true;
            this.lblAnioLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAnioLibro.Location = new System.Drawing.Point(50, 212);
            this.lblAnioLibro.Name = "lblAnioLibro";
            this.lblAnioLibro.Size = new System.Drawing.Size(127, 19);
            this.lblAnioLibro.TabIndex = 44;
            this.lblAnioLibro.Text = "Año de publicacion";
            // 
            // tbTituloLibro
            // 
            this.tbTituloLibro.Location = new System.Drawing.Point(35, 137);
            this.tbTituloLibro.Name = "tbTituloLibro";
            this.tbTituloLibro.Size = new System.Drawing.Size(300, 20);
            this.tbTituloLibro.TabIndex = 43;
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloLibro.Location = new System.Drawing.Point(50, 112);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(43, 19);
            this.lblTituloLibro.TabIndex = 42;
            this.lblTituloLibro.Text = "Titulo";
            // 
            // cbGeneroLibro
            // 
            this.cbGeneroLibro.FormattingEnabled = true;
            this.cbGeneroLibro.Location = new System.Drawing.Point(35, 287);
            this.cbGeneroLibro.Name = "cbGeneroLibro";
            this.cbGeneroLibro.Size = new System.Drawing.Size(300, 21);
            this.cbGeneroLibro.TabIndex = 49;
            // 
            // cbAutorLibro
            // 
            this.cbAutorLibro.FormattingEnabled = true;
            this.cbAutorLibro.Location = new System.Drawing.Point(35, 187);
            this.cbAutorLibro.Name = "cbAutorLibro";
            this.cbAutorLibro.Size = new System.Drawing.Size(300, 21);
            this.cbAutorLibro.TabIndex = 50;
            // 
            // CP_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.cbAutorLibro);
            this.Controls.Add(this.cbGeneroLibro);
            this.Controls.Add(this.lblGeneroLibro);
            this.Controls.Add(this.tbAnioLibro);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.lblAnioLibro);
            this.Controls.Add(this.tbTituloLibro);
            this.Controls.Add(this.lblTituloLibro);
            this.Controls.Add(this.btnFormDatosLibro);
            this.Controls.Add(this.lblTituloFormularioLibro);
            this.Controls.Add(this.pbLogoLibro);
            this.Controls.Add(this.btnMenuLibro);
            this.Controls.Add(this.btnLogoutLibro);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnEditarLibro);
            this.Controls.Add(this.lblTitutoListadoLibro);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP_Libro";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbMinimizarLibro;
        private System.Windows.Forms.PictureBox pbCerrarLibro;
        private System.Windows.Forms.Label lblHeaderGenero;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Label lblTitutoListadoLibro;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.PictureBox pbLogoLibro;
        private System.Windows.Forms.Button btnMenuLibro;
        private System.Windows.Forms.Button btnLogoutLibro;
        private System.Windows.Forms.Label lblTituloFormularioLibro;
        private System.Windows.Forms.Button btnFormDatosLibro;
        private System.Windows.Forms.Label lblGeneroLibro;
        private System.Windows.Forms.TextBox tbAnioLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Label lblAnioLibro;
        private System.Windows.Forms.TextBox tbTituloLibro;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.ComboBox cbGeneroLibro;
        private System.Windows.Forms.ComboBox cbAutorLibro;
    }
}