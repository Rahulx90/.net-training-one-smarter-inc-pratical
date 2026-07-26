using System;


class Program
{   
    //Module 1 -- solution 
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "admin123";

        bool loginSuccess = false;

        try
        {
            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("\nLogin Successful");
                    loginSuccess = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Login");

                    if (attempt < 3)
                    {
                        Console.WriteLine("Attempts Left : " + (3 - attempt));
                    }
                }
            }

            if (!loginSuccess)
            {
                throw new LoginFailedException("Login Failed! Account Locked.");
            }
        }
        catch (LoginFailedException ex)
        {
            Console.WriteLine("\nCustom Exception: " + ex.Message);
        }

         //module 2

    
    {
        int choice;

        do
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine(" Stationery Store Management System");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Items");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");

            Console.Write("\nEnter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Stationery Item");
                    break;

                case 2:
                    Console.WriteLine("Display All Items");
                    break;

                case 3:
                    Console.WriteLine("Search Item");
                    break;

                case 4:
                    Console.WriteLine("Update Item");
                    break;

                case 5:
                    Console.WriteLine("Delete Item");
                    break;

                case 6:
                    Console.WriteLine("Purchase Item");
                    break;

                case 7:
                    Console.WriteLine("View Low Stock Items");
                    break;

                case 8:
                    Console.WriteLine("Sort Items");
                    break;

                case 9:
                    Console.WriteLine("Thank You!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 9);
 
   }
      



    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("\n----- Item Details -----");
        Console.WriteLine("Item ID      : " + ItemId);
        Console.WriteLine("Item Name    : " + ItemName);
        Console.WriteLine("Category     : " + Category);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Quantity     : " + Quantity);
        Console.WriteLine("Brand        : " + Brand);
    }

    // Method to update quantity
    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
        Console.WriteLine("Quantity Updated Successfully.");
    }
}

  StationeryItem item = new StationeryItem();

        item.ItemId = 101;
        item.ItemName = "Pen";
        item.Category = "Writing";
        item.Price = 20;
        item.Quantity = 50;
        item.Brand = "Reynolds";

        item.DisplayDetails();

        item.UpdateQuantity(80);

        item.DisplayDetails();
}

  //  ADD ITEM 
        static void AddItem()
        {
            Console.WriteLine("\nSelect Item Type:");
            Console.WriteLine("1. Pen");
            Console.WriteLine("2. Notebook");
            Console.WriteLine("3. Marker");

            int type = ReadInt("Enter choice: ");

            int id = ReadInt("Enter Item ID: ");

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            double price = ReadDouble("Enter Price: ");
            int quantity = ReadInt("Enter Quantity: ");

            StationeryItem item;

            switch (type)
            {
                case 1:
                    Console.Write("Enter Ink Color: ");
                    string inkColor = Console.ReadLine();
                    Console.Write("Enter Pen Type: ");
                    string penType = Console.ReadLine();

                    item = new Pen
                    {
                        InkColor = inkColor,
                        PenType = penType
                    };
                    break;

                case 2:
                    int pages = ReadInt("Enter Number of Pages: ");
                    Console.Write("Enter Paper Type: ");
                    string paperType = Console.ReadLine();

                    item = new Notebook
                    {
                        Pages = pages,
                        PaperType = paperType
                    };
                    break;

                case 3:
                    Console.Write("Is it Permanent? (Y/N): ");
                    bool permanent = Console.ReadLine().Trim().Equals("Y", StringComparison.OrdinalIgnoreCase);

                    item = new Marker
                    {
                        Permanent = permanent
                    };
                    break;

                default:
                    Console.WriteLine("\nInvalid item type selected.");
                    return;
            }

            item.ItemId = id;
            item.ItemName = name;
            item.Category = category;
            item.Brand = brand;
            item.Price = price;
            item.Quantity = quantity;

            store.AddItem(item);
        }

        // SEARCH
static void SearchItem()
{
    Console.WriteLine("\nSearch By:");
    Console.WriteLine("1. ID");
    Console.WriteLine("2. Name");

    int choice = ReadInt("Enter choice: ");

    StationeryItem item = null;

    switch (choice)
    {
        case 1:
            int id = ReadInt("Enter Item ID: ");
            item = store.SearchById(id);
            break;

        case 2:
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Item name cannot be empty.");
                return;
            }

            item = store.SearchByName(name);
            break;

        default:
            Console.WriteLine("Invalid choice.");
            return;
    }

    if (item != null)
    {
        Console.WriteLine("\nItem Found:");
        item.DisplayDetails();
    }
    else
    {
        Console.WriteLine("Item not found.");
    }
}

//  UPDATE 
static void UpdateItem()
{
    int id = ReadInt("Enter Item ID to Update: ");

    StationeryItem item = store.SearchById(id);

    if (item == null)
    {
        Console.WriteLine("Item not found.");
        return;
    }

    double newPrice = ReadDouble("Enter New Price: ");
    int newQuantity = ReadInt("Enter New Quantity: ");

    Console.Write("Enter New Brand: ");
    string newBrand = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(newBrand))
    {
        Console.WriteLine("Brand cannot be empty.");
        return;
    }

    store.UpdateItem(id, newPrice, newQuantity, newBrand);
    Console.WriteLine("Item updated successfully.");
}

// DELETE 
static void DeleteItem()
{
    int id = ReadInt("Enter Item ID to Delete: ");

    StationeryItem item = store.SearchById(id);

    if (item == null)
    {
        Console.WriteLine("Item not found.");
        return;
    }

    store.DeleteItem(id);
    Console.WriteLine("Item deleted successfully.");
}

//  PURCHASE 
static void PurchaseItem()
{
    int id = ReadInt("Enter Item ID to Purchase: ");
    int qty = ReadInt("Enter Quantity to Purchase: ");

    if (qty <= 0)
    {
        Console.WriteLine("Quantity must be greater than zero.");
        return;
    }

    StationeryItem item = store.SearchById(id);

    if (item == null)
    {
        Console.WriteLine("Item not found.");
        return;
    }

    store.PurchaseItem(id, qty);
}

//  INPUT HELPERS 
static int ReadInt(string prompt)
{
    int value;

    while (true)
    {
        Console.Write(prompt);

        if (int.TryParse(Console.ReadLine(), out value))
            return value;

        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

static double ReadDouble(string prompt)
{
    double value;

    while (true)
    {
        Console.Write(prompt);

        if (double.TryParse(Console.ReadLine(), out value))
            return value;

        Console.WriteLine("Invalid input. Please enter a valid decimal number.");
    }
}







     

