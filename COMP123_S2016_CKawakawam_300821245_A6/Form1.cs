﻿using System;
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
 * Modified Date:July26th2016
 * Descripntion: This program is to show users IBM
 * Version: 0.0.3- Added pushing Decimal Button and clear button Event 
 */
namespace COMP123_S2016_CKawakawam_300821245_A6
{
    public partial class Form1 : Form
    {

        //     public string ActiveOperator { get; set; }
        public bool ActiveError { get; set; }
        public bool ActiveDecimal { get; set; }

        public string currentResultH { get; set; }
        public string currentResultW { get; set; }
        public double BMIResult{ get; set; }
    
        public Form2 SecondForm = Program.SecondForm;
        public Form1()
        {
            InitializeComponent();
        }


        private void button13_Click(object sender, EventArgs e)
        {

            double incheValue;
            double poundValue;
            if (inches.Checked&&pounds.Checked)
            {
               
                    BMIResult = (Convert.ToDouble(WeighttextBox.Text) * 703) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));

                
            }
            else if (metres.Checked&&kilograms.Checked)
            {
                    BMIResult = Convert.ToDouble(WeighttextBox.Text) / (Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text));
                
            }
            else if(inches.Checked&&kilograms.Checked)
            {
                incheValue = Convert.ToDouble(HeighttextBox.Text)/100;//convert form inch to metric
                BMIResult = Convert.ToDouble(WeighttextBox.Text) / (incheValue * incheValue);
            }else if(metres.Checked&&pounds.Checked)// convert from pound to kg
            {
                // 1 pound = 0.453592kg
                poundValue = Convert.ToDouble(WeighttextBox.Text) * 0.453592;
                BMIResult = poundValue / ((Convert.ToDouble(HeighttextBox.Text) * Convert.ToDouble(HeighttextBox.Text)));
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
            if(String.Equals(HeighttextBox.Text,"0"))
            {
                MessageBox.Show("Enter your heigth");
                HeighttextBox.Clear();
            }
            if(String.Equals(WeighttextBox.Text,"0"))
            {
                MessageBox.Show("Enter your weight");
                WeighttextBox.Clear();
            }
            string currentResultH = HeighttextBox.Text;
            string currentResultW = WeighttextBox.Text;
          
             currentResultH += bottonClick.Text;
            
            currentResultW += bottonClick.Text;

            HeighttextBox.Text = currentResultH;
            WeighttextBox.Text = currentResultW;
           
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            HeighttextBox.Text = "0";
            WeighttextBox.Text = "0";
            this.ActiveDecimal = false;
            this.ActiveError = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(this.ActiveError==false)
            {
                string currentString = String.Empty;
                if(this.ActiveDecimal == false)
                {
                    this.ActiveDecimal = true;
                    currentString = WeighttextBox.Text;
                    currentString = HeighttextBox.Text;
                    currentString += ".";
                    WeighttextBox.Clear();
                    HeighttextBox.Clear();
                    WeighttextBox.Text = currentString;
                    HeighttextBox.Text = currentString;


                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(HeighttextBox.Text.Length == 1 && WeighttextBox.Text.Length==1)
            {
                HeighttextBox.Text = "0";
                WeighttextBox.Text = "0";
            }

            else if(HeighttextBox.Text.Length >1 &&WeighttextBox.Text.Length>1)
            {
                if(HeighttextBox.Text[HeighttextBox.Text.Length-1]=='.' && WeighttextBox.Text[WeighttextBox.Text.Length-1]=='.')
                {
                  this.ActiveDecimal = false;
                }

                HeighttextBox.Text = HeighttextBox.Text.Remove(HeighttextBox.Text.Length-1);
                WeighttextBox.Text = WeighttextBox.Text.Remove(WeighttextBox.Text.Length-1);

            }
            
        }

      
       


      
    }
}
