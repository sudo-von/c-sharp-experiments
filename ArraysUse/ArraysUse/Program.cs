using System;

namespace ArraysUse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit array.
            var strings = new[]{"Sudo","VoN"};
            var numbers = new[] { 15, 28, 35, 75.5, 30.30 }; // Casting all to double.
            // Objects array.
            Employee[] employees = new Employee[2];
            employees[0] = new Employee("Sudo", 24);
            employees[1] = new Employee("Von", 24);
            // Anonymous classes array.
            var people = new[]
            {
                new{Name="Sudo", Age=24},
                new{Name="Von", Age=24},
                new{Name="Sphinx", Age=30}
            };
        }
    }

    class Employee
    {
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string name;
        public int age;
    }
}
