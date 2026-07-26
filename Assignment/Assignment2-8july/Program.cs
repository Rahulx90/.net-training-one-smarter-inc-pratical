// Scenario array

// A company stores the monthly sales (in ₹) of 6 employees in an array.
//  Display all sales, calculate the total sales, average sales, highest sales, and lowest sales.

using System;

class Program
{
    static void Main()
    {
        int[] sales = { 25000, 40500, 18700, 52300, 33900, 47600 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        Console.WriteLine("Monthly Sales of Employees:");

        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": Rs. " + sales[i]);
            total = total + sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }

        double average = (double)total / sales.Length;

        Console.WriteLine("\nTotal Sales: Rs. " + total);
        Console.WriteLine("Average Sales: Rs. " + average);
        Console.WriteLine("Highest Sales: Rs. " + highest);
        Console.WriteLine("Lowest Sales: Rs. " + lowest);
    }
}


// Scenario list coln A library stores the names of available books in a List.
//  Display all books, add one new book, remove one old book, and display the updated list along 
// with the total number of books.





using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> books = new List<string>
        {
            "The Alchemist",
            "Wings of Fire",
            "Rich Dad Poor Dad",
            "The Da Vinci Code",
            "A Brief History of Time"
        };

        Console.WriteLine("Available Books:");
        foreach (string book in books)
        {
            Console.WriteLine("- " + book);
        }

        // Add a new book
        books.Add("Atomic Habits");

        // Remove an old book
        books.Remove("The Da Vinci Code");

        Console.WriteLine("\nUpdated List of Books:");
        foreach (string book in books)
        {
            Console.WriteLine("- " + book);
        }

        Console.WriteLine("\nTotal Number of Books: " + books.Count);
    }
}