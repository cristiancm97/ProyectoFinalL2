namespace capaPresentacion
{
    partial class menuAdmin
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
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbAutor = new System.Windows.Forms.PictureBox();
            this.pbGenero = new System.Windows.Forms.PictureBox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnLogoutMenu = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.pbMinimizar);
            this.pnlHeader.Controls.Add(this.pbCerrar);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 0;
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
            this.pbMinimizar.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.pbCerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(272, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Menu del Administrador";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(307, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(607, 36);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Bienvenido NOMBRE, que desea gestionar?";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::capaPresentacion.Properties.Resources.LOGO_NARANJA;
            this.pbLogo.Location = new System.Drawing.Point(1038, 513);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // pbAutor
            // 
            this.pbAutor.Image = global::capaPresentacion.Properties.Resources.AUTOR;
            this.pbAutor.Location = new System.Drawing.Point(930, 150);
            this.pbAutor.Name = "pbAutor";
            this.pbAutor.Size = new System.Drawing.Size(240, 240);
            this.pbAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAutor.TabIndex = 5;
            this.pbAutor.TabStop = false;
            // 
            // pbGenero
            // 
            this.pbGenero.Image = global::capaPresentacion.Properties.Resources.GENERO;
            this.pbGenero.Location = new System.Drawing.Point(630, 150);
            this.pbGenero.Name = "pbGenero";
            this.pbGenero.Size = new System.Drawing.Size(240, 240);
            this.pbGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGenero.TabIndex = 4;
            this.pbGenero.TabStop = false;
            // 
            // pbLibro
            // 
            this.pbLibro.Image = global::capaPresentacion.Properties.Resources.LIBROS;
            this.pbLibro.Location = new System.Drawing.Point(330, 150);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(240, 240);
            this.pbLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibro.TabIndex = 3;
            this.pbLibro.TabStop = false;
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Image = global::capaPresentacion.Properties.Resources.EMPLEADO;
            this.pbEmpleado.Location = new System.Drawing.Point(30, 150);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(240, 240);
            this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpleado.TabIndex = 2;
            this.pbEmpleado.TabStop = false;
            // 
            // pbFondo
            // 
            this.pbFondo.Image = global::capaPresentacion.Properties.Resources.FONDO_LOGIN;
            this.pbFondo.Location = new System.Drawing.Point(0, 50);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(1200, 550);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 1;
            this.pbFondo.TabStop = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Location = new System.Drawing.Point(50, 420);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(200, 40);
            this.btnEmpleado.TabIndex = 7;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(350, 420);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(200, 40);
            this.btnLibro.TabIndex = 9;
            this.btnLibro.Text = "LIBROS";
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenero.ForeColor = System.Drawing.Color.White;
            this.btnGenero.Location = new System.Drawing.Point(650, 420);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(200, 40);
            this.btnGenero.TabIndex = 10;
            this.btnGenero.Text = "GENEROS";
            this.btnGenero.UseVisualStyleBackColor = false;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.White;
            this.btnAutor.Location = new System.Drawing.Point(950, 420);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(200, 40);
            this.btnAutor.TabIndex = 11;
            this.btnAutor.Text = "AUTORES";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnLogoutMenu
            // 
            this.btnLogoutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogoutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutMenu.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutMenu.ForeColor = System.Drawing.Color.White;
            this.btnLogoutMenu.Location = new System.Drawing.Point(12, 558);
            this.btnLogoutMenu.Name = "btnLogoutMenu";
            this.btnLogoutMenu.Size = new System.Drawing.Size(120, 30);
            this.btnLogoutMenu.TabIndex = 12;
            this.btnLogoutMenu.Text = "Cerrar Sesión";
            this.btnLogoutMenu.UseVisualStyleBackColor = false;
            this.btnLogoutMenu.Click += new System.EventHandler(this.btnLogoutMenu_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnLogoutMenu);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnGenero);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbAutor);
            this.Controls.Add(this.pbGenero);
            this.Controls.Add(this.pbLibro);
            this.Controls.Add(this.pbEmpleado);
            this.Controls.Add(this.pbFondo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private System.Windows.Forms.PictureBox pbLibro;
        private System.Windows.Forms.PictureBox pbGenero;
        private System.Windows.Forms.PictureBox pbAutor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnLogoutMenu;
    }
}