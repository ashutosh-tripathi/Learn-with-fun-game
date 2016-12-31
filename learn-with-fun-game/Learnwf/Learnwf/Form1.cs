using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Learnwf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
         
        }
        public int scorequiz;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                scorequiz += 10;
            if (radioButton8.Checked)
                scorequiz += 10;
            if (radioButton5.Checked)
                scorequiz += 10;
            if (radioButton1.Checked)
                scorequiz += 10;
            if (radioButton15.Checked)
                scorequiz += 10;
            if (radioButton11.Checked)
                scorequiz += 10;
            Form2 f4 = new Form2(scorequiz);
            f4.ShowDialog();
            Close();
            
       

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

          

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
