Console.WriteLine("Hello, World!");

Employee employee1 = new Employee();
employee1.name = "John";
employee1.id = "123";
employee1.salary = 40000;
employee1.email = "john@gmail.com";
employee1.Work();
double employee1Salary = employee1.GetSalary();

Console.WriteLine(employee1.name);
Console.WriteLine(employee1.GetSalary());
