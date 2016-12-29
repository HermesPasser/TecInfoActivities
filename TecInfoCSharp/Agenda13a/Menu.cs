using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda13a_verValorDiv2e3
{
    public partial class Menu : Form
    {
        private string[] aVetor;
        private int count;

        public Menu()
        {
            InitializeComponent();
            aVetor = new string[12];
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não pode ser nulo");
                return;
            }

            try
            {
                aVetor[count] = textBox1.Text;
                textBox1.Text = "";
                count++;

            } catch (Exception) { }

            if (count == 9)
                add.Enabled = false;
        }

        private void show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < count; i++)
                listBox1.Items.Add(aVetor[i]);
        }
    }
}
