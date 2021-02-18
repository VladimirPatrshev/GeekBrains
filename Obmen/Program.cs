using System;

namespace Obmen
{
    class Program
    {
        static void Main()
        {
            double a, b;
            int i;
            
            Console.WriteLine("Введите а");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вариант вывода");
              i = Convert.ToInt32(Console.ReadLine());
            switch (i) 
                {


                case 1:
                    double c;
                    c = a;
                    a = b;
                    b = c;
                    Console.WriteLine("Значение a ={0} b ={1}", a,b);
                    break;
                case 2:
                    a = a +b ;
                    b = a - b;
                    a = a - b;
                    Console.WriteLine("Значение a={0} b ={1}" ,a,b);
                    break;
            }
            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
