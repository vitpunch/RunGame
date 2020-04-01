using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class Circle
    {
        public Point center { get; private set; }
        public int radius { get; private set; }
        public Color color { get; private set; }
        public Circle(int x, int y, int radius)
        {
            center = new Point(x, y);
            this.radius = radius;
            color = Color.Blue;
        }
    }
}