using System;
using System.Collections.Generic;

namespace Composite
{
    class Section : IPage
    {
        private readonly IList<IPage> _pages = new List<IPage>();
        public string Header { get; set; }
        public string Info { get; set; }

        public IPage Find(string header)
        {
            if (Header.Equals(header))
            {
                return this;
            }

            foreach (var item in _pages)
            {
                var elPage = item.Find(header);
                if (elPage!=null)
                {
                    return elPage;
                }
            }

            return null;
        }

        public void Print()
        {
            Console.WriteLine("{0} - {1}", Header, Info);
            foreach (var item in _pages)
            {
                item.Print();
            }
        }

        public void AddPage(IPage page)
        {
            _pages.Add(page);
        }
    }
}
