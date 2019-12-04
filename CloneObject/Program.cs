using System;
using System.Text;

namespace CloneObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee { Name = "John Doe", Age = 30, Type = EmployeeType.Fulltime, Signature = Encoding.UTF8.GetBytes("John Doe") };
            PrintEmployee(employee1);

            Console.WriteLine("Update name of employee1Copy to Jenny Doe, and print Employeee1 and Employee1Copy");
            var employee1Copy = employee1;
            employee1Copy.Name = "Jenny Doe";
            PrintEmployee(employee1);
            PrintEmployee(employee1Copy);

            Console.WriteLine("Copy Employee1 using MemberWiseClone to Emploee1Clone, update Name to johny Doe and print Employee1 and employee1Clone");
            var employee1Clone = employee1.Copy();
            employee1Clone.Name = "Johny Doe";
            employee1Clone.Age = 16;
            PrintEmployee(employee1);
            PrintEmployee(employee1Clone);
        }

        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Employe Type: {employee.Type}, Signature: {Convert.ToBase64String(employee.Signature)}, Is Adult: {employee.IsAdult().ToString()}");
        }
    }
}
