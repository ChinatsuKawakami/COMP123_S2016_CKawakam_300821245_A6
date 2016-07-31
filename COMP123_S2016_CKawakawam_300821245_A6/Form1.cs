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
 * Modified Date:July30th2016
 * Descripntion: This program is to show users IBM
 * Version: 0.0.7- updated to check wether DecimalButton works or not
 */
namespace COMP123_S2016_CKawakawam_300821245_A6
{
    public partial class Form1 : Form
    {
        //public bool ActiveDecimal { get; set; }
        //public string ActiveOperator { get; set; }
      
        public bool ActiveError { get; set; }
      
        bool HeightCheker = false;
        bool WeightCheker = false;

        //checker to check whether heightBox and WeightBox are error or not

       public bool HeightDecimal { get; set; }
       public bool WeightDecimal  { get; set; }

        public string currentResultH { get; set; }
        public string currentResultW { get; set; }
        public double BMIResult { get; set; }

        public Form2 SecondForm = Program.SecondForm;
        public Form1()
        {
            InitializeComponent();
        }


        private void button13_Click(object sender, EventArgs e)
        {


            double incheValue;
            double poundValue;
            try
            {
                if (ActiveError == false)
                {
                    if (inches.Checked && pounds.Checked)
                    {


                        BMIResult = (Convert.ToDouble(WeighttextBox.Text) * 703) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));


                    }
                    else if (metres.Checked && kilograms.Checked)
                    {
                        BMIResult = Convert.ToDouble(WeighttextBox.Text) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));

                    }
                    else if (inches.Checked && kilograms.Checked)
                    {
                        incheValue = Convert.ToDouble(HeighttextBox.Text) / 100;//convert form inch to metric
                        BMIResult = Convert.ToDouble(WeighttextBox.Text) / (incheValue * incheValue);
                    }
                    else if (metres.Checked && pounds.Checked)// convert from pound to kg
                    {
                        // 1 pound = 0.453592kg
                        poundValue = Convert.ToDouble(WeighttextBox.Text) * 0.453592;
                        BMIResult = poundValue / ((Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text)));
                    }
                }
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }

            if (BMIResult < 18.5)
            {
                SecondForm.BMIlabel.Text = "Under Weight";

            }
            else if (BMIResult >= 18.5 && BMIResult <= 24.9)
            {
                SecondForm.BMIlabel.Text = "Normal";
            }
            else if (BMIResult >= 25.0 && BMIResult <= 29.9)
            {
                SecondForm.BMIlabel.Text = "Over Weight";
            }
            else if (BMIResult >= 30)
            {

                SecondForm.BMIlabel.Text = "Obese";
            }

            SecondForm.ResultLabel.Text = Convert.ToString(BMIResult);

            SecondForm.Show();

        }



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
                    HeighttextBox.Text += ".";
                }
                  
                else if (this.WeightDecimal == false && WeightCheker == true)
                    {
                        this.WeightDecimal = true;
                        WeighttextBox.Text += ".";


                    }
              
                  /*  if (HeightCheker == true && this.HeightDecimal == true)
                    {
                        HeighttextBox.Text += ".";
                     if(WeightCheker == true && this.WeightDecimal == true)
                     {
                         WeighttextBox.Text += ".";
                     }
                       
                    }
                    else if(WeightCheker == true && this.WeightDecimal == true)
                    {
                        WeighttextBox.Text += ".";
                         if (HeightCheker == true && this.HeightDecimal == true)
                         {
                             HeighttextBox.Text += ".";
                         }
                   
                    }
                  
                      */
                   
                }//close ActiveError
           
            }//close this method
        

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
            }
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
          }


        
                 

              }

     

        private void HeighttextBox_Click(object sender, EventArgs e)
        {
            HeightCheker = true;
            WeightCheker = false;
        }

        private void WeighttextBox_Click(object sender, EventArgs e)
        {
            WeightCheker = true;
            HeightCheker = false;
        }


    }
 }


    

