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
       private bool xIsPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int z = 0;

            while (!xIsPressed)
            {
               textBox1.Text += "\r\nTestando while.Para sair/entrar do loop aperte X.";
                if (z == 3)
                    xIsPressed = !xIsPressed;
                z++;
            }

            int x = 0;
            do
            {
                textBox2.Text += "\r\nx: " + x ;
                x++;
            } while (x < 10);

            int y = 0;

            for (y = 0; y <= 10; y += 2)
            {
                textBox3.Text += ("\r\ny:" + y);
            }
        }
    }
}