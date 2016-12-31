using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learnwf
{
    public partial class apti1 : Form
    {
        public apti1()
        {
            InitializeComponent();
        }

        private void apti1_Load(object sender, EventArgs e)
        {

        }
        public int scorequiz;
        public static int quiztaken = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            quiztaken = 1;
            if (radioButton1.Checked)
                scorequiz += 10;
            if (radioButton8.Checked)
                scorequiz += 10;
            if (radioButton9.Checked)
                scorequiz += 10;
            if (radioButton15.Checked)
                scorequiz += 10;
            if (radioButton18.Checked)
                scorequiz += 10;
            Form2 f4 = new Form2(scorequiz);
            f4.ShowDialog();
            Close();
        }
    }
}
