using System.Drawing;

namespace AdapterObjectPool
{
    public interface IImage
    {
        Bitmap NegativeBitmap(Bitmap image);
        Bitmap RotateBitmap90Clockwise(Bitmap image); // по часовой стрелке
        Bitmap RotateBitmap90CounterClockwise(Bitmap image); // против часовой стрелки
        bool SaveToDisk(Bitmap image, string fileName);
    }
}