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



namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplishStart));

            t.Start();

            Thread.Sleep(5000);
            t.Abort();

            InitializeComponent();
        }

        private void SplishStart()
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            progressBar1.Increment(1);

        }


            
        

        private void button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            
            Form3 f2 = new Form3();
            f2.x = "X";
            f2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();

            f2.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Welcome to our TicTacToe game!", "Shaief and Omar ");
        }

       

        private void button2_MouseClick_2(object sender, MouseEventArgs e)
        {
            Form3 f2 = new Form3();
            f2.x = "O";
            f2.o = "O";
            f2.ShowDialog();

        }

        private void button1_MouseClick_3(object sender, MouseEventArgs e)
        {
            Form3 f2 = new Form3();
            f2.y = "Computer";
            f2.ShowDialog();
        }

       

       
    }
}
