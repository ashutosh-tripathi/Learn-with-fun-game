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
    public partial class cprogram2 : Form
    {
        public cprogram2()
        {
            InitializeComponent();
        }
        public int scorequiz;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static int quiztaken = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            quiztaken = 1;
            if (radioButton1.Checked)
                scorequiz += 10;
            if (radioButton7.Checked)
                scorequiz += 10;
            if (radioButton11.Checked)
                scorequiz += 10;
            if (radioButton14.Checked)
                scorequiz += 10;
            if (radioButton16.Checked)
                scorequiz += 10;
            Form2 f4 = new Form2(scorequiz);
            f4.ShowDialog();
            Close();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cprogram2_Load(object sender, EventArgs e)
        {

        }
    }
}
