using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    class LineFactory
    {
        private readonly Dictionary<Color, Line> lines = new Dictionary<Color, Line>();

        public Line GetLine(Color color)
        {
            if (!lines.ContainsKey(color))
            {
                if (color ==Color.Black )
                {
                    lines.Add(color, new BlackLine());
                }
                else
                {//жёлтый вместо остальных цветов :)
                    lines.Add(color, new YellowLine());
                }
            }
            return lines[color];
        }
    }
}
