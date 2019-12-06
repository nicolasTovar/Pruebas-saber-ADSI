namespace PruebaSaberPro
{
    partial class FrmPreguntaOcho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntaOcho));
            this.lblPregunta8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblP8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSiguiente8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta8
            // 
            this.lblPregunta8.AutoSize = true;
            this.lblPregunta8.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPregunta8.Location = new System.Drawing.Point(168, 28);
            this.lblPregunta8.Name = "lblPregunta8";
            this.lblPregunta8.Size = new System.Drawing.Size(231, 36);
            this.lblPregunta8.TabIndex = 0;
            this.lblPregunta8.Text = "Pregunta Ocho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblP8
            // 
            this.lblP8.AutoSize = true;
            this.lblP8.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.lblP8.Location = new System.Drawing.Point(32, 90);
            this.lblP8.Name = "lblP8";
            this.lblP8.Size = new System.Drawing.Size(573, 20);
            this.lblP8.TabIndex = 2;
            this.lblP8.Text = "8. De acuerdo con la siguiente imagen, realice el código correspondiente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 391);
            this.textBox1.TabIndex = 3;
            // 
            // btnSiguiente8
            // 
            this.btnSiguiente8.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente8.Location = new System.Drawing.Point(763, 481);
            this.btnSiguiente8.Name = "btnSiguiente8";
            this.btnSiguiente8.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente8.TabIndex = 4;
            this.btnSiguiente8.Text = "Siguiente";
            this.btnSiguiente8.UseVisualStyleBackColor = true;
            // 
            // FrmPreguntaOcho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(885, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnSiguiente8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblP8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPregunta8);
            this.Name = "FrmPreguntaOcho";
            this.Text = "Pregunta Ocho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblP8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSiguiente8;
    }
}