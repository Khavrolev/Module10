using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public class Calc : ICalc
    {
        ILogger Logger { get; }
        private double a = 0;
        private double b = 0;

        public Calc(ILogger logger)
        {
            int counter = 3;
            Logger = logger;

            try
            {
                do
                {
                    if (counter == 0)
                        throw new Exception();

                    Logger.Event($"Введите первое число, у вас осталось {counter} попыток");
                    counter--;
                } while (!Double.TryParse(Console.ReadLine(), out a));

                counter = 3;

                do
                {
                    if (counter == 0)
                        throw new Exception();

                    Logger.Event($"Введите второе число, у вас осталось {counter} попыток");
                    counter--;
                } while (!Double.TryParse(Console.ReadLine(), out b));
            }
            catch (Exception)
            {
                Logger.Error($"Вы исчерпали попытки ввода чисел!");
                throw;
            }
        }

        public double Sum()
        {
            Logger.Event($"Начат расчёт суммы {a} и {b}");
            double result =  a + b;
            Logger.Event($"Сумма - {result}");
            return result;
        }
    }
}