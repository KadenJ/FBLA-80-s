﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace space_invaders
{
    public partial class ScoreBoard : Form
    {
        string path;
        bool newGame;

        int score = Form1.score;   
        public ScoreBoard()
        {
            InitializeComponent();
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            
            int[] scores = new int[5] {10000, 9500, 9000, 5000, 3000};
            Array.Sort(scores);
            Array.Reverse(scores);

            #region score check
            if (score >= scores[4] + 1 && score <= scores[3])
            {
                scores[4] = score;
            }
            if(score >= scores[3] + 1 && score <= scores[2])
            {
                scores[3] = score;
            }
            if(score >= scores[2] + 1 && score <= scores[1])
            {
                scores[2] = score;
            }
            if (score >= scores[1] + 1 && score <= scores[0])
            {
                scores[1] = score;
            }
            if (score>= scores[0] + 1)
            {
                //highscore
                scores[0] = score;
            }
            #endregion

            #region assign scores
            Score1.Text = scores[0].ToString();
            Score2.Text = scores[1].ToString();
            Score3.Text = scores[2].ToString();
            Score4.Text = scores[3].ToString();
            Score5.Text = scores[4].ToString();
            #endregion

            //need to check if txt file exists

            //use json instead

            /*using (StreamWriter sw = new StreamWriter(path + "SIScoreBoard.txt"))
            {
                //should save array of scores
                for(int i = 0; i<scores.Length; i++)
                {
                    sw.WriteLine(scores[i]);
                }
                sw.Close();
            }

            using (StreamReader sr = new StreamReader(path + "SIScoreBoard.txt"))
            {
                // load scoreboard
                for(int i = 0; i<5; i++)
                {
                    scores[i] = sr.Read();
                }
                sr.Close();
            }*/

            
        }


        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            

            
        }

        private void ScoreBoard_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ScoreBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                Form1 MM = new Form1();
                MM.Show();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
