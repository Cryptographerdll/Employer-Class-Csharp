using System;

namespace EmployerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a class called Employee that includes three pieces of information as either instance variables or automatic properties—a first name (type string), a last name (type
            string) and a monthly salary (decimal). Your class should have a constructor that initializes the three values. 
            Provide a property with a get and set accessor for any instance variables.
            If the monthly salary is negative, the set accessor should leave the instance variable unchanged.
            Write a test app
            named EmployeeTest that demonstrates class Employee’s capabilities. Create two Employee objects and display each object’s yearly salary. 
            Then give each Employee a 10% raise and display each Employee’s yearly salary again.
             */

            // Creating Our Employer Object .

            Employee employer1 = new Employee("khalid", "amini", (decimal)17100);
            Employee employer2 = new Employee("John", "Pickman", (decimal)45000);

            // Emp1

            Console.WriteLine("Emploeyer1 firstname: {0}", employer1.Name);
            Console.WriteLine("Emploeyer1 lastName: {0}", employer1.LastName);
            Console.WriteLine("Emploeyer1 salary: {0} $\n", employer1.salaire);

            // Emp2

            Console.WriteLine("Emploeyer2 firstname: {0}", employer2.Name);
            Console.WriteLine("Emploeyer2 lastName: {0}", employer2.LastName);
            Console.WriteLine("Emploeyer2 salary: {0} $", employer2.salaire);

            Console.WriteLine();
            Console.WriteLine("After raise of 10% ");

            employer1.salaire = employer1.salaire * (decimal)1.1;
            employer2.salaire = employer2.salaire * (decimal)1.1;

            // New Salary 

            Console.WriteLine("the New salary after Rais 10% {0} $", employer1.salaire);
            Console.WriteLine("the New salary after Rais 10% {0} $", employer2.salaire);

            Console.ReadLine();

        }
    }
}
