using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reaction100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            goButton.Enabled = false;
        }

        Stopwatch timer = new Stopwatch();

        private void startButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = true;
            lightTimer.Enabled = true;
            startButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            if (lightOne.BackColor == Color.Olive)
            {
                lightOne.BackColor = Color.Yellow;
                lightTwo.BackColor = Color.Yellow;
            }
            else if (lightThree.BackColor == Color.Olive)
            {
                lightThree.BackColor = Color.Yellow;
                lightFour.BackColor = Color.Yellow;
            }
            else if (lightFive.BackColor == Color.Olive)
            {
                lightFive.BackColor = Color.Yellow;
                lightSix.BackColor = Color.Yellow;
            }
            else if (lightSeven.BackColor == Color.DarkOliveGreen)
            {
                lightSeven.BackColor = Color.Lime;
                lightEight.BackColor = Color.Lime;
                lightTimer.Enabled = false;
                timer.Start();
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            TimeSpan elapsed = timer.Elapsed;
            if (timer.ElapsedMilliseconds > 0)
            {
                outputLabel.Text = elapsed.ToString(@"s\:fff");
            }
            else
            {
                outputLabel.Text = "Foul Start";
            }
            goButton.Enabled = false;
            resetButton.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            lightOne.BackColor = Color.Olive;
            lightTwo.BackColor = Color.Olive;
            lightThree.BackColor = Color.Olive;
            lightFour.BackColor = Color.Olive;
            lightFive.BackColor = Color.Olive;
            lightSix.BackColor = Color.Olive;
            lightSeven.BackColor = Color.DarkOliveGreen;
            lightEight.BackColor = Color.DarkOliveGreen;
            startButton.Enabled = true;
            goButton.Enabled = false;
            timer.Reset();
            outputLabel.Text = "0.00";
        }
    }
}
