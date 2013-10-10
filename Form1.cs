using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class Form1 : Form
    {
        //The total cost for the base model car
        double baseCostTotal = 0;
        //The total trad in value
        double tradeInAmount = 0;
        //The total variable for all the appearance costs
        double appearanceTotal = 0;
        //Total cost for all extra add-on's
        double addOnTotal = 0;
        //The total cost for the whole car with everything included
        double totalFinalCost = 0;
        //The array of invlaid characters for user input
        char[] invalidChar = { ' ', ',', '$', '!', '%' };

        public Form1()
        {
            InitializeComponent();
        }

        private void BaseCalculateButton_Click(object sender, EventArgs e)
        {
            String baseCost;
            String tradeIn;

            double d_baseCost;
            double d_tradeIn;

            baseCost = "" + BaseCostTextBox.Text;
            tradeIn = "" + TradeInTextBox.Text;

            baseCost = baseCost.TrimStart(invalidChar);
            double.TryParse(baseCost, out d_baseCost);

            tradeIn = tradeIn.TrimStart(invalidChar);
            double.TryParse(tradeIn, out d_tradeIn);

            baseCostTotal = d_baseCost;
            tradeInAmount = d_tradeIn;
            baseCostTotalTextBox.Text = "$" + baseCostTotal.ToString("###,###,###.00");

        }

        private void AppearenceCalculateButton_Click(object sender, EventArgs e)
        {
            //declare the option variables
            double colourCost = 0;
            double rimCost = 0;
            double othersCost = 0;

            //Check to see which paint colour is chosen.
            if (WhiteRadioButton.Checked || BlackRadioButton.Checked)
            {
                colourCost = 0;
            }
            else if (GreenRadioButton.Checked)
            {
                colourCost = 100;
            }
            else if (BlueRadioButton.Checked)
            {
                colourCost = 150;
            }
            else
            {
                colourCost = 200;
            }

            //Get the value of the rim's variable
            if (TwentyOneRadioButton.Checked)
            {
                rimCost = 250;
            }
            else if (TwentyOneAeroRadioButton.Checked)
            {
                rimCost = 300;
            }
            else if (NineTeenAeroRadioButton.Checked)
            {
                rimCost = 100;
            }
            else
            {
                rimCost = 0;
            }

            //Get the value of the other option's cost
            if (TintCheckBox.Checked)
            {
                othersCost += 400;
            }

            if (SunroofCheckBox.Checked)
            {
                othersCost += 450;
            }

            //Set the total for appearanceTotal to be equal to the option variables added together
            appearanceTotal = colourCost + rimCost + othersCost;
            //Output the total in a formated String
            AppearanceTotalTextBox.Text = "$" + appearanceTotal.ToString("###,###,###.00");
        }

        private void AddOnCalculateButton_Click(object sender, EventArgs e)
        {
            double tempAddOn = 0;

            if (TechCheckBox.Checked)
            {
                tempAddOn += 2500;
            }

            if (EntertainmentCheckBx.Checked)
            {
                tempAddOn += 1500;
            }

            if (ComfortCheckBox.Checked)
            {
                tempAddOn += 750;
            }

            addOnTotal = tempAddOn;

            AddOnTotalTextBox.Text = "$" + addOnTotal.ToString("###,###,##0.00");
        }

        private void TotalCalculateButton_Click(object sender, EventArgs e)
        {
            String salesTax;

            double d_salesTax;
            double d_tempFinalCost = 0;

            salesTax = SalesTaxTextBox.Text;
            salesTax = salesTax.TrimEnd(invalidChar);

            double.TryParse(salesTax, out d_salesTax);
            d_salesTax = d_salesTax / 100;

            d_tempFinalCost = baseCostTotal + appearanceTotal + addOnTotal;

            totalFinalCost = (d_tempFinalCost + (d_tempFinalCost * d_salesTax)) - tradeInAmount;
            TotalTextBox.Text = "$" + totalFinalCost.ToString("###,###,##0.00");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Code from online source found here: http://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "$0.00";
                    else
                        func(control.Controls);
            };


            func(Controls);

            SalesTaxTextBox.Text = "0%";
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

    }
}
