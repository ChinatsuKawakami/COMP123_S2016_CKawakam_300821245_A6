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
            this.YourResultLabel = new System.Windows.Forms.Label();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMILevelLabel = new System.Windows.Forms.Label();
            this.ResultProcessingBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // YourResultLabel
            // 
            this.YourResultLabel.AutoSize = true;
            this.YourResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.YourResultLabel.Location = new System.Drawing.Point(74, 38);
            this.YourResultLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.YourResultLabel.Name = "YourResultLabel";
            this.YourResultLabel.Size = new System.Drawing.Size(145, 27);
            this.YourResultLabel.TabIndex = 0;
            this.YourResultLabel.Text = "Your Result";
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BMIResultLabel.Location = new System.Drawing.Point(36, 112);
            this.BMIResultLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(222, 27);
            this.BMIResultLabel.TabIndex = 1;
            this.BMIResultLabel.Text = "Here is your result";
            // 
            // BMILevelLabel
            // 
            this.BMILevelLabel.AutoSize = true;
            this.BMILevelLabel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BMILevelLabel.Location = new System.Drawing.Point(52, 186);
            this.BMILevelLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BMILevelLabel.Name = "BMILevelLabel";
            this.BMILevelLabel.Size = new System.Drawing.Size(187, 27);
            this.BMILevelLabel.TabIndex = 2;
            this.BMILevelLabel.Text = "Your BMI Level";
            // 
            // ResultProcessingBar
            // 
            this.ResultProcessingBar.ForeColor = System.Drawing.Color.DarkOrange;
            this.ResultProcessingBar.Location = new System.Drawing.Point(16, 266);
            this.ResultProcessingBar.Margin = new System.Windows.Forms.Padding(7);
            this.ResultProcessingBar.Name = "ResultProcessingBar";
            this.ResultProcessingBar.Size = new System.Drawing.Size(262, 52);
            this.ResultProcessingBar.TabIndex = 3;
           
            // 
            // ResultOfBMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.ResultProcessingBar);
            this.Controls.Add(this.BMILevelLabel);
            this.Controls.Add(this.BMIResultLabel);
            this.Controls.Add(this.YourResultLabel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "ResultOfBMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultOfBMICalculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultOfBMICalculator_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YourResultLabel;
        public System.Windows.Forms.Label BMIResultLabel;
        public System.Windows.Forms.Label BMILevelLabel;
    
    }
}