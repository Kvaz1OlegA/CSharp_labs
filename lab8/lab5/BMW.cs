using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class BMW : Auto
    {
        public BMW()
        {
            body = "сoupe";
            seats = 4;
            country = "Germany";
            brand = "Bmw";
            speed = new Speed(250, 4.7);
        }
        public override string Signal
        {
            get { return "wrung"; }
        }
    }
}
