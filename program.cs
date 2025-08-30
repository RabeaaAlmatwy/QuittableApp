using System;

namespace QuittableApp
{
    // Define an interface called IQuittable
    // This interface requires implementing a method called Quit with no return value (void)
    interface IQuittable
    {
        void Quit();
    }

    // Define a class called Employee that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Properties for the Employee class (optional, for demonstration)
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // This method could include cleanup, logging, etc.
            // For now, it just writes a message to the console
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // The Program class contains the Main method, which is the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and set its properties
            Employee emp = new Employee() { FirstName = "Jane", LastName = "Doe" };

            // Use polymorphism to assign the Employee object to a variable of type IQuittable
            IQuittable quittable = emp;

            // Call the Quit method using the IQuittable reference
            quittable.Quit();

            // Keep the console window open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
