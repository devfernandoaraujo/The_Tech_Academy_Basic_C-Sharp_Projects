using Final_Assignment.Models;

namespace Final_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In order to run this program, you need to run the following commands. 

            //Click on Package Manager Console 

            //Run the commands beloww 
            //Enable-Migrations
            //Add-Migration InitialCreate
            //Update-Database

            using (var context = new SchoolContext())
            {

                //Generating a student object
                var student = new Student
                {
                    FirstName = "John Doe",
                    LastName ="Doe",
                    Email="john.doe@gmail.com",
                    Phone="558-938-1987"

                };

                //Adding the student in the table 
                context.Students.Add(student);
                context.SaveChanges();

                System.Console.WriteLine("Student saved to the database.");

                // Display all students from the database
                foreach (var s in context.Students)
                {
                    System.Console.WriteLine(s);
                }
            }

            Console.ReadLine();
        }

    }
}