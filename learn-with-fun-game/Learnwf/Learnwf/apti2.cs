﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learnwf
{
    public partial class apti2 : Form
    {
        public apti2()
        {
            InitializeComponent();
        }

        public int scorequiz;
        public static int quiztaken = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            quiztaken = 1;
            if (radioButton4.Checked)
                scorequiz += 10;
            if (radioButton7.Checked)
                scorequiz += 10;
            if (radioButton10.Checked)
                scorequiz += 10;
            if (radioButton15.Checked)
                scorequiz += 10;
            if (radioButton17.Checked)
                scorequiz += 10;
            Form2 f4 = new Form2(scorequiz);
            f4.ShowDialog();
            Close();
            
        }

        private void apti2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
