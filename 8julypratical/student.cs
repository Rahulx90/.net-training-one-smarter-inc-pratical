//class is a logical entity which is used to represent real world entities. It is a blueprint of an object. It contains data members and member functions. Data members are the properties of the class and member functions are the behaviors of the class.
//stores values of similar data
//eg. electronics, home appl, stationary, etc

using System;

public class Asign{

    public int rollno;
    public string name;
    public string institute;
    public long dob;
    public string branch;
    public char gender;
    public float height;

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollno);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Institute: " + institute);
        Console.WriteLine("Date of Birth: " + dob);
        Console.WriteLine("Branch: " + branch);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Height: " + height);
    }
}


// we are creating a class object here
class Student
{
    static void Main()
    {
        Asign s1 = new Asign();

        s1.rollno = 101;
        s1.name = "rahul paghrut ";
        s1.institute = "SSGMCE";
        s1.dob = 24/06/2005;
        s1.branch = "cse";
        s1.gender = 'M';
        s1.height = 5.8f;

        s1.Display();
    }
}