//O - Open/Closed Principle
//Software should be open for extension but closed for modification

class OC
{
    public void Process(Payment p)
    {
        p.Pay();
    }

    static void Main()
    {
        OC c = new OC();
        c.Process(new CreditCard());
    }
}