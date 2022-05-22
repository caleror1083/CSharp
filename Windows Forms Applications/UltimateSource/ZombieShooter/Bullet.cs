using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooter
    {
        internal class Bullet
            {
                public string direction;    // creating a publis string called direction
                public int bulletLeft;    // create a new public integer
                public int bulletTop;    // create a new public integer;

                private int speed = 20;    // creating an integer called speed and assigning a value of 20
                private PictureBox bullet = new PictureBox();    // create a picture box
                private Timer bulletTimer = new Timer();    // create a new timer called bulletTimer

                // this method will add the bullet to the game play, it is required to be called from the main class
                public void MakeBullet (Form form)
                    {
                        bullet.BackColor = Color.White;    // set the color of the bullet to white
                        bullet.Size = new Size(5, 5);    // set the size of the bullet to 5 by 5
                        bullet.Tag = "bullet";    // set the tag to bullet
                        bullet.Left = bulletLeft;    // set bullet left
                        bullet.Top = bulletTop;    // set bullet top
                        bullet.BringToFront();    // bring the bullet to the front of other objects
                        form.Controls.Add(bullet);    // add the bullet to the screen

                        bulletTimer.Interval = speed;    // the bullet will move 20 milliseconds towards any direction we set
                        bulletTimer.Tick += new EventHandler(BulletTimerEvent);    // assign the bullet timer with an event
                        bulletTimer.Start();    // start the timer
                    }

                private void BulletTimerEvent(object sender, EventArgs e)
                    {
                        if (direction == "left")
                            {
                                bullet.Left -= speed;
                            }

                        if (direction == "right")
                            {
                                bullet.Left += speed;
                            }

                        if (direction == "up")
                            {
                                bullet.Top -= speed;
                            }

                        if (direction == "down")
                            {
                                bullet.Top += speed;
                            }

                        if (bullet.Left < 0 || bullet.Left > MainScreen.ActiveForm.ClientSize.Width || bullet.Top < 44 || bullet.Top > MainScreen.ActiveForm.ClientSize.Height)
                            {
                                bulletTimer.Stop();
                                bulletTimer.Dispose();
                                bullet.Dispose();
                                bulletTimer = null;
                                bullet = null;
                            }
                    }
            }
    }