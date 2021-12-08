using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new[]
            {
                new { Name = "Sudo", Age = 24},
                new { Name = "VoN", Age = 24}
            };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"name: {people[i].Name} - age: {people[i].Age}");
            }

            foreach (var person in people)
            {
                Console.WriteLine($"name: {person.Name} - age: {person.Age}");
            }

        }
    }
}
