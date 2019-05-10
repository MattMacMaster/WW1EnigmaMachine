using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class RotorClass
    {
        private String[] InputArray;
        private String[] OutputArray;


        public RotorClass(String[] InArray, String[] OutArray) {
            InputArray = InArray;
            OutputArray = OutArray;
        }

        //Takes in value from plugboard and then runs through dual array
        //Should work both ways
        public String InwardVal(String Input)
        {
            int i = 0;
            int match = 0;
            foreach (String Char in InputArray)
            {
                if (Input == InputArray[i])
                {
                    match = i;
                }

                    i++;
            }

            return OutputArray[match].ToString();

        }
        //for testing rotors
        public int RotorLength()
        {
            return this.InputArray.Length;
        }
        public String RotorLet (int a)
        {
            return InputArray[a] + "," + OutputArray[a];
        }
    }
}
