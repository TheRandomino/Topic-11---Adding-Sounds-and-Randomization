using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_11___Adding_Sounds_and_Randomization
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
    }
}
