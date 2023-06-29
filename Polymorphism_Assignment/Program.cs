using Polymorphism_Assignment;

//Instance of the Emplyees
Employee employee = new Employee { FirstName = "John", LastName="Lee", Id = 1 };
Manager manager = new Manager { FirstName = "Jane", LastName = "Mars", Id = 2 };

// Polymorphism example
IQuittable quittableEmployee = employee;
IQuittable quittableManager = manager;

quittableEmployee.Quit(); // Output: "Employee has quit the company."
quittableManager.Quit(); // Output: "Manager has resigned from the company."