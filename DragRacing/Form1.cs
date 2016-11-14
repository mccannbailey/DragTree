using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragRacing
{
    public partial class Form1 : Form
    {
        Stopwatch watch;
        int lights = 1;
        bool start;
        public Form1()
        {
            InitializeComponent();
            watch = new Stopwatch();
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            raceTimer.Enabled = true;          
        }
        private void raceTimer_Tick(object sender, EventArgs e)
        {
            switch (lights)
            {
                case 1:
                    light1Row1.BackColor = Color.Gold;
                    light2Row1.BackColor = Color.Gold;
                    lights++;
                    break;
                case 2:
                    light1Row2.BackColor = Color.Gold;
                    light2Row2.BackColor = Color.Gold;
                    lights++;
                    break;
                case 3:
                    light1Row3.BackColor = Color.Gold;
                    light2Row3.BackColor = Color.Gold;
                    lights++;                  
                    break;
                case 4:
                    greenLight1.BackColor = Color.Lime;
                    greenLight2.BackColor = Color.Lime;
                    start = true;
                    watch.Start();
                    break;
            }
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                watch.Stop();                
                reactionLabel.Text = Convert.ToString(watch.ElapsedMilliseconds + " milliseconds");
            }
            else if (start != true)
            {
                reactionLabel.Text = "FOUL START";
                watch.Stop();
                raceTimer.Enabled = false;
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            lights = 1;
            watch.Reset();
            watch.Stop();
            raceTimer.Enabled = false;
            reactionLabel.Text = "0.000";

            light1Row1.BackColor = Color.DimGray;
            light2Row1.BackColor = Color.DimGray;
            light1Row2.BackColor = Color.DimGray;
            light2Row2.BackColor = Color.DimGray;
            light1Row3.BackColor = Color.DimGray;
            light2Row3.BackColor = Color.DimGray; 
        }
    }
}
