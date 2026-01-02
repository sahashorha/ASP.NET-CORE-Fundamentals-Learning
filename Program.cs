// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Employee
{
    public Employee()
    {
        // Constructor same name is class name excuted when object is called or executed 
    }
    public int _experience; /// variable or you say this is property
    public int Experience { get; set; }
    public void CalculateSalary()
    {
        int salary = _experience * 300000;
        Console.WriteLine("Salary= {0} ",salary);
    }
}


public class program 
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Experience = 3;
        employee.CalculateSalary();
        Console.ReadLine();
    }
}


