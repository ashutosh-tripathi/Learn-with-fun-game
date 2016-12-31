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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int scorequiz;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                scorequiz += 10;
            if (radioButton6.Checked)
                scorequiz += 10;
            if (radioButton10.Checked)
                scorequiz += 10;
            if (radioButton13.Checked)
                scorequiz += 10;
            if (radioButton17.Checked)
                scorequiz += 10;
            Form2 f4 = new Form2(scorequiz);
            f4.ShowDialog();
            Close();
        }
    }
}
