using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GunLog
{
    internal class Gun
    {
        public string serial;
        public string make;
        public string model;
        public string caliber;
        public int roundCount;
        public double price;
        public string dateAcquired;

        public Gun(string serial, string make, string model, string caliber, int roundCount, double price, string dateAcquired)
        {
            this.serial = serial;
            this.make = make;
            this.model = model;
            this.caliber = caliber;
            this.roundCount = roundCount;
            this.price = price;
            this.dateAcquired = dateAcquired;
        }

        public override string ToString()
        {
            return $"{serial}, {make}, {model}, {caliber}, {roundCount}, {price}, {dateAcquired}";
        }
    }
}
