using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboboxComboCalc_operator.Items.Clear();

            comboboxComboCalc_operator.Items.Add("+");
            comboboxComboCalc_operator.Items.Add("-");
            comboboxComboCalc_operator.Items.Add("*");
            comboboxComboCalc_operator.Items.Add("/");
            comboboxComboCalc_operator.Items.Add("^");

            comboboxComboCalc_operator.SelectedIndex = 0;
        }

        private void buttonComboBoxCalculate_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxComboCalc_oper1.Text;
            String oper2 = textBoxComboCalc_oper2.Text;

            decimal fOper1 = Convert.ToDecimal(oper1);
            decimal fOper2 = Convert.ToDecimal(oper2);
            decimal fResult = 0;

            if(comboboxComboCalc_operator.SelectedIndex == 0)
                fResult = fOper1 + fOper2;
            else if(comboboxComboCalc_operator.SelectedIndex == 1)
                fResult = fOper1 - fOper2;
            else if (comboboxComboCalc_operator.SelectedIndex == 2)
                fResult = fOper1 * fOper2;
            else if (comboboxComboCalc_operator.SelectedIndex == 3)
                fResult = fOper1 / fOper2;
            else if (comboboxComboCalc_operator.SelectedIndex == 4)
            {
                // fOper2 == 0
                fResult = 1;
                
                if (fOper2 == 1)
                    fResult = fOper1;
                else
                {
                    for (int i = 0; i < fOper2; i++)
                        fResult *= fOper1;
                }
            }

            String strResult = Convert.ToString(fResult);

            textBoxComboCalc_Result.Text = strResult;
        }

        private void buttonRadioCalculate_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxRadioCalc_oper1.Text;
            String oper2 = textBoxRadioCalc_oper2.Text;

            decimal fOper1 = Convert.ToDecimal(oper1);
            decimal fOper2 = Convert.ToDecimal(oper2);
            decimal fResult = 0;

            if (radioButtonAdd.Checked) 
                fResult = fOper1 + fOper2;
            else if (radioButtonSub.Checked)
                fResult = fOper1 - fOper2;
            else if (radioButtonMul.Checked) 
                fResult = fOper1 * fOper2;
            else if (radioButtonDiv.Checked) 
                fResult = fOper1 / fOper2;
            else if (radioButtonPower.Checked)
            {
                // fOper2 == 0
                fResult = 1;

                if (fOper2 == 1)
                    fResult = fOper1;
                else
                {
                    for (int i = 0; i < fOper2; i++)
                        fResult *= fOper1;
                }
            }

            String strResult = Convert.ToString(fResult);

            textBoxRadioCalc_Result.Text = strResult;
        }
    }
}
