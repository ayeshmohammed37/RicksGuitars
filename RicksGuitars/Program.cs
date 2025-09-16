namespace RicksGuitars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec guitarSpec = new GuitarSpec(Builder.FENDER, "Jazzmaster",
                6, Type.ELECTRIC, Wood.ALDER, Wood.ALDER);

            List<Guitar> guitars = inventory.Search(guitarSpec);

            if (guitars.Count != 0)
            {
                foreach (Guitar guitar in guitars)
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

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95,
                new GuitarSpec(Builder.COLLINGS, "CJ", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.SITKA));
            inventory.AddGuitar("V95693", 1499.95,
                new GuitarSpec(Builder.FENDER, "Stratocastor", 6, Type.ELECTRIC,
                               Wood.ALDER, Wood.ALDER));
            // Add 18 more guitars here...
            inventory.AddGuitar("V9512", 1549.95,
                new GuitarSpec(Builder.FENDER, "Stratocastor", 6, Type.ELECTRIC,
                               Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("122784", 5495.95,
                new GuitarSpec(Builder.MARTIN, "D-18", 6, Type.ACOUSTIC,
                               Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.AddGuitar("76531", 6295.95,
                new GuitarSpec(Builder.MARTIN, "OM-28", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("70108", 2295.95,
                new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", 6, Type.ELECTRIC,
                               Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("82451", 2100.95,
                new GuitarSpec(Builder.GIBSON, "Les Paul", 6, Type.ELECTRIC,
                               Wood.MAHOGANY, Wood.MAPLE));
            inventory.AddGuitar("77023", 6275.95,
                new GuitarSpec(Builder.MARTIN, "D-28", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("1092", 12995.95,
                new GuitarSpec(Builder.OLSON, "SJ", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.CEDAR));
            inventory.AddGuitar("566-62", 8999.95,
                new GuitarSpec(Builder.RYAN, "Cathedral", 12, Type.ACOUSTIC,
                               Wood.COCOBOLO, Wood.CEDAR));
            inventory.AddGuitar("6 29584", 2100.95,
                new GuitarSpec(Builder.GIBSON, "Les Paul", 6, Type.ELECTRIC,
                               Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("77023", 6275.95,
                new GuitarSpec(Builder.MARTIN, "D-28", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.SITKA));
            inventory.AddGuitar("89002", 4500.95,
                new GuitarSpec(Builder.COLLINGS, "OM-2", 6, Type.ACOUSTIC,
                               Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("345-34", 9500.00,
                new GuitarSpec(Builder.TAYLOR, "GS Mini", 6, Type.ACOUSTIC,
                               Wood.ROSEWOOD, Wood.SAPELE));
            inventory.AddGuitar("98765", 750.00,
                new GuitarSpec(Builder.FENDER, "Telecaster", 6, Type.ELECTRIC,
                               Wood.ASH, Wood.MAPLE));
            inventory.AddGuitar("54321", 1850.50,
                new GuitarSpec(Builder.GIBSON, "SG Special", 6, Type.ELECTRIC,
                               Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("333-22", 2999.95,
                new GuitarSpec(Builder.PRS, "Custom 24", 6, Type.ELECTRIC,
                               Wood.MAHOGANY, Wood.MAPLE));
            inventory.AddGuitar("555-44", 899.00,
                new GuitarSpec(Builder.IBANEZ, "RG550", 6, Type.ELECTRIC,
                               Wood.BASSWOOD, Wood.MAPLE));
            inventory.AddGuitar("111-99", 3500.00,
                new GuitarSpec(Builder.MARTIN, "000-15M", 6, Type.ACOUSTIC,
                               Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("222-88", 2500.00,
                new GuitarSpec(Builder.FENDER, "Jazzmaster", 6, Type.ELECTRIC,
                               Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("2222-88", 2550.00,
                new GuitarSpec(Builder.FENDER, "Jazzmaster", 6, Type.ELECTRIC,
                               Wood.ALDER, Wood.ALDER));
        }

    }
}
