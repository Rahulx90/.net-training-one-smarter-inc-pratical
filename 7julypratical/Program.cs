﻿//Problem 1 
// An automated conveyor belt processes 20 packages. Package IDs are generated from 1001 to 1020 using a loop.

// For each package:

// If the package ID is divisible by 4, it is marked as Quality Check Required.
// Else if the package ID is divisible by 5, it is marked as Priority Shipment.
// Otherwise, it is marked as Normal Processing.
// At the end of the program, display:

// Total packages processed
// Number of packages requiring quality check
// Number of priority shipments
// Number of normal packages

//Solution 1
using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int qualityCheck = 0;
        int priority = 0;
        int normal = 0;

        for (int id = 1001; id <= 1020; id++)
        {
            total++;

            if (id % 4 == 0)
            {
                qualityCheck++;
                Console.WriteLine("Package " + id + " - Quality Check Required");
            }
            else if (id % 5 == 0)
            {
                priority++;
                Console.WriteLine("Package " + id + " - Priority Shipment");
            }
            else
            {
                normal++;
                Console.WriteLine("Package " + id + " - Normal Processing");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total packages processed: " + total);
        Console.WriteLine("Quality check packages: " + qualityCheck);
        Console.WriteLine("Priority shipments: " + priority);
        Console.WriteLine("Normal packages: " + normal);
    }
}





// Problem 2
// A smart city has 30 street lights numbered 1 to 30. The power consumption (in watts) for each light is calculated using the formula:

// Power = 80 + (Light Number × 5)

// For each street light:

// If power consumption is greater than 180 W, display "Maintenance Required".
// Else if power consumption is between 140 W and 180 W, display "Normal Operation".
// Otherwise, display "Energy Efficient".
// Also calculate and display:

// Total power consumed by all street lights
// Average power consumption
// Number of lights in each category

using System;

class Program
{
    static void Main()
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int lightNumber = 1; lightNumber <= 30; lightNumber++)
        {
            int power = 80 + (lightNumber * 5);
            totalPower = totalPower + power;

            if (power > 180)
            {
                maintenance++;
                Console.WriteLine("Light " + lightNumber + ": " + power + " W -> Maintenance Required");
            }
            else if (power >= 140 && power <= 180)
            {
                normal++;
                Console.WriteLine("Light " + lightNumber + ": " + power + " W -> Normal Operation");
            }
            else
            {
                efficient++;
                Console.WriteLine("Light " + lightNumber + ": " + power + " W -> Energy Efficient");
            }
        }

        double averagePower = (double)totalPower / 30;

        Console.WriteLine();
        
        Console.WriteLine("Total power consumed: " + totalPower + " W");
        Console.WriteLine("Average power consumption: " + averagePower.ToString("F2") + " W");
        Console.WriteLine("Maintenance Required: " + maintenance + " lights");
        Console.WriteLine("Normal Operation: " + normal + " lights");
        Console.WriteLine("Energy Efficient: " + efficient + " lights");
    }
}