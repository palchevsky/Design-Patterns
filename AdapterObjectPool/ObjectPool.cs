using System.Collections.Generic;

namespace AdapterObjectPool
{
    public static class Pool
    {
        private static readonly List<Image> _available = new List<Image>();
        private static readonly List<Image> _inUse = new List<Image>();

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
            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }
    }
}
