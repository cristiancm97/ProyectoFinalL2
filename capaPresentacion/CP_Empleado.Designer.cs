﻿namespace capaPresentacion
{
    partial class CP_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CP_Empleado));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblHeaderEmp = new System.Windows.Forms.Label();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.lblTituloFormularioEmp = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFormDatosEmp = new System.Windows.Forms.Button();
            this.btnLogoutEmp = new System.Windows.Forms.Button();
            this.btnMenuEmp = new System.Windows.Forms.Button();
            this.lblTitutoListadoEmp = new System.Windows.Forms.Label();
            this.btnEditarEmp = new System.Windows.Forms.Button();
            this.btnEliminarEmp = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmailU = new System.Windows.Forms.Label();
            this.lblUsuarioU = new System.Windows.Forms.Label();
            this.lblApellidoU = new System.Windows.Forms.Label();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.pbMinimizar);
            this.pnlHeader.Controls.Add(this.pbCerrar);
            this.pnlHeader.Controls.Add(this.lblHeaderEmp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = global::capaPresentacion.Properties.Resources.MINIMIZAR_SB;
            this.pbMinimizar.Location = new System.Drawing.Point(1122, 9);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::capaPresentacion.Properties.Resources.CERRAR_SB;
            this.pbCerrar.Location = new System.Drawing.Point(1158, 9);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(30, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lblHeaderEmp
            // 
            this.lblHeaderEmp.AutoSize = true;
            this.lblHeaderEmp.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderEmp.ForeColor = System.Drawing.Color.White;
            this.lblHeaderEmp.Location = new System.Drawing.Point(12, 9);
            this.lblHeaderEmp.Name = "lblHeaderEmp";
            this.lblHeaderEmp.Size = new System.Drawing.Size(246, 28);
            this.lblHeaderEmp.TabIndex = 0;
            this.lblHeaderEmp.Text = "Gestion de Empleados";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDivisor.Location = new System.Drawing.Point(393, 75);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(5, 400);
            this.pnlDivisor.TabIndex = 2;
            // 
            // lblTituloFormularioEmp
            // 
            this.lblTituloFormularioEmp.AutoSize = true;
            this.lblTituloFormularioEmp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormularioEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloFormularioEmp.Location = new System.Drawing.Point(78, 75);
            this.lblTituloFormularioEmp.Name = "lblTituloFormularioEmp";
            this.lblTituloFormularioEmp.Size = new System.Drawing.Size(205, 26);
            this.lblTituloFormularioEmp.TabIndex = 3;
            this.lblTituloFormularioEmp.Text = "Datos del Empleado";
            this.lblTituloFormularioEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(25, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApellido.Location = new System.Drawing.Point(25, 155);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(255, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(127, 183);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(219, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nro de celular";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(25, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 243);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(263, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(110, 273);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(236, 20);
            this.txtContra.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña";
            // 
            // btnFormDatosEmp
            // 
            this.btnFormDatosEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFormDatosEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormDatosEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDatosEmp.ForeColor = System.Drawing.Color.White;
            this.btnFormDatosEmp.Location = new System.Drawing.Point(45, 322);
            this.btnFormDatosEmp.Name = "btnFormDatosEmp";
            this.btnFormDatosEmp.Size = new System.Drawing.Size(275, 40);
            this.btnFormDatosEmp.TabIndex = 16;
            this.btnFormDatosEmp.Text = "Enviar datos";
            this.btnFormDatosEmp.UseVisualStyleBackColor = false;
            this.btnFormDatosEmp.Click += new System.EventHandler(this.btnFormDatosEmp_Click);
            // 
            // btnLogoutEmp
            // 
            this.btnLogoutEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogoutEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutEmp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutEmp.ForeColor = System.Drawing.Color.White;
            this.btnLogoutEmp.Location = new System.Drawing.Point(29, 458);
            this.btnLogoutEmp.Name = "btnLogoutEmp";
            this.btnLogoutEmp.Size = new System.Drawing.Size(120, 30);
            this.btnLogoutEmp.TabIndex = 17;
            this.btnLogoutEmp.Text = "Cerrar Sesión";
            this.btnLogoutEmp.UseVisualStyleBackColor = false;
            this.btnLogoutEmp.Click += new System.EventHandler(this.btnLogoutEmp_Click);
            // 
            // btnMenuEmp
            // 
            this.btnMenuEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenuEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEmp.ForeColor = System.Drawing.Color.White;
            this.btnMenuEmp.Location = new System.Drawing.Point(29, 413);
            this.btnMenuEmp.Name = "btnMenuEmp";
            this.btnMenuEmp.Size = new System.Drawing.Size(120, 30);
            this.btnMenuEmp.TabIndex = 18;
            this.btnMenuEmp.Text = "Menu";
            this.btnMenuEmp.UseVisualStyleBackColor = false;
            this.btnMenuEmp.Click += new System.EventHandler(this.btnMenuEmp_Click);
            // 
            // lblTitutoListadoEmp
            // 
            this.lblTitutoListadoEmp.AutoSize = true;
            this.lblTitutoListadoEmp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutoListadoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitutoListadoEmp.Location = new System.Drawing.Point(495, 75);
            this.lblTitutoListadoEmp.Name = "lblTitutoListadoEmp";
            this.lblTitutoListadoEmp.Size = new System.Drawing.Size(222, 26);
            this.lblTitutoListadoEmp.TabIndex = 20;
            this.lblTitutoListadoEmp.Text = "Listado de Empleados";
            this.lblTitutoListadoEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarEmp
            // 
            this.btnEditarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmp.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmp.Location = new System.Drawing.Point(730, 445);
            this.btnEditarEmp.Name = "btnEditarEmp";
            this.btnEditarEmp.Size = new System.Drawing.Size(120, 30);
            this.btnEditarEmp.TabIndex = 21;
            this.btnEditarEmp.Text = "Editar";
            this.btnEditarEmp.UseVisualStyleBackColor = false;
            this.btnEditarEmp.Click += new System.EventHandler(this.btnEditarEmp_Click);
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmp.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmp.Location = new System.Drawing.Point(884, 445);
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarEmp.TabIndex = 22;
            this.btnEliminarEmp.Text = "Eliminar";
            this.btnEliminarEmp.UseVisualStyleBackColor = false;
            this.btnEliminarEmp.Click += new System.EventHandler(this.btnEliminarEmp_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.ColumnHeadersHeight = 30;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvEmp.Location = new System.Drawing.Point(419, 119);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmp.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmp.Size = new System.Drawing.Size(732, 305);
            this.dgvEmp.TabIndex = 23;
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
            this.pnlUser.TabIndex = 24;
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
            // CP_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnEliminarEmp);
            this.Controls.Add(this.btnEditarEmp);
            this.Controls.Add(this.lblTitutoListadoEmp);
            this.Controls.Add(this.btnMenuEmp);
            this.Controls.Add(this.btnLogoutEmp);
            this.Controls.Add(this.btnFormDatosEmp);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloFormularioEmp);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlHeader);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP_Empleado";
            this.Load += new System.EventHandler(this.CP_Empleado_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblHeaderEmp;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.Label lblTituloFormularioEmp;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFormDatosEmp;
        private System.Windows.Forms.Button btnLogoutEmp;
        private System.Windows.Forms.Button btnMenuEmp;
        private System.Windows.Forms.Label lblTitutoListadoEmp;
        private System.Windows.Forms.Button btnEditarEmp;
        private System.Windows.Forms.Button btnEliminarEmp;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailU;
        private System.Windows.Forms.Label lblUsuarioU;
        private System.Windows.Forms.Label lblApellidoU;
        private System.Windows.Forms.Label lblNombreU;
    }
}