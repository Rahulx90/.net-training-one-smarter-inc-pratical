//linq - langauge integrated query
// use to query collection like arrays.,list
// where (): filter data ,select (), orderBy(), orderByDescending()
//first(),count(),min(),max(),sum

using System;
using System.Linq;

class Linqeg
{
    static void Main(string[] args)
    {
        int[] numbers = { 8, 7, 6, 4, 1, 8, 7, 8, 3, 9 };

        var even = numbers.Where(x => x % 2 == 0);

        Console.WriteLine("Even Numbers:");

        foreach (var n in even)
        {
            Console.WriteLine(n);
        }
    }
}