using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Auto : Transport
    {
        public Auto()
        {
            wheels = 4;
            color = "metal";
            number = "A000ZZ";
            speed = new Speed(60, 4.2);
        }
        public override string Signal
        {
            get { return "bip"; }
        }
    }
}
