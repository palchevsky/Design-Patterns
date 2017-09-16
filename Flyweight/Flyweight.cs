using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int x1 = 0;
        private int y1 = 0;
        private int x2 = 0;
        private int y2 = 0;
        Color selectedColor = Color.Black;
        LineFactory lineFactory = new LineFactory();
        List<Points> pts = new List<Points>() { };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            pts.Add(new Points(x1, y1, x2, y2));
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x2 = e.X;
                y2 = e.Y;
                pbMain.Invalidate();
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            DialogResult dResult = colorDialog.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pts.Clear();
            pbMain.Refresh();
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            //Всё что не чёрный, то жёлтый (цвет линии) :)
            var line = lineFactory.GetLine(selectedColor);
            line.Draw(x1, y1, x2, y2, e);
            foreach (var p in pts)
            {
                line.Draw(p.X1, p.Y1, p.X2, p.Y2, e);
            }
        }
    }
}
