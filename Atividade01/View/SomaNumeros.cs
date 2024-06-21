using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01.View
{
    public partial class SomaNumeros : Form
    {
        public SomaNumeros()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(tbx_Valor1.Text);
            int valor2 = Convert.ToInt16(tbx_Valor2.Text);
            int calcular = valor1 + valor2;

            lbl_Mensagem1.Text = calcular.ToString();

        }

        private void lbl_Mensagem1_Click(object sender, EventArgs e)
        {

        }
    }
}
