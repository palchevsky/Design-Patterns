using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObjectPool
{
    public static class Pool
    {
        private static List<Image> _available = new List<Image>();
        private static List<Image> _inUse = new List<Image>();

        public static Image GetObject()
        {
            lock (_available)
            {
                if (_available.Count != 0)
                {
                    Image po = _available[0];
                    _inUse.Add(po);
                    _available.RemoveAt(0);
                    return po;
                }
                else
                {
                    Image po = new Image();
                    _inUse.Add(po);
                    return po;
                }
            }
        }

        public static void ReleaseObject(Image po)
        {
            //CleanUp(po);

            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }

        //private static void CleanUp(Image po)
        //{
        //    po.TempData = null;
        //}
    }


    //class ObjectPool
    //{
    //    //private readonly int _maxSize;
    //    private readonly List<Object> _objects;

    //    public ObjectPool(Bitmap address)
    //    {
    //        //_maxSize = maxSize;

    //        _objects = new List<Object>();
    //        for (int i = 0; i < 4; i++)
    //        {
    //            var obj = new Object(address);
    //            _objects.Add(obj);
    //        }
    //    }
    //    public Object GetObject(Bitmap image)
    //    {
    //        var obj = _objects.FirstOrDefault(x => !x.IsInUse);
    //        if (obj == null)
    //        {
    //            obj = CreateObject(image);
    //        }
    //        obj.IsInUse = true;

    //        return obj;
    //    }

    //    public void ReleaseObject(Object obj)
    //    {
    //        if (!_objects.Contains(obj))
    //        {
    //            throw new InvalidOperationException();
    //        }
    //        obj.IsInUse = false;
    //    }

    //    private Object CreateObject(Bitmap image)
    //    {
    //        if (_objects.Count == 4)
    //        {
    //            throw new InvalidOperationException();
    //        }

    //        var obj = new Object(image);
    //        _objects.Add(obj);
    //        return obj;
    //    }


    //}
}
