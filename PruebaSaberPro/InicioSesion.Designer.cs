namespace PruebaSaberPro
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblCorreo2 = new System.Windows.Forms.Label();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContraseñaInicio = new System.Windows.Forms.TextBox();
            this.txtCorreoInicio = new System.Windows.Forms.TextBox();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblInicioSesion.Location = new System.Drawing.Point(276, 59);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(217, 31);
            this.lblInicioSesion.TabIndex = 0;
            this.lblInicioSesion.Text = "Inicio de sesión";
            // 
            // lblCorreo2
            // 
            this.lblCorreo2.AutoSize = true;
            this.lblCorreo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo2.Location = new System.Drawing.Point(152, 67);
            this.lblCorreo2.Name = "lblCorreo2";
            this.lblCorreo2.Size = new System.Drawing.Size(192, 24);
            this.lblCorreo2.TabIndex = 1;
            this.lblCorreo2.Text = "Correo Electrónico:";
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña2.Location = new System.Drawing.Point(221, 152);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(128, 24);
            this.lblContraseña2.TabIndex = 2;
            this.lblContraseña2.Text = "Contraseña: ";
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.btnCancelar);
            this.gbInicio.Controls.Add(this.pictureBox2);
            this.gbInicio.Controls.Add(this.btnIniciar);
            this.gbInicio.Controls.Add(this.pictureBox1);
            this.gbInicio.Controls.Add(this.txtContraseñaInicio);
            this.gbInicio.Controls.Add(this.txtCorreoInicio);
            this.gbInicio.Controls.Add(this.lblCorreo2);
            this.gbInicio.Controls.Add(this.lblContraseña2);
            this.gbInicio.Location = new System.Drawing.Point(57, 121);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(719, 288);
            this.gbInicio.TabIndex = 3;
            this.gbInicio.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(385, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(79, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(221, 239);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 31);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtContraseñaInicio
            // 
            this.txtContraseñaInicio.Location = new System.Drawing.Point(385, 159);
            this.txtContraseñaInicio.Name = "txtContraseñaInicio";
            this.txtContraseñaInicio.PasswordChar = '*';
            this.txtContraseñaInicio.Size = new System.Drawing.Size(287, 20);
            this.txtContraseñaInicio.TabIndex = 4;
            // 
            // txtCorreoInicio
            // 
            this.txtCorreoInicio.Location = new System.Drawing.Point(385, 67);
            this.txtCorreoInicio.Name = "txtCorreoInicio";
            this.txtCorreoInicio.Size = new System.Drawing.Size(287, 20);
            this.txtCorreoInicio.TabIndex = 3;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbInicio);
            this.Controls.Add(this.lblInicioSesion);
            this.Name = "FrmInicioSesion";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblCorreo2;
        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.TextBox txtContraseñaInicio;
        private System.Windows.Forms.TextBox txtCorreoInicio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}