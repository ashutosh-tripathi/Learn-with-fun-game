using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Learnwf
{
    public partial class Learn : Form
    {
        public Learn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomval = Game1.Random.Next(2);
            if (randomval == 0)
            {
                apti1 f5 = new apti1();
                f5.ShowDialog();
                Game1.gameWorld.Reset();
                this.Close();
            }
            else if (randomval == 1)
            {
                apti2 f3 = new apti2();
                f3.ShowDialog();
                Game1.gameWorld.Reset();
                this.Close();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            int randomval = Game1.Random.Next(2);
            if (randomval == 0)
            {
                cprogram1 f5 = new cprogram1();
                f5.ShowDialog();
                Game1.gameWorld.Reset();
                this.Close();
            }
            else if (randomval == 1)
            {
                cprogram2 f3 = new cprogram2();
                f3.ShowDialog();
                Game1.gameWorld.Reset();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomval = Game1.Random.Next(2);
            if (randomval == 0)
            {
                apti1 f5 = new apti1();
                f5.ShowDialog();
                Game1.gameWorld.Reset();
            }
            else if (randomval == 1)
            {
                apti2 f3 = new apti2();
                f3.ShowDialog();
                Game1.gameWorld.Reset();
            }
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            
        }
    }
}

