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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((this.txtNombre.Text.Length>0) && (this.txtApellido.Text.Length>0) && (this.txtCorreo.Text.Length>0) && (this.txtContraseña.Text.Length > 0))
            {
                Auxiliar.nombre = this.txtNombre.Text.Trim();
                Auxiliar.apellido = this.txtApellido.Text.Trim();
                Auxiliar.correo = this.txtCorreo.Text.Trim();
                Auxiliar.contraseña = this.txtContraseña.Text.Trim();
                this.Hide();
                FrmInicioSesion iniciar = new FrmInicioSesion();
                iniciar.Show();

            }
            else
            {
                MessageBox.Show("debe diligenciar todos los campos", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
