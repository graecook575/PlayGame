/*Graeme Cook
 * February 8th, 2021
 * A program that, when initiated, counts down from three and displays a message, as would be done when starting a game.*/

//Setup
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class mainForm : Form
   {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On button press, make the button dissapear and another, white, one popup to display the countdown, also setup soundplayer for audio playback
            playButton.Visible = false;
            countdownText.Visible = true;
            countdownText.BackColor = Color.White;
            SoundPlayer countPlayer = new SoundPlayer(Properties.Resources.Count);
            SoundPlayer goPlayer = new SoundPlayer(Properties.Resources.Go);

            //Countdown & accompanying sounds as a loop
            for (int t = 3; t > 0; t--)
            {
                countdownText.Text = $"{t}...";
                countPlayer.Play();
                Refresh();
                Thread.Sleep(2000);
            }
            
            //Display "GO" message, change BG colour, and play sound
            countdownText.Text = "Go!!!";
            BackColor = Color.SlateBlue;
            goPlayer.Play();
        }
    }
}