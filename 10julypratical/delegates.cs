// // func - return an values
 using System;

// // built in delegate func
//  Func<int, int, int> add = (a, b) => a + b;
//  Console.WriteLine(add(588,756));

delegate void MessageDelegate(string msg);

class Delegateeg
{
    static MessageDelegate m ;
    static void Display(string message)
    {
        Console.WriteLine("Method1 : "+message);
    }
     static void Display1(string message)
    {
        Console.WriteLine("Method2 : "+message);
    }
     static void Display2(string message)
    {
        Console.WriteLine("Method3: "+message);
    }


    static void Main()
    {
    //   m += Display; 
    //   m += Display1;
    //   m += Display2;

        MessageDelegate m = Display;
        m("Hello, i m learning dot net c#");
        Buttons bt = new Buttons();
        bt.Click +=() =>Console.WriteLine("Click event");
        bt.Press();
    }
}