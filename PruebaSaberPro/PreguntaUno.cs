﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSaberPro
{
    public partial class FrmPreguntaUno : Form
    {
        public FrmPreguntaUno()
        {
            InitializeComponent();
        }

   
      

        private void FrmPreguntaUno_Load(object sender, EventArgs e)
        {
            this.rbA1.Checked = false;
            this.rbB1.Checked = false;
            this.rbC1.Checked = false;
            this.rbD1.Checked = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((this.rbA1.Checked== false) && (this.rbB1.Checked == false) && (this.rbC1.Checked == false) && (this.rbD1.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.rbB1.Checked == true)
                {
                    Auxiliar.contador += 10;
                }
                this.Hide();
                FrmPreguntaDos dos = new FrmPreguntaDos();
                dos.Show();
            }
        }
    }
}
