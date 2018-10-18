using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textNome.Select();
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            // bruto até 1200,00 isento
            // de 1200,01-2500,00 8%
            // acima 2500,00 12%
            double bruto = Convert.ToDouble(textBruto.Text);

            if (bruto <= 1200.00)
                textLiquido.Text = Convert.ToString(bruto);
            else if (bruto > 1200.00 && bruto <= 2500.00)
                textLiquido.Text = Convert.ToString(bruto - (bruto*0.8));
            else if (bruto > 2500.00)
                textLiquido.Text = Convert.ToString(bruto - (bruto*0.12));
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem certeza que deseja sair do sistema?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Close();
            else
                MessageBox.Show("Seu sistema não será fechado.", "", MessageBoxButtons.OK);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textLiquido.Text = "";
            textDireito.Text = "";
            textBruto.Text = "";
            textNome.Text = "";
            comCargo.Text = "";
            textNome.Select();
        }

        private void comCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comCargo.Text == "Diretoria")
                textDireito.Text = "Previdência Privada, Auxílio Educação, Vale Alimentação, Seguro Saúde";
            else if (comCargo.Text == "Gerência")
                textDireito.Text = "Auxílio Educação, Vale Alimentação, Seguro Saúde";
            else if (comCargo.Text == "Serviços Gerais")
                textDireito.Text = "Vale Alimentação, Seguro Saúde";
        }
    }
}
