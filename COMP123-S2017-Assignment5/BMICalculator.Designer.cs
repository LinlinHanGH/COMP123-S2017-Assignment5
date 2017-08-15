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
            this.HeightUnitTextBox = new System.Windows.Forms.TextBox();
            this.WeightUnitTextBox = new System.Windows.Forms.TextBox();
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
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
            this.StandardMetricTableLayoutPanel.Location = new System.Drawing.Point(16, 4);
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
            this.CalculationTableLayoutPanel.Controls.Add(this.HeightUnitTextBox, 2, 0);
            this.CalculationTableLayoutPanel.Controls.Add(this.WeightUnitTextBox, 2, 1);
            this.CalculationTableLayoutPanel.Location = new System.Drawing.Point(2, 53);
            this.CalculationTableLayoutPanel.Name = "CalculationTableLayoutPanel";
            this.CalculationTableLayoutPanel.RowCount = 2;
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculationTableLayoutPanel.Size = new System.Drawing.Size(294, 130);
            this.CalculationTableLayoutPanel.TabIndex = 1;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(6, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(135, 65);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(7, 65);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(133, 65);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.Location = new System.Drawing.Point(150, 6);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(82, 53);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.Location = new System.Drawing.Point(150, 71);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(82, 53);
            this.WeightTextBox.TabIndex = 3;
            // 
            // HeightUnitTextBox
            // 
            this.HeightUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightUnitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightUnitTextBox.Enabled = false;
            this.HeightUnitTextBox.Location = new System.Drawing.Point(238, 6);
            this.HeightUnitTextBox.Name = "HeightUnitTextBox";
            this.HeightUnitTextBox.Size = new System.Drawing.Size(53, 46);
            this.HeightUnitTextBox.TabIndex = 4;
            // 
            // WeightUnitTextBox
            // 
            this.WeightUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightUnitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightUnitTextBox.Enabled = false;
            this.WeightUnitTextBox.Location = new System.Drawing.Point(238, 71);
            this.WeightUnitTextBox.Name = "WeightUnitTextBox";
            this.WeightUnitTextBox.Size = new System.Drawing.Size(53, 46);
            this.WeightUnitTextBox.TabIndex = 5;
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.ColumnCount = 1;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultTableLayoutPanel.Controls.Add(this.BMILabel, 0, 0);
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(2, 246);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 4;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(294, 173);
            this.ResultTableLayoutPanel.TabIndex = 2;
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(3, 0);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(126, 43);
            this.BMILabel.TabIndex = 0;
            this.BMILabel.Text = "label1";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.PowderBlue;
            this.CalculateButton.Location = new System.Drawing.Point(2, 191);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(294, 41);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.TextBox HeightUnitTextBox;
        private System.Windows.Forms.TextBox WeightUnitTextBox;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

