using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooter
    {
        internal class Bullet
            {
                // Bullet class Properties
                public string Direction { get; set; }
                public int BulletLeft {get; set;}
                public int BulletTop {get; set; }

                private readonly int _Speed = 20;    // creating an integer called speed and assigning a value of 20
                private PictureBox _bullet = new PictureBox();    // create a picture box
                private Timer _bulletTimer = new Timer();    // create a new timer called bulletTimer

                // this method will add the bullet to the game play, it is required to be called from the main class
                public void MakeBullet(Form form)
                    {
                        _bullet.BackColor = Color.White;    // set the color of the bullet to white
                        _bullet.Size = new Size(5, 5);    // set the size of the bullet to 5 by 5
                        _bullet.Tag = "bullet";    // set the tag to bullet
                        _bullet.Left = BulletLeft;    // set bullet left
                        _bullet.Top = BulletTop;    // set bullet top
                        _bullet.BringToFront();    // bring the bullet to the front of other objects
                        form.Controls.Add(_bullet);    // add the bullet to the screen

                        _bulletTimer.Interval = _Speed;    // the bullet will move 20 milliseconds towards any direction we set
                        _bulletTimer.Tick += new EventHandler(BulletTimerEvent);    // assign the bullet timer with an event
                        _bulletTimer.Start();    // start the timer
                    }

                private void BulletTimerEvent(object sender, EventArgs e)
                    {
                        if (Direction == "left")
                            {
                                _bullet.Left -= _Speed;
                            }

                        if (Direction == "right")
                            {
                                _bullet.Left += _Speed;
                            }

                        if (Direction == "up")
                            {
                                _bullet.Top -= _Speed;
                            }

                        if (Direction == "down")
                            {
                                _bullet.Top += _Speed;
                            }

                        if (_bullet.Left < 0 || _bullet.Left > MainScreen.ActiveForm.ClientSize.Width || _bullet.Top < 44 || _bullet.Top > MainScreen.ActiveForm.ClientSize.Height)
                            {
                                _bulletTimer.Stop();
                                _bulletTimer.Dispose();
                                _bullet.Dispose();
                                _bulletTimer = null;
                                _bullet = null;
                            }
                    }
            }
    }