using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee : Person
    {
        public Employee(int age, string firstName, string lastName)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }
        public void Experience()
        {
            Console.WriteLine("Введите со скольки лет вы тут работаете:");
            int experience = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы работаете тут {Age - experience} лет");
        }
        public override void SayHello()
        {
            Console.WriteLine($"Я - {FirstName}, не мешай мне работать!");
        }
    }
}