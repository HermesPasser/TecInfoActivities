using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loginAndXButtonEven : Form
    {
        public int i = 0;

        public loginAndXButtonEven()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Vai fechar?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {


            if (name.Text == "Doutor" && pass.Text == "Ornitorinco")
            {
                MessageBox.Show("Logado com sucesso.", "Sucesso!", MessageBoxButtons.OK);

            }

            i++;

             if (i == 3)
                Environment.Exit(0);
             else
                MessageBox.Show("Tente denovo vacilão.", "Errou!", MessageBoxButtons.OK);
        }


        private void gerarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new orcamento().Show();
            Environment.Exit(0);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
