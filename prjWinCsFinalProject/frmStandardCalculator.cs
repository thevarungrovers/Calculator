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
    public partial class frmStandardCalculator : Form
    {
        public frmStandardCalculator()
        {
            InitializeComponent();
        }

        Single val1;
        string sign;

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if(lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "7";
            }
            else
            {
                lblDisplayPrimary.Text += "7";
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

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (lblDisplayPrimary.Text == "0")
            {
                lblDisplayPrimary.Text = "0";
            }
            else
            {
                lblDisplaySecondary.Visible = true;
                val1 = Convert.ToSingle(lblDisplayPrimary.Text);
                sign = "-";
                lblDisplaySecondary.Text += lblDisplayPrimary.Text + " - ";
                lblDisplayPrimary.Text = "0";
            }
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

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!(lblDisplayPrimary.Text.Contains("."))){
                lblDisplayPrimary.Text += ".";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Text = "0";
            lblDisplayPrimary.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplayPrimary.Text = "0";
            lblDisplaySecondary.Visible = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Single val2 = Convert.ToSingle(lblDisplayPrimary.Text);

            if(sign == "+")
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
            if (sign == "/")
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
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Single result = val1 * val1;
            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "sqr( " + val1 + " )";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = true;
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);
            Single result = Convert.ToSingle(Math.Sqrt(val1));
            lblDisplayPrimary.Text = Convert.ToString(result);
            lblDisplaySecondary.Text = "√(" + val1 + ")";
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

        private void btnFraction_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToSingle(lblDisplayPrimary.Text);

            if(val1 == 0)
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lblDisplayPrimary.Text.Equals("0") && (lblDisplaySecondary.Text.Contains("+") || lblDisplaySecondary.Text.Contains("-") || lblDisplaySecondary.Text.Contains("*") || lblDisplaySecondary.Text.Contains("/")))
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

        private void frmStandardCalculator_Load(object sender, EventArgs e)
        {
            lblDisplaySecondary.Visible = false;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = true;
            btnMC.Enabled = true;
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = true;
            btnMC.Enabled = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = true;
            btnMC.Enabled = true;
        }


    }
}
