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
    public partial class FrmPreguntaCinco : Form
    {
        FrmPreguntaSeis seis = new FrmPreguntaSeis();
        public FrmPreguntaCinco()
        {
            InitializeComponent();
        }

        private void btnSiguiente5_Click(object sender, EventArgs e)
        {
            if ((txtResp1.Text.Length > 0) && (txtResp2.Text.Length > 0) && (txtResp3.Text.Length > 0) && (txtResp4.Text.Length > 0)&&(txtResp4.Text.Length > 0))
                if ((txtResp1.Text == "D") && (txtResp2.Text == "C") && (txtResp3.Text == "B") && (txtResp4.Text == "E")&&(txtResp5.Text=="A"))
                {
                    Auxiliar.contador += 10;
                    this.Hide();

                    seis.Show();

                }
            if ((txtResp1.Text != "") | (txtResp2.Text != "") | (txtResp3.Text != "") | (txtResp4.Text != "") | (txtResp5.Text != ""))
            {
                this.Hide();

                seis.Show();
            }


            else
            {
                if ((txtResp1.Text == "") && (txtResp2.Text == "") && (txtResp3.Text == "") && (txtResp4.Text == "") && (txtResp5.Text == ""))
                {
                    MessageBox.Show("Debe seleccionar todas las opciones", "Prueba", MessageBoxButtons.OK);

                }
            }

        }
    }
}
