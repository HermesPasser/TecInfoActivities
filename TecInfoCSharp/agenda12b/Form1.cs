using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
/*
 * PROF, EXECUTE O COLAB10 EM BIN/DEBUG SE ELE NÃO APARECER NA GUIA DE DEBUG/RUN. 
 */
namespace agenda12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioliquido = 0;

            // se o código for > que 100 então granha um bonus de 3%

            if (codigo.Text == "" || salario.Text == "" || name.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preencidos.", "Type Error", MessageBoxButtons.OK);
                return;
            }
            salarioliquido = Convert.ToDouble(salario.Text);
            if (Convert.ToInt32(codigo.Text) > 100)
                salarioliquido = salarioliquido + (salarioliquido * 0.3);
              
           textBox1.Text += name.Text +" "+ "(" + codigo.Text + ") salário atualizado: " + salarioliquido + "\r\n";
            clear();
        }

        private void clear()
        {
            name.Text = "";
            codigo.Text = "";
            salario.Text = "";
        }
    }
}