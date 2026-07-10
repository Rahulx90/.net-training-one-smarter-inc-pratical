using System;


// Lambda Expression Examples


// Square of a number
Func<int, int> square = x => x * x;
Console.WriteLine("Square of 6 = " + square(6));

// Subtraction using Lambda
Func<int, int, int> subtract = (a, b) => a - b;
Console.WriteLine("10 - 50 = " + subtract(10, 50));

// Method Example
void SubtractMethod(int a, int b)
{
    int result = a - b;
    Console.WriteLine("50 - 20 = " + result);
}

SubtractMethod(50, 20);