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
    public partial class FrmVetor : Form
    {
        List<double> lista = new List<double>();
        public FrmVetor()
        {
            InitializeComponent();
        }

        void mostrar()
        {
            listGastos.Items.Clear();
            foreach (double v in lista)
                listGastos.Items.Add(string.Format("{0:C}", v));
        }// fim mostra

        private void bntAdd_Click(object sender, EventArgs e)
        {
            double valor;
            valor = Convert.ToDouble(txtValor.Text);
            lista.Add(valor);
            mostrar();
            txtValor.Clear();
            txtValor.Focus();
            
        }
    }
}
