using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace something
{
    public partial class Form1 : Form
    {

        Random randNum = new Random();
        List<PictureBox> zombiesList = new List<PictureBox>();
        List<int[]> irany = new List<int[]>();
        public Form1()
        {
            model mod = new model();
            persistence pers = new persistence();
            Random rand = new Random();
            InitializeComponent();
            txtammo.Text = "Max record :" + Convert.ToString(pers.Import());
            Timer time = new Timer();
            time.Interval = 15;
            time.Start();
            Bitmap zombie = new Bitmap("zup.png");
            List<PictureBox> zombi = new List<PictureBox>();
            List<PictureBox> bullet = new List<PictureBox>();

            Bitmap kep = new Bitmap("up.png");
            playerbox.SizeMode = PictureBoxSizeMode.AutoSize;
            playerbox.Location = new Point(389, 273);
            playerbox.Size = new Size(500, 500);
            this.Controls.Add(playerbox);
            playerbox.Image = kep;
            KeyDown += (s, e) =>
            {


                if (e.KeyCode == Keys.Left)
                {
                    mod.num1 = 3;
                    mod.facing = "left";



                }
                if (e.KeyCode == Keys.Right)
                {
                    mod.num1 = 1;
                    mod.facing = "right";
                }
                if (e.KeyCode == Keys.Up)
                {

                    mod.num1 = 0;
                    mod.facing = "up";
                }
                if (e.KeyCode == Keys.Down)
                {
                    mod.num1 = 2;

                    mod.facing = "down";
                }

            };
            KeyUp += (s, e) =>
             {
                 if (e.KeyCode == Keys.Left)
                 {
                     if (mod.facing != "right" || mod.facing != "up" || mod.facing != "down")
                     {
                         mod.facing = "";

                     }
                     
                 }
                 if (e.KeyCode == Keys.Right)
                 {
                     if (mod.facing != "left" || mod.facing != "up" || mod.facing != "down")
                     {
                         mod.facing = "";

                     }


                 }
                 if (e.KeyCode == Keys.Up)
                 {
                     if (mod.facing != "right" || mod.facing != "left" || mod.facing != "down")
                     {
                         mod.facing = "";

                     }

                 }
                 if (e.KeyCode == Keys.Down)
                 {
                     if (mod.facing != "right" || mod.facing != "up" || mod.facing != "left")
                     {
                         mod.facing = "";

                     }
                     
                 }
             };
            MouseClick += (s, e) =>
            {
                if (mod.ammo > 0)
                {
                    int[] iranyka = new int[2];
                    PictureBox bull = new PictureBox();
                    bullet.Add(bull);
                    bullet[bullet.Count() - 1].BackColor = Color.White;
                    bullet[bullet.Count() - 1].Location = new Point(playerbox.Location.X + playerbox.Width / 2, playerbox.Location.Y + playerbox.Height / 2);
                    bullet[bullet.Count() - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                    bullet[bullet.Count() - 1].Size = new Size(5, 5);
                    this.Controls.Add(bullet[bullet.Count() - 1]);
                    if (mod.num2 == 3)
                    {
                        iranyka[0] = -6;
                        iranyka[1] = 0;
                    }
                    if (mod.num2 == 1)
                    {
                        iranyka[0] = 6;
                        iranyka[1] = 0;
                    }
                    if (mod.num2 == 2)
                    {
                        iranyka[0] = 0;
                        iranyka[1] = 6;
                    }
                    if (mod.num2 == 0)
                    {
                        iranyka[0] = 0;
                        iranyka[1] = -6;
                    }
                    irany.Add(iranyka);
                    mod.ammo--;
                }
            };
            time.Tick += (s, e) =>
             {

                 if (mod.playerHealth > 1)
                 {
                     healthbar.Value = mod.playerHealth;


                 }
                 else
                 {
                     time.Stop();
                     pers.Export(mod.score);
                     DialogResult result = MessageBox.Show("Game Over! \n your score is:" + mod.score + " \n Do you want to play again? ", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (result == DialogResult.Yes)
                     {
                         Application.Restart();
                     }
                     else if (result == DialogResult.No)
                     {
                         this.Close();
                     }
                 }
                 txtammo.Text = "Ammo:" + mod.ammo;
                 txtscore.Text = "Kills:" + mod.score;

                 if (mod.facing == "left" && playerbox.Location.X > 0)
                 {
                     playerbox.Location = new Point(playerbox.Location.X - mod.speed, playerbox.Location.Y);

                 }
                 if (mod.facing == "right" && playerbox.Location.X + playerbox.Width < this.ClientSize.Width)
                 {
                     playerbox.Location = new Point(playerbox.Location.X + mod.speed, playerbox.Location.Y);
                 }
                 if (mod.facing == "up" && playerbox.Location.Y > 40)
                 {
                     playerbox.Location = new Point(playerbox.Location.X, playerbox.Location.Y - mod.speed);
                 }
                 if (mod.facing == "down" && playerbox.Location.Y + playerbox.Height < this.ClientSize.Height)
                 {
                     playerbox.Location = new Point(playerbox.Location.X, playerbox.Location.Y + mod.speed);
                 }
                 if (mod.num1 != mod.num2)
                 {

                     while (mod.num1 != mod.num2)
                     {
                         kep.RotateFlip(RotateFlipType.Rotate270FlipXY);

                         mod.num2++;
                         if (mod.num2 == 4)
                         {
                             mod.num2 = 0;

                         }


                     }


                     playerbox.Image = kep;
                 }

                 if (mod.ido == 180 - mod.score)
                 {
                     mod.ido = 0;

                     PictureBox zamb = new PictureBox();
                     zombi.Add(zamb);
                     int zox;
                     int zoy;
                     if (rand.Next(0, 2) == 0)
                     {
                         if (rand.Next(0, 2) == 0)
                         {
                             zox = rand.Next(0, this.Width);
                             zoy = Convert.ToInt32(this.Height * -0.2);
                         }
                         else
                         {
                             zox = rand.Next(0, this.Width);
                             zoy = Convert.ToInt32(this.Height * 1.2);
                         }
                     }
                     else
                     {
                         if (rand.Next(0, 2) == 0)
                         {
                             zox = Convert.ToInt32(this.Width * -0.2);
                             zoy = rand.Next(0, this.Width);

                         }
                         else
                         {
                             zox = Convert.ToInt32(this.Height * 1.2);
                             zoy = rand.Next(0, this.Width);

                         }
                     }

                     zombi[zombi.Count() - 1].Image = zombie;
                     zombi[zombi.Count() - 1].Location = new Point(zox, zoy);
                     zombi[zombi.Count() - 1].Tag = "zombie";
                     zombi[zombi.Count() - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                     zombi[zombi.Count() - 1].Size = new Size(75, 75);
                     zombi[zombi.Count() - 1].BringToFront();
                     this.Controls.Add(zombi[zombi.Count() - 1]);
                 }
                 mod.ido++;
                 foreach (PictureBox zom in zombi)
                 {



                     if (zom.Bounds.IntersectsWith(playerbox.Bounds))
                     {
                        mod. playerHealth -= 1;
                     }



                     if (zom.Left > playerbox.Left)
                     {
                         (zom).Left -= mod.zombespeed;
                         mod.znum1 = 3;

                     }

                     if (zom.Top > playerbox.Top)
                     {
                         (zom).Top -= mod.zombespeed;
                         mod.znum1 = 0;

                     }
                     if (zom.Right < playerbox.Right)
                     {
                         zom.Left += mod.zombespeed;
                         mod.znum1 = 1;
                     }
                     if (zom.Top < playerbox.Top)
                     {
                         zom.Top += mod.zombespeed;
                         mod.znum1 = 2;

                     }


                     if (mod.znum1 !=mod.znum2)
                     {

                         while (mod.znum1 !=mod.znum2)
                         {
                             zombie.RotateFlip(RotateFlipType.Rotate270FlipXY);

                             mod.znum2++;
                             if (mod.znum2 == 4)
                             {
                                mod.znum2 = 0;

                             }

                         }

                         zom.Image = zombie;
                     }
                 }
                 for (int i = 0; i < irany.Count(); ++i)
                 {

                     bool talalt = false;
                     bullet[i].Location = new Point(bullet[i].Location.X + irany[i][0], bullet[i].Location.Y + irany[i][1]);
                     for (int j = 0; j < zombi.Count(); ++j)
                     {

                         if (bullet[i].Bounds.IntersectsWith(zombi[j].Bounds))
                         {

                             talalt = true;
                             this.Controls.Remove(zombi[j]);
                             zombi.Remove(zombi[j]);
                             mod.score++;
                             mod.ammo += 2;
                             if(mod.zombespeed<5&& mod.zumba==true)
                             {
                                 mod.zombespeed++;
                                 mod.zumba = false;
                             }
                             else
                             {
                                 mod.zumba = true;
                             }
                             if (mod.playerHealth < 90)
                             {
                                 mod.playerHealth += 5;
                             }

                         }
                         if (talalt == true)
                         {
                             this.Controls.Remove(bullet[i]);
                             bullet.Remove(bullet[i]);
                             irany.Remove(irany[i]);
                         }
                     }

                 }
                 for (int i = 0; i < irany.Count(); ++i)
                 {
                     if (bullet[i].Location.X < this.Width * -0.2 || bullet[i].Location.X > this.Width * 1.2 || bullet[i].Location.Y < this.Height * -0.2 || bullet[i].Location.Y > this.Height * 1.2)
                     {
                         this.Controls.Remove(bullet[i]);
                         bullet.Remove(bullet[i]);
                         irany.Remove(irany[i]);


                     }
                 };

             };

        }


    }
}
