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
    public partial class PreguntaCuatro : Form
    {
        public PreguntaCuatro()
        {
            InitializeComponent();
        }

        private void FrmPreguntaCuatro_Load(object sender, EventArgs e)
        {
            this.rbA4.Checked = false;
            this.rbB4.Checked = false;
            this.rbC4.Checked = false;
            this.rbD4.Checked = false;
        }

        private void btnSiguiente4_Click(object sender, EventArgs e)
        {
            if ((this.rbA4.Checked == false) && (this.rbB4.Checked == false) && (this.rbC4.Checked == false) && (this.rbD4.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.rbB4.Checked == true)
                {
                    Auxiliar.contador += 10;
                }
                this.Hide();
                FrmPreguntaCinco cinco = new FrmPreguntaCinco();
                cinco.Show();
            }

        }
    }
}
