using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VARP
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void RollingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RollingMill Rm = new RollingMill();
            Rm.MdiParent = this; //IV to open in same project 
            if (!isWinOpen("RollingMill")) { 
            Rm.Show();
            } 
            else
            {
                 Rm.BringToFront(); 
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void IntermediateShearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dividingShearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void QTBToolStripMenuItem_Clock(object sender, EventArgs e)
        {
            QTB qtb = new QTB();
            qtb.MdiParent = this; //IV to open in same project 
            if (!isWinOpen("QTB"))
            {
                qtb.Show();
            }
            else
            {
                qtb.BringToFront();
            }
        }
// IV metod to check is page already open or not
        public bool isWinOpen(string PageName)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == PageName)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            return isOpen;
        }
    }
}
