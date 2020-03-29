using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Volvo : Auto
    {
        public Volvo()
        {
            body = "suv";
            seats = 5;
            country = "Sweeden";
            brand = "Volvo";
            speed = new Speed(190, 12.3);
        }
        public override string Signal
        {
            get { return "there should play SABATON"; }
        }
    }
}
