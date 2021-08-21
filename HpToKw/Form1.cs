using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpToKw
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chooseFromCb.Items.Add(Units.Watt);
            chooseFromCb.Items.Add(Units.Kilowatt);
            chooseFromCb.Items.Add(Units.Megawatt);
            chooseFromCb.Items.Add(Units.Gigawatt);
            chooseFromCb.Items.Add(Units.Horse_power_metric);
            chooseFromCb.Items.Add(Units.Horse_power_electric);

            chooseToCb.Items.Add(Units.Watt);
            chooseToCb.Items.Add(Units.Kilowatt);
            chooseToCb.Items.Add(Units.Megawatt);
            chooseToCb.Items.Add(Units.Gigawatt);
            chooseToCb.Items.Add(Units.Horse_power_metric);
            chooseToCb.Items.Add(Units.Horse_power_electric);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string value = valueTb.Text;
            string from = chooseFromCb.Text;
            string to = chooseToCb.Text;
            
            if((value != null) && (from != null) && (to != null))
            {
                double valueDouble = Double.Parse(value);

                if(valueDouble >= 0 && !from.Equals(to))
                {
                    string calculatedAnswer;
                    double calculatedValue = Converter.calculate(from, to, valueDouble);
                    calculatedAnswer = valueDouble + " " + from + " = " + calculatedValue + " " + to + ".";
                    
                    resultLabel.Text = calculatedAnswer;
                } else
                {
                    resultLabel.Text = "Invalid value.";
                }
            }

        }
        
        private void chooseCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
