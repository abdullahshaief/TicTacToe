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

namespace TicTacToe
{
    public partial class Form2 : Form
    {

      

        public Form2()

        {
            

            InitializeComponent();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Abdullah\Desktop\spooky_laugh.wav");
           // simpleSound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // // playSimpleSound();

            progressBar1.Increment(1);

            if (progressBar1.Value == 20)
            {
                pictureBox3.Visible = false;
                timer1.Stop();
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
