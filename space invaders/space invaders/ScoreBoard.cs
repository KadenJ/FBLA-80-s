using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_invaders
{
    public partial class ScoreBoard : Form
    {
        
        public ScoreBoard()
        {
            InitializeComponent();
            
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            var scores = new ArrayList();
            scores.Add(10000);
            scores.Add(9500);
            scores.Add(9000);
            scores.Add(5000);
            scores.Add(3000);

            
        }
    }
}
