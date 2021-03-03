using System;

namespace Module10
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            try
            { 
                Logger = new Logger();
                Calc calc = new Calc(Logger);

                calc.Sum();
            }
            catch(Exception)
            {
                Logger.Error("Данные заполнены неверно, рассчёт невозможен");
            }

            Console.ReadKey();
        }
    }
}
