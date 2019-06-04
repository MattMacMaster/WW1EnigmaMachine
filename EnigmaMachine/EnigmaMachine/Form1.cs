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
        int RightCounter = 0;
        int CenterCounter = 0;
        int LeftCounter = 0;
        // Rotar Decalrations
        //Rotor 1 is base default
        // new String[] Set1In = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        //String[] Set1Out = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            //LIMIT IS INDEX 25

        RotorClass Rotor1 = new RotorClass(
            new String[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"},
           new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });

        RotorClass Rotor2 = new RotorClass(
            new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" },
            new String[] { "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A" });

        RotorClass Rotor3 = new RotorClass(
            new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" },
            new String[] { "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" });
        //Enhanced encryption here
        RotorClass Rotor4 = new RotorClass(
            new String[] { "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S" },
            new String[] { "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F" });

        RotorClass Rotor5 = new RotorClass(
            new String[] { "S", "T", "U", "V", "P", "Q", "R", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" },
            new String[] { "W", "X", "Y", "Z", "A", "B", "C", "D", "S", "T", "U", "V", "P", "Q", "R", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" }
            );

        

        public Form1()
        {
            InitializeComponent();
           
            //On boot display no notches
            RightNotch.Text = Convert.ToString(LeftNotchVal);
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
            LeftNotch.Text = Convert.ToString(RightNotchVal);

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
            if (LeftNotchVal < 26)
            {
                LeftNotchVal += 1;
                LeftNotch.Text = Convert.ToString(LeftNotchVal);
            }
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
            if (CenterNotchVal < 26)
            {
                CenterNotchVal += 1;
                CenterNotch.Text = Convert.ToString(CenterNotchVal);
            }
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
        {if (RightNotchVal < 26)
            {
                RightNotchVal += 1;
                RightNotch.Text = Convert.ToString(RightNotchVal);
            }
       
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
            RightNotch.Text = Convert.ToString(LeftNotchVal);
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
            LeftNotch.Text = Convert.ToString(RightNotchVal);
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
        //Rotor Orientation
        private int[] Orientation()
        {
            int[] DecisionLayer = new int[3];
            //Right Decision
            int a = 0;
            if(Right1.Checked == true)
            {
                a = 1;
            }
          else  if (Right2.Checked == true)
            {
                a = 2;
            }
           else if (Right3.Checked == true)
            {
                a = 3;
            }
           else if (Right4.Checked == true)
            {
                a = 4;
            }
           else if (Right5.Checked == true)
            {
                a = 5;
            }
            DecisionLayer[0] = a;
            //center Decision
            int b = 0;
            if (center1.Checked == true)
            {
                b = 1;
            }
            else if (center2.Checked == true)
            {
                b = 2;
            }
            else if (center3.Checked == true)
            {
                b = 3;
            }
            else if (center4.Checked == true)
            {
                b = 4;
            }
            else if (center5.Checked == true)
            {
                b = 5;
            }
            DecisionLayer[1] = b;


            //Left Decision
            int c = 0;
            if (left1.Checked == true)
            {
                c = 1;
            }
            else if (left2.Checked == true)
            {
                c = 2;
            }
            else if (left3.Checked == true)
            {
                c = 3;
            }
            else if (left4.Checked == true)
            {
                c = 4;
            }
            else if (left5.Checked == true)
            {
                c = 5;
            }
            DecisionLayer[2] = c;

            //returns int array into for a switch statement
            return DecisionLayer;

        }
        private String InLayer(int[] Orient,string input)
        {
            string inputEdit = "";
            inputEdit = input;
            //First rotor
            if(Orient[0] == 1)
            {
                inputEdit = Rotor1.InwardVal(inputEdit);
            }
          else  if (Orient[0] == 2)
            {
                inputEdit = Rotor2.InwardVal(inputEdit);
            }
           else if (Orient[0] == 3)
            {
                inputEdit = Rotor3.InwardVal(inputEdit);
            }
           else if (Orient[0] == 4)
            {
                inputEdit = Rotor4.InwardVal(inputEdit);
            }
           else if (Orient[0] == 5)
            {
                inputEdit = Rotor5.InwardVal(inputEdit);
            }
            //set2
            if (Orient[1] == 1)
            {
                inputEdit = Rotor1.InwardVal(inputEdit);
            }
            else if (Orient[1] == 2)
            {
                inputEdit = Rotor2.InwardVal(inputEdit);
            }
            else if (Orient[1] == 3)
            {
                inputEdit = Rotor3.InwardVal(inputEdit);
            }
            else if (Orient[1] == 4)
            {
                inputEdit = Rotor4.InwardVal(inputEdit);
            }
            else if (Orient[1] == 5)
            {
                inputEdit = Rotor5.InwardVal(inputEdit);
            }
            //set3
            if (Orient[2] == 1)
            {
                inputEdit = Rotor1.InwardVal(inputEdit);
            }
            else if (Orient[2] == 2)
            {
                inputEdit = Rotor2.InwardVal(inputEdit);
            }
            else if (Orient[2] == 3)
            {
                inputEdit = Rotor3.InwardVal(inputEdit);
            }
            else if (Orient[2] == 4)
            {
                inputEdit = Rotor4.InwardVal(inputEdit);
            }
            else if (Orient[2] == 5)
            {
                inputEdit = Rotor5.InwardVal(inputEdit);
            }

            return inputEdit;
        }
        private String OutLayer(int[] Orient,String Input)
        {
          String  OutEdit = Input;
            if (Orient[0] == 1)
            {
                OutEdit = Rotor1.InwardVal(OutEdit);
            }
            else if (Orient[0] == 2)
            {
                OutEdit = Rotor2.InwardVal(OutEdit);
            }
            else if (Orient[0] == 3)
            {
                OutEdit = Rotor3.InwardVal(OutEdit);
            }
            else if (Orient[0] == 4)
            {
                OutEdit = Rotor4.InwardVal(OutEdit);
            }
            else if (Orient[0] == 5)
            {
                OutEdit = Rotor5.InwardVal(OutEdit);
            }
            //set2
            if (Orient[1] == 1)
            {
                OutEdit = Rotor1.InwardVal(OutEdit);
            }
            else if (Orient[1] == 2)
            {
                OutEdit = Rotor2.InwardVal(OutEdit);
            }
            else if (Orient[1] == 3)
            {
                OutEdit = Rotor3.InwardVal(OutEdit);
            }
            else if (Orient[1] == 4)
            {
                OutEdit = Rotor4.InwardVal(OutEdit);
            }
            else if (Orient[1] == 5)
            {
                OutEdit = Rotor5.InwardVal(OutEdit);
            }
            //set3
            if (Orient[2] == 1)
            {
                OutEdit = Rotor1.InwardVal(OutEdit);
            }
            else if (Orient[2] == 2)
            {
                OutEdit = Rotor2.InwardVal(OutEdit);
            }
            else if (Orient[2] == 3)
            {
                OutEdit = Rotor3.InwardVal(OutEdit);
            }
            else if (Orient[2] == 4)
            {
                OutEdit = Rotor4.InwardVal(OutEdit);
            }
            else if (Orient[2] == 5)
            {
                OutEdit = Rotor5.InwardVal(OutEdit);
            }
            return OutEdit; //Actually Output
        }



        private void Scramble_Click(object sender, EventArgs e)
        {

            //CALLS ALL PROCESSUS WITH ACCORDING CONFIGURATIONS
            // LeftNotchVal,RightNotchVal,centerNotchVal

            int[] Orient = Orientation();

            if (RightCounter == RightNotchVal)
            {
                if(Orient[0] == 1) { Rotor1.Rotation(); CenterCounter++; }
                if (Orient[0] == 2) { Rotor2.Rotation(); CenterCounter++; }
                if (Orient[0] == 3) { Rotor3.Rotation(); CenterCounter++; }
                if (Orient[0] == 4) { Rotor4.Rotation(); CenterCounter++; }
                if (Orient[0] == 5) { Rotor5.Rotation(); CenterCounter++; }
                RightCounter = 0;
            }
            RightCounter++;

            if(CenterCounter == CenterNotchVal)
            {
                if (Orient[1] == 1) { Rotor1.Rotation(); LeftCounter++; }
                if (Orient[1] == 2) { Rotor2.Rotation(); LeftCounter++; }
                if (Orient[1] == 3) { Rotor3.Rotation(); LeftCounter++; }
                if (Orient[1] == 4) { Rotor4.Rotation(); LeftCounter++; }
                if (Orient[1] == 5) { Rotor5.Rotation(); LeftCounter++; }
                CenterCounter = 0;
            }
            if (LeftCounter == LeftNotchVal)
            {
                if (Orient[3] == 1) { Rotor1.Rotation(); }
                if (Orient[3] == 2) { Rotor2.Rotation(); }
                if (Orient[3] == 3) { Rotor3.Rotation(); }
                if (Orient[3] == 4) { Rotor4.Rotation(); }
                if (Orient[3] == 5) { Rotor5.Rotation(); }
                LeftCounter = 0;

            }

                //Plugboard->Right->Center->left->left->center->->right->plugboard -> OUTPUT
                Output.Text = PlugBoard(OutLayer(Orientation(),InLayer(Orientation(), PlugBoard(Input.Text))));
            // Output.Text = Counter.ToString();
            


        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            //Reverse everything

            //When it comes to notches the 

            //PlugBoard Inputed value returns static value
            //Goes Outlayer first then inlayer AS WELL AS having input array and outarray SWAPPED
            //Inverted Plugboard and then output ,TESTED THIS IDEA IS CORRECt

            //Output.Text = 
        }
    }
}
