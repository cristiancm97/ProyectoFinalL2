namespace capaPresentacion
{
    partial class Login
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
            this.pbMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.pbCerrarLogin = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMinimizarLogin
            // 
            this.pbMinimizarLogin.Image = global::capaPresentacion.Properties.Resources.MINIMIZAR_SB;
            this.pbMinimizarLogin.Location = new System.Drawing.Point(272, 12);
            this.pbMinimizarLogin.Name = "pbMinimizarLogin";
            this.pbMinimizarLogin.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizarLogin.TabIndex = 4;
            this.pbMinimizarLogin.TabStop = false;
            this.pbMinimizarLogin.Click += new System.EventHandler(this.pbMinimizarLogin_Click);
            // 
            // pbCerrarLogin
            // 
            this.pbCerrarLogin.Image = global::capaPresentacion.Properties.Resources.CERRAR_SB;
            this.pbCerrarLogin.Location = new System.Drawing.Point(308, 12);
            this.pbCerrarLogin.Name = "pbCerrarLogin";
            this.pbCerrarLogin.Size = new System.Drawing.Size(30, 30);
            this.pbCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarLogin.TabIndex = 3;
            this.pbCerrarLogin.TabStop = false;
            this.pbCerrarLogin.Click += new System.EventHandler(this.pbCerrarLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(50, 300);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(250, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(60, 275);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 22);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(50, 240);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(250, 20);
            this.tbUsuario.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(60, 215);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 22);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.LOGO_BLANCO;
            this.pictureBox1.Location = new System.Drawing.Point(75, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(75, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(129, 174);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(77, 28);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Log in";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(350, 436);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbMinimizarLogin);
            this.Controls.Add(this.pbCerrarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimizarLogin;
        private System.Windows.Forms.PictureBox pbCerrarLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
    }
}