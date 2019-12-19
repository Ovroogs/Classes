using static System.Console;

namespace Classes
{
    class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age { get; set; }
        protected string Gender { get; set; }

        public Person(int age, string lastName)
        {
            Age = age;
            LastName = lastName;
        }
        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }
        public Person()
        {
            
        }

        public virtual void SayHello()
        {
            WriteLine($"Привет меня зовут {FirstName}, мне {Age} лет");
        }
    }
}