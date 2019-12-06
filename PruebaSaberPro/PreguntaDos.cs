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
    public partial class FrmPreguntaDos : Form
    {
        public FrmPreguntaDos()
        {
            InitializeComponent();
        }

        private void cboRespuesta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRespuesta2.Text == "Es la mejor solución a problemas recurrentes en el software")
            {
                Auxiliar.contador += 10;

            }
            this.Hide();
            FrmPreguntaTres tres = new FrmPreguntaTres();
            tres.Show();
        }

        private void FrmPreguntaDos_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            if (cboRespuesta2.Text == "")
            {
                MessageBox.Show("Debe seleccionar una opción de respuesta", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                FrmPreguntaTres ocho = new FrmPreguntaTres();
                ocho.Show();
            }
        }
    }
}
