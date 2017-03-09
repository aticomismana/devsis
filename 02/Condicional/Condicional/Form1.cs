using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcIdade_Click(object sender, EventArgs e)
        {
            int idade = (int)  Convert.ToInt64(textIdade.Text);

            if (idade >= 18) { MessageBox.Show("Maior de idade"); } else { MessageBox.Show("Menor de idade"); }

        }
    }
}
