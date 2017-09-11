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
    class Snake
    {
        public SolidBrush snakebrush;
        public float snake_x;
        public float snake_y;
        enum snakeposition
        {
            left, right, up, down
        }
    }
}
