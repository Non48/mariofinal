using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newProjeecttttttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


        }
        Boolean kr = false;
        Boolean kl = false;
        bool mr = false;
        bool ml = false;
        int marioJumpdistance = 25;





        int kratosJumpdistance = 25;


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

            //Marioo
            if (e.KeyCode == Keys.D)
            {
                mr = true;
                ml = false;

                pictureBox1.Image = Properties.Resources.marioo;

                //Point myPoint = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 0);
                //pictureBox1.Location = myPoint;
            }
            if (e.KeyCode == Keys.A)
            {
                ml = true;
                mr = false;

                pictureBox1.Image = Properties.Resources.mariooleft;
                //Point myPoint = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 0);
                // pictureBox1.Location = myPoint;
            }
            if (e.KeyCode == Keys.W)
            {

                if (marioJumpdistance <= -26) //jump is over
                {
                    marioJumpdistance = 25;
                }

                // Point myPoint = new Point(pictureBox1.Location.X + 0, pictureBox1.Location.Y - 100);
                // pictureBox1.Location = myPoint;
                timer1.Start();
            }




            //kratos

            if (e.KeyCode == Keys.NumPad3)
            {

                kr = true;


                kl = false;

                pictureBox2.Image = Properties.Resources.hiright;
                //Point myPoint = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 0);
                //pictureBox2.Location = myPoint;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                kl = true;
                kr = false;

                pictureBox2.Image = Properties.Resources.hi;
                // Point myPoint = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y + 0);
                // pictureBox2.Location = myPoint;
            }
            if (e.KeyCode == Keys.NumPad5)
            {

                if (kratosJumpdistance <= -26) //jump is over
                {
                    kratosJumpdistance = 25;
                }

                // Point myPoint = new Point(pictureBox1.Location.X + 0, pictureBox1.Location.Y - 100);
                // pictureBox1.Location = myPoint;
                timer2.Start();

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {


             Point myPoint = new Point(pictureBox1.Location.X + 0, pictureBox1.Location.Y - marioJumpdistance);
             pictureBox1.Location = myPoint;
             marioJumpdistance -= 1;

             //if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))// mario collide with brick1
             //{
             //    if (marioJumpdistance < 0)//mario going down
             //    {
             //        marioJumpdistance = -26;
             //    }
             //}

             //timer4.Start();

             if (marioJumpdistance <= -26)
             {
                 timer1.Stop();
             }


        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {




            Point myPoint = new Point(pictureBox2.Location.X + 0, pictureBox2.Location.Y - kratosJumpdistance);
            pictureBox2.Location = myPoint;
            kratosJumpdistance -= 1;


            if (kratosJumpdistance <= -26)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (mr == true && pictureBox1.Location.X < 1390)
            {
                Point myPoint = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 0);
                pictureBox1.Location = myPoint;
            }


            if (ml == true && pictureBox1.Location.X > -10)
            {
                Point myPoint = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 0);
                pictureBox1.Location = myPoint;
            }
            if (kr == true && pictureBox2.Location.X < 1390)
            {
                Point myPoint = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 0);
                pictureBox2.Location = myPoint;
            }


            if (kl == true && pictureBox2.Location.X > -10)
            {
                Point myPoint = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y + 0);
                pictureBox2.Location = myPoint;
            }






            //block collison checks


            //collision checks for marrio and ktratos
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (pictureBox1.Location.X < pictureBox2.Location.X)  //Mario is more to the left
                {
                    Point myPoint = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 0);
                    pictureBox1.Location = myPoint;
                }
                else  //Mario is more to the right
                {
                    Point myPoint = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 0);
                    pictureBox1.Location = myPoint;
                }
                if (pictureBox2.Location.X < pictureBox1.Location.X)
                {
                    Point myPoint = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y + 0);
                    pictureBox2.Location = myPoint;
                }
                else
                {
                    Point myPoint = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 0);
                    pictureBox2.Location = myPoint;
                }

            }




        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                mr = false;
            }

            if (e.KeyCode == Keys.A)
            {
                ml = false;
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                kr = false;
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                kl = false;
            }



        }

         private void timer4_Tick(object sender, EventArgs e)
         {
             if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
             {
                 if (marioJumpdistance !=  24)
                 {
                     marioJumpdistance = -24;
                 }
             }
    
        }
        int mhealth = 100;
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            mhealth -= 20;
            progressBar1.Value = mhealth;
            if(mhealth ==0)
            {
                MessageBox.Show("Kratos Wins");
            }
        }
        int khealth = 100;
        private void progressBar2_Click(object sender, EventArgs e)
        {
            khealth -= 20;
            progressBar2.Value = khealth;
            if (khealth == 0)
            {
                MessageBox.Show("Mario Wins");
            }
        }
    }
}
