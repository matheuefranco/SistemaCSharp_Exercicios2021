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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            if (usuario == "adm") { 
                MessageBox.Show("Seja bem vindo " + usuario + "!");
                //FrmSistema s = new FrmSistema();
                FrmVetor f = new FrmVetor();
                f.Show();
            }// fim if
            else
                MessageBox.Show("Acesso negado :(");

        }
    }
}
