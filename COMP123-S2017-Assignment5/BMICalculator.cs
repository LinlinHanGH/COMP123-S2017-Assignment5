using System;
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
 * Version: 0.4 - Changed the ForeColor of readonly textbox
 */

namespace COMP123_S2017_Assignment5
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private double _result;
        private double _height;
        private double _weight;
        private string _BMIScale;

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

        public string BMIScale
        {
            get
            {
                return this._BMIScale;
            }

            set
            {
                this._BMIScale = value;
            }

        }


        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This event handler shows the metric units when MetricRadioButton is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Metric = sender as RadioButton;
            HeightUnitLabel.Text = "cm";
            WeightUnitLabel.Text = "kg";
        }

        /// <summary>
        /// This event handler shows the Imperial units when ImperialRadioButton is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Imperial = sender as RadioButton;
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lbs";
        }

        /// <summary>
        /// This event handler shows the BMI result when CalculateButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BMIResultTextBox.ForeColor = SystemColors.ControlText;
            Button calculateButton = sender as Button;
            Height = double.Parse(HeightTextBox.Text);
            Weight = double.Parse(WeightTextBox.Text);

            if (MetricRadioButton.Checked)
            {
                Result = Math.Round(Weight / Math.Pow(Height / 100, 2));
            }
            else if (ImperialRadioButton.Checked)
            {
                Result = Math.Round(Weight*703 / Math.Pow(Height, 2));
            }
            BMIResultTextBox.ReadOnly = false;
            BMIResultTextBox.ForeColor = Color.MidnightBlue;
            BMIResultTextBox.Text = this.Result.ToString();
            BMIResultTextBox.ReadOnly = true;
            this._ShowBMISacle();
            
        }

        /// <summary>
        /// This method shows the result of BMI Scale
        /// </summary>
        private void _ShowBMISacle()
        {
            if (Result < 18.5)
            {
                BMIScale = "UnderWeight";
            }
            else if ((Result >= 18.5) && (Result < 24.9))
            {
                BMIScale = "Normal";
            }
            else if ((Result >= 25) && (Result < 29.9))
            {
                BMIScale = "Overweight";
            }
            else if (Result > 30)
            {
                BMIScale = "Obese";
            }
            else
            {
                BMIScale = "Undefined";
            }
            BMIScaleResultTextBox.Text = BMIScale;
            BMIScaleResultTextBox.ReadOnly = false;
            BMIScaleResultTextBox.ForeColor = Color.MidnightBlue;
            
            BMIScaleResultTextBox.ReadOnly = true;
        }

        /// <summary>
        /// This is an event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
