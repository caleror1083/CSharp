using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooter
    {
        public partial class MainScreen : Form
            {
                // variables
                bool goLeft;    // this boolean will be used for the player to go left on the screen
                bool goRight;    // this boolean will be used for the player to go right on the screen
                bool goUp;    // this boolean will be used for the player to go up on the screen
                bool goDown;    // this boolean will be used for th player to go down on the screen
                bool gameOver = false;    // this boolean is false in the beginning and it will be used when the game is finished
                string facing = "up";    // this string is called facing and it will be used to guide the bullets
                int playerHealth = 100;    // this integer represents the player's health bar
                int speed = 10;    // this integer is for the speed of the player
                int ammo = 10;    // this integer will hold the number of ammo the player has at the start of the game
                int zombieSpeed = 3;    // this integer will hold the speed which the zombies move in the game
                int score = 0;    // this integer will hold the number of kills in the game
                Random randomNumber = new Random();    // this is an instance of the random class that will be used to create a random number
                List<PictureBox> zombiesList = new List<PictureBox>();    // this list represents the zombie enemies

                public MainScreen()
                    {
                        InitializeComponent();
                        RestartGame();
                    }

                private void GameEngine(object sender, EventArgs e)
                    {
                        if (playerHealth > 1)    // if player health is greater than 1
                            {
                                healthbar.Value = (playerHealth);    // assign the progress bar to the player health integer
                            }
                        else
                            {
                                gameOver = true;    // change game over to true
                                player.Image = Properties.Resources.dead;
                                GameTimer.Stop();
                            }

                        lblAmmo.Text = $"Ammo: {ammo}";    // show the ammo amount on ammo label
                        lblScore.Text = $"Kills: {score}";    // show the total kills on the score label

                        if (playerHealth <= 30)
                            {
                                healthbar.ForeColor = Color.Red;
                            }

                        if (goLeft == true && player.Left > 0)    // if moving left is true AND player is 1 pixel more from the left 
                            {   
                                player.Left -= speed;    // then move the player to the LEFT                     
                            }

                        if (goRight == true && player.Left + player.Width < this.ClientSize.Width)    // if moving right is true AND player left + player width is less than the width of the form
                            {
                                player.Left += speed;    // then move the player to the RIGHT
                            }

                        if (goUp == true && player.Top > 44)    // if moving up is true and player is 1 pixel more from the bottom of the menu bar
                            {
                                player.Top -= speed;    // then move the player UP
                            }

                        if (goDown == true && player.Top + player.Height < this.ClientSize.Height)    // if moving down is true AND player top + player height is less than the height of the form
                            {
                                player.Top += speed;    // then move the player DOWN
                            }

                        foreach (Control x in this.Controls)
                            {
                                if (x is PictureBox && (string)x.Tag == "ammo")
                                    {
                                        if (player.Bounds.IntersectsWith(x.Bounds))
                                            {
                                                this.Controls.Remove(x);
                                                ((PictureBox)x).Dispose();
                                                ammo += randomNumber.Next(1, 101);
                                            }
                                    }

                                if (x is PictureBox && (string)x.Tag == "zombie")
                                    {
                                        if (player.Bounds.IntersectsWith(x.Bounds))
                                            { 
                                                playerHealth -= 1;
                                            }

                                        if (x.Left > player.Left)
                                            {
                                                x.Left -= zombieSpeed;
                                                ((PictureBox)x).Image = Properties.Resources.zleft;
                                            }

                                        if (x.Left < player.Left)
                                            {
                                                x.Left += zombieSpeed;
                                                ((PictureBox)x).Image = Properties.Resources.zright;
                                            }

                                        if (x.Top > player.Top)
                                            {
                                                x.Top -= zombieSpeed;
                                                ((PictureBox)x).Image = Properties.Resources.zup;
                                            }

                                        if (x.Top < player.Top)
                                            {
                                                x.Top += zombieSpeed;
                                                ((PictureBox)x).Image = Properties.Resources.zdown;
                                            }
                                    }

                                foreach (Control j in this.Controls)
                                    {
                                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                                            {
                                                if (x.Bounds.IntersectsWith(j.Bounds))
                                                    {
                                                        score++;
                                                        this.Controls.Remove(j);
                                                        ((PictureBox)j).Dispose();
                                                        this.Controls.Remove(x);
                                                        ((PictureBox)x).Dispose();
                                                        zombiesList.Remove(((PictureBox)x));
                                                        MakeZombies();
                                                    }
                                            }
                                    }
                            }
        }

                private void KeyIsDown(object sender, KeyEventArgs e)
                    {
                        if (gameOver == true)
                            {
                                return;
                            }

                        // if the left key is pressed then do the following
                        if (e.KeyCode == Keys.Left)
                            {
                                goLeft = true;    // change goLeft to true
                                facing = "left";    // change facing to left
                                player.Image = Properties.Resources.left;    // change the player image to LEFT image
                            }

                        // if the right key is pressed then do the following
                        if (e.KeyCode == Keys.Right)
                            {
                                goRight = true;    // change goRight to true
                                facing = "right";    // change facing to right
                                player.Image = Properties.Resources.right;    // change the player image to RIGHT image
                            }

                        // if the up key is pressed then do the following
                        if (e.KeyCode == Keys.Up)
                            {
                                goUp = true;    // change goUp to true
                                facing = "up";    // change facing to up
                                player.Image = Properties.Resources.up;    // change the player image to UP image
                            }

                        // if the down key is pressed then do the following
                        if (e.KeyCode == Keys.Down)
                            {
                                goDown = true;    // change goDown to true
                                facing = "down";    // change facing to down
                                player.Image = Properties.Resources.down;    // change the player image to DOWN image
                            }
                    }

                private void KeyIsUp(object sender, KeyEventArgs e)
                    {
                        // below is the key up selection for the left key
                        if (e.KeyCode == Keys.Left)
                            {
                                goLeft = false;    // change the go left boolean to false
                            }

                        // below is the key up selection for the right key
                        if (e.KeyCode == Keys.Right)
                            {
                                goRight = false;    // change the go right boolean to false
                            }

                        // below is the key up selection for the up key
                        if (e.KeyCode == Keys.Up)
                            {
                                goUp = false;    // change the go up boolean to false
                            }

                        // below is the key up selection for the down key
                        if (e.KeyCode == Keys.Down)
                            {
                                goDown = false;    // change the go down boolean to false
                            }

                        if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)    // checking if the space bar is up
                            {
                                ammo--;
                                ShootBullet(facing);    // invoke the ShootBullet function with the facing string inside it, facing will transfer up, down, left or right to the function and that will shoot the bullet that way

                                if (ammo < 1)
                                    {
                                        DropAmmo();
                                    }
                            }
                        if (e.KeyCode == Keys.Enter && gameOver == true)
                            {
                                RestartGame();
                            }
                    }

                private void ShootBullet(string direction)
                    {
                        Bullet shootBullet = new Bullet();
                        shootBullet.Direction = direction;
                        shootBullet.BulletLeft = player.Left + (player.Width / 2);
                        shootBullet.BulletTop = player.Top + (player.Height / 2);
                        shootBullet.MakeBullet(this);
                    }

                private void MakeZombies()    // this method will dynamically spawn the enemies
                    {
                        PictureBox zombie = new PictureBox();
                        zombie.Tag = "zombie";
                        zombie.Image = Properties.Resources.zdown;
                        zombie.Left = randomNumber.Next(0, this.ClientSize.Width - zombie.Width);
                        zombie.Top = randomNumber.Next(44, this.ClientSize.Height - zombie.Height);
                        zombie.SizeMode = PictureBoxSizeMode.AutoSize;
                        zombiesList.Add(zombie);
                        this.Controls.Add(zombie);
                        player.BringToFront();
                    }

                private void DropAmmo()
                    {
                        PictureBox ammo = new PictureBox();
                        ammo.Image = Properties.Resources.ammo_Image;
                        ammo.SizeMode = PictureBoxSizeMode.AutoSize;
                        ammo.Left = randomNumber.Next(0, this.ClientSize.Width - ammo.Width);
                        ammo.Top = randomNumber.Next(44, this.ClientSize.Height - ammo.Height);
                        ammo.Tag = "ammo";
                        this.Controls.Add(ammo);
                        ammo.BringToFront();
                        player.BringToFront();
                    }

                private void RestartGame()    // this method will restart the game
                    { 
                        player.Image = Properties.Resources.up;

                        foreach (PictureBox i in zombiesList)
                            {
                                this.Controls.Remove(i);
                            }
                        zombiesList.Clear();

                        for (int i = 0; i < 3; i++)
                            {
                                MakeZombies();
                            }
                        goUp = false;
                        goDown = false;
                        goLeft = false;
                        goRight = false;
                        gameOver = false;

                        playerHealth = 100;
                        score = 0;
                        ammo = 10;

                        GameTimer.Start();
                    }
            }
    }