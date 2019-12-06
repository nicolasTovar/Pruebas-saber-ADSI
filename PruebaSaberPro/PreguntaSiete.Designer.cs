namespace PruebaSaberPro
{
    partial class FrmPreguntaSiete
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
            this.lblPRegunta7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRespuesta7 = new System.Windows.Forms.ComboBox();
            this.lblP7 = new System.Windows.Forms.Label();
            this.btnSiguiente7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPRegunta7
            // 
            this.lblPRegunta7.AutoSize = true;
            this.lblPRegunta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPRegunta7.Location = new System.Drawing.Point(146, 26);
            this.lblPRegunta7.Name = "lblPRegunta7";
            this.lblPRegunta7.Size = new System.Drawing.Size(211, 31);
            this.lblPRegunta7.TabIndex = 0;
            this.lblPRegunta7.Text = "Pregunta siete ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboRespuesta7);
            this.groupBox1.Controls.Add(this.lblP7);
            this.groupBox1.Location = new System.Drawing.Point(89, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hace referencia a:";
            // 
            // cboRespuesta7
            // 
            this.cboRespuesta7.FormattingEnabled = true;
            this.cboRespuesta7.Items.AddRange(new object[] {
            "Singleton",
            "Patrón creacional",
            "Patrón fabrica abstracta ",
            "Patrón comportamental"});
            this.cboRespuesta7.Location = new System.Drawing.Point(215, 119);
            this.cboRespuesta7.Name = "cboRespuesta7";
            this.cboRespuesta7.Size = new System.Drawing.Size(426, 21);
            this.cboRespuesta7.TabIndex = 8;
            this.cboRespuesta7.SelectedIndexChanged += new System.EventHandler(this.cboRespuesta7_SelectedIndexChanged);
            // 
            // lblP7
            // 
            this.lblP7.AutoSize = true;
            this.lblP7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP7.Location = new System.Drawing.Point(6, 52);
            this.lblP7.Name = "lblP7";
            this.lblP7.Size = new System.Drawing.Size(570, 20);
            this.lblP7.TabIndex = 0;
            this.lblP7.Text = "7. ¿A qué se hace referencia cuando se habla de patrón estrategia y comando?";
            // 
            // btnSiguiente7
            // 
            this.btnSiguiente7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente7.Location = new System.Drawing.Point(664, 367);
            this.btnSiguiente7.Name = "btnSiguiente7";
            this.btnSiguiente7.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente7.TabIndex = 2;
            this.btnSiguiente7.Text = "Siguiente";
            this.btnSiguiente7.UseVisualStyleBackColor = true;
            this.btnSiguiente7.Click += new System.EventHandler(this.btnSiguiente7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(12, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 451);
            this.textBox1.TabIndex = 20;
            // 
            // FrmPreguntaSiete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSiguiente7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPRegunta7);
            this.Name = "FrmPreguntaSiete";
            this.Text = "Pregunta Siete";
            this.Load += new System.EventHandler(this.FrmPreguntaSiete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPRegunta7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblP7;
        private System.Windows.Forms.Button btnSiguiente7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRespuesta7;
        private System.Windows.Forms.TextBox textBox1;
    }
}