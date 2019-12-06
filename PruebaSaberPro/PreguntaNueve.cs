using System;
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
    public partial class FrmPreguntaNueve : Form
    {
        public FrmPreguntaNueve()
        {
            InitializeComponent();
        }

        private void FrmPreguntaNueve_Load(object sender, EventArgs e)
        {
            this.rbA9.Checked = false;
            this.rbB9.Checked = false;
            this.rbC9.Checked = false;
            this.rbD9.Checked = false;
        }

        private void btnSiguiente9_Click(object sender, EventArgs e)
        {
            if ((this.rbA9.Checked == false)&&(this.rbB9.Checked == false)&& (this.rbC9.Checked == false)&&(this.rbD9.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.rbD9.Checked == true)
                {
                    Auxiliar.contador += 10;
                }
                this.Hide();
                FrmPreguntaDiez Diez = new FrmPreguntaDiez();
                Diez.Show();
            }

        }
    }
}
