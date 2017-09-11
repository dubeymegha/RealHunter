using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace abcde
{
    public partial class Form1 : Form
    {
        Random rdm = new Random();
        float snake_x;
        float snake_y;
        float food_x;
        float food_y;
        SolidBrush foodbrush; 
        SolidBrush snakebrush; 

        enum snakeposition
        {
            left,right,up,down
        }
        snakeposition currentposition;
        public Form1()
        {
            InitializeComponent();

            //window size full screen
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //Initialize brushes color
            snakebrush = new SolidBrush(Color.Black);
            foodbrush = new SolidBrush(Color.Black);

            //Snake coordinates
             snake_x = 20;
             snake_y = 20;

            //setting food corrdinates randomly
             food_x = rdm.Next(10, this.Size.Width - 10);  
             food_y = rdm.Next(10, this.Size.Height - 10);

            //snake current position
              currentposition = snakeposition.right;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(snakebrush, snake_x, snake_y, 20, 10);
            e.Graphics.FillRectangle(foodbrush, food_x,food_y, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //setting the direction of snake according to the keys
            if (currentposition == snakeposition.right)
            {
                snake_x = snake_x + 4;
            }
            else if (currentposition == snakeposition.left)
            {
                snake_x = snake_x - 4;
            }
            else if (currentposition == snakeposition.up)
            {
                snake_y = snake_y - 4;
            }
            else if (currentposition == snakeposition.down)
            {
                snake_y = snake_y + 4;
            }
            Invalidate();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //getting keyboard values
            if (e.KeyCode == Keys.Escape)
                this.Close();

            else if(e.KeyCode==Keys.Left)
            {
                currentposition = snakeposition.left;
            }
            else if(e.KeyCode==Keys.Right)
            {
                currentposition = snakeposition.right;
            }
            else if(e.KeyCode==Keys.Up)
            {
                currentposition = snakeposition.up;
            }
            else if(e.KeyCode==Keys.Down)
            {
                currentposition = snakeposition.down;
            }
        }

      
    }
}
