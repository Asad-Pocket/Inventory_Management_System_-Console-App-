namespace Retail_Store
{
    public static class Features
    {

        public static int choice()
        {

            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("         1. Add new item to inventory".PadRight(60));
            Console.WriteLine("         2. Update the item".PadRight(60));
            Console.WriteLine("         3. Display inventory".PadRight(60));
            Console.WriteLine("         4. Search item by name or ID".PadRight(60));
            Console.WriteLine("         5. Remove item from inventory".PadRight(60));
            Console.WriteLine("         6. Exit".PadRight(60));
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("\nEnter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return choice;
        }
        public static void AddItem(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("\nEnter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter item quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter item price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            items.Add(new Item(name, quantity, price));
            Console.WriteLine($"{name} has been added to the inventory.");
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }
        public static void UpdateItem(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("\nEnter item name: ");
            string itemToUpdate = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("1.Change The Quantity.");
            Console.WriteLine("2.Change The Price.");
            Console.WriteLine("3.Change Both Quantity and Price.");
            Console.WriteLine("4.Change All");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter an option : ");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 4)
            {
                Console.Write("\nEnter item new name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new quantity: ");
                int newQuantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Price: ");
                int newPrice = Convert.ToInt32(Console.ReadLine());

                foreach (Item item in items)
                {
                    if (item.Name == itemToUpdate)
                    {
                        item.Name = newName;
                        item.Quantity = newQuantity;
                        item.Price = newPrice;
                        Console.WriteLine($"{item.Name} has been updated.");
                        break;
                    }
                }
            }
            else if (opt == 1)
            {
                Console.Write("Enter new quantity: ");
                int newQuantity = Convert.ToInt32(Console.ReadLine());
                foreach (Item item in items)
                {
                    if (item.Name == itemToUpdate)
                    {
                        item.Quantity = newQuantity;
                        Console.WriteLine($"{item.Name} has been updated.");
                        break;
                    }
                }
            }
            else if (opt == 2)
            {
                Console.Write("Enter new Price: ");
                int newPrice = Convert.ToInt32(Console.ReadLine());
                foreach (Item item in items)
                {
                    if (item.Name == itemToUpdate)
                    {
                        item.Price = newPrice;
                        Console.WriteLine($"{item.Name} has been updated.");
                        break;
                    }
                }
            }
            else if (opt == 3)
            {
                Console.Write("Enter new quantity: ");
                int newQuantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter new Price: ");
                int newPrice = Convert.ToInt32(Console.ReadLine());
                foreach (Item item in items)
                {
                    if (item.Name == itemToUpdate)
                    {
                        item.Price = newPrice;
                        item.Quantity = newQuantity;
                        Console.WriteLine($"{item.Name} has been updated.");
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void DisplayInventory(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            if (items.Any())
            {
                Console.WriteLine("\n******************** Current Inventory ********************");
                Console.WriteLine();
                string t = "ID".PadRight(10);
                string t1 = "NAME".PadRight(15);
                string t2 = "QUANTITY".PadRight(15);
                string t3 = "PRICE".PadRight(15);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(t + t1 + t2 + t3);
                Console.WriteLine("------------------------------------------------------------");
                foreach (Item item in items)
                {
                    string temp_id = item.Id.ToString().PadRight(10);
                    string temp_name = item.Name.ToString().PadRight(15);
                    string temp_quantity = item.Quantity.ToString().PadRight(15);
                    string temp_price = item.Price.ToString().PadRight(15);

                    Console.WriteLine(temp_id + temp_name + temp_quantity + temp_price);
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Search_Item(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1.Search with ID.");
            Console.WriteLine("2.Search with NAME.");
            Console.WriteLine();
            Console.Write("Enter an option : ");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                Console.Write("\nEnter item ID: ");
                int item_id = int.Parse(Console.ReadLine());

                foreach (Item item in items)
                {
                    if (item.Id == item_id)
                    {
                        Console.WriteLine($"{item.Name} ({item.Id}) - Quantity: {item.Quantity}, Price: ${item.Price}");
                        break;
                    }
                }
            }
            else if (opt == 2)
            {
                Console.Write("\nEnter item name: ");
                string searchItem = Console.ReadLine();
                foreach (Item i in items)
                {
                    if (i.Name == searchItem)
                    {
                        Console.WriteLine($"{i.Name} ({i.Id}) - Quantity: {i.Quantity}, Price: ${i.Price}");
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Remove_Item(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("\nEnter item name to remove: ");
            string itemToRemove = Console.ReadLine();

            int removedItems = items.RemoveAll(item => item.Name == itemToRemove);

            if (removedItems > 0)
            {
                Console.WriteLine($"{removedItems} {itemToRemove} has been removed from the inventory.");
            }
            else
            {
                Console.WriteLine($"{itemToRemove} was not found in the inventory.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
