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
    public partial class FrmPreguntaDiez : Form
    {
        public FrmPreguntaDiez()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmPreguntaDiez_Load(object sender, EventArgs e)
        {
            this.cbRespues1.Checked = false;
            this.cbRespues2.Checked = false;
            this.cbRespues3.Checked = false;
            this.cbRespues4.Checked = false;
            this.cbRespues5.Checked = false;
            this.cbRespues6.Checked = false;
            this.cbRespues7.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.cbRespues1.Checked = false) && (this.cbRespues2.Checked = false) && (this.cbRespues3.Checked = false) && (this.cbRespues4.Checked = false) && (this.cbRespues5.Checked = false) && (this.cbRespues6.Checked = false)&&(this.cbRespues7.Checked = false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((this.cbRespues3.Checked = true) && (this.cbRespues4.Checked = true) && (this.cbRespues6.Checked = true))
                {


                    Auxiliar.contador += 10;
                }
                this.Hide();
                FrmResultadoP resultadoP = new FrmResultadoP();
                resultadoP.Show();
            }
        }
    }
}
