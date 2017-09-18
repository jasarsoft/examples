using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Audio
{
    public partial class Form1 : Form
    {
        SoundPlayer player;

        public Form1()
        {
            InitializeComponent();

            player = new SoundPlayer("audio.wav");
        }

        private void play_CheckedChanged(object sender, EventArgs e)
        {
            if(play.Checked)
            {
                play.Text = "Stop";
                player.Play();
            }
            else
            {
                play.Text = "Play";
                player.Stop();
            }
        }
    }
}
