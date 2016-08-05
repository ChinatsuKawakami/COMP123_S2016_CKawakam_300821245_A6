namespace COMP123_S2016_CKawakawam_300821245_A6
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.HeightLable = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Myheight = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightLabel2 = new System.Windows.Forms.Label();
            this.WeightLabel2 = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.Myheight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.Controls.Add(this.Clear_Button, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.TableLayoutPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.BackButton, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(24, 257);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(238, 183);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Red;
            this.Clear_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Clear_Button.Location = new System.Drawing.Point(3, 3);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(73, 30);
            this.Clear_Button.TabIndex = 0;
            this.Clear_Button.Text = "C";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 39);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(73, 30);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(82, 39);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(73, 30);
            this.EightButton.TabIndex = 2;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(161, 39);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(74, 30);
            this.NineButton.TabIndex = 3;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 75);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(73, 30);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(82, 75);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(73, 30);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(161, 75);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(74, 30);
            this.SixButton.TabIndex = 6;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 111);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(73, 30);
            this.OneButton.TabIndex = 7;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(82, 111);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(73, 30);
            this.TwoButton.TabIndex = 8;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(161, 111);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(74, 30);
            this.ThreeButton.TabIndex = 9;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(161, 147);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(74, 33);
            this.DecimalButton.TabIndex = 11;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(82, 147);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(73, 33);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(82, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(73, 30);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(18, 99);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(120, 34);
            this.HeighttextBox.TabIndex = 1;
            this.HeighttextBox.Click += new System.EventHandler(this.HeighttextBox_Click);
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(18, 163);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(125, 34);
            this.WeighttextBox.TabIndex = 2;
            this.WeighttextBox.Click += new System.EventHandler(this.WeighttextBox_Click);
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(19, 66);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(125, 27);
            this.HeightLable.TabIndex = 3;
            this.HeightLable.Text = "My Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(19, 133);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(128, 27);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(6, 17);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(102, 31);
            this.MetricRadioButton.TabIndex = 6;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(114, 17);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(118, 31);
            this.ImperialRadioButton.TabIndex = 7;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(0, 203);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(189, 38);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Calculate BMI";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Myheight
            // 
            this.Myheight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Myheight.Controls.Add(this.ImperialRadioButton);
            this.Myheight.Controls.Add(this.MetricRadioButton);
            this.Myheight.Location = new System.Drawing.Point(12, 0);
            this.Myheight.Name = "Myheight";
            this.Myheight.Size = new System.Drawing.Size(247, 52);
            this.Myheight.TabIndex = 11;
            this.Myheight.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(195, 203);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(97, 38);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightLabel2
            // 
            this.HeightLabel2.AutoSize = true;
            this.HeightLabel2.Location = new System.Drawing.Point(155, 102);
            this.HeightLabel2.Name = "HeightLabel2";
            this.HeightLabel2.Size = new System.Drawing.Size(78, 27);
            this.HeightLabel2.TabIndex = 14;
            this.HeightLabel2.Text = "label1";
            this.HeightLabel2.Visible = false;
            // 
            // WeightLabel2
            // 
            this.WeightLabel2.AutoSize = true;
            this.WeightLabel2.Location = new System.Drawing.Point(155, 166);
            this.WeightLabel2.Name = "WeightLabel2";
            this.WeightLabel2.Size = new System.Drawing.Size(78, 27);
            this.WeightLabel2.TabIndex = 15;
            this.WeightLabel2.Text = "label2";
            this.WeightLabel2.Visible = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.WeightLabel2);
            this.Controls.Add(this.HeightLabel2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Myheight);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HeightLable);
            this.Controls.Add(this.WeighttextBox);
            this.Controls.Add(this.HeighttextBox);
            this.Controls.Add(this.TableLayoutPanel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.TableLayoutPanel.ResumeLayout(false);
            this.Myheight.ResumeLayout(false);
            this.Myheight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox Myheight;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label HeightLabel2;
        private System.Windows.Forms.Label WeightLabel2;
    }
}

