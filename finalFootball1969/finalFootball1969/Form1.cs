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
 
namespace finalFootball1969
{
    //images provided by google common license search
    //TrapingPiano.wav copyright of Cesar Mojarro
    // all other wav files are from common license sound search

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        int duration = 180;
        
        int yardsGained = 0;
        int yardslost = 0;
        bool sameyardline = false;
        int qbxp = 0;
        int rbxp = 0;
        int rcxp = 0;
        int yardsgained = 0;

        private SoundPlayer _soundPlayer; 
        private SoundPlayer _fxsoundPlayer;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            runningback.Visible = false;
            quarterback.Visible = false;
            receiver.Visible = false;
            received.Visible = false;
            sacked.Visible = false;
            blitz.Visible = false;
            label8.Visible = false;
            strt.Visible = true;
            strt1.Visible = true;
            _soundPlayer = new SoundPlayer("TrapingPiano.wav");
            _soundPlayer.Play();
            _fxsoundPlayer = new SoundPlayer("defense.wav");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            duration--;
            
            
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!\r\nGame Over!!!!\r\nYou have scored:\r\nQuarterback : " + qbxp + " expereince points\r\n" + "Runningback : " + rbxp + " expereince points\r\n" + "Receiver : " + rcxp + " expereince points\r\n" + "Yards Gained : "+ yardsGained + "\r\nYards Lost : " + yardslost);
                
            }
            
            
            textBox1.Text = duration.ToString();
            
           
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            _fxsoundPlayer.Play();

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _soundPlayer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fxsoundPlayer.Play();
            runningback.Visible = false;
            quarterback.Visible = true;
            receiver.Visible = false;
            received.Visible = false;
            sacked.Visible = false;
            blitz.Visible = false;
            strt.Visible = false;
            strt1.Visible = false;

            Random aiRandom = new Random();
            
            int comp = aiRandom.Next(3) + 1;
            label8.Text = comp.ToString();
            label12.Text = yardsGained.ToString();
            label11.Text = yardslost.ToString();
            label10.Text = sameyardline.ToString();
            textBox2.Text = qbxp.ToString();
            yardsgainedlabel.Text = yardsgained.ToString();
            
            if (comp == 1)
            {
                received.Visible = true;
                label3.Text = "Player Gains Yards";
                stats.Text = "You have gained 5 yards!\r\n\r\nYou have gained 7 Quarterback experience points!\n";
                aiLabel.Text = "AI defense is slacking";
                yardsGained = yardsGained + 5;
                qbxp = qbxp + 7;
                sameyardline = false;
                yardsgained = 5;

            }
            else if (comp == 2)
            {
                sacked.Visible = true;
                label3.Text = "Player Down same Yard Line";
                stats.Text = "No yards gained same yard line!\r\n\r\nYou have lost 1 Quarterback experience point!\n";
                aiLabel.Text = "That's it, sacked money!!";
                sameyardline = true;
                qbxp = qbxp - 1;
                yardsgained = 0;
            }
            else if (comp == 3)
            {
                blitz.Visible = true;
                label3.Text = "Player Lost Yards";
                stats.Text = "You have lost 2 yards!\r\n\r\nYou have lost 4 Quarterback experience points!\n";
                aiLabel.Text = "We bout to make some toast, blitz!";
                yardslost = yardslost + 2;
                yardsGained = yardsGained - 2;
                sameyardline = false;
                qbxp = qbxp - 4;
                yardsgained = -2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            runningback.Visible = true;
            quarterback.Visible = false;
            receiver.Visible = false;
            received.Visible = false;
            sacked.Visible = false;
            blitz.Visible = false;
            strt.Visible = false;
            strt1.Visible = false;

            Random aiRandom = new Random();

            int comp = aiRandom.Next(3) + 1;
            label8.Text = comp.ToString();
            label12.Text = yardsGained.ToString();
            label11.Text = yardslost.ToString();
            label10.Text = sameyardline.ToString();
            textBox3.Text = rbxp.ToString();
            yardsgainedlabel.Text = yardsgained.ToString();

            if (comp == 1)
            {
                received.Visible = true;
                label3.Text = "Player Gains Yards";
                stats.Text = "You have gained 5 yards!\r\n\r\nYou have gained 8 Runningback experience points!\n";
                aiLabel.Text = "AI defense is slacking";
                yardsGained = yardsGained + 5;
                rbxp = rbxp + 8;
                sameyardline = false;
                yardsgained = 5;

            }
            else if (comp == 2)
            {
                sacked.Visible = true;
                label3.Text = "Player Down same Yard Line";
                stats.Text = "No yards gained same yard line!\r\n\r\nYou have lost 2 Runningback experience points!\n";
                aiLabel.Text = "That's it, sacked money!!";
                sameyardline = true;
                rbxp = rbxp - 2;
                yardsgained = 0;
            }
            else if (comp == 3)
            {
                blitz.Visible = true;
                label3.Text = "Player Lost Yards";
                stats.Text = "You have lost 3 yards!\r\n\r\nYou have lost 6 Runningback experience points!\n";
                aiLabel.Text = "We bout to make some toast, blitz!";
                yardslost = yardslost + 3;
                yardsGained = yardsGained - 3;
                sameyardline = false;
                rbxp = rbxp - 6;
                yardsgained = -3;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _fxsoundPlayer.Play();
            runningback.Visible = false;
            quarterback.Visible = false;
            receiver.Visible = true;
            received.Visible = false;
            sacked.Visible = false;
            blitz.Visible = false;
            strt.Visible = false;
            strt1.Visible = false;

            Random aiRandom = new Random();

            int comp = aiRandom.Next(3) + 1;
            label8.Text = comp.ToString();
            label12.Text = yardsGained.ToString();
            label11.Text = yardslost.ToString();
            label10.Text = sameyardline.ToString();
            textBox4.Text = rcxp.ToString();
            yardsgainedlabel.Text = yardsgained.ToString();

            if (comp == 1)
            {
                received.Visible = true;
                label3.Text = "Player Gains Yards";
                stats.Text = "You have gained 5 yards!\r\n\r\nYou have gained 8 Receiver experience points!\n";
                aiLabel.Text = "AI defense is slacking";
                yardsGained = yardsGained + 5;
                rcxp = rcxp + 8;
                sameyardline = false;
                yardsgained = 5;

            }
            else if (comp == 2)
            {
                sacked.Visible = true;
                label3.Text = "Player Down same Yard Line";
                stats.Text = "No yards gained same yard line!\r\n\r\nYou have lost 2 Receiver experience points!\n";
                aiLabel.Text = "That's it, sacked money!!";
                sameyardline = true;
                rcxp = rcxp - 2;
                yardsgained = 0;
            }
            else if (comp == 3)
            {
                blitz.Visible = true;
                label3.Text = "Player Lost Yards";
                stats.Text = "You have lost 3 yards!\r\n\r\nYou have lost 6 Receiver experience points!\n";
                aiLabel.Text = "We bout to make some toast, blitz!";
                yardslost = yardslost + 3;
                yardsGained = yardsGained - 3;
                sameyardline = false;
                rcxp = rcxp - 6;
                yardsgained = -3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void credits_CheckedChanged(object sender, EventArgs e)
        {
            if (credits.Checked)
            {
                credits.Text = "Cesar Mojarro\r\nColumbia College Chicago";
            }
            else
            {
                credits.Text = "Credits";
            }
        }
    }
}
