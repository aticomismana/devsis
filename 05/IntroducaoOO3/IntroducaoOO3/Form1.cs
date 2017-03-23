using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoOO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta altamirando = new Conta();
            Conta rodopiando = new Conta();

            altamirando.codigoConta = 1;
            altamirando.titularConta = "All tamirando a mina";
            altamirando.saldo = 500;

            rodopiando.codigoConta = 2;
            rodopiando.titularConta = "rodopiando na batatinha";
            rodopiando.saldo = 1000;

            txtCodConta.Text = Convert.ToString(altamirando.codigoConta);
            txtTitularConta.Text = altamirando.titularConta;
            txtSaldoConta.Text = Convert.ToString(altamirando.saldo);

            altamirando.sacar();
            MessageBox.Show("Novo saldo de altamirando"+altamirando.saldo());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
