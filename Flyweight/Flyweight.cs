using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/*
 * Задание № 3
 * С помощью паттерна Flyweight напишите примитивный графический редактор, 
 * позволяющий рисовать отрезки из прямых
 * и точек (использовать WPF/Windows Forms).
 */


namespace Flyweight
{
    public partial class MainWindow : Form
    {
        private int _x1 = 0;
        private int _y1 = 0;
        private int _x2 = 0;
        private int _y2 = 0;
        private Color _selectedColor = Color.Black;
        readonly LineFactory _lineFactory = new LineFactory();
        readonly List<Points> _pts = new List<Points> { };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            _x2 = e.X;
            _y2 = e.Y;
            _pts.Add(new Points(_x1, _y1, _x2, _y2));
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _x2 = e.X;
                _y2 = e.Y;
                pbMain.Invalidate();
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            _x1 = e.X;
            _y1 = e.Y;
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            DialogResult dResult = colorDialog.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                _selectedColor = colorDialog.Color;
                
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            _pts.Clear();
            pbMain.Refresh();
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            //Всё что не чёрный, то жёлтый (цвет линии)
            var line = _lineFactory.GetLine(_selectedColor);
            line.Draw(_x1, _y1, _x2, _y2, e);
            foreach (var p in _pts)
            {
                line.Draw(p.X1, p.Y1, p.X2, p.Y2, e);
            }
        }
    }
}
