using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class NalogCar : User
    {
        public NalogCar(string firstName, string lastName, string patronymic, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Number = number;
        }

        public void TaxCalculation()
        {
            foreach (var item in Cars)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}