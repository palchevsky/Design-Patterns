using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IPage
    {
        string Header { get; set; }
        string Info { get; set; }
        void Print();
        IPage Find(string header);
    }
}
