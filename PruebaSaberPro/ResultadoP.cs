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
    public partial class FrmResultadoP : Form
    {
        public FrmResultadoP()
        {
            InitializeComponent();
        }

        private void FrmResultadoP_Load(object sender, EventArgs e)
        {
            this.txtDatos.Text = Auxiliar.nombre + "" + Auxiliar.apellido + "";
            this.txtCorrectas.Text = Convert.ToString(Auxiliar.contador);
            this.txtPuntaje.Text = Convert.ToString(Auxiliar.contador);
            this.txtPorcentaje.Text = Auxiliar.contador + "%";
            this.txtIncorrectas.Text = Convert.ToString(100-Auxiliar.contador );
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
