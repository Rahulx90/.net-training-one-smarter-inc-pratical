using System;

public class Employee
{
    public int Id {get;set;}
    public string EmpName {get;set;}
    public double MonthySalary {get;set;}
    public Employee(int i,string e,double s)
    {
        Id =i;
        EmpName = e ;
        MonthySalary =s;

    }
    double CalculateAnnualSalary()
    {
        return MonthySalary = 12;
    }
    public void Display()
    {
        Console.WriteLine("Id :" +Id);
        Console.WriteLine("Name : "+EmpName);
        Console.WriteLine("Monthly : "+ MonthySalary);
        Console.WriteLine("Annual : "+  CalculateAnnualSalary());
    }

}