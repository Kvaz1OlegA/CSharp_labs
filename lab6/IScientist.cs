using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    interface IScientist:IComparable
    {
        int Money { get; set; }
        int Intelligence{ get; set; }
        void Research();
    }
}
