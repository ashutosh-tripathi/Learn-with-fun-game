using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Learnwf
{
    public partial class Form4 : Form  
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomval = Game1.Random.Next(2);
            if (randomval == 0)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
                Game1.gameWorld.Reset();
            }
            else if (randomval == 1)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                Game1.gameWorld.Reset();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            int randomval = Game1.Random.Next(2);
            if (randomval == 0)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
                Game1.gameWorld.Reset();
            }
            else if (randomval == 1)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                Game1.gameWorld.Reset();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
            
           
        }
           
    }
}
