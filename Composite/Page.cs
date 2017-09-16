using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Page : IPage
    {
        public string Header { get; set; }
        public string Info { get; set; }

        public IPage Find(string header)
        {
            return Header.Equals(header) ? this : null;
        }

        public void Print()
        {
            Console.WriteLine("\t{0} - {1}", Header, Info);
        }

    }
}
