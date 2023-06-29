using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    internal class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get;set; }
        public string LastName { get;set; }

        //Interface Implementation
        public virtual void Quit()
        {
            Console.WriteLine("Employee has quit the company.");
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
