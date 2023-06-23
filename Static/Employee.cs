using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static
{
    public class Employee
    {
        /*Create a class Employee
        Accept name & basic salary from the constructor
        Class must auto generate the emp id using static

        Create method CalculateSalary() for salary calculation
        Hra 40% of bs
        Ta  20 % of bs
        Da  15 % of bs
        Pf  12 % of bs

        Calculate the total salary & Gross salary of employee

        Create Print method to display employee details
        Create static method to display total count of employee*/
        protected string employeeName;
        protected int employeeId;
        protected double employeeBasicSalary;
        protected double employeeGrossSalary,hra,ta,da,pf;
                private static int count =0;

        public Employee(string employeeName, int employeeBasicSalary )
        {
            count++;
            employeeId = count;
            this.employeeName = employeeName;
            this.employeeBasicSalary = employeeBasicSalary;
        }


        public virtual void CalculateSalary()// virtual keyword used to hide the base class implimentation
        {
            hra = employeeBasicSalary * 0.40;
            ta = employeeBasicSalary * 0.20;
            da = employeeBasicSalary * 0.15;
            pf = employeeBasicSalary * 0.12;
            employeeGrossSalary = (employeeBasicSalary + hra + ta + da) - pf;
           

        }
        public static int GetCount()
        {
            return count;
        }

        public override string ToString() //ToString() gives the string representation of the class
        {
            return $"\nEmployee Name:{employeeName}\nEmployee Id:{employeeId}\nEmployee Basic Salary:{employeeBasicSalary}\nEmployee Gross Salary:{employeeGrossSalary}";
        }
    }// Base class close
                                         //Employee is base class
    public class SalesManager :Employee //SalesManager is child class
    {
        private double comm;
        public SalesManager(string employeeName,int employeeBasicSalary,double comm):base(employeeName,employeeBasicSalary)// base keyword used to called base class members
        {
            this.comm = comm;
        }

        public override void CalculateSalary()//override keyword allow to invoking the function from base class(for polymorphism)
        {
            hra = employeeBasicSalary * 0.40;
            ta = employeeBasicSalary * 0.20;
            da = employeeBasicSalary * 0.15;
            pf = employeeBasicSalary * 0.12;
            employeeGrossSalary = (employeeBasicSalary + hra + ta + da+comm) - pf;


        }

    }
    public class Ceo: Employee
    {
        private double performanceBonus;
        public Ceo(string employeeName, int employeeBasicSalary,double performanceBonus):base(employeeName,employeeBasicSalary)
        {
            this.performanceBonus = performanceBonus;
        }

        public override void CalculateSalary()//override keyword allow to invoking the function from base class(for polymorphism)
        {
            hra = employeeBasicSalary * 0.40;
            ta = employeeBasicSalary * 0.20;
            da = employeeBasicSalary * 0.15;
            pf = employeeBasicSalary * 0.12;
            employeeGrossSalary = (employeeBasicSalary + hra + ta + da + performanceBonus) - pf;


        }
    }
}
