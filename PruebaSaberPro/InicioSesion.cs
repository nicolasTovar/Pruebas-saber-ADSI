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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((txtCorreoInicio.Text.Length > 0) && (txtContraseñaInicio.Text.Length > 0))
            {
                if ((txtCorreoInicio.Text == Auxiliar.correo) && (txtContraseñaInicio.Text == Auxiliar.contraseña))
                {
                    this.Hide();
                    FrmPreguntaUno uno = new FrmPreguntaUno();
                    uno.Show();
                }
                if ((txtCorreoInicio.Text != Auxiliar.correo) | (txtContraseñaInicio.Text != Auxiliar.contraseña))
                {
                    MessageBox.Show("Escribió un dato incorrecto", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}