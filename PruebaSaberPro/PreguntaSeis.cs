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
    public partial class FrmPreguntaSeis : Form
    {
        public FrmPreguntaSeis()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

  

        private void FrmPreguntaSeis_Load(object sender, EventArgs e)
        {
            this.cbOpcion1.Checked = false;
            this.cbOpcion2.Checked = false;
            this.cbOpcion3.Checked = false;
            this.cbOpcion4.Checked = false;
            this.cbOpcion5.Checked = false;
            this.cbOpcion6.Checked = false;
        }

        private void btnSiguiente6_Click(object sender, EventArgs e)
        {
            if ((this.cbOpcion1.Checked = false) && (this.cbOpcion2.Checked = false) && (this.cbOpcion3.Checked = false) && (this.cbOpcion4.Checked = false) && (this.cbOpcion5.Checked = false) && (this.cbOpcion6.Checked = false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((this.cbOpcion1.Checked = true) && (this.cbOpcion4.Checked = true))
                {
                    Auxiliar.contador += 10;
                }
                this.Hide();
                FrmPreguntaSiete siete = new FrmPreguntaSiete();
                siete.Show();
            }

        }
    }
}
