﻿class Program
{
    static void Main(String[] args)
    {
        int age = 20;
        Console.WriteLine("int: " + age);

        long population = 100000000L;
        Console.WriteLine("long: " + population);

        float percentage = 99.9f;
        Console.WriteLine("float: " + percentage);

        double pi = 3.1415;
        Console.WriteLine("double: " + pi);

        decimal salary = 50000.75m;
        Console.WriteLine("decimal: " + salary);

        char grade = 'A';
        Console.WriteLine("char: " + grade);

        string name = "rahul";
        Console.WriteLine("string: " + name);

        bool isStudent = true;
        Console.WriteLine("bool: " + isStudent);

        ConditionalStatment p = new ConditionalStatment();
        p.displayed();

    }

}

///conditanol 



using System;

class ConditionalStatment
{

    public void displayed()
    {
        int age = 20;
        int marks = 75;
        bool hasLicense = true;
        int day = 3;

        // 1. if
        Console.WriteLine("1. if Statement");
        if (age >= 18)
        {
            Console.WriteLine("Eligible to vote");
        }

        // 2. if-else
        Console.WriteLine("\n2. if-else Statement");
        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }

        // 3. if-else-if
        Console.WriteLine("\n3. if-else-if Statement");
        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }

        // 4. Nested if
        Console.WriteLine("\n4. Nested if Statement");
        if (age >= 18)
        {
            if (hasLicense)
            {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("Get a driving license");
            }
        }

        // 5. switch
        Console.WriteLine("\n5. Switch Statement");
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }




    }

}
