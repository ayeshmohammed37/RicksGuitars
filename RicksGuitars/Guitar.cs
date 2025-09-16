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

        public Guitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            SerialNumber = serialNumber;
            Price = price;
            GuitarSpec = new GuitarSpec(builder,model, type, backWood, topWood);
        }

        public string SerialNumber { get => serialNumber; private set => serialNumber = value; }
        public double Price { get => price; set => price = value; }
        public GuitarSpec GuitarSpec { get => guitarSpec; private set => guitarSpec = value; }


        
        public override string ToString()
        {
            return $"Guitar: Serial Number: {SerialNumber},\n\tPrice: {Price}," +
               $"\n\t{GuitarSpec.ToString()}";
        }

        //public override bool Equals(object? obj)
        //{
        //   if (obj is GuitarSpec spec)
        //   {
        //        return GuitarSpec.Equals(spec);    
        //   }
        //    return false;
        //}

        
    }
}
