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

namespace space_invaders
{
    public partial class ScoreBoard : Form
    {
        int score = Form1.score;   
        public ScoreBoard()
        {
            InitializeComponent();

            

            int[] scores = new int[5] {10000, 9500, 9000, 5000, 3000};
            Array.Reverse(scores);

            if(score >= scores[4] + 1 && score <= scores[3])
            {
                scores[4] = score;
            }else if(score >= scores[3] + 1 && score <= scores[2])
            {
                scores[3] = score;
            }else if(score >= scores[2] + 1 && score <= scores[1])
            {
                scores[2] = score;
            }else if (score >= scores[1] + 1 && score <= scores[0])
            {
                scores[1] = score;
            }else if (score>= scores[0] + 1)
            {
                //highscore
                scores[0] = score;
            }

            Score1.Text = scores[0].ToString();
            Score2.Text = scores[1].ToString();
            Score3.Text = scores[2].ToString();
            Score4.Text = scores[3].ToString();
            Score5.Text = scores[4].ToString();

            //need to check if txt file exists

            using (StreamWriter sw = new StreamWriter("SIScoreBoard.txt"))
            {
                //should save array of scores
                sw.WriteLine(scores);
            }

            using (StreamReader sr = new StreamReader("SIScoreBoard.txt"))
            {
                // load scoreboard
            }
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}
