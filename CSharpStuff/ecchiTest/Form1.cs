using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ecchiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            button.Text = "Ah~ Pevertido";
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = System.IO.Directory.GetCurrentDirectory() + "/grunido.wav";

            sound.Play();
        }
    }
}