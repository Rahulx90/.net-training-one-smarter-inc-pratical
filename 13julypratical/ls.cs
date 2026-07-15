//l - liskow substitution principle 
//a derived class should able to replace its base class 
//without changing programs correctness

class Bird
{
    public void Fly()
    {
        Console.WriteLine("flyingg");

    }

}
class penguin : Bird
{
    public override void Fly()
    {
      throw new Exception("cnt fly");    
    }
    
}