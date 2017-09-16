using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AdapterObjectPool
{
    public class Image : IImage
    {
        public Bitmap NegativeBitmap(Bitmap image)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                ColorMatrix colorMatrix = new ColorMatrix(
                    new float[][]
                        {
                            new float[] {-1, 0, 0, 0, 0},
                            new float[] {0, -1, 0, 0, 0},
                            new float[] {0, 0, -1, 0, 0},
                            new float[] {0, 0, 0, 1, 0},
                            new float[] {1, 1, 1, 0, 1}
                        });

                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                            0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return image;
        }

        public  Bitmap RotateBitmap90Clockwise(Bitmap image)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return image;
        }

        public  Bitmap RotateBitmap90CounterClockwise(Bitmap image)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return image;
        }

        public bool SaveToDisk(Bitmap image, string fileName)
        {
            try
            {
                image.Save(fileName, ImageFormat.Jpeg);
                MessageBox.Show(fileName,"File saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}