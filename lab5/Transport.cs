using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
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
        protected Speed speed;
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
            speed=new Speed(0, 0);
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
        public virtual int Wheels
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
        public virtual int Seats
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
        public virtual string Body
        {
            get { return body; }
            set
            {
                body = value;
            }
        }
        public virtual string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        public virtual string Brand
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
        public enum Colors { Red = 1, Orange, Yellow, Green, Blue, Violet };
        public void ChooseColor(int n)
        {
            switch (n)
            {
                case (int)Colors.Red:
                    color = "red";
                    break;
                case (int)Colors.Orange:
                    color = "orange";
                    break;
                case (int)Colors.Yellow:
                    color = "yellow";
                    break;
                case (int)Colors.Green:
                    color = "green";
                    break;
                case (int)Colors.Blue:
                    color = "blue";
                    break;
                case (int)Colors.Violet:
                    color = "violet";
                    break;
                default:
                    color = "black";
                    break;
            }
        }
        public struct Speed
        {
            public int max;
            public double time;
            public Speed(int max, double time)
            {
                this.max = max;
                this.time = time;
            }
        }
        public void SpeedInfo()
        {
            Console.WriteLine("Max speed : "+speed.max+ " km/h\nAcceleration speed up to 100 km/h : "+speed.time+"sec.");
        }
    }
}
