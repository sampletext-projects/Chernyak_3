using System;

namespace Chernyak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            Console.Write("Введите N: ");
            double n = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите X: ");
            double x = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите B0: ");
            double b0 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите Bk: ");
            double bk = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите dB: ");
            double db = double.Parse(Console.ReadLine().Replace(".", ","));
            for (double b = b0; b <= bk; b += db)
            {
                double divider = (x * x - Math.Sqrt(b));
                if (divider == 0)
                {
                    Console.WriteLine("Ошибка на {0} шаге. Знаменатель 0", divider);
                }
                else
                {
                    double T = 0.5 * x + Math.Cos(b) / divider + Math.Tan(n) * Math.Tan(n);
                    Console.WriteLine("T({0:0.00}) = {1:0.000}", b, T);
                }
            }

            Console.ReadKey(); //ожидание любой клавиши
        }
    }
}