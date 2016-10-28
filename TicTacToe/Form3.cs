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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            
        }

       

        public string x,y,o;
        public int count = 0;
        public bool t = false, r = false,f =false, winatlastmove=false;
        public bool turn = false, computer = false,oterm =false;


        private void button1_Click(object sender, EventArgs e)
        {
            r = true;
            
            Form3 f2 = new Form3();
            f2.ShowDialog();
          
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            if(o=="O"){
                oterm = true;
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = x;

            }
            else
            {
                textBox1.Text = "X";
            }
           if (y == "Computer")
           {
               computer = true;
               textBox1.Text = "X";
           }

          
        }
        

        

        private void button_click(object sender, EventArgs e)
        {

           if(!computer){
               
               Button b = (Button)sender;
               textBox1.Text = x;

               b.Enabled = false;
               count++;// // // playSimpleSound();
              

               if ((!turn) && (x == "X"))
               {

                   b.Text = x;
                   x = "O";
                   b.BackColor = System.Drawing.Color.Lime;

               }


               else if ((!turn) && (x == "O"))
               {
                   b.Text = "O";
                   x = "X";
                   b.BackColor = System.Drawing.Color.MediumSlateBlue;
                   b.ForeColor = Color.AliceBlue;

               }

               else if ((turn) && (x == "O"))
               {
                   b.Text = "O";
                   x = "X";
                   b.BackColor = System.Drawing.Color.MediumSlateBlue;

               }

               else
               {
                   b.Text = "X";
                   x = "O";
                   b.BackColor = System.Drawing.Color.Lime;
               }

               turn = !turn;

               // To figure out whose turn it is

               if ((turn) && (textBox1.Text == "X"))
               {

                   textBox1.Text = "O";


               }
               else if ((turn) && (textBox1.Text == "O"))
               {
                   textBox1.Text = "X";
               }
               else if ((!turn) && (textBox1.Text == "X"))
               {
                   textBox1.Text = "O";
               }

           
               textBox1.Enabled = false;

               b.Enabled = false;
               checkWinner();

               if ((count == 9) && (winatlastmove == true))
               {
                 //  playSimpleSound3();
                   r = true;
                   gameOver();

                   MessageBox.Show("Oops! No one wins!");

               }
           }
           else
           {
               Button b = (Button)sender;
               textBox1.Text = "X";

               b.Enabled = false;
               count++;
            
               x = "X";
               if ((!turn) && (x == "X"))
               {
                  
                   b.Text = x;
                   x = "X";
                   b.BackColor = System.Drawing.Color.Lime;
                   if (!A1.Enabled && !A2.Enabled && A1.Text != "O" && A3.Enabled)
                   {
                       A3.Text = "O";
                       A3.Enabled  = false;
                    //   // playSimpleSound();
                   }
                   else if (!A3.Enabled && !A2.Enabled && A3.Text != "O" && A1.Enabled)
                   {
                       A1.Text = "O";
                       A1.Enabled = false;
                    //   // playSimpleSound();
                   }
                   else if (!A3.Enabled && !B3.Enabled && C3.Enabled)
                   {
                       C3.Text = "O";
                       C3.Enabled = false; 
                      // // playSimpleSound();
                   }
                   else if (!C3.Enabled && !B3.Enabled  && A3.Enabled)
                   {
                       A3.Text = "O";
                       A3.Enabled = false;
                  //     // playSimpleSound();
                   }
                   else if (!B2.Enabled && !B3.Enabled && B1.Enabled)
                   {
                       B1.Text = "O";
                       B1.Enabled = false;
                      // // playSimpleSound();
                   }
                   else if (!B1.Enabled && !B2.Enabled && B1.Text=="O" && B3.Enabled)
                   {
                       B3.Text = "O";
                       B3.Enabled = false;
                    //   // playSimpleSound();
                   }
                   else if (!C2.Enabled && !C3.Enabled && C1.Enabled)
                   {
                       C1.Text = "O";
                       C1.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if (!C1.Enabled && !C2.Enabled && C3.Enabled)
                   {
                       C3.Text = "O";
                       C3.Enabled = false;
                       // // playSimpleSound();
                   }
                       //Vertical
                   else if (!A1.Enabled && !B1.Enabled && C1.Enabled)
                   {
                       C1.Text = "O";
                       C1.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if (!A2.Enabled && !B2.Enabled && C2.Enabled)
                   {
                       C2.Text = "O";
                       C2.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if (!C2.Enabled && !B2.Enabled && A2.Enabled)
                   {
                       A2.Text = "O";
                       A2.Enabled = false;
                       // // playSimpleSound();
                   }
                       // Random buttons
                   else if ((B2.Text == "") && (B2.Enabled))
                   {
                       B2.Text = "O";
                       B2.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if ((A1.Text == "") && (A1.Enabled))
                   {
                       A1.Text = "O";
                       A1.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if ((A3.Text == "") && (A3.Enabled))
                   {
                       A3.Text = "O";
                       A3.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if ((C1.Text == "") && (C1.Enabled))
                   {
                       C1.Text = "O";
                       C1.Enabled = false;
                       // // playSimpleSound();
                   }
                   else if ((C3.Text == "") && (C3.Enabled))
                   {
                       C3.Text = "O";
                       C3.Enabled = false;
                       // playSimpleSound();
                   }
                   else if ((A2.Text == "") && (A2.Enabled))
                   {
                       A2.Text = "O";
                       A2.Enabled = false;
                       // playSimpleSound();
                   }
                   else if ((C2.Text == "") && (C2.Enabled))
                   {
                       C2.Text = "O";
                       C2.Enabled = false;
                       // playSimpleSound();
                   }
                   else if ((B1.Text == "") && (B1.Enabled))
                   {
                       B1.Text = "O";
                       B1.Enabled = false;
                       // playSimpleSound();
                   }
                   else if ((B3.Text == "") && (B3.Enabled))
                   {
                       B3.Text = "O";
                       B3.Enabled = false;
                       // playSimpleSound();
                   }
               }
               checkWinner();
               if ((count == 9) && (winatlastmove == true))
               {
                   playSimpleSound3();
                   r = true;
                   gameOver();

                   MessageBox.Show("Oops! No one wins!");

               }

               textBox1.Enabled = false;

               b.Enabled = false;
           }

            
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Abdullah\Desktop\minions___text.wav");
          //  simpleSound.Play();
        }
        private void playSimpleSound1()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Abdullah\Desktop\Woo.wav");
          //  simpleSound.Play();
        }
        private void playSimpleSound3()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Abdullah\Desktop\no winner.wav");
           // simpleSound.Play();
        }
        
        private void checkWinner()
        {
            bool winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
                x = A1.Text;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
                x = B1.Text;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
                x = C1.Text;
            }

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
                x = A1.Text;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
                x = B2.Text;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
                x = A3.Text;
            }

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
                x = A1.Text;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                winner = true;
                x = B2.Text;
            }


            if (winner)
            {
                if (turn)
                {
                    t = true;
 
                    pictureBox1.Enabled = false;
                    A1.Enabled = A2.Enabled = A3.Enabled = false;
                    B1.Enabled = B2.Enabled = B3.Enabled = false;
                    C1.Enabled = C2.Enabled = C3.Enabled = false;
                    A1.Visible = A2.Visible = A3.Visible = false;
                    B1.Visible = B2.Visible = B3.Visible = false;
                    C1.Visible = C2.Visible = C3.Visible = false;
                    
                }

                else
                {
                    t = true;

                    pictureBox1.Enabled = false;
                    A1.Enabled = A2.Enabled = A3.Enabled = false;
                    B1.Enabled = B2.Enabled = B3.Enabled = false;
                    C1.Enabled = C2.Enabled = C3.Enabled = false;
                    A1.Visible = A2.Visible = A3.Visible = false;
                    B1.Visible = B2.Visible = B3.Visible = false;
                    C1.Visible = C2.Visible = C3.Visible = false;
                   
                }
              
               
            }

        }

        private void gameOver()
        {
            if (r)
            {
                button1.Visible = true;
                button2.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                A1.Enabled = A2.Enabled = A3.Enabled = false;
                B1.Enabled = B2.Enabled = B3.Enabled = false;
                C1.Enabled = C2.Enabled = C3.Enabled = false;
                A1.Visible = A2.Visible = A3.Visible = false;
                B1.Visible = B2.Visible = B3.Visible = false;
                C1.Visible = C2.Visible = C3.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

       

        private void button2_Click(object sender, EventArgs e)
        {

           
            DialogResult result;

            result = MessageBox.Show("Do you really want to quit?", "Exit window", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form. 

                Application.Exit();

            }
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (t)
            {
                winatlastmove = true;
                timer1.Start();
                progressBar2.Increment(1);
                
                if (progressBar2.Value == 30)
                {
                    MessageBox.Show("The winner is: " + x, "Congrats!"); 
                }

                else if (progressBar2.Value == 1)
                {
                 //   playSimpleSound1();
                    pictureBox2.Visible = true;
                }
                else if (progressBar2.Value == 60)
                {
                    pictureBox2.Visible = false;
                }

                else if (progressBar2.Value == 61)
                {

                    button1.Visible = true;
                    button2.Visible = true;
                }
               
                

                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            
            }
           
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = x;
            
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
          if(b.Enabled ==true)
            b.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




        public string c { get; set; }
    }
}











        