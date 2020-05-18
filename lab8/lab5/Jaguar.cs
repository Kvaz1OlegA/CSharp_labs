using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Jaguar : Auto
    {
        public Jaguar()
        {
            body = "sport";
            seats = 2;
            country = "England";
            brand = "Jaguar";
            speed = new Speed(250, 5.6);
        }
        public override string Signal
        {
            get { return "nice cup of tea"; }
        }
    }
}
