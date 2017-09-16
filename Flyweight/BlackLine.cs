﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    class BlackLine : Line
    {
        //координаты для линии + контекст рисования
        public override void Draw(int x1, int y1, int x2, int y2, PaintEventArgs args)
        {
            args.Graphics.DrawLine(new Pen(Color.Black), new Point(x1, y1), new Point(x2, y2));
        }
    }
}
