using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunGame
{
    class Arena
    {
        static public Size Range { get; private set; }
        static public Random random = new Random();

        PictureBox picture;
        Graphics graphics;

        public Arena (PictureBox picture)
        {
            this.picture = picture;
            Range = picture.Size;
            this.picture.Image = new Bitmap(Range.Width, Range.Height);
            graphics = Graphics.FromImage(this.picture.Image);
            Clear();
        }
        public void Clear()
        {
            graphics.Clear(picture.BackColor);
        }

        public  void Show(Игрок obj)
        {
            if (obj.GetType() == typeof(Box))
                Show((Box)obj);
            if (obj.GetType() == typeof(Circle))
                Show((Circle)obj);
        }
        public void Show(Circle circle)
        {
            Pen pen = new Pen(circle.color);
            graphics.DrawEllipse(pen, circle.center.X - circle.radius, circle.center.Y - circle.radius, circle.radius * 2, circle.radius * 2);
        }
        public void Show(Box box)
        {
            Pen pen = new Pen(box.color);
            graphics.DrawRectangle (pen, box.box);
        }
        
        public void Refresh()
        {
            picture.Refresh();
        }
        static public Circle NewCircle()
        {
            int radius = random.Next(Range.Width / 200, Range.Width / 50);
            int x = random.Next(radius, Range.Width - radius);
            int y = random.Next(radius, Range.Height - radius);
            return new Circle(x, y, radius);
        }
        static public Box NewBox()
        {
            int width = random.Next(Range.Width / 200, Range.Width / 50);
            int height = random.Next(Range.Width / 200, Range.Width / 50);
            int x = random.Next(0, Range.Width - width);
            int y = random.Next(0, Range.Height - height);
            return new Box(x, y, width, height);
        }
    }
}
