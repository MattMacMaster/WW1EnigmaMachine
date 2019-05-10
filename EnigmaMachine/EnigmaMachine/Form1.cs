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
        private string PlugBoard(String Input)
        {
            if (PlugA.Text != "" && Input == "A")
            {
                return PlugA.Text.ToUpper();
            }
            else if (PlugB.Text != "" && Input == "B")
            {
                return PlugB.Text.ToUpper();
            }
            else if (PlugC.Text != "" && Input == "C")
            {
                return PlugC.Text.ToUpper();
            }
            else if (PlugD.Text != "" && Input == "D")
            {
                return PlugD.Text.ToUpper();
            }
            else if (PlugE.Text != "" && Input == "E")
            {
                return PlugE.Text.ToUpper();
            }
            else if (PlugF.Text != "" && Input == "F")
            {
                return PlugF.Text.ToUpper();
            }
            else if (PlugG.Text != "" && Input == "G")
            {
                return PlugG.Text.ToUpper();
            }
            else if (PlugH.Text != "" && Input == "H")
            {
                return PlugH.Text.ToUpper();
            }
            else if (PlugI.Text != "" && Input == "I")
            {
                return PlugI.Text.ToUpper();
            }
            else if (PlugJ.Text != "" && Input == "J")
            {
                return PlugJ.Text.ToUpper();
            }
            else if (PlugK.Text != "" && Input == "K")
            {
                return PlugK.Text.ToUpper();
            }
            else if (PlugL.Text != "" && Input == "L")
            {
                return PlugL.Text.ToUpper();
            }
            else if (PlugM.Text != "" && Input == "M")
            {
                return PlugM.Text.ToUpper();
            }
            else if (PlugN.Text != "" && Input == "N")
            {
                return PlugN.Text.ToUpper();
            }
            else if (PlugO.Text != "" && Input == "O")
            {
                return PlugO.Text.ToUpper();
            }
            else if (PlugP.Text != "" && Input == "P")
            {
                return PlugP.Text.ToUpper();
            }
            else if (PlugQ.Text != "" && Input == "Q")
            {
                return PlugQ.Text.ToUpper();
            }
            else if (PlugR.Text != "" && Input == "R")
            {
                return PlugR.Text.ToUpper();
            }
            else if (PlugS.Text != "" && Input == "S")
            {
                return PlugS.Text.ToUpper();
            }
            else if (PlugT.Text != "" && Input == "T")
            {
                return PlugT.Text.ToUpper();
            }
            else if (PlugU.Text != "" && Input == "U")
            {
                return PlugU.Text.ToUpper();
            }
            else if (PlugV.Text != "" && Input == "V")
            {
                return PlugV.Text.ToUpper();
            }
            else if (PlugW.Text != "" && Input == "W")
            {
                return PlugW.Text.ToUpper();
            }
            else if (PlugX.Text != "" && Input == "X")
            {
                return PlugX.Text.ToUpper();
            }
            else if (PlugY.Text != "" && Input == "Y")
            {
                return PlugY.Text.ToUpper();
            }
            else if (PlugZ.Text != "" && Input == "Z")
            {
                return PlugZ.Text.ToUpper();
            }
            else
            {
                return Input.ToUpper();
            }
        }
        //Rotor Creation





        private void Scramble_Click(object sender, EventArgs e)
        {
            //CALLS ALL PROCESSUS WITH ACCORDING CONFIGURATIONS
          string PlugOutput = PlugBoard(Input.Text);
            Output.Text = PlugOutput;
        }
    }
}
