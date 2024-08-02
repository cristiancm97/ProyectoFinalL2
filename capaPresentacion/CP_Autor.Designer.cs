namespace capaPresentacion
{
    partial class CP_Autor
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
            this.pbMinimizarAutor = new System.Windows.Forms.PictureBox();
            this.pbCerrarAutor = new System.Windows.Forms.PictureBox();
            this.lblHeaderAutor = new System.Windows.Forms.Label();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.lblTitutoListadoAutor = new System.Windows.Forms.Label();
            this.lblTituloFormularioAutor = new System.Windows.Forms.Label();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.pbLogoAutor = new System.Windows.Forms.PictureBox();
            this.btnMenuAutor = new System.Windows.Forms.Button();
            this.btnLogoutAutor = new System.Windows.Forms.Button();
            this.tbBibliografiaAutor = new System.Windows.Forms.RichTextBox();
            this.lblBibliografiaAutor = new System.Windows.Forms.Label();
            this.tbNombreAutor = new System.Windows.Forms.TextBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.btnFormDatosAutor = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.pbMinimizarAutor);
            this.pnlHeader.Controls.Add(this.pbCerrarAutor);
            this.pnlHeader.Controls.Add(this.lblHeaderAutor);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 2;
            // 
            // pbMinimizarAutor
            // 
            this.pbMinimizarAutor.Image = global::capaPresentacion.Properties.Resources.MINIMIZAR_SB;
            this.pbMinimizarAutor.Location = new System.Drawing.Point(1122, 9);
            this.pbMinimizarAutor.Name = "pbMinimizarAutor";
            this.pbMinimizarAutor.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizarAutor.TabIndex = 2;
            this.pbMinimizarAutor.TabStop = false;
            this.pbMinimizarAutor.Click += new System.EventHandler(this.pbMinimizarAutor_Click);
            // 
            // pbCerrarAutor
            // 
            this.pbCerrarAutor.Image = global::capaPresentacion.Properties.Resources.CERRAR_SB;
            this.pbCerrarAutor.Location = new System.Drawing.Point(1158, 9);
            this.pbCerrarAutor.Name = "pbCerrarAutor";
            this.pbCerrarAutor.Size = new System.Drawing.Size(30, 30);
            this.pbCerrarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarAutor.TabIndex = 1;
            this.pbCerrarAutor.TabStop = false;
            this.pbCerrarAutor.Click += new System.EventHandler(this.pbCerrarAutor_Click);
            // 
            // lblHeaderAutor
            // 
            this.lblHeaderAutor.AutoSize = true;
            this.lblHeaderAutor.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderAutor.ForeColor = System.Drawing.Color.White;
            this.lblHeaderAutor.Location = new System.Drawing.Point(12, 9);
            this.lblHeaderAutor.Name = "lblHeaderAutor";
            this.lblHeaderAutor.Size = new System.Drawing.Size(319, 28);
            this.lblHeaderAutor.TabIndex = 0;
            this.lblHeaderAutor.Text = "Gestion de Autores Literarios";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDivisor.Location = new System.Drawing.Point(369, 75);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(5, 400);
            this.pnlDivisor.TabIndex = 3;
            // 
            // lblTitutoListadoAutor
            // 
            this.lblTitutoListadoAutor.AutoSize = true;
            this.lblTitutoListadoAutor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutoListadoAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitutoListadoAutor.Location = new System.Drawing.Point(495, 75);
            this.lblTitutoListadoAutor.Name = "lblTitutoListadoAutor";
            this.lblTitutoListadoAutor.Size = new System.Drawing.Size(191, 26);
            this.lblTitutoListadoAutor.TabIndex = 22;
            this.lblTitutoListadoAutor.Text = "Listado de Autores";
            this.lblTitutoListadoAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloFormularioAutor
            // 
            this.lblTituloFormularioAutor.AutoSize = true;
            this.lblTituloFormularioAutor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormularioAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloFormularioAutor.Location = new System.Drawing.Point(78, 75);
            this.lblTituloFormularioAutor.Name = "lblTituloFormularioAutor";
            this.lblTituloFormularioAutor.Size = new System.Drawing.Size(163, 26);
            this.lblTituloFormularioAutor.TabIndex = 21;
            this.lblTituloFormularioAutor.Text = "Datos del Autor";
            this.lblTituloFormularioAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAutor
            // 
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Location = new System.Drawing.Point(419, 119);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.Size = new System.Drawing.Size(732, 305);
            this.dgvAutor.TabIndex = 24;
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAutor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAutor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAutor.Location = new System.Drawing.Point(884, 445);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarAutor.TabIndex = 26;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = false;
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAutor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAutor.ForeColor = System.Drawing.Color.White;
            this.btnEditarAutor.Location = new System.Drawing.Point(730, 445);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(120, 30);
            this.btnEditarAutor.TabIndex = 25;
            this.btnEditarAutor.Text = "Editar";
            this.btnEditarAutor.UseVisualStyleBackColor = false;
            // 
            // pbLogoAutor
            // 
            this.pbLogoAutor.Image = global::capaPresentacion.Properties.Resources.LOGO_BLANCO;
            this.pbLogoAutor.Location = new System.Drawing.Point(196, 413);
            this.pbLogoAutor.Name = "pbLogoAutor";
            this.pbLogoAutor.Size = new System.Drawing.Size(150, 75);
            this.pbLogoAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoAutor.TabIndex = 29;
            this.pbLogoAutor.TabStop = false;
            // 
            // btnMenuAutor
            // 
            this.btnMenuAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenuAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAutor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAutor.ForeColor = System.Drawing.Color.White;
            this.btnMenuAutor.Location = new System.Drawing.Point(29, 413);
            this.btnMenuAutor.Name = "btnMenuAutor";
            this.btnMenuAutor.Size = new System.Drawing.Size(120, 30);
            this.btnMenuAutor.TabIndex = 28;
            this.btnMenuAutor.Text = "Menu";
            this.btnMenuAutor.UseVisualStyleBackColor = false;
            this.btnMenuAutor.Click += new System.EventHandler(this.btnMenuAutor_Click);
            // 
            // btnLogoutAutor
            // 
            this.btnLogoutAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogoutAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutAutor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAutor.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAutor.Location = new System.Drawing.Point(29, 458);
            this.btnLogoutAutor.Name = "btnLogoutAutor";
            this.btnLogoutAutor.Size = new System.Drawing.Size(120, 30);
            this.btnLogoutAutor.TabIndex = 27;
            this.btnLogoutAutor.Text = "Cerrar Sesión";
            this.btnLogoutAutor.UseVisualStyleBackColor = false;
            this.btnLogoutAutor.Click += new System.EventHandler(this.btnLogoutAutor_Click);
            // 
            // tbBibliografiaAutor
            // 
            this.tbBibliografiaAutor.Location = new System.Drawing.Point(35, 185);
            this.tbBibliografiaAutor.Name = "tbBibliografiaAutor";
            this.tbBibliografiaAutor.Size = new System.Drawing.Size(300, 150);
            this.tbBibliografiaAutor.TabIndex = 39;
            this.tbBibliografiaAutor.Text = "";
            // 
            // lblBibliografiaAutor
            // 
            this.lblBibliografiaAutor.AutoSize = true;
            this.lblBibliografiaAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliografiaAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBibliografiaAutor.Location = new System.Drawing.Point(50, 160);
            this.lblBibliografiaAutor.Name = "lblBibliografiaAutor";
            this.lblBibliografiaAutor.Size = new System.Drawing.Size(77, 19);
            this.lblBibliografiaAutor.TabIndex = 38;
            this.lblBibliografiaAutor.Text = "Bibliografia";
            // 
            // tbNombreAutor
            // 
            this.tbNombreAutor.Location = new System.Drawing.Point(35, 135);
            this.tbNombreAutor.Name = "tbNombreAutor";
            this.tbNombreAutor.Size = new System.Drawing.Size(300, 20);
            this.tbNombreAutor.TabIndex = 37;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreAutor.Location = new System.Drawing.Point(50, 110);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(119, 19);
            this.lblNombreAutor.TabIndex = 36;
            this.lblNombreAutor.Text = "Nombre del autor";
            // 
            // btnFormDatosAutor
            // 
            this.btnFormDatosAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFormDatosAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormDatosAutor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDatosAutor.ForeColor = System.Drawing.Color.White;
            this.btnFormDatosAutor.Location = new System.Drawing.Point(45, 347);
            this.btnFormDatosAutor.Name = "btnFormDatosAutor";
            this.btnFormDatosAutor.Size = new System.Drawing.Size(275, 40);
            this.btnFormDatosAutor.TabIndex = 40;
            this.btnFormDatosAutor.Text = "Enviar datos";
            this.btnFormDatosAutor.UseVisualStyleBackColor = false;
            // 
            // CP_Autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.btnFormDatosAutor);
            this.Controls.Add(this.tbBibliografiaAutor);
            this.Controls.Add(this.lblBibliografiaAutor);
            this.Controls.Add(this.tbNombreAutor);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.pbLogoAutor);
            this.Controls.Add(this.btnMenuAutor);
            this.Controls.Add(this.btnLogoutAutor);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnEditarAutor);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.lblTitutoListadoAutor);
            this.Controls.Add(this.lblTituloFormularioAutor);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Autor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP_Autor";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbMinimizarAutor;
        private System.Windows.Forms.PictureBox pbCerrarAutor;
        private System.Windows.Forms.Label lblHeaderAutor;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.Label lblTitutoListadoAutor;
        private System.Windows.Forms.Label lblTituloFormularioAutor;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.PictureBox pbLogoAutor;
        private System.Windows.Forms.Button btnMenuAutor;
        private System.Windows.Forms.Button btnLogoutAutor;
        private System.Windows.Forms.RichTextBox tbBibliografiaAutor;
        private System.Windows.Forms.Label lblBibliografiaAutor;
        private System.Windows.Forms.TextBox tbNombreAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Button btnFormDatosAutor;
    }
}