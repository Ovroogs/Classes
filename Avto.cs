using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Classes
{
    class Avto
    {
        private string Number;
        private double maxAmountOfFuel;
        private double amountOfFuel;
        private double amountOfFuelPer100;

        public Avto()
        {
            SetInfo();
            Clear();
            GetInfo();
        }

        public void SetInfo()
        {
            bool b = true;
            do
            {
                WriteLine("\nВведите номер машины:");
                string str = ReadLine();
                if (!Regex.IsMatch(str, @"[A-Za-z]{1}\d{3}[A-Za-z]{1}") || Regex.IsMatch(str, @"[А-Яа-я]{1}\d{3}[А-Яа-я]{1}"))
                {
                    Warning("Номер введён неверно. Примеры: А234АА, р564Еа...");
                    continue;
                }
                Number = str;
                b = false;
            } while (b);

            b = true;
            do
            {
                WriteLine("Введите максимальное количество топлива в баке ");
                if (!double.TryParse(ReadLine(), out maxAmountOfFuel) && maxAmountOfFuel > 0)
                {
                    Warning("Вводите только неотрицательные числа...", $"Номер машины: {Number}\n");
                    continue;
                }
                b = false;
            } while (b);

            b = true;
            do
            {
                WriteLine("Введите расход топлива на 100км");
                if (!double.TryParse(ReadLine(), out amountOfFuelPer100) && amountOfFuelPer100 > 0)
                {
                    Warning("Вводите только неотрицательные числа...", $"Номер машины: {Number}, максимальное количество топлива в баке: {maxAmountOfFuel}\n");
                    continue;
                }
                b = false;
            } while (b);

            b = true;
            do
            {
                WriteLine("Введите текущее количество топлива в баке");
                if (!double.TryParse(ReadLine(), out amountOfFuel) && amountOfFuel > 0)
                {
                    Warning("Вводите только неотрицательные числа...", $"Номер машины: {Number}, максимальное количество топлива в баке: {maxAmountOfFuel}, " +
                           $"расход топлива на 100км: {amountOfFuelPer100}\n");
                    continue;
                }

                if(amountOfFuel > maxAmountOfFuel)
                {
                    Warning("Текущее количество топлива должно быть не больше максимального возможного", 
                           $"Номер машины: {Number}, максимальное количество топлива в баке: {maxAmountOfFuel}, " +
                           $"расход топлива на 100км: {amountOfFuelPer100}\n");
                    continue;
                }
                b = false;
            } while (b);
            Clear();
        }

        private void Warning(string message)
        {
            WriteLine(message);
            ReadKey();
            Clear();
        }
        private void Warning(string message, string str)
        {
            WriteLine(message);
            ReadKey();
            Clear();
            Write(str);
        }

        public void GetInfo()
        {
            WriteLine($"Номер машины: {Number}, количество топлива в баке: {amountOfFuel}, " +
                      $"максимальное количество топлива в баке: {maxAmountOfFuel}, расход топлива на 100км: {amountOfFuelPer100}");
        }

        public void FuelCalculation()
        {
            bool b = true;
            double ikm;
            do
            {
                WriteLine("Введите количество км, которое надо проехать");
                if (!double.TryParse(ReadLine(), out ikm) && ikm > 0)
                {
                    Warning("Вводите только неотрицательные числа...");
                    continue;
                }
                b = false;
            } while (b);

            amountOfFuel -= amountOfFuelPer100 / 100 * ikm ;

            if (amountOfFuel < 0)
            {
                int count = 0;
                while (amountOfFuel < 0)
                {
                    FillTheCar();
                    count++;
                }
                WriteLine($"Вы проедите это расстояние, заправившись {count} раз, останется топлива: {Math.Round(amountOfFuel)}");
            }
            else
            {
                WriteLine($"Вы проедите это расстояние без заправок, останется топлива: {amountOfFuel}");
            }
        }

        public void FillTheCar() 
        {
            amountOfFuel += maxAmountOfFuel;
        }
    }
}