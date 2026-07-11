using System;

class Genericseg
{
    void Printt(int number)
    {
        Console.WriteLine(number);
    }

    void Printt1(string namee)
    {
        Console.WriteLine(namee);
    }
}

// Generics - write one class or method that works with different data types

public class Genericseg<T>
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}