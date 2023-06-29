using Polymorphism_Assignmen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    internal class Manager : Employee
    {
        //Overide of Quit method on Employee class
        public override void Quit()
        {
            Console.WriteLine("Manager has resigned from the company.");
        }
    }
}
