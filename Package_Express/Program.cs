using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pkWeight = 0;
            decimal pkWidth = 0;
            decimal pkHeight = 0;
            decimal pkLength = 0;
            decimal deliveryAmount = 0;

            try
            {
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
                Console.WriteLine("Please enter the package weight:");
                
                //The the Weight of the box prompet by the user
                pkWeight = Convert.ToDecimal(Console.ReadLine());
                if (pkWeight > 50)
                    throw new Exception("Package too heavy to be shipped via Package Express. Have a good day.");

                Console.WriteLine("Please enter the package width:");
               
                //The the Width of the box prompet by the user
                pkWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                
                //The the Height of the box prompet by the user
                pkHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
               
                //The the length of the box prompet by the user
                pkLength = Convert.ToDecimal(Console.ReadLine());

                //Check it the dimensions of the box it too big
                if (pkWidth > 50 || pkHeight > 50 || pkLength > 50)
                    throw new Exception("Package too big to be shipped via Package Express.");

              
                //Calculate the delivery price
                deliveryAmount = (pkWidth * pkHeight * pkLength * pkWeight) / 100;

                //Estimation of delivery price
                Console.WriteLine(String.Format("Your estimated total for shipping this package is: ${0:0.00}", deliveryAmount));
                Console.WriteLine("Thank you!");

                //Wait for the user iteration to close the program
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                //Validation errors 
                Console.WriteLine("Error: {0}", ex.Message);
                Console.ReadLine();
            }
            







        }
    }
}
