using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public abstract class Line
    {
        //координаты начальной и конечно точки + контекст для рисования
        public abstract void Draw(int x1, int y1, int x2, int y2, PaintEventArgs args);
    }
}