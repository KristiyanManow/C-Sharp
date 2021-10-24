using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            over.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			moveLine(gamespeed);
            enemy(gamespeed);
            gameover();
            coin(gamespeed);
            coinscollection();
		}

        int collectedcoin = 0;
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,190);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 380);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }





        }

        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 190);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(50, 150);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(150, 250);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(250, 350);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }

        }




        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

		void moveLine(int speed)
		{
			if (pictureBox1.Top >= 500)
			{
				pictureBox1.Top = 0;
			}
			else { pictureBox1.Top += speed; }

			if (pictureBox2.Top >= 500)
			{
				pictureBox2.Top = 0;
			}
			else { pictureBox2.Top += speed; }

			if (pictureBox3.Top >= 500)
			{
				pictureBox3.Top = 0;
			}
			else { pictureBox3.Top += speed; }


		}

	   private void pictureBox6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{}

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 150);
                coin2.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(250, 350);
                coin3.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(250, 350);
                coin4.Location = new Point(x, 0);

            }
        }




		int gamespeed = 0;
		private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				if (car.Left > 0)
				{
					car.Left += -8;
				}
			}
			if (e.KeyCode == Keys.Right)
			{
				if (car.Left <335)
				{
					car.Left += 8;
				}
			}

			if (e.KeyCode == Keys.Up)
			{
				if (gamespeed < 21)
				{ gamespeed++; }
			}
			if (e.KeyCode == Keys.Down)
			{
				if (gamespeed > 0)
				{ gamespeed--; }
			}
		}
	}
}
