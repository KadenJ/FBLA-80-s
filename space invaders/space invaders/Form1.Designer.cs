
namespace space_invaders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.WorL = new System.Windows.Forms.Label();
            this.Mmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Title = new System.Windows.Forms.PictureBox();
            this.Prompt = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.GBG = new System.Windows.Forms.Panel();
            this.Mmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prompt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Mishmash BRK", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtScore.Location = new System.Drawing.Point(12, 533);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 16);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // GameTime
            // 
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // WorL
            // 
            this.WorL.AutoSize = true;
            this.WorL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WorL.Font = new System.Drawing.Font("Mishmash BRK", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorL.Location = new System.Drawing.Point(280, 272);
            this.WorL.Name = "WorL";
            this.WorL.Size = new System.Drawing.Size(0, 16);
            this.WorL.TabIndex = 2;
            // 
            // Mmenu
            // 
            this.Mmenu.Controls.Add(this.Title);
            this.Mmenu.Controls.Add(this.Prompt);
            this.Mmenu.Location = new System.Drawing.Point(1, -1);
            this.Mmenu.Name = "Mmenu";
            this.Mmenu.Size = new System.Drawing.Size(684, 558);
            this.Mmenu.TabIndex = 4;
            this.Mmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Title
            // 
            this.Title.Image = global::space_invaders.Properties.Resources.title;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(681, 222);
            this.Title.TabIndex = 0;
            this.Title.TabStop = false;
            // 
            // Prompt
            // 
            this.Prompt.Image = global::space_invaders.Properties.Resources.prompt;
            this.Prompt.Location = new System.Drawing.Point(3, 231);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(681, 105);
            this.Prompt.TabIndex = 1;
            this.Prompt.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::space_invaders.Properties.Resources.tank;
            this.Player.Location = new System.Drawing.Point(275, 472);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(65, 85);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // GBG
            // 
            this.GBG.Location = new System.Drawing.Point(12, 12);
            this.GBG.Name = "GBG";
            this.GBG.Size = new System.Drawing.Size(660, 545);
            this.GBG.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 560);
            this.Controls.Add(this.Mmenu);
            this.Controls.Add(this.WorL);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.GBG);
            this.Name = "Form1";
            this.Text = "SI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            this.Mmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prompt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Label WorL;
        private System.Windows.Forms.FlowLayoutPanel Mmenu;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.PictureBox Prompt;
        private System.Windows.Forms.Panel GBG;
    }
}

