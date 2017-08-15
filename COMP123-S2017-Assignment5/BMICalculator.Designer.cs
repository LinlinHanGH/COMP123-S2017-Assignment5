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
            this.StandardMetricTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardMetricTableLayoutPanel
            // 
            this.StandardMetricTableLayoutPanel.ColumnCount = 2;
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StandardMetricTableLayoutPanel.Controls.Add(this.MetricRadioButton, 0, 0);
            this.StandardMetricTableLayoutPanel.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.StandardMetricTableLayoutPanel.Location = new System.Drawing.Point(16, 9);
            this.StandardMetricTableLayoutPanel.Name = "StandardMetricTableLayoutPanel";
            this.StandardMetricTableLayoutPanel.RowCount = 1;
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StandardMetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.StandardMetricTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.Text = "BMICalculator";
            this.StandardMetricTableLayoutPanel.ResumeLayout(false);
            this.StandardMetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StandardMetricTableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
    }
}

