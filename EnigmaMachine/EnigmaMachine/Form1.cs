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
        public Form1()
        {
            InitializeComponent();
            int LeftNotchVal = 0;
            int CenterNotchVal = 0;
            int RightNotchVal = 0;

            LeftNotch.Text = Convert.ToString(LeftNotchVal);
            CenterNotch.Text = Convert.ToString(CenterNotchVal);
            RightNotch.Text = Convert.ToString(RightNotchVal);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
