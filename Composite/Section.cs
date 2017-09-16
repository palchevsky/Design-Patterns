using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Section : IPage
    {
        private readonly IList<IPage> pages = new List<IPage>();
        public string Header { get; set; }
        public string Info { get; set; }

        public IPage Find(string header)
        {
            if (Header.Equals(header))
            {
                return this;
            }

            foreach (var item in pages)
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
            foreach (var item in pages)
            {
                item.Print();
            }
        }

        public void AddPage(IPage page)
        {
            pages.Add(page);
        }
    }
}
