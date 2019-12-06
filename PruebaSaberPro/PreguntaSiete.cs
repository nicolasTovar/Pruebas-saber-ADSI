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
    public partial class FrmPreguntaSiete : Form
    {
        FrmPreguntaOcho ocho = new FrmPreguntaOcho();
        public FrmPreguntaSiete()
        {
            InitializeComponent();
        }

        private void FrmPreguntaSiete_Load(object sender, EventArgs e)
        {
       
        }

        private void btnSiguiente7_Click(object sender, EventArgs e)
        {
            if (cboRespuesta7.Text == "")
            {
                MessageBox.Show("Debe seleccionar una opción de respuesta", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                
                ocho.Show();
            }
        }

        private void cboRespuesta7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRespuesta7.Text == "Patrón comportamental")
            {
                Auxiliar.contador += 10;
            }
            this.Hide();
            ocho.Show();
        }

    }
}
