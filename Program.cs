using System.IO;
using static System.Console;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            //Person person1 = new Person(606, "Bob", "Bob");
            ////Person person2 = new Person();
            //Person person3 = new Person(1, "Боб");

            ////person2.firstName = "Alice";
            //person3.FirstName = "Дима";

            //person1.Gender = "боевой Боб";
            ////person2.gender = "женщина";
            //person3.Gender = "боевой виртолит";

            //WriteLine($"Имя:{person1.FirstName} Гендер:{person1.Gender} Лет:{person1.Age} Фамилия:{person1.LastName}");
            ////WriteLine($"Имя:{person2.firstName} Гендер:{person2.gender}");
            //WriteLine($"Имя:{person3.FirstName} Гендер:{person3.Gender} Лет:{person3.Age} Фамилия:{person3.LastName}");

            //***********************************************************************************************************//

            //Game game1 = new Game();
            //Game game2 = new Game("Heroes of Might and Magic III", "пошаговая стратегия, ролевая игра", "New World Computing", 1999);

            //game1.GetInfo();
            //game2.GetInfo();

            //***********************************************************************************************************//

            //Avto avto = new Avto();

            //avto.FuelCalculation();

            //***********************************************************************************************************//

            //Person person = new Person(18, "Дима", "Жуков");
            //Employee employee = new Employee(50, "Bob", "Bob");

            //person.SayHello();
            //employee.SayHello();
            //employee.Experience();

            //***********************************************************************************************************//

            FileInfo fileInf = new FileInfo(@"Users.txt");
            if (!fileInf.Exists)
                fileInf.Create();

            WriteLine("Выберите пункт:\n1.Авторизация\n2.Регистрация");

            byte b;
            while (true)
            {
                if (byte.TryParse(ReadLine(), out b))
                    if (b == 1 || b == 2)
                        break;
            }

            if (b == 1)
            {
                WriteLine("Введите ваш номер пользователя");
                if (true)
                {

                }
            }
            else
            {
                string fName, lName, p;
                List<string> cars;
                List<int> hp, cost;
                Write("Введите вашу фамилию: ");
                lName = ReadLine();
                Write("Введите ваше имя: ");
                fName = ReadLine();
                Write("Введите ваше отчество: ");
                p = ReadLine();


            }
            

            ReadKey();
        }
    }
}