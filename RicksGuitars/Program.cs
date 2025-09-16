namespace RicksGuitars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, 
                "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);

            List<Guitar> guitars = inventory.Search(whatErinLikes);

            if (guitars != null)
            {
                foreach (var guitar in guitars)
                {
                    Console.WriteLine(guitar);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);

            inventory.AddGuitar("V95123", 1549.95, Builder.FENDER, "Telecaster", Type.ELECTRIC, Wood.ASH, Wood.ASH);

            inventory.AddGuitar("11277", 3999.95, Builder.MARTIN, "D-18", Type.ACOUSTIC, Wood.MAHOGANY, Wood.ADIRONDACK);

            inventory.AddGuitar("629584", 2599.99, Builder.GIBSON, "Les Paul", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE);

            inventory.AddGuitar("70108276", 2199.00, Builder.GIBSON, "SG", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAHOGANY);

            inventory.AddGuitar("56619-2", 1899.99, Builder.COLLINGS, "D2H", Type.ACOUSTIC, Wood.ROSEWOOD, Wood.SITKA);

            inventory.AddGuitar("82765501", 1299.50, Builder.TAYLOR, "314ce", Type.ACOUSTIC, Wood.SAPELE, Wood.SITKA);

            inventory.AddGuitar("9019920", 899.00, Builder.IBANEZ, "RG550", Type.ELECTRIC, Wood.BASSWOOD, Wood.BASSWOOD);

            inventory.AddGuitar("9019921", 899.00, Builder.IBANEZ, "RG550", Type.ELECTRIC, Wood.BASSWOOD, Wood.BASSWOOD);

            inventory.AddGuitar("9019922", 899.00, Builder.IBANEZ, "RG550", Type.ELECTRIC, Wood.BASSWOOD, Wood.BASSWOOD);
        }
    }
}
