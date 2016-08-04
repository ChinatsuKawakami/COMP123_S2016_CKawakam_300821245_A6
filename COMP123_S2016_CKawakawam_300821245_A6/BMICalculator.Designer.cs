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
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.HeightLable = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Myheight = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightlLabel = new System.Windows.Forms.Label();
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
            this.TableLayoutPanel.Controls.Add(this.Seven, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.Eight, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.Nine, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.Four, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.Five, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.Six, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.One, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.Two, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.Three, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.TableLayoutPanel.Controls.Add(this.Zero, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.BackButton, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(21, 247);
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
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(3, 39);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(73, 30);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(82, 39);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(73, 30);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(161, 39);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(74, 30);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(3, 75);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(73, 30);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(82, 75);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(73, 30);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(161, 75);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(74, 30);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(3, 111);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(73, 30);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(82, 111);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(73, 30);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(161, 111);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(74, 30);
            this.Three.TabIndex = 9;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Calculator_Click);
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
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(82, 147);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(73, 33);
            this.Zero.TabIndex = 10;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Calculator_Click);
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
            this.HeighttextBox.Location = new System.Drawing.Point(24, 96);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(120, 34);
            this.HeighttextBox.TabIndex = 1;
            this.HeighttextBox.Click += new System.EventHandler(this.HeighttextBox_Click);
           
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(24, 163);
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
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(6, 17);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(102, 31);
            this.Metric.TabIndex = 6;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(114, 17);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(118, 31);
            this.Imperial.TabIndex = 7;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(0, 198);
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
            this.Myheight.Controls.Add(this.Imperial);
            this.Myheight.Controls.Add(this.Metric);
            this.Myheight.Location = new System.Drawing.Point(12, 0);
            this.Myheight.Name = "Myheight";
            this.Myheight.Size = new System.Drawing.Size(247, 63);
            this.Myheight.TabIndex = 11;
            this.Myheight.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(195, 198);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(97, 38);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightlLabel
            // 
            this.HeightlLabel.AutoSize = true;
            this.HeightlLabel.Location = new System.Drawing.Point(155, 99);
            this.HeightlLabel.Name = "HeightlLabel";
            this.HeightlLabel.Size = new System.Drawing.Size(78, 27);
            this.HeightlLabel.TabIndex = 14;
            this.HeightlLabel.Text = "label1";
            this.HeightlLabel.Visible = false;
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
            this.Controls.Add(this.HeightlLabel);
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
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox Myheight;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label HeightlLabel;
        private System.Windows.Forms.Label WeightLabel2;
    }
}

