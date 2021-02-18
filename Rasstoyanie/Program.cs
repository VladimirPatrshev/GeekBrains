using System;

namespace Rasstoyanie
{
    class Program
    {
        static void Line()
        {
            double x1, y1, x2, y2,r;

            Console.WriteLine("Введите координату x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние ={0}", r.ToString("0.00"));
        }
        static void Main()
        {
            Console.WriteLine("Введите вариант вывода");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:

            double x1, y1, x2, y2, r;

            Console.WriteLine("Введите координату x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние ={0}", r.ToString("0.00"));
            break;

                case 2:
                    Line();
                    break;
            }        
        }

    }
}
