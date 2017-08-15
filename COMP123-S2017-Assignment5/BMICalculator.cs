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
 * Description: A BMI calculator app with Windows Forms
 * Version: 0.2 - Add Metric BMI Calculation
 */

namespace COMP123_S2017_Assignment5
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private double _result;
        private double _height;
        private double _weight;

        // PUBLIC PROPERTIES
        public double Result
        {
            get
            {
                return this._result;
            }

            set
            {
                this._result = value;
            }
        }

        public double Height
        {
            get
            {
                return this._height;
            }

            set
            {
                this._height = value;
            }

        }

        public double Weight
        {
            get
            {
                return this._weight;
            }

            set
            {
                this._weight = value;
            }

        }


        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Metric = sender as RadioButton;
            HeightUnitTextBox.Text = "cm";
            WeightUnitTextBox.Text = "kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Imperial = sender as RadioButton;
            HeightUnitTextBox.Text = "in";
            WeightUnitTextBox.Text = "lbs";
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Button calculateButton = sender as Button;
            Height = double.Parse(HeightTextBox.Text);
            Weight = double.Parse(WeightTextBox.Text);
            
            if (MetricRadioButton.Checked)
            {
                Result = Math.Round(Weight/Math.Pow(Height/100,2));
                BMIResultTextBox.Text = this.Result.ToString();
            }
            

        }
    }
}
