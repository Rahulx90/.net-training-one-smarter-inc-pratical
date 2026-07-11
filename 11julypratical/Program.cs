using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Genericseg<int> n = new Genericseg<int>();
        n.Print(100);

        Genericseg<string> n1 = new Genericseg<string>();
        n1.Print("Mamta");

        Genericseg<double> n2 = new Genericseg<double>();
        n2.Print(100.25);
        
        List<Employee> employees = new List<Employee>();
        List<Manager> managers = new List<Manager>();
        while (true)
        {
            Console.WriteLine("welcome to Emp System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Manager");
            Console.WriteLine("3. view Employee");
            Console.WriteLine("4. view manager");
            Console.WriteLine("5. Search Employee by id");
            Console.WriteLine("6. Exit");

            Console.WriteLine("ENTER CHOICE 1-6");
            try
            {  
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    Console.Write("Enter Id: ");
                     int id = Convert.ToInt32(Console.ReadLine());
                     bool exists = false;
                     foreach (Employee emp in employees)
                        {
                            if(emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (exists)
                        {
                            Console.WriteLine("employee is already exists");
                            break;
                        }
                        Console.Write("enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("enter salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Employee employee = new Employee(id,name,salary);
                        
                        //add in collection
                        employees.Add(employee);
                        Console.WriteLine("employee added successfully");
                        break;
                    case 2:
    Console.Write("Enter Manager Id: ");
    int mid = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Name: ");
    string mname = Console.ReadLine()!;

    Console.Write("Enter Salary: ");
    double msalary = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Department: ");
    string mdept = Console.ReadLine()!;

    Console.Write("Enter Bonus: ");
    double mbonus = Convert.ToDouble(Console.ReadLine());

    Manager manager = new Manager(mid, mname, msalary, mdept, mbonus);

    managers.Add(manager);

    Console.WriteLine("Manager added successfully.");
    break;

                    case 3:

                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No Employees in System.");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }

                        break;

                     case 4:

                        if (managers.Count == 0)
                        {
                            Console.WriteLine("No namagers in System.");
                        }
                        else
                        {
                            foreach (Manager m in managers)
                            {
                                m.DisplayManager();
                            }
                        }

                        break;    

                    case 5:

                        Console.Write("Enter Employee Id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;

                    case 6:
                        Console.WriteLine("Thank You!");
                        return;   

                    


                }

            }
            catch (FormatException)
            {
                Console.WriteLine("please enter number only ");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

