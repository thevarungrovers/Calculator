using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalProject
{
    public partial class frmOfflineCurrencyConverter : Form
    {
        public frmOfflineCurrencyConverter()
        {
            InitializeComponent();
        }
        // /*
        struct struct_currency
        {
            public string country;
            public string currency;
            public string currency_value;
            public string currency_usa;
        }
        

        static struct_currency[] arr_currency = new struct_currency[20];
        // */
        //clsCurrency[] arr_currency = new clsCurrency[20];
        Int16 selected_country;

        private void frmOfflineCurrencyConverter_Load(object sender, EventArgs e)
        {
            StreamReader myFile = new StreamReader("currency.txt");
            Int16 i = 0;
            while(myFile.EndOfStream == false)
            {
                // adding the data to array from the file
                arr_currency[i].country = myFile.ReadLine();
                arr_currency[i].currency = myFile.ReadLine();
                arr_currency[i].currency_value = myFile.ReadLine();
                arr_currency[i].currency_usa = myFile.ReadLine();

                // adding country names to combo box
                cboCountry.Items.Add(arr_currency[i].country);

                // increasing the index
                i++;
            }

            myFile.Close();

            cboCountry.SelectedIndex = selected_country = 0;
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_country = Convert.ToInt16(cboCountry.SelectedIndex);

            if (selected_country == 0)
            {
                // clearing all the fields when the combo box is at "Select Country"
                lblSelectedCurrency.Text = radCurrencyFrom.Text = radCurrencyTo.Text = lblCurrencyFrom.Text = lblCurrencyTo.Text = txtAmount.Text = lblResult.Text = "";
            }
            else
            {
                // radio buttons
                radCurrencyFrom.Text = "From US Dollars to " + arr_currency[selected_country].currency;
                radCurrencyTo.Text = arr_currency[selected_country].currency + " to US Dollar(s)";

                // adding conversion values to labels
                lblCurrencyFrom.Text = "1 US Dollar = " + arr_currency[selected_country].currency_value + " " + arr_currency[selected_country].currency;
                lblCurrencyTo.Text = "1 " + arr_currency[selected_country].currency + " = " + arr_currency[selected_country].currency_usa + " US Dollar(s)";
            }
      
            // uncheck the radio buttons everytime the index of combo box changed
            radCurrencyTo.Checked = radCurrencyFrom.Checked = false;

        }

        private void radCurrencyFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (radCurrencyFrom.Checked)
            {
                lblSelectedCurrency.Text = "US Dollars";
            }
            txtAmount.Text = lblResult.Text = "";
        }

        private void radCurrencyTo_CheckedChanged(object sender, EventArgs e)
        {
            //Int16 selected_country = Convert.ToInt16(cboCountry.SelectedIndex);
            if (radCurrencyTo.Checked)
            {
                lblSelectedCurrency.Text = arr_currency[selected_country].currency;
            }
            txtAmount.Text = lblResult.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string amt = txtAmount.Text.Trim();
            /*
            Int16 countDecimal;
            for(Int16 i = 0; i < amt.Length; i++)
            {
                if (amt.IndexOf('.')) 
            }
            */
            if (selected_country == 0)
            {
                MessageBox.Show("Please choose the country  !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCountry.Focus();
            }
            else if(lblSelectedCurrency.Text == "")
            {
                MessageBox.Show("Please choose the type of currency to convert !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(amt == "")
            {
                MessageBox.Show("Please enter the Amount to convert !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
            }
            
            else if (amt.Contains(".."))
            {
                MessageBox.Show("Amount cannot contain more than one decimal !!\n Please add only one decimal.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
            }
            else
            {

                Single amount = Convert.ToSingle(amt);
                Single result = 0;
                string result_currency = "";

                // calculating the converted value
                if (radCurrencyFrom.Checked)
                {
                    result = amount * Convert.ToSingle(arr_currency[selected_country].currency_value);
                    result_currency = arr_currency[selected_country].currency;
                }
                else if (radCurrencyTo.Checked)
                {
                    result = amount * Convert.ToSingle(arr_currency[selected_country].currency_usa);
                    result_currency = "US Dollar";
                }

                lblResult.Text = result.ToString() + " " + result_currency + "(s)";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboCountry.SelectedIndex = 0;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowing only numbers, backspace, del and .
            if(char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program ?", "Closing Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
