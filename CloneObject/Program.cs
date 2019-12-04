using System;
using System.Text;

namespace CloneObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee { Name = "John Doe", Age = 30, Type = EmployeeType.Fulltime, Signature = Encoding.UTF8.GetBytes("John Doe") };

            Console.WriteLine($"Name: {employee1.Name}, Age: {employee1.Age}, Employe Type: {employee1.Type}, Signature: {Convert.ToBase64String(employee1.Signature)}");
        }
    }
}
