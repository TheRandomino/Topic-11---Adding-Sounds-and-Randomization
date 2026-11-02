using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topic_11___Adding_Sounds_and_Randomization.Properties;

namespace Topic_11___Adding_Sounds_and_Randomization
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
        Random generator = new Random();

        int cat = 1, pig = 2, dog = 3, randomSound = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void imgPig_Click(object sender, EventArgs e)
        {
            if (randomSound == 0)
            {
                lblResultTxt.Text = "Click the button.";
            }
            else if (randomSound == 2)
            {
                lblResultTxt.Text = "Correct!";
            }
            else
            {
                lblResultTxt.Text = "Wrong!";
            }
            randomSound = 0;
        }

        private void imgDog_Click(object sender, EventArgs e)
        {
            if (randomSound == 0)
            {
                lblResultTxt.Text = "Click the button.";
            }
            else if (randomSound == 3)
            {
                lblResultTxt.Text = "Correct!";
            }
            else
            {
                lblResultTxt.Text = "Wrong!";
            }
            randomSound = 0;
        }

        private void imgCat_Click(object sender, EventArgs e)
        {
            if (randomSound == 0)
            {
                lblResultTxt.Text = "Click the button.";
            }
            else if (randomSound == 1)
            {
                lblResultTxt.Text = "Correct!";
            }
            else
            {
                lblResultTxt.Text = "Wrong!";
            }
            randomSound = 0;
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            lblResultTxt.Text = "";
            randomSound = generator.Next(1, 4);
            if (randomSound == cat)
            {
                player = new SoundPlayer(Resources.meow);

            }
            else if (randomSound == pig)
            {
                player = new SoundPlayer(Resources.oink);
            }
            else
            {
                player = new SoundPlayer(Resources.woof);
            }
            player.Play();


        }
    }
}
