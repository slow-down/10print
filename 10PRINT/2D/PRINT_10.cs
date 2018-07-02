using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PRINT
{
    class PRINT_10
    {
        private Random rnd = new Random();
        private Pen black = new Pen(Color.Black, 2);
        private Pen red = new Pen(Color.Red, 2);

        public void Draw(Graphics g, Rectangle rec)
        {
            int x = 0;
            int y = 0;
            int spacing = 20;
            for (int i = 0; i < rec.Width * rec.Height; i += spacing)
            {
                if (rnd.Next(2) < 1) g.DrawLine(black, x, y, x + spacing, y + spacing);
                else g.DrawLine(black, x, y + spacing, x + spacing, y);

                x += spacing;
                if (x > rec.Width)
                {
                    x = 0;
                    y += spacing;
                }
            }
        }
    }
}
