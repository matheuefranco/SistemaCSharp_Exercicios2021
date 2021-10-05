using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroSistema
{
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double real, cotacao, dolar;
            real = Convert.ToDouble(txtReal.Text);
            cotacao = Convert.ToDouble(txtCotacao.Text);
            dolar = real / cotacao;
            lblResultado.Text = "Valor em dólar:" + Math.Round(dolar,2);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtReal.Clear();
            txtCotacao.Clear();
            lblResultado.Text = "";
            txtReal.Focus();
        }
    }
}
