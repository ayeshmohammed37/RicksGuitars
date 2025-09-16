using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitars
{
    public class Guitar
    {
		private string serialNumber;
        private double price;
        private GuitarSpec guitarSpec;

        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            SerialNumber = serialNumber;
            Price = price;
            GuitarSpec = guitarSpec;
        }

        public string SerialNumber { get => serialNumber; private set => serialNumber = value; }
        public double Price { get => price; set => price = value; }
        public GuitarSpec GuitarSpec { get => guitarSpec; private set => guitarSpec = value; }


        
        public override string ToString()
        {
            return $"Guitar: Serial Number: {SerialNumber},\n\tPrice: {Price}," +
               $"\n\t{GuitarSpec.ToString()}";
        }

        
    }
}
