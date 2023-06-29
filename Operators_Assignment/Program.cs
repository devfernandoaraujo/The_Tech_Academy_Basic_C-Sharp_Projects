//Refering the Namespace where the class is located
using Operators_Assignment;

//List of Employees
Employee employee1 = new Employee { Id=1, FirstName="Fernando", LastName="Araujo"};
Employee employee2 = new Employee { Id = 2, FirstName = "Luiz", LastName = "Roxo" };
Employee employee3 = new Employee { Id = 1, FirstName = "Fernando", LastName = "Araujo" };

//Comaring Employees
Console.WriteLine("Is the Employee 1 equals the Employee 2? {0}", employee1 == employee2);
Console.WriteLine("Is the Employee 1 equals the Employee 3? {0}", employee1 == employee3);

Console.ReadLine();