using System;

namespace IMT
{
    class Program
    {
        static void Main()
        {

            double m,h;
                

            Console.WriteLine("Введите вес");

          m = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Введите рост");

            h = Convert.ToDouble(Console.ReadLine());
            

           double I = m / (h * h);

           Console.WriteLine("Индекс массы:{0}", I.ToString("0.00000"));

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
