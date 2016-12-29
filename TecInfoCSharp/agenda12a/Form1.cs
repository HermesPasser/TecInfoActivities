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

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(input.Text, "[^0-9]"))
            {
                output.Text = "Valor inválido.";
                return;
            }

            double result = 0;

            if (Convert.ToDouble(input.Text) <= 1200.00)
                result = Convert.ToDouble(input.Text);
            else if (Convert.ToDouble(input.Text) > 1200.01 && Convert.ToDouble(input.Text) <= 2500.00)
                result = (Convert.ToDouble(input.Text) - (Convert.ToDouble(input.Text) * 0.8));
            else if (Convert.ToDouble(input.Text) > 2500.00)
                result = (Convert.ToDouble(input.Text) - (Convert.ToDouble(input.Text) * 0.12));

            output.Text = Convert.ToString(result);
        }
    }
}