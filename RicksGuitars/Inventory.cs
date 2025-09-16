using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitars
{
    public class Inventory
    {
        private List<Guitar> guitarList;

        public Inventory()
        {
            guitarList = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);

            guitarList.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitarList)
            {
                if (guitar.SerialNumber == serialNumber) return guitar;
            }

            return null;
        }

        public List<Guitar> Search(GuitarSpec guitarSpec)
        {
            List<Guitar> List = new List<Guitar> ();

            foreach (var guitar in guitarList)
            {
                if (guitarSpec.Equals(guitar.GuitarSpec))
                {
                    List.Add(guitar);
                }
            }
            return List;
        }
    }
}
