﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace colab10
{
    public partial class Form1 : Form
    {
        SoundPlayer sound = new SoundPlayer();

        public Form1()
       {
            InitializeComponent();
       }

        private void button_Click(object sender, EventArgs e)
        {
            //  sound.SoundLocation = System.IO.Directory.GetCurrentDirectory()+"grunido.wav";

            labelAluno.Text = textNome.Text;
            labelMedia.Text = Convert.ToString(Convert.ToDouble(textNota1.Text) + Convert.ToDouble(textNota2.Text) + Convert.ToDouble(textNota3.Text) / 3);

            //button.Text = "Ah~ Pevertido";
            //  sound.Play();

        }


    }
}