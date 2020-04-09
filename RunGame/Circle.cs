using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class Circle : Игрок
    {
        public Point center { get; private set; }
        public int radius { get; private set; }
        public Color color { get; private set; }
        int sx, sy;
        public Circle(int x,int y,int radius)
            : this(x, y, radius, 0, 0)
        {
        }
        public Circle(int x, int y, int radius, int sx, int sy)
        {
            center = new Point(x, y);
            this.radius = radius;
            color = Color.Blue;
            this.sx = sx;
            this.sy = sy;
        }

        void Игрок.Беги()
        {
            int x = center.X + sx;
            int y = center.Y + sy;
            if (x < radius || x > Arena.Range.Width - radius)
                sx = -sx;
            if (y < radius || y > Arena.Range.Height - radius)
                sy = -sy;
            center = new Point(center.X + sx, center.Y + sy);
        }

        void Игрок.Голя()
        {
            color = Color.Red;
        }

        void Игрок.НеГоля()
        {
            color = Color.Blue;
        }

        bool Игрок.Поймал(Игрок obj)
        {
            if (obj.GetType() != typeof(Circle))
                return false;
            return Cross(this, (Circle)obj);
        } 
        private bool Cross(Circle circle1, Circle circle2)
        {
            return Distance(circle1.center, circle2.center) < circle1.radius + circle2.radius;
        }
        private int Distance(Point point1, Point point2)
        {
            return Convert.ToInt16(Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y)*(point1.Y - point2.Y)));
        }
    }
}