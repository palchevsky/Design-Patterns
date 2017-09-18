using System.Collections.Generic;
using System.Drawing;

namespace Flyweight
{
    class LineFactory
    {
        private readonly Dictionary<Color, Line> _lines = new Dictionary<Color, Line>();

        public Line GetLine(Color color)
        {
            if (!_lines.ContainsKey(color))
            {
                if (color ==Color.Black )
                {
                    _lines.Add(color, new BlackLine());
                }
                else
                {//жёлтый вместо остальных цветов :)
                    _lines.Add(color, new YellowLine());
                }
            }
            return _lines[color];
        }
    }
}
