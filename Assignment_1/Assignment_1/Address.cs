using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Address
    {
        private int houseNo, roadNo;
        private string city;
        public string country;

        public Address(int houseNo, int roadNo, string city, string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
            this.country = country;
        }
        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }

        }

        public void GetAddress()
        {

            Console.WriteLine("Address:House No-{0}\nRoad No-{1}\nCity-{2}\nCountry-{3}\n", this.houseNo, this.roadNo, this.city, this.country);

        }
    }
}
}
