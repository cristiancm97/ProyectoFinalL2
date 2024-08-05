namespace capaPresentacion
{
    partial class CP_Genero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CP_Genero));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbMinimizarGenero = new System.Windows.Forms.PictureBox();
            this.pbCerrarGenero = new System.Windows.Forms.PictureBox();
            this.lblHeaderGenero = new System.Windows.Forms.Label();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.lblTitutoListadoGenero = new System.Windows.Forms.Label();
            this.lblTituloFormularioGenero = new System.Windows.Forms.Label();
            this.btnEliminarGenero = new System.Windows.Forms.Button();
            this.btnEditarGenero = new System.Windows.Forms.Button();
            this.btnMenuGenero = new System.Windows.Forms.Button();
            this.btnLogoutGenero = new System.Windows.Forms.Button();
            this.lblDescripcionGenero = new System.Windows.Forms.Label();
            this.txtNombreGenero = new System.Windows.Forms.TextBox();
            this.lblNombreGenero = new System.Windows.Forms.Label();
            this.txtDescripcionGenero = new System.Windows.Forms.RichTextBox();
            this.btnFormDatosGenero = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmailU = new System.Windows.Forms.Label();
            this.lblUsuarioU = new System.Windows.Forms.Label();
            this.lblApellidoU = new System.Windows.Forms.Label();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.pbMinimizarGenero);
            this.pnlHeader.Controls.Add(this.pbCerrarGenero);
            this.pnlHeader.Controls.Add(this.lblHeaderGenero);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pbMinimizarGenero
            // 
            this.pbMinimizarGenero.Image = global::capaPresentacion.Properties.Resources.MINIMIZAR_SB;
            this.pbMinimizarGenero.Location = new System.Drawing.Point(1122, 9);
            this.pbMinimizarGenero.Name = "pbMinimizarGenero";
            this.pbMinimizarGenero.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizarGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizarGenero.TabIndex = 2;
            this.pbMinimizarGenero.TabStop = false;
            this.pbMinimizarGenero.Click += new System.EventHandler(this.pbMinimizarGenero_Click);
            // 
            // pbCerrarGenero
            // 
            this.pbCerrarGenero.Image = global::capaPresentacion.Properties.Resources.CERRAR_SB;
            this.pbCerrarGenero.Location = new System.Drawing.Point(1158, 9);
            this.pbCerrarGenero.Name = "pbCerrarGenero";
            this.pbCerrarGenero.Size = new System.Drawing.Size(30, 30);
            this.pbCerrarGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarGenero.TabIndex = 1;
            this.pbCerrarGenero.TabStop = false;
            this.pbCerrarGenero.Click += new System.EventHandler(this.pbCerrarGenero_Click);
            // 
            // lblHeaderGenero
            // 
            this.lblHeaderGenero.AutoSize = true;
            this.lblHeaderGenero.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderGenero.ForeColor = System.Drawing.Color.White;
            this.lblHeaderGenero.Location = new System.Drawing.Point(12, 9);
            this.lblHeaderGenero.Name = "lblHeaderGenero";
            this.lblHeaderGenero.Size = new System.Drawing.Size(322, 28);
            this.lblHeaderGenero.TabIndex = 0;
            this.lblHeaderGenero.Text = "Gestion de Generos Literarios";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDivisor.Location = new System.Drawing.Point(393, 75);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(5, 400);
            this.pnlDivisor.TabIndex = 3;
            // 
            // dgvGenero
            // 
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(419, 119);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.Size = new System.Drawing.Size(732, 305);
            this.dgvGenero.TabIndex = 24;
            // 
            // lblTitutoListadoGenero
            // 
            this.lblTitutoListadoGenero.AutoSize = true;
            this.lblTitutoListadoGenero.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutoListadoGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitutoListadoGenero.Location = new System.Drawing.Point(495, 75);
            this.lblTitutoListadoGenero.Name = "lblTitutoListadoGenero";
            this.lblTitutoListadoGenero.Size = new System.Drawing.Size(290, 26);
            this.lblTitutoListadoGenero.TabIndex = 26;
            this.lblTitutoListadoGenero.Text = "Listado de Generos Literarios";
            this.lblTitutoListadoGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloFormularioGenero
            // 
            this.lblTituloFormularioGenero.AutoSize = true;
            this.lblTituloFormularioGenero.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormularioGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloFormularioGenero.Location = new System.Drawing.Point(78, 75);
            this.lblTituloFormularioGenero.Name = "lblTituloFormularioGenero";
            this.lblTituloFormularioGenero.Size = new System.Drawing.Size(178, 26);
            this.lblTituloFormularioGenero.TabIndex = 25;
            this.lblTituloFormularioGenero.Text = "Datos del Genero";
            this.lblTituloFormularioGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGenero.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGenero.ForeColor = System.Drawing.Color.White;
            this.btnEliminarGenero.Location = new System.Drawing.Point(884, 445);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarGenero.TabIndex = 28;
            this.btnEliminarGenero.Text = "Eliminar";
            this.btnEliminarGenero.UseVisualStyleBackColor = false;
            this.btnEliminarGenero.Click += new System.EventHandler(this.btnEliminarGenero_Click);
            // 
            // btnEditarGenero
            // 
            this.btnEditarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGenero.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGenero.ForeColor = System.Drawing.Color.White;
            this.btnEditarGenero.Location = new System.Drawing.Point(730, 445);
            this.btnEditarGenero.Name = "btnEditarGenero";
            this.btnEditarGenero.Size = new System.Drawing.Size(120, 30);
            this.btnEditarGenero.TabIndex = 27;
            this.btnEditarGenero.Text = "Editar";
            this.btnEditarGenero.UseVisualStyleBackColor = false;
            this.btnEditarGenero.Click += new System.EventHandler(this.btnEditarGenero_Click);
            // 
            // btnMenuGenero
            // 
            this.btnMenuGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenuGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGenero.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGenero.ForeColor = System.Drawing.Color.White;
            this.btnMenuGenero.Location = new System.Drawing.Point(29, 413);
            this.btnMenuGenero.Name = "btnMenuGenero";
            this.btnMenuGenero.Size = new System.Drawing.Size(120, 30);
            this.btnMenuGenero.TabIndex = 30;
            this.btnMenuGenero.Text = "Menu";
            this.btnMenuGenero.UseVisualStyleBackColor = false;
            this.btnMenuGenero.Click += new System.EventHandler(this.btnMenuGenero_Click);
            // 
            // btnLogoutGenero
            // 
            this.btnLogoutGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogoutGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutGenero.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutGenero.ForeColor = System.Drawing.Color.White;
            this.btnLogoutGenero.Location = new System.Drawing.Point(29, 458);
            this.btnLogoutGenero.Name = "btnLogoutGenero";
            this.btnLogoutGenero.Size = new System.Drawing.Size(120, 30);
            this.btnLogoutGenero.TabIndex = 29;
            this.btnLogoutGenero.Text = "Cerrar Sesión";
            this.btnLogoutGenero.UseVisualStyleBackColor = false;
            this.btnLogoutGenero.Click += new System.EventHandler(this.btnLogoutGenero_Click);
            // 
            // lblDescripcionGenero
            // 
            this.lblDescripcionGenero.AutoSize = true;
            this.lblDescripcionGenero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripcionGenero.Location = new System.Drawing.Point(50, 160);
            this.lblDescripcionGenero.Name = "lblDescripcionGenero";
            this.lblDescripcionGenero.Size = new System.Drawing.Size(81, 19);
            this.lblDescripcionGenero.TabIndex = 34;
            this.lblDescripcionGenero.Text = "Descripción";
            // 
            // txtNombreGenero
            // 
            this.txtNombreGenero.Location = new System.Drawing.Point(35, 135);
            this.txtNombreGenero.Name = "txtNombreGenero";
            this.txtNombreGenero.Size = new System.Drawing.Size(300, 20);
            this.txtNombreGenero.TabIndex = 33;
            // 
            // lblNombreGenero
            // 
            this.lblNombreGenero.AutoSize = true;
            this.lblNombreGenero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreGenero.Location = new System.Drawing.Point(50, 110);
            this.lblNombreGenero.Name = "lblNombreGenero";
            this.lblNombreGenero.Size = new System.Drawing.Size(129, 19);
            this.lblNombreGenero.TabIndex = 32;
            this.lblNombreGenero.Text = "Nombre del genero";
            // 
            // txtDescripcionGenero
            // 
            this.txtDescripcionGenero.Location = new System.Drawing.Point(35, 185);
            this.txtDescripcionGenero.Name = "txtDescripcionGenero";
            this.txtDescripcionGenero.Size = new System.Drawing.Size(300, 150);
            this.txtDescripcionGenero.TabIndex = 35;
            this.txtDescripcionGenero.Text = "";
            // 
            // btnFormDatosGenero
            // 
            this.btnFormDatosGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFormDatosGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormDatosGenero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDatosGenero.ForeColor = System.Drawing.Color.White;
            this.btnFormDatosGenero.Location = new System.Drawing.Point(45, 347);
            this.btnFormDatosGenero.Name = "btnFormDatosGenero";
            this.btnFormDatosGenero.Size = new System.Drawing.Size(275, 40);
            this.btnFormDatosGenero.TabIndex = 36;
            this.btnFormDatosGenero.Text = "Enviar datos";
            this.btnFormDatosGenero.UseVisualStyleBackColor = false;
            this.btnFormDatosGenero.Click += new System.EventHandler(this.btnFormDatosGenero_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Controls.Add(this.lblEmailU);
            this.pnlUser.Controls.Add(this.lblUsuarioU);
            this.pnlUser.Controls.Add(this.lblApellidoU);
            this.pnlUser.Controls.Add(this.lblNombreU);
            this.pnlUser.Location = new System.Drawing.Point(170, 396);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(208, 92);
            this.pnlUser.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmailU
            // 
            this.lblEmailU.AutoSize = true;
            this.lblEmailU.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailU.ForeColor = System.Drawing.Color.White;
            this.lblEmailU.Location = new System.Drawing.Point(10, 70);
            this.lblEmailU.Name = "lblEmailU";
            this.lblEmailU.Size = new System.Drawing.Size(42, 17);
            this.lblEmailU.TabIndex = 3;
            this.lblEmailU.Text = "Email";
            // 
            // lblUsuarioU
            // 
            this.lblUsuarioU.AutoSize = true;
            this.lblUsuarioU.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioU.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioU.Location = new System.Drawing.Point(69, 49);
            this.lblUsuarioU.Name = "lblUsuarioU";
            this.lblUsuarioU.Size = new System.Drawing.Size(55, 17);
            this.lblUsuarioU.TabIndex = 2;
            this.lblUsuarioU.Text = "Usuario";
            // 
            // lblApellidoU
            // 
            this.lblApellidoU.AutoSize = true;
            this.lblApellidoU.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoU.ForeColor = System.Drawing.Color.White;
            this.lblApellidoU.Location = new System.Drawing.Point(69, 28);
            this.lblApellidoU.Name = "lblApellidoU";
            this.lblApellidoU.Size = new System.Drawing.Size(60, 17);
            this.lblApellidoU.TabIndex = 1;
            this.lblApellidoU.Text = "Apellido";
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreU.ForeColor = System.Drawing.Color.White;
            this.lblNombreU.Location = new System.Drawing.Point(69, 7);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(58, 17);
            this.lblNombreU.TabIndex = 0;
            this.lblNombreU.Text = "Nombre";
            // 
            // CP_Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.btnFormDatosGenero);
            this.Controls.Add(this.txtDescripcionGenero);
            this.Controls.Add(this.lblDescripcionGenero);
            this.Controls.Add(this.txtNombreGenero);
            this.Controls.Add(this.lblNombreGenero);
            this.Controls.Add(this.btnMenuGenero);
            this.Controls.Add(this.btnLogoutGenero);
            this.Controls.Add(this.btnEliminarGenero);
            this.Controls.Add(this.btnEditarGenero);
            this.Controls.Add(this.lblTitutoListadoGenero);
            this.Controls.Add(this.lblTituloFormularioGenero);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Genero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP_Genero";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbMinimizarGenero;
        private System.Windows.Forms.PictureBox pbCerrarGenero;
        private System.Windows.Forms.Label lblHeaderGenero;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.Label lblTitutoListadoGenero;
        private System.Windows.Forms.Label lblTituloFormularioGenero;
        private System.Windows.Forms.Button btnEliminarGenero;
        private System.Windows.Forms.Button btnEditarGenero;
        private System.Windows.Forms.Button btnMenuGenero;
        private System.Windows.Forms.Button btnLogoutGenero;
        private System.Windows.Forms.Label lblDescripcionGenero;
        private System.Windows.Forms.TextBox txtNombreGenero;
        private System.Windows.Forms.Label lblNombreGenero;
        private System.Windows.Forms.RichTextBox txtDescripcionGenero;
        private System.Windows.Forms.Button btnFormDatosGenero;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailU;
        private System.Windows.Forms.Label lblUsuarioU;
        private System.Windows.Forms.Label lblApellidoU;
        private System.Windows.Forms.Label lblNombreU;
    }
}