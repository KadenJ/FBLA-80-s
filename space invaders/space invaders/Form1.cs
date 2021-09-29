using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace space_invaders
{
    
    public partial class Form1 : Form
    {

        bool goLeft, goRight;
        int playerSpeed = 12;
        int enemySpeed = 5;
        public static int score = 0;
        int enemyCount;
        int enemyBulletTimer = 300;
        int level;

        PictureBox[] InvaderArray;

        bool shooting;
        bool isGameOver;
        bool victory;
        bool menu = true;


        // C:\Users\7542674\Desktop\FBLA\space invaders\space invaders\Resources\
        //get file directory path


        //SoundPlayer BGMusic = new SoundPlayer(Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\sounds\") + "BGMusic.wav");    //add file for BG sound
        
        SoundPlayer bulletSound = new SoundPlayer(Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\sounds\") + "playerFire.wav");
        public Form1()
        {
            
            InitializeComponent();
            //change spot of gameSetup
            //gameSetup();
            menu = true;
            

            //BGMusic.PlayLooping();
        }
        
        private void txtScore_Click(object sender, EventArgs e)
        {
            
        }

        //basically update function from unity
        private void mainGameTimer(object sender, EventArgs e)
        {
            //BGMusic.PlayLooping();    //background music

            txtScore.Text = "Score: " + score;

            if (goLeft)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight)
            {
                Player.Left += playerSpeed;
            }

            enemyBulletTimer -= 10;

            if(enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                makeBullet("sadBullet");
            }

            foreach (Control x in this.Controls)
            {

                if(x is PictureBox && (string)x.Tag == "Invaders")
                {
                    x.Left += enemySpeed;

                    if(x.Left > 730)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }

                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        ////gameOver("You've been invaded!!");
                        // go to scoreboard
                    }

                    foreach(Control y  in this.Controls)
                    {
                        if(y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                //random score of 50 - 100
                                Random rnd = new Random();
                                int z = rnd.Next(50, 150);
                                score += z;
                                enemyCount += 1;
                                shooting = false;
                            }                            
                        }
                    }                    
                }

                if(x is PictureBox &&(string)x.Tag == "bullet")
                {
                    x.Top -= 20;
                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }

                if(x is PictureBox && (string)x.Tag == "sadBullet")
                {
                    x.Top += 20;

                    if(x.Top> 620)
                    {
                        this.Controls.Remove(x);
                    }

                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("you've been killed");
                        //go to scoreboard
                    }
                }

            }
                        
            if(enemyCount >= 8 )
            {

                enemySpeed = 5 + level +1;

                if(level == 5)
                {
                    enemySpeed = 11;
                }
                Console.WriteLine(enemySpeed);
                                
            }

            if (enemyCount == InvaderArray.Length)
            {
                win("you saved the planet!! " +
                    "continue?");
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                
            }

            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = true;
                
                    
            }
            if(e.KeyCode == Keys.Right || e.KeyCode == Keys.S)
            {
                goRight = true;
                
            }
            if(e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                makeBullet("bullet");
                bulletSound.Play();
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeAll();
                //send to scoreboard
                this.Hide();
                ScoreBoard f2 = new ScoreBoard();
                f2.Show();
                //get rid of game setupup
                //gameSetup();
            }
            if (e.KeyCode == Keys.Enter && victory == true)
            {
                victory = false;
                removeAll();
                nextLevel();
                WorL.Text = "";
            }
            if(menu == true && e.KeyCode == Keys.Enter)
            {
                Mmenu.SendToBack();
                gameSetup();
                menu = false;
                Title.SendToBack();
                Prompt.SendToBack();
            }
        }

        private void makeInvaders()
        {
            InvaderArray = new PictureBox[15];

            int left = 0;

            for(int i = 0; i < InvaderArray.Length; i++)
            {
                InvaderArray[i] = new PictureBox();
                InvaderArray[i].Size = new Size(60, 50);
                InvaderArray[i].Image = Properties.Resources.aliean;
                InvaderArray[i].Top = 5;
                InvaderArray[i].Tag = "Invaders";
                InvaderArray[i].Left = left;
                InvaderArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(InvaderArray[i]);
                left = left - 80;
                InvaderArray[i].BringToFront();
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.S)
            {
                goRight = false;
            }
        }

        private void gameSetup()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            isGameOver = false;
            victory = false;

            enemyBulletTimer = 300;
            enemySpeed = 5;
            shooting = false;

            makeInvaders();
            GameTime.Start();

            level = 1;
            enemyCount = 0;
        }

        private void nextLevel()
        {
            enemyBulletTimer = 300;

            if (victory == true)
            {
                enemySpeed += 1;
            }else if(enemySpeed == 10)
            {
                enemySpeed = 10;
            }
            
            shooting = false;

            removeAll();
            makeInvaders();
            GameTime.Start();

            level += 1;
            enemyCount = 0;
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            GameTime.Stop();
            txtScore.Text = "Score: " + score + " " + message;

            //save score for scoreboard
        }

        private void win(string message)
        {
            removeAll();
            victory = true;
            GameTime.Stop();
            WorL.Text = message;
        }

        private void removeAll()
        {
            foreach (PictureBox i in InvaderArray)
            {
                this.Controls.Remove(i);
            }

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "bullet" ||(string) x.Tag == "sadBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {

        }

        private void makeBullet(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.c_users_anhar_ali_appdata_local_microsoft_windows_2;
            bullet.Size = new Size(5, 20);
            bullet.Tag = bulletTag;
            bullet.Left = Player.Left + Player.Width / 2;

            if((string) bullet.Tag == "bullet")
            {
                bullet.Top = Player.Top - 20;
            }            
            else if((string)bullet.Tag == "sadBullet")
            {
                bullet.Top = -100;
            }

            this.Controls.Add(bullet);
            bullet.BringToFront();

            //SoundPlayer bulletSound = new SoundPlayer(@"C:\Users\7542674\Desktop\FBLA\sounds\playerFire.wav");
            //bulletSound.Play();
        }

        
    }

    
    //scoreboard script
}
