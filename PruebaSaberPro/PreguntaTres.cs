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
    public partial class FrmPreguntaTres : Form
    {
        public FrmPreguntaTres()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPreguntaTres_Load(object sender, EventArgs e)
        {
            this.rbA3.Checked = false;
            this.rbB3.Checked = false;
            this.rbC3.Checked = false;
            this.rbD3.Checked = false;
        }

        private void btnSiguiente3_Click(object sender, EventArgs e)
        {
            if ((this.rbA3.Checked == false) && (this.rbB3.Checked == false) && (this.rbC3.Checked == false) && (this.rbD3.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.rbA3.Checked == true)
                {
                    Auxiliar.contador += 10;
                }
                this.Hide();
                PreguntaCuatro cuatro = new PreguntaCuatro();
                cuatro.Show();
            }

            
        }
    }
}
