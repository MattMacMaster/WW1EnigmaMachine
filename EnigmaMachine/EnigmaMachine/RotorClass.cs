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


        public String InwardVal(String Input)
        {
            int i = 0;
            int match = 0;
            foreach (String m in InputArray)
            {
                if (m == InputArray[i])
                {
                    match = i;
                }

                    i++;
            }

            return OutputArray[match].ToString();

        }


    }
}
