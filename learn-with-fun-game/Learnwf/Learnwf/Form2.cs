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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int sc;
        public Form2(int n)
        {
            InitializeComponent();
            sc = n;
            textBox3.Text = Game1.GameWorld.score.ToString();
            textBox2.Text = n.ToString();
            sc += Game1.GameWorld.score;
            textBox1.Text = sc.ToString();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game1.GameWorld.Reset();
            Close();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
