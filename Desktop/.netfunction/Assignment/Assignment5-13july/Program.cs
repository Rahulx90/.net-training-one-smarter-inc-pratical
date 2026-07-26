using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Registration 
        // Enter Customer ID 
        // Enter Name 
       // Enter Email 
      // Enter Password 

        // Console.Write("Enter Customer ID: ");
        // int customerId = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter Name: ");
        // string customerName = Console.ReadLine();

        // Console.Write("Enter Email: ");
        // string customerEmail = Console.ReadLine();

        // Console.Write("Enter Password: ");
        // string customerPassword = Console.ReadLine();

        // Console.WriteLine("\nRegistration Successful");

        //   // Login
        // Console.WriteLine("\n----- Login -----");

        // bool isLoggedIn = false;

        // for (int attempt = 1; attempt <= 3; attempt++)
        // {
        //     Console.Write("Enter Email: ");
        //     string loginEmail = Console.ReadLine();

        //     Console.Write("Enter Password: ");
        //     string loginPassword = Console.ReadLine();

        //     if (loginEmail == customerEmail && loginPassword == customerPassword)
        //     {
        //         Console.WriteLine("Welcome " + customerName);
        //         isLoggedIn = true;
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid Email or Password");

        //         if (attempt < 3)
        //         {
        //             Console.WriteLine("Attempts Remaining: " + (3 - attempt));
        //         }
        //     }
        // }

        // if (!isLoggedIn)
        // {
        //     Console.WriteLine("Account Locked");
        // }

        //problem 2

        List<Product>products= new List<Product>();

        Console.Write("How many products do you want to add? ");
        int count = Convert.ToInt32(Console.ReadLine());

         for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"\nEnter Details of Product {i}");

            Product p = new Product();

            Console.Write("Enter Product ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
        }

        Console.WriteLine("\n----- Product List -----");

        foreach (Product p in products)
        {
            Console.WriteLine("Product ID   : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price        : " + p.Price);
            Console.WriteLine("Stock        : " + p.Stock);
            Console.WriteLine("---------------------------");
        }
          //problem 4
         // Search Product
        Console.Write("Enter product name to search: ");
         string searchName = Console.ReadLine() ?? "";

        bool found = false;

        foreach (Product p in products)
        {
            if (p.ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine($"Product Id   : {p.ProductId}");
                Console.WriteLine($"Product Name : {p.ProductName}");
                Console.WriteLine($"Price        : {p.Price}");
                Console.WriteLine($"Stock        : {p.Stock}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product Not Found");
        } 

        //problem 5

         List<CartItem> cart = new List<CartItem>();

            while (true)
            {
                Console.Write("\nEnter Product ID : ");
                int pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Quantity : ");
                int qty = Convert.ToInt32(Console.ReadLine());

                Product product = products.Find(x => x.ProductId == pid);

                if (product != null)
                {
                    if (product.Stock >= qty)
                    {
                        product.Stock -= qty;

                        CartItem item = new CartItem();

                        item.Product = product;
                        item.Quantity = qty;

                        cart.Add(item);

                        Console.WriteLine("Added to Cart");
                    }
                    else
                    {
                        Console.WriteLine("Stock Not Available");
                    }
                }
                else
                {
                    Console.WriteLine("Product Not Found");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to add another product?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                    break;
            }
              //problem
             // DISPLAY CART

               Console.WriteLine("\n========== CART ==========");

            decimal totalAmount = 0;

            foreach (CartItem item in cart)
            {
                Console.WriteLine($"{item.Product.ProductName} x {item.Quantity}");

                totalAmount += item.Product.Price * item.Quantity;
            }

            // ==========================
            // DISCOUNT
            // ==========================

            decimal discount = 0;

            if (totalAmount < 1000)
            {
                discount = 0;
            }
            else if (totalAmount >= 1000 && totalAmount < 5000)
            {
                discount = totalAmount * 0.10m;
            }
            else if (totalAmount >= 5000 && totalAmount < 10000)
            {
                discount = totalAmount * 0.20m;
            }
            else
            {
                discount = totalAmount * 0.30m;
            }

            decimal finalAmount = totalAmount - discount;

            Console.WriteLine("\n========== BILL ==========");

            Console.WriteLine($"Total Amount : {totalAmount}");
            Console.WriteLine($"Discount     : {discount}");
            Console.WriteLine($"Final Amount : {finalAmount}");

            // ==========================
            // PAYMENT
            // ==========================

            Console.WriteLine("\nChoose Payment Method");
            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Debit Card");
            Console.WriteLine("4. Cash On Delivery");

            int payment = Convert.ToInt32(Console.ReadLine());

            switch (payment)
            {
                case 1:
                    Console.WriteLine("Payment Successful through UPI");
                    break;

                case 2:
                    Console.WriteLine("Payment Successful through Credit Card");
                    break;

                case 3:
                    Console.WriteLine("Payment Successful through Debit Card");
                    break;

                case 4:
                    Console.WriteLine("Payment Successful through Cash On Delivery");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("\nThank You for Shopping.");
        }


    }







    

    

