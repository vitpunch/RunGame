using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class Box : Игрок 
    {
        public Rectangle box { get; private set; }
        public Color color { get; private set; }
        int sx, sy;
        //Random random = new Random();
        public Box(int x, int y, int width, int height, int sx, int sy)
            : this(x, y, width, height)
        {
            this.sx = sx;
            this.sy = sy;
        }
        public Box(int x, int y, int width, int height)
        {
            box = new Rectangle(x, y, width, height);
            color = Color.Green;
            sx = Arena.random.Next(-4, 5);
            if (sx == 0) sx--;
            sy = Arena.random.Next(-4, 5);
            if (sy == 0) sy--;
        }
        public void Беги()
        {
            Move();
        }
        public void Голя()
        {
            color = Color.Red;
        }
        public void НеГоля()
        {
            color = Color.Green;
        }
        public bool Поймал(Игрок obj)
        {
            if (obj.GetType() != typeof(Box))
                return false;
            Box incomingBox = (Box)obj;
            return (box.X - incomingBox.box.Width < incomingBox.box.X &
                incomingBox.box.X < box.X + box.Width &
                box.Y - incomingBox.box.Height < incomingBox.box.Y &
                incomingBox.box.Y < box.Y + box.Height);
        }
        private void Move()
        {
            int x = box.X + sx;
            int y = box.Y + sy;
            if (x < 0 || x > Arena.Range.Width - box.Width)
                sx = -sx;
            if (y < 0 || y > Arena.Range.Height - box.Height)
                sy = -sy;
            box = new Rectangle(box.X + sx, box.Y + sy,
                box.Width, box.Height);
        }
    }
}
