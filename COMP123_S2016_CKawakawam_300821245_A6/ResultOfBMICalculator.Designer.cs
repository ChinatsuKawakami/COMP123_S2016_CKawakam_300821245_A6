namespace COMP123_S2016_CKawakawam_300821245_A6
{
    partial class ResultOfBMICalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Result";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.Location = new System.Drawing.Point(36, 112);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(222, 27);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "Here is your result";
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BMIlabel.Location = new System.Drawing.Point(52, 186);
            this.BMIlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(187, 27);
            this.BMIlabel.TabIndex = 2;
            this.BMIlabel.Text = "Your BMI Level";
            // 
            // Bar
            // 
            this.Bar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Bar.Location = new System.Drawing.Point(16, 266);
            this.Bar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(262, 52);
            this.Bar.TabIndex = 3;
            // 
            // ResultOfBMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.BMIlabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimizeBox = false;
            this.Name = "ResultOfBMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultOfBMICalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ResultLabel;
        public System.Windows.Forms.Label BMIlabel;
    
    }
}