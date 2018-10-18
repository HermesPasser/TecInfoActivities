using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda12_forum_loopListBox_plus_trap
{
    public partial class loopListBox : Form
    {
        public loopListBox()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lstConv.Items.Count)
            {
                lstConv.SelectedIndex = i;
                lstConf.Items.Add(lstConv.SelectedItem.ToString());
                i++;
            }

            lstConv.Items.Clear();

        }
        private void loopListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i = 0;
            while (i < 10*1024)
            {
                new loopListBox().Show();
                i++;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lstConv.Items.Add(txtNome.Text);
            txtNome.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
