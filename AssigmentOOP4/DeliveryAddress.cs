using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP4
{
    internal struct DeliveryAddress
    {
        private string City;
        private string Street;
        private int BuldingNumber;
        public DeliveryAddress(string c, string s, int b)
        {
            City = c;
            Street = s;
            BuldingNumber = b;
        }
        public DeliveryAddress()
        {

        }
        public void setCity(string c)
        {
            City = c;
        }
        public string getCity()
        {
            return City;
        }
        public void setStreet(string s)
        {
            Street = s;
        }
        public string getStreet()
        {
            return Street;
        }
        public void setBuldingNum(int b)
        {
            BuldingNumber = b;
        }
        public int getBuldingNum()
        {
            return BuldingNumber;
        }
        public string GetFullAdress()
        {
            return $" {getCity()}: {getStreet()}: {getBuldingNum()} ";
        }
    }
}
