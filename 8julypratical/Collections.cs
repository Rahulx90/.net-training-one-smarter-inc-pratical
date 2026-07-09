//Collections - group of objects that can grow or shrink dynamically
// more flexible than array
// List - dynamic array, automatically incr or decr
// dictionary

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Collections
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("aryan");
        names.Add("aditya");
        names.Add("rahul");
        names.Add("ammar");
        names.Add("anshuman");
         foreach (String f in names)
        {
            Console.WriteLine(f);
        }
        List<Stud> st = new List<Stud>
        {
            new Stud{id=1,sname="rahul"},
            new Stud{id=2,sname="atharav"},

        };

        
    }
}