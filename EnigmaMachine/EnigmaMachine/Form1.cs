using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public partial class Form1 : Form
    {
        //Default there are no notches until user input
        int LeftNotchVal = 0;
        int CenterNotchVal = 0;
        int RightNotchVal = 0;
        public Form1()
        {
            InitializeComponent();
           
            //On boot display no notches
            LeftNotch.Text = Convert.ToString(LeftNotchVal);
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
            RightNotch.Text = Convert.ToString(RightNotchVal);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close application
            Close();
        }

        private void LeftAdd_Click(object sender, EventArgs e)
        {
            //Creates a notch, notch location on value once scramble is hit ONLY ALLOWS ONE NOTCH
            LeftNotchVal += 1;
            LeftNotch.Text = Convert.ToString(LeftNotchVal);
        }

        private void LeftMin_Click(object sender, EventArgs e)
        {
            //Moves notch index one less
            if (LeftNotchVal != 0)
            {
                LeftNotchVal -= 1;

            }
            else { LeftNotchVal = 0; }
            LeftNotch.Text = Convert.ToString(LeftNotchVal);
        }

        private void CenterAdd_Click(object sender, EventArgs e)
        {
            CenterNotchVal += 1;
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
        }

        private void CenterMin_Click(object sender, EventArgs e)
        {
            if (CenterNotchVal != 0)
            {
                CenterNotchVal -= 1;

            }
            else { CenterNotchVal = 0; }
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
        }

        private void RightAdd_Click(object sender, EventArgs e)
        {
            RightNotchVal += 1;
            RightNotch.Text = Convert.ToString(RightNotchVal);
        }

        private void RightMin_Click(object sender, EventArgs e)
        {
            if (RightNotchVal != 0)
            {
                RightNotchVal -= 1;

            }
            else { RightNotchVal = 0; }
            RightNotch.Text = Convert.ToString(RightNotchVal);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Notch Clearing
             LeftNotchVal = 0;
             CenterNotchVal = 0;
             RightNotchVal = 0;
            LeftNotch.Text = Convert.ToString(LeftNotchVal);
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
            RightNotch.Text = Convert.ToString(RightNotchVal);
            //End Notch Clearing
        }

        private void Scramble_Click(object sender, EventArgs e)
        {
            //CALLS ALL PROCESSUS WITH ACCORDING CONFIGURATIONS


        }
    }
}
