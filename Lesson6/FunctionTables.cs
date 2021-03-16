using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public delegate double Funсtion(double a, double x);

    public class FunctionTables
    {
        // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
        // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
        public static void Table(Funсtion F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        //Метод возвращает значение функции a*x^2
        public static double MyFunction(double a, double x)
        {
            return a * x * x;
        }

        //Метод возвращает значение функции a*sin(x);
        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
