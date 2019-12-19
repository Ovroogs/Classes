using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class User
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Patronymic { get; set; }
        protected string Number { get; set; }

        protected Dictionary<string, Dictionary<int, int>> Cars { get; set; }
        protected Dictionary<string, Dictionary<int, int>> TheProperty { get; set; }

        public User(string firstName, string lastName, string patronymic, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;

            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                Number += random.Next(10);
            }
        }

        public User(string firstName, string lastName, string patronymic)
        {

        }

        public User()
        {

        }


    }
}