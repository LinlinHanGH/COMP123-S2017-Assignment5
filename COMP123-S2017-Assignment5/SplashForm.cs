﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Linlin Han
 * Number: 300883493
 * Date: August 15, 2017
 * Description: This is the Splash form shown before the BMICalculator
 * Version: 0.1 - Created Splash Form
 */

namespace COMP123_S2017_Assignment5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.BMIcalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled= false;//turn timer off
        }
    }
}
