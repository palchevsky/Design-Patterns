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
 * Задание № 4
 * Для класса System.Drawing.Bitmap реализуйте Adapter, позволяющий получить негатив изображения, 
 * повернуть его на 90 градусов влево и вправо, а также сохранить его на диск.
 * Реализуйте Object Pool, позволяющий загрузить изображение, получить
 * его обработанные варианты (с использование адаптера) из пула объектов.
 */ 


namespace AdapterObjectPool
{
    public partial class TestForm : Form
    {
        OpenFileDialog dialog;
        Bitmap negativeOrig;
        Bitmap rotate90cwOrig;
        Bitmap rotate90ccwOrig;
        Image tmp;
        Bitmap negative;
        Bitmap rotate90cw;
        Bitmap rotate90ccw;

        public TestForm()
        {
            InitializeComponent();
            dialog = new OpenFileDialog();
            
            dialog.InitialDirectory = "E:\\";
            dialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            dialog.FilterIndex=2;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                negativeOrig = new Bitmap(dialog.FileName);
                rotate90cwOrig = new Bitmap(dialog.FileName);
                rotate90ccwOrig = new Bitmap(dialog.FileName);
            }

            tmp=Pool.GetObject();

            negative=tmp.NegativeBitmap(negativeOrig);
            rotate90cw = tmp.RotateBitmap90Clockwise(rotate90cwOrig);
            rotate90ccw = tmp.RotateBitmap90CounterClockwise(rotate90ccwOrig);

            pb90ccw.Size = rotate90ccw.Size;
            pb90ccw.Image = rotate90ccw;
            pb90ccw.Invalidate();

            pbNegative.Size = negative.Size;
            pbNegative.Image = negative;
            pbNegative.Invalidate();

            pb90cw.Size = rotate90cw.Size;
            pb90cw.Image = rotate90cw;
            pb90cw.Invalidate();

            tmp.SaveToDisk(rotate90cw, @"rotated90cw.jpg");
            tmp.SaveToDisk(rotate90ccw, @"rotated90ccw.jpg");
            tmp.SaveToDisk(negative, @"negative.jpg");
        }
    }
}
