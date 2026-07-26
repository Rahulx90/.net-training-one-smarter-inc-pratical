using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        PermanentEmployee emp1 = new PermanentEmployee
        {
            EmployeeId = 101,
            Name = "Rahul",
            Department = "Development"
        };
        emp1.SetLeaveBalance();
        employees.Add(emp1);

        ContractEmployee emp2 = new ContractEmployee
        {
            EmployeeId = 102,
            Name = "Om",
            Department = "Testing"
        };
        emp2.SetLeaveBalance();
        employees.Add(emp2);

        PermanentEmployee emp3 = new PermanentEmployee
        {
            EmployeeId = 103,
            Name = "Ajay",
            Department = "Accounts"
        };
        emp3.SetLeaveBalance();
        employees.Add(emp3);

        ContractEmployee emp4 = new ContractEmployee
        {
            EmployeeId = 104,
            Name = "Sneha",
            Department = "Support"
        };
        emp4.SetLeaveBalance();
        employees.Add(emp4);

        Console.WriteLine("All Employees");

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        List<LeaveRequest> leaveList = new List<LeaveRequest>();

        leaveList.Add(new LeaveRequest
        {
            LeaveId = 1,
            EmployeeId = 101,
            NumberOfDays = 3,
            Reason = "Sick Leave"
        });

        leaveList.Add(new LeaveRequest
        {
            LeaveId = 2,
            EmployeeId = 103,
            NumberOfDays = 5,
            Reason = "Vacation"
        });

        leaveList.Add(new LeaveRequest
        {
            LeaveId = 3,
            EmployeeId = 102,
            NumberOfDays = 2,
            Reason = "Personal Reason"
        });

        Console.WriteLine("\nAll Leave Requests");

        foreach (LeaveRequest leave in leaveList)
        {
            leave.DisplayLeave();
        }

        Console.WriteLine("\nPermanent Employees");

        foreach (Employee emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }

        Console.WriteLine("\nEmployee with ID 103");

        Employee result = employees.Find(emp => emp.EmployeeId == 103);

        if (result != null)
        {
            result.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Employee Not Found");
        }

        Console.WriteLine("\nTotal Employees : " + employees.Count);
        Console.WriteLine("Total Leave Requests : " + leaveList.Count);
    }
}