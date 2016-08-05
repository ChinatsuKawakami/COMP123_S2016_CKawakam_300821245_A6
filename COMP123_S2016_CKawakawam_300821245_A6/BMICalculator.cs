using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2016_CKawakawam_300821245_A6.Properties;

/*
 * Author:Chinatsu Kawakami
 * CreateDate:July23th2016
 * Modified Date:August 5th 2016
 * Descripntion: This program is to show users IBM
 * Version: 0.0.14- Added ProgressBarClass to change the color of ProgressBar depend on BMI Result and Fixed Error about SplashHomeScreen caused.
 */
namespace COMP123_S2016_CKawakawam_300821245_A6
{
    public partial class BMICalculator : Form
    {

        // PUBLIC PROPERTIES*******************************************************
      
        // This check if Weight and Height user input will cause error or not
        public bool ActiveError { get; set; }
       
        // They have a role to check which box is forcused by user
        bool HeightCheker = false;
        bool WeightCheker = false;

        //checker to check whether heightBox and WeightBox are error or not

       public bool HeightDecimal { get; set; }
       public bool WeightDecimal  { get; set; }

        // this is properties to store what numbers user input into TextBox  
        public string currentResultH { get; set; }
        public string currentResultW { get; set; }

        // This store which final result for BMI
        public double BMIResult { get; set; }

        // This is instance of Form2 
        public ResultOfBMICalculator SecondForm = Program.SecondForm;
      
        
       //PUBLIC METHOD++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public BMICalculator()
        {
            InitializeComponent();
            //First, Numbers in TextBox is Zero
            HeighttextBox.Text = "0";
            WeighttextBox.Text = "0";
        }

        // PRIVATE METHOD++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /*
         *<summary>
           If user Clicks Calculate BMI, This Event happens 
         * <summary>
         * @method SubmitButton_Click
         * @property {void}
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
           //Create instance of ResultOfBMICalculator 
            ResultOfBMICalculator SecondForm = new ResultOfBMICalculator();

            //Create ProgressBar instance and assign to ProgressBar Which is in ResultOfBMICalculator Form
            ProgressBar Progress = SecondForm.ResultProcessingBar;

            //Height and Weight label is false till user choose Metric or Imperial
            HeightLabel2.Visible = false;
            WeightLabel2.Visible = false;

            // set try and catch to check if DivideByZeroException happends or not
            try
            {
                if (ActiveError == false)// if DivideByZeroException does not happen, this Event continues
                {
                    if (ImperialRadioButton.Checked)
                    {
                        
                        BMIResult = (Convert.ToDouble(WeighttextBox.Text) * 703) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));


                    }
                    else if (MetricRadioButton.Checked)
                    {
                       
                        BMIResult = Convert.ToDouble(WeighttextBox.Text) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));
                      
                    }
                 
                  
                }//close ActiveError
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }

            if (BMIResult < 18.5)
            {
                SecondForm.BMILevelLabel.Text = "Under Weight";
                SecondForm.ForeColor = System.Drawing.Color.Aqua;
                

            }
            else if (BMIResult >= 18.5 && BMIResult <= 24.9)
            {
                SecondForm.BMILevelLabel.Text = "Normal";
                SecondForm.ForeColor = System.Drawing.Color.Blue;
               
            }
            else if (BMIResult >= 25.0 && BMIResult <= 29.9)
            {
                SecondForm.BMILevelLabel.Text = "Over Weight";
                SecondForm.ForeColor = System.Drawing.Color.Yellow;
              
            }
            else if (BMIResult >= 30)
            {

                SecondForm.BMILevelLabel.Text = "Obese";
                SecondForm.ForeColor = System.Drawing.Color.Red;
                
            }

            int ResultForBar = (int)Program.FirstForm.BMIResult;
            Progress.Maximum = 100;
            Progress.Minimum = 0;
            switch (SecondForm.BMILevelLabel.Text)
            {
                case "Under Weight":
                    Progress.Value = 25;
                    Progress.BackColor = Color.Aqua;
                    Progress.ForeColor = Color.Aqua;
                    ProgressBarClass.SetState(Progress,1);
                      break;
                case "Normal":
                    Progress.Value = 50;
                    Progress.BackColor = Color.Blue;
                    Progress.ForeColor = Color.Blue;
                    ProgressBarClass.SetState(Progress, 1);
                    break;
                case "Over Weight":
                    Progress.Value = 75;
                    Progress.BackColor = Color.Yellow;
                    Progress.ForeColor = Color.Yellow;
                    ProgressBarClass.SetState(Progress, 3);
                    break;
                case "Obese":
                    Progress.Value = 100;
                    Progress.BackColor = Color.Red;
                    Progress.ForeColor = Color.Red;
                   ProgressBarClass.SetState(Progress, 2);
                    break;

            }
            //ResultOfBMICalculator's label shows BMI Result
            SecondForm.BMIResultLabel.Text = Convert.ToString(BMIResult);  
            //ResultOfBMICalculator shows
            SecondForm.Show();

        }

        /*
        *<summary>
          If Numbers which are in TableLayoutTable are clicked, this Event happens
        * <summary>
        * @method Calculator_Click
        * @property {void}
        */

        private void Calculator_Click(object sender, EventArgs e)
        {
            
            
            Button bottonClick = (Button)sender;
            if (HeightCheker)
            {

              if (String.Equals(HeighttextBox.Text, "0") || string.IsNullOrEmpty(HeighttextBox.Text))
                {
                    MessageBox.Show("Enter your heigth");
                    HeighttextBox.Clear();
                }
             
                string currentResultH = HeighttextBox.Text;
                currentResultH += bottonClick.Text;
                HeighttextBox.Text = currentResultH;

            }
            if (WeightCheker)
            {
                if (String.Equals(WeighttextBox.Text, "0") || string.IsNullOrEmpty(WeighttextBox.Text))
                {
                    MessageBox.Show("Enter your weight");
                    WeighttextBox.Clear();
                }
               
                string currentResultW = WeighttextBox.Text;


                currentResultW += bottonClick.Text;

                WeighttextBox.Text = currentResultW;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            HeighttextBox.Text = "0";
            WeighttextBox.Text = "0";
            this.HeightDecimal = false;
            this.WeightDecimal = false;
            this.ActiveError = false;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveError == false)
           {

                //check if Height focus , HeightDecimal true 
               // string currentString = String.Empty;
                if (this.HeightDecimal == false && this.HeightCheker == true)
                {
                    this.HeightDecimal = true;
                    if (HeightCheker == true && this.HeightDecimal == true)
                    {
                        HeighttextBox.Text += ".";
                    } 
                 }
                  
                   if (this.WeightDecimal == false && WeightCheker == true)
                    {
                        this.WeightDecimal = true;
                        if (WeightCheker == true && this.WeightDecimal == true)
                        {
                            WeighttextBox.Text += ".";
                        }
                     }
              
                   
                }//close check ActiveError
           
            }//close this method

        /*
       *<summary>
         If -> button which is in TableLayoutTable is clicked, this Event happens to delete numbers in TextBox each one
       * <summary>
       * @method BackButton_Click
       * @property {void}
       */

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (HeightCheker == true)
            {
          if (HeighttextBox.Text.Length == 1)
            {
                HeighttextBox.Text = "0";
            }
          else if (HeighttextBox.Text.Length > 1)
              if (HeighttextBox.Text[HeighttextBox.Text.Length - 1] == '.')
          {
              this.HeightDecimal = false;
          }
                 HeighttextBox.Text = HeighttextBox.Text.Remove(HeighttextBox.Text.Length - 1);
            }//close HeightCheker 
          else if (WeightCheker == true){
              if (WeighttextBox.Text.Length == 1)
              {
                  WeighttextBox.Text = "0";
              }
           else if(WeighttextBox.Text.Length > 1)
            if(WeighttextBox.Text[WeighttextBox.Text.Length - 1] == '.')
            {
                 this.WeightDecimal = false;

            }
               WeighttextBox.Text = WeighttextBox.Text.Remove(WeighttextBox.Text.Length - 1);
          }//close WeightCheker
         }//close BackButton Click method


        /*
       *<summary>
          If user click HeighttextBox to input numbers, HeightCheker is true
       * <summary>
       * @method HeighttextBox_Click
       * @property {void}
       */
        private void HeighttextBox_Click(object sender, EventArgs e)
        {
            HeightCheker = true;
            WeightCheker = false;
        }
        /*
         *<summary>
            If user click WeighttextBox to input numbers, WeightCheker is true
         * <summary>
         * @method weighttextBox_Click
         * @property {void}
         */
        private void WeighttextBox_Click(object sender, EventArgs e)
        {
            WeightCheker = true;
            HeightCheker = false;
        }

        /*
          *<summary>
             If user click ResetButton, SplashFormScreen shows up and Numbers in TextBox become Zero 
          * <summary>
          * @method ResetButton_Click
          * @property {void}
          */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // make instance of SplashHomeScreen which shows up if user enters the ResetButton
            SplashHomeScreen Splash = new SplashHomeScreen();
            this.Hide();
            Splash.Show();
            HeighttextBox.Text = "0";
            WeighttextBox.Text = "0";
            this.HeightDecimal = false;
            this.WeightDecimal = false;
            this.ActiveError = false;

        }

        /*
          *<summary>
             If user chooses Metric in RadioButton, labels will be "M" and "kg" and the way to calculate BMI is changed apropriately
          * <summary>
          * @method Metric_CheckedChanged
          * @property {void}
          */
        private void Metric_CheckedChanged(object sender, EventArgs e)
        {

            this.HeightLabel2.Text = "M";
            this.WeightLabel2.Text = "Kg";
            HeightLabel2.Visible = true;
            WeightLabel2.Visible=true;
        }
        /*
       *<summary>
          If user chooses Imperial in RadioButton, labels will be "inches" and "pounds" and the way to calculate BMI is changed apropriately
       * <summary>
       * @method Imperial_CheckedChanged
       * @property {void}
       */
        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            this.HeightLabel2.Text = "inches";
            this.WeightLabel2.Text = "pounds";
            HeightLabel2.Visible = true;
            WeightLabel2.Visible=true;
        }


    }
 }


    

