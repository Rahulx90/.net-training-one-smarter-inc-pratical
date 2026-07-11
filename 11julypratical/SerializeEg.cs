
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class SerializeEg
{
    Employee e = new Employee(0101,"rahul",4500);
    string json = JsonSerializer.Serialize(0);
    Console.WriteLine(json);


    Employee e1  = JsonSerializer.Deserialize<Employee>(json);
    Console.WriteLine(e1.EmpName);
}
