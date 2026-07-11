using System;
using System.Threading.Tasks;

public class AsyncAwaitt
{
    static async Task Main()
    {
        Console.WriteLine("loading employee data details .....");
        await LoadEmployee();
        Console.WriteLine("completed");

    }
    static async Task LoadEmployee()
    {
        await Task.Delay(3000);
        Console.WriteLine("employee loaded");
    }

}