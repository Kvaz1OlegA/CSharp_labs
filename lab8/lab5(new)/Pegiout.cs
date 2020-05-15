using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Pegiout : Auto
    {
        public Pegiout()
        {
            body = "bus";
            seats = 21;
            country = "France";
            brand = "Pegiout";
            speed = new Speed(155, 16.2);
        }
        public override string Signal
        {
            get { return "there should play chanson"; }
        }
    }
}
