using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Transport
    {
        protected string color;
        protected string number;
        protected static int counter;
        protected int wheels;
        protected string engine;
        protected int seats;
        protected string body;
        protected string country;
        protected int id = 0;
        protected string brand;
        public Transport()
        {
            engine = "Transport is not started";
            id = counter;
            wheels = 0;
            seats = 0;
            body = "unknown";
            country = "unknown";
            brand = "unknown";
            color = "unknown";
            number = "xxxxxx";
            counter++;
        }
        public Transport(int wheels, int seats, string body, string country, string brand)
        {
            engine = "Transport is not started";
            id = counter;
            this.wheels = wheels;
            this.seats = seats;
            this.body = body;
            this.country = country;
            this.brand = brand;
            counter++;
        }
        public int Id
        {
            get { return id; }
        }
        public int Wheels
        {
            get { return wheels; }
            set
            {
                if(value>0)
                {
                    wheels = value;
                }
            }
        }
        public string Engine
        {
            set 
            {
                if(value=="on")
                {
                    engine = "Transport is started";
                }
                else if(value=="off")
                {
                    engine = "Transport is not started";
                }
            }
            get { return engine; }
        }
        public int Seats
        {
            get { return seats; }
            set
            {
                if (value > 0)
                {
                    seats = value;
                }
            }
        }
        public string Body
        {
            get { return body; }
            set
            {
                body = value;
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length == 6)
                {
                    number = value;
                }
            }
        }
        public virtual string Signal
        {
            get { return "there are no signal"; }
        }
    }
}
