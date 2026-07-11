//reffering the data from the file or write from the file

using System;
using System.IO;

public class FileHandling
{
    static void Main()
    {
        File.WriteAllText("emp.txt","Name: rahul");

        string data = File.ReadAllText("emp.txt");
        Console.WriteLine(data);
    }

}