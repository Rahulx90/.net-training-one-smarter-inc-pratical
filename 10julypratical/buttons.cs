using System;

class Buttons
{
    public event Action Click;

    public void Press(){
     Console.WriteLine("Button Pressed");
        Click?.Invoke();
    }
} 
