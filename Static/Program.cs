using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Employee e1 = new Employee("Sonam",40000);
            //    Employee e2 = new Employee("Jayesh", 50000);


            //    e1.CalculateSalary();
            //    e2.CalculateSalary();

            //    Console.WriteLine(Employee.GetCount());

            //    Console.WriteLine(e1.GetEmployeeDetails());
            //    Console.WriteLine(e2.GetEmployeeDetails());
            //}



            //Overloading obj = new Overloading();
            //int calculation1 = obj.Addition(50, 60);
            //int calculation2 = obj.Addition(50, 60, 70);
            //double calculation3 = obj.Addition(50.12, 89.36);

            //int calculation4 = obj.Subtraction(50, 60);
            //int calculation5 = obj.Subtraction(50, 60, 70);
            //double calculation6 = obj.Subtraction(50.12, 89.36, 46.36);


            //int calculation7 = obj.Multiplication(50, 60);
            //int calculation8 = obj.Multiplication(50, 60, 70);
            //double calculation9 = obj.Multiplication(50.12, 89.36);


            //Console.WriteLine($"Addition:{calculation1}\n");
            //Console.WriteLine($"Addition:{calculation2}\n");

            //Console.WriteLine($"Addition{calculation3}\n");

            //Console.WriteLine($"Subtraction:{calculation4}\n");

            //Console.WriteLine($"Subtraction:{calculation5}\n");

            //Console.WriteLine($"Subtraction:{calculation6}\n");

            //Console.WriteLine($"Multiplication:{calculation7}\n");

            //Console.WriteLine($"Multiplication:{calculation8}\n");

            //Console.WriteLine($"Multiplication:{calculation9}\n");








            SalesManager salesmanager = new SalesManager("Aakash", 45000, 2500);

            salesmanager.CalculateSalary();
            Console.WriteLine(salesmanager);

            Employee employee = new Employee("Sunita", 35000);
            employee.CalculateSalary();
            Console.WriteLine(employee);

            Ceo ceo = new Ceo("Sonam", 54000, 5000);

            ceo.CalculateSalary();
            Console.WriteLine(ceo);





        }
    }
}