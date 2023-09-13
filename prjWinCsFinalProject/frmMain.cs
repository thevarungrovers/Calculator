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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program ?", "Closing Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStandardCalculator frmSCalculator = new frmStandardCalculator();
            frmSCalculator.Show();
            frmSCalculator.MdiParent = this;
            
            // setting position
            frmSCalculator.Left = frmSCalculator.Top = 0;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScientificCalculator frmSciCalculator = new frmScientificCalculator();
            frmSciCalculator.Show();
            frmSciCalculator.MdiParent = this;
            
            // setting position
            frmSciCalculator.Left = frmSciCalculator.Top = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolbarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.Checked = true;
            toolStripStatusLabel1.Text = "Ready";
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolbarToolStripMenuItem.Checked ? true : false;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked ? true : false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
            frmAbout.MdiParent = this;
            
            // setting position
            frmAbout.Left = frmAbout.Top = 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStandardCalculator frmSCalculator = new frmStandardCalculator();
            frmSCalculator.Show();
            frmSCalculator.MdiParent = this;

            // setting position
            frmSCalculator.Left = frmSCalculator.Top = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmScientificCalculator frmSciCalculator = new frmScientificCalculator();
            frmSciCalculator.Show();
            frmSciCalculator.MdiParent = this;
            
            // setting position
            frmSciCalculator.Left = frmSciCalculator.Top = 0;
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManual frmUserManual = new frmUserManual();
            frmUserManual.Show();
            frmUserManual.MdiParent = this;
            
            // setting position
            frmUserManual.Left = frmUserManual.Top = 0;
        }

        private void localVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfflineCurrencyConverter frmOfflineCurrencyConverter = new frmOfflineCurrencyConverter();
            frmOfflineCurrencyConverter.Show();
            frmOfflineCurrencyConverter.MdiParent = this;
            
            // setting position
            frmOfflineCurrencyConverter.Left = frmOfflineCurrencyConverter.Top = 0;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmOfflineCurrencyConverter frmOfflineCurrencyConverter = new frmOfflineCurrencyConverter();
            frmOfflineCurrencyConverter.Show();
            frmOfflineCurrencyConverter.MdiParent = this;
            
            // setting position
            frmOfflineCurrencyConverter.Left = frmOfflineCurrencyConverter.Top = 0;
        }  
    }
}
