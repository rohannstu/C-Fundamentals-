
class CallByRef
{
    static void Main()
    {
        Employee emp1 = new()
        {
            EmployeeID = 1001,
            Name = "James"
        };

        Employee emp2 = emp1;

        emp1.Name = "Smith";

        Console.WriteLine($"Emp1 Name = {emp1.Name}");
        Console.WriteLine($"Emp2 Name = {emp2.Name}");
    }
}

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; } = string.Empty;
}
