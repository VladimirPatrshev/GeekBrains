using System;

namespace anketa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя");
            string n = Console.ReadLine(); // n - name

            Console.WriteLine("Введите фамилию");
            string s = Console.ReadLine(); // s - familiya

            Console.WriteLine("Введите возраст");
            int a = Convert.ToInt32( Console.ReadLine()); // a - vozrast

            Console.WriteLine("Введите рост");
            int h = Convert.ToInt32( Console.ReadLine()); // h - rost

            Console.WriteLine("Введите вес");
            int w = Convert.ToInt32( Console.ReadLine()); // w - ves

           Console.WriteLine("Выберите вариант вывода данных");

            int i =Convert.ToInt32( Console.ReadLine());

            switch (i)
            {

                case 1:
                    Console.WriteLine(n + s + a + h + w);
                    break;

               case 2:

                    Console.WriteLine("Имя:{0}   Фамилия:{1}    Возраст:{2}   Рост:{3}   Вес:{4}", n, s, a, h, w);
                    break;
               case 3:

                  Console.WriteLine($"Имя:{n}");
                  Console.WriteLine($"Фамилия:{s}");
                  Console.WriteLine($"Возраст:{a}");
                  Console.WriteLine($"Рост:{h}");
                  Console.WriteLine($"Вес:{w}");
                  break;
            }

            Console.Write("Press Any Key");
            Console.Read();
        }
        }
}

namespace anketa
{


    class IMT
    {
        static void Main()
        {

            double m, h;


            Console.WriteLine("Введите вес");

            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост");

            h = Convert.ToDouble(Console.ReadLine());


            double I = m / (h * h);

            Console.WriteLine("Индекс массы:{0}", I.ToString("0.00000"));

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}