namespace COMP123_S2017_Assignment5
{
    partial class BMICalculator
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
            this.StandardMetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.BMIScaleResultTextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.StandardMetricTableLayoutPanel.SuspendLayout();
            this.CalculationTableLayoutPanel.SuspendLayout();
            this.ResultTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardMetricTableLayoutPanel
            // 
            this.StandardMetricTableLayoutPanel.ColumnCount = 2;
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.Controls.Add(this.MetricRadioButton, 0, 0);
            this.StandardMetricTableLayoutPanel.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.StandardMetricTableLayoutPanel.Location = new System.Drawing.Point(23, 8);
            this.StandardMetricTableLayoutPanel.Name = "StandardMetricTableLayoutPanel";
            this.StandardMetricTableLayoutPanel.RowCount = 1;
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.StandardMetricTableLayoutPanel.Size = new System.Drawing.Size(265, 52);
            this.StandardMetricTableLayoutPanel.TabIndex = 0;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(3, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(126, 46);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(135, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(127, 46);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // CalculationTableLayoutPanel
            // 
            this.CalculationTableLayoutPanel.ColumnCount = 3;
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CalculationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.CalculationTableLayoutPanel.Location = new System.Drawing.Point(2, 67);
            this.CalculationTableLayoutPanel.Name = "CalculationTableLayoutPanel";
            this.CalculationTableLayoutPanel.RowCount = 2;
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculationTableLayoutPanel.Size = new System.Drawing.Size(294, 122);
            this.CalculationTableLayoutPanel.TabIndex = 1;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(6, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(135, 61);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(7, 61);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(133, 61);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.Location = new System.Drawing.Point(150, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(82, 53);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.Location = new System.Drawing.Point(150, 65);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(82, 53);
            this.WeightTextBox.TabIndex = 3;
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.ColumnCount = 2;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.Controls.Add(this.BMILabel, 0, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIResultTextBox, 1, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIScaleLabel, 0, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIScaleResultTextBox, 1, 1);
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(0, 280);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 2;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(294, 106);
            this.ResultTableLayoutPanel.TabIndex = 2;
            // 
            // BMILabel
            // 
            this.BMILabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(54, 3);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(90, 46);
            this.BMILabel.TabIndex = 0;
            this.BMILabel.Text = "BMI";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(2, 207);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(294, 41);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMIScaleLabel.AutoSize = true;
            this.BMIScaleLabel.Location = new System.Drawing.Point(23, 53);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(121, 53);
            this.BMIScaleLabel.TabIndex = 2;
            this.BMIScaleLabel.Text = "BMI Scale";
            // 
            // BMIScaleResultTextBox
            // 
            this.BMIScaleResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIScaleResultTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BMIScaleResultTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BMIScaleResultTextBox.Location = new System.Drawing.Point(150, 56);
            this.BMIScaleResultTextBox.Name = "BMIScaleResultTextBox";
            this.BMIScaleResultTextBox.ReadOnly = true;
            this.BMIScaleResultTextBox.Size = new System.Drawing.Size(141, 53);
            this.BMIScaleResultTextBox.TabIndex = 3;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(238, 7);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(31, 46);
            this.HeightUnitLabel.TabIndex = 6;
            this.HeightUnitLabel.Text = " ";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(238, 68);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(31, 46);
            this.WeightUnitLabel.TabIndex = 7;
            this.WeightUnitLabel.Text = " ";
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIResultTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BMIResultTextBox.Location = new System.Drawing.Point(150, 3);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.ReadOnly = true;
            this.BMIResultTextBox.Size = new System.Drawing.Size(141, 53);
            this.BMIResultTextBox.TabIndex = 1;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.ResultTableLayoutPanel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CalculationTableLayoutPanel);
            this.Controls.Add(this.StandardMetricTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.StandardMetricTableLayoutPanel.ResumeLayout(false);
            this.StandardMetricTableLayoutPanel.PerformLayout();
            this.CalculationTableLayoutPanel.ResumeLayout(false);
            this.CalculationTableLayoutPanel.PerformLayout();
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.ResultTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StandardMetricTableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TableLayoutPanel CalculationTableLayoutPanel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label BMIScaleLabel;
        private System.Windows.Forms.TextBox BMIScaleResultTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
    }
}

