using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalProject
{
    public partial class frmScientificCalculator : Form
    {
        public frmScientificCalculator()
        {
            InitializeComponent();
        }

        Single val1;
        string sign;

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!(lblDisplayPrimary.Text.Contains(".")))
            {
                lblDisplayPrimary.Text += ".";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
                lblDisplayPrimary.Text += "0";
            }
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            if (val1 < 0)
            {
                lblDisplayPrimary.Text = Convert.ToString(Math.Abs(val1));
            }
            else if (val1 > 0)
            {
                lblDisplayPrimary.Text = "-" + val1;
            }
        }

        

        private void btnClosingParenthesis_Click(object sender, EventArgs e)
        {
            lblDisplayPrimary.Text += ")";
        }

        private void btnOpeningParenthesis_Click(object sender, EventArgs e)
        {
            lblDisplayPrimary.Text += "(";

        }

        

        private void btnPi_Click(object sender, EventArgs e)
        {
            lblDisplayPrimary.Text = Convert.ToString(Math.PI);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
                lblDisplaySecondary.Visible = true;
                val1 = Convert.ToSingle(lblDisplayPrimary.Text);
                sign = "+";
                lblDisplaySecondary.Text += lblDisplayPrimary.Text + " + ";
                lblDisplayPrimary.Text = "0";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            /*
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
            */
                lblDisplaySecondary.Visible = true;
                val1 = Convert.ToSingle(lblDisplayPrimary.Text);
                sign = "-";
                lblDisplaySecondary.Text += lblDisplayPrimary.Text + " - ";
                lblDisplayPrimary.Text = "0";
            //}
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
                lblDisplaySecondary.Visible = true;
                val1 = Convert.ToSingle(lblDisplayPrimary.Text);
                sign = "*";
                lblDisplaySecondary.Text += lblDisplayPrimary.Text + " * ";
                lblDisplayPrimary.Text = "0";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
                lblDisplaySecondary.Visible = true;
                val1 = Convert.ToSingle(lblDisplayPrimary.Text);
                sign = "/";
                lblDisplaySecondary.Text += lblDisplayPrimary.Text + " ÷ ";
                lblDisplayPrimary.Text = "0";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "3";
            }
            else
            {
                lblDisplayPrimary.Text += "3";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "2";
            }
            else
            {
                lblDisplayPrimary.Text += "2";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "1";
            }
            else
            {
                lblDisplayPrimary.Text += "1";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "6";
            }
            else
            {
                lblDisplayPrimary.Text += "6";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "5";
            }
            else
            {
                lblDisplayPrimary.Text += "5";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "4";
            }
            else
            {
                lblDisplayPrimary.Text += "4";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "9";
            }
            else
            {
                lblDisplayPrimary.Text += "9";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "8";
            }
            else
            {
                lblDisplayPrimary.Text += "8";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "7";
            }
            else
            {
                lblDisplayPrimary.Text += "7";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text.Equals("0") && (lblDisplaySecondary.Text.Contains("+") || lblDisplaySecondary.Text.Contains("-") || lblDisplaySecondary.Text.Contains("*") || lblDisplaySecondary.Text.Contains("/")))
            {
                string content = lblDisplaySecondary.Text;
                lblDisplayPrimary.Text = content.Substring(0, content.Length - 3);
                lblDisplaySecondary.Text = "0";
            }
            else
            {
                string content = lblDisplayPrimary.Text;
                lblDisplayPrimary.Text = content.Substring(0, content.Length - 1);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Text = "0";
            lblDisplayPrimary.Text = "0";
        }

        

        private void btnFraction_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            if (val1 == 0)
            {
                lblDisplayPrimary.Text = "Cannot divide by 0";
            }
            else
            {
                lblDisplaySecondary.Visible = true;
                lblDisplayPrimary.Text = Convert.ToString(1 / val1);
            }
            lblDisplaySecondary.Text = "1/(" + val1 + ")";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Single result = Convert.ToSingle(Math.Sqrt(val1));
            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "√(" + val1 + ")";
        }

        

        private void btnSquare_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Single result = val1 * val1;
            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "sqr( " + val1 + " )";
        }

        private void frmScientificCalculator_Load(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = false;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        

        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Single result = Math.Abs(val1);
            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "abs( " + val1 + " )";
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            Single result = 1;
            for(Int16 i = 1; i <= val1; i++)
            {
                result *= i;
            }

            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "fact(" + val1 + ")";
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            Single result = Convert.ToSingle(Math.Pow(10, val1));

            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "10^(" + val1 + ")";
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            lblDisplaySecondary.Text = val1 + "^";
            lblDisplayPrimary.Text = "0";
            sign = "^";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            lblDisplaySecondary.Text = val1 + " mod ";
            lblDisplayPrimary.Text = "0";
            sign = "mod";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            lblDisplayPrimary.Text = Convert.ToString(Math.E);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Double result = Math.Log10(val1);
            lblDisplaySecondary.Text = "log( " + val1 + " )";
            lblDisplayPrimary.Text = Convert.ToString(result);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Double result = Math.Log(val1);
            lblDisplaySecondary.Text = "ln( " + val1 + " )";
            lblDisplayPrimary.Text = Convert.ToString(result);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Single val2 = Convert.ToSingle(lblDisplayPrimary.Text);

            if (sign == "+")
            {
                Single result = val1 + val2;
                lblDisplayPrimary.Text = Convert.ToString(result);
                val2 = 0;
            }
            else if (sign == "-")
            {
                Single result = val1 - val2;
                lblDisplayPrimary.Text = Convert.ToString(result);
                val2 = 0;
            }
            else if (sign == "*")
            {
                Single result = val1 * val2;
                lblDisplayPrimary.Text = Convert.ToString(result);
                val2 = 0;
            }
            else if (sign == "/")
            {
                if (val2 == 0)
                {
                    lblDisplayPrimary.Text = "Cannot divide by 0";
                }
                else
                {
                    Single result = val1 / val2;
                    lblDisplayPrimary.Text = Convert.ToString(result);
                    val2 = 0;
                }
            }
            else if(sign == "^")
            {
                lblDisplaySecondary.Text += Convert.ToString(val2);
                Single result = Convert.ToSingle(Math.Pow(val1, val2));
                lblDisplayPrimary.Text = Convert.ToString(result);
                val2 = 0;
            }
            else if(sign == "mod")
            {
                lblDisplaySecondary.Text += Convert.ToString(val2);
                Single result = Convert.ToSingle(val1 % val2);
                lblDisplayPrimary.Text = Convert.ToString(result);
                val2 = 0;
            }

        }

        
    }
}
