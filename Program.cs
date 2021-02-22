using System;

namespace Lesson2
{
    class Program
    {
        
        // Задача 1. 
        // для запуска введите 1
        // Написать метод, возвращающий минимальное из трех чисел.
        // Патрушев
        static void Min()
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > b && b> c && a>c)
            {
                Console.WriteLine("Минимальное число - c = {0}", c);
            }
            else if (a > b && c > b && a > b)
            {
                Console.WriteLine("Минимальное число - b = {0}", b);
            }
            else if (c > a && c > b && b > a)
            {
                Console.WriteLine("Минимальное число - a = {0}", a);
            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine("Минимальное число - c = {0}", c);
            }
                    }
        // Задача 2.
        // для запуска введите 2
        // Написать метод подсчета количества цифр числа.
        // Патрушев
        static void Digits()
        {
            
            Console.WriteLine("Введите число");
            string dig = Console.ReadLine();
            int L = dig.Length;
                        
            Console.WriteLine("Количество цифр ={0}", L);
        }
        // Задача 3.
        // для запуска введите 3
        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех
        // нечетных положительных чисел.
        // Патрушев
        static void Summ()
        {
            int s = 0;
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 2 != 0)
                {
                    s = s + a;
                    Console.WriteLine("Введите следующее число, по окончании введите 0");
                    a = int.Parse(Console.ReadLine());
                   
                }
                else
                {
                    Console.WriteLine("Введите следующее число");
                    a = int.Parse(Console.ReadLine());
                   
                }
                Console.WriteLine("Сумма нечетных положительных чисел ={0}",s);
            }
        }
        // Задача 4.
        // Реализовать метод проверки логина и пароля. 
        // а) На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
        // и ложь, если не прошел (Логин: root, Password: GeekBrains).
        // для запуска введите 4
        // б) Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
        // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        // для запуска введите 5
        // Патрушев
        static void Authorization(string pass0, string login0)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string pass = Console.ReadLine();

            if (pass == pass0 && login == login0)
            {
                Console.WriteLine("Спасибо за авторизацию");
            }
            else
            {
                Console.WriteLine("Неправильный логин и пароль");
            }
        }
        // Задача 5.
        // для запуска введите 6
        // Задача решена с выполнением сразу всех вариантов и а) и б)
        // а) Написать программу, которая запрашивает массу и рост человека, 
        // вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        // Патрушев

        // Задача 6.
        // для запуска введите 7
        // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        // «Хорошим» называется число, которое делится на сумму своих цифр. 
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        // Патрушев
        
        // Задача 7.
        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        // для запуска введите 8
        // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        // для запуска введите 9
        // Патрушев
        static void Loop(int a, int b)
        {
            Console.WriteLine("{0,4} ", a);
            if (a < b) Loop(a + 1, b);
        }
        static void LoopSum(int a1, int b1,int s)
        {

            if (a1 < b1 + 1)
            {
                LoopSum(a1 + 1, b1,s+a1);
            }
            else Console.WriteLine("Сумма чисел от начального до конечного = {0}",s);
        }


        static void Main()
        {
            Console.WriteLine("Введите номер задания");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    #region Task1
                    Min();

                    Console.ReadLine();
                    Console.Clear();
                    break;
                #endregion
                case 2:
                    #region Task2

                    Digits();

                    Console.ReadLine();
                    Console.Clear();
                    break;
                #endregion
                case 3:
                    #region Task 3

                    Summ();

                    Console.ReadLine();
                    Console.Clear();
                    break;
                #endregion
                case 4:
                    #region Task 4a
                    string pass0 = "GeekBrains";
                    string login0 = "root";

                    Authorization(pass0,login0);

                    Console.ReadLine();
                    Console.Clear();
                break;
                #endregion

                case 5:
                    #region Task 4b

                    int pop = 3;
                    
                    Console.WriteLine("Пройдите регистрацию");

                    Console.WriteLine("Введите логин");
                    string login1 = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    string pass1 = Console.ReadLine();
                    Console.WriteLine("Спасибо за регистрацию, теперь выполните вход");

                                      
                        Console.WriteLine("У Вас {0} попытки ", pop);
                        do
                        {
                            Authorization(pass1, login1);
                            --pop;
                        if (pop > 0)
                            Console.WriteLine("У Вас осталось {0} попытки ", pop);
                        else Console.WriteLine("Попробуйте позже");
                        }
                        while (pop > 0);
                    
                    Console.ReadLine();
                    Console.Clear();
                break;



                #endregion

                case 6:
                    #region Task 5

                    Console.WriteLine("Введите вес");

                    double m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите рост в сантиметрах");

                    double h = Convert.ToDouble(Console.ReadLine());

                    double I = m / (h * h)*10000;

                    double norm = h - (100+(h-100)/20);
                    Console.WriteLine("Для Вас нормальный вес составляет: {0} кг",norm);
                    
                    // можно сделать и  switch в зависимости от I, но не понял как сделать в режиме region
                    Console.WriteLine("Индекс массы:{0}", I.ToString("00.00"));
                    if (I < 16)
                    {
                        Console.WriteLine("Выраженный дефицит массы тела");
                        double bal = norm - m;
                        Console.WriteLine("Вам надо набрать {0} кг",bal);
                    }
                    else if (16 < I && I < 18.5)
                    {
                        Console.WriteLine("Дефицит массы тела");
                        double bal = norm - m;
                        Console.WriteLine("Вам надо набрать {0} кг", bal);
                    }
                    else if (18.5 < I && I < 25)
                    {
                        Console.WriteLine("Норма");
                    }
                    else if (25 < I && I < 30)
                    {
                        Console.WriteLine("Избыточная масса тела(предожирение)");
                        double bal = m - norm;
                        Console.WriteLine("Вам надо сбросить {0} кг", bal);
                    }
                    else if (I < 30 && I < 35)
                    {
                        Console.WriteLine("Ожирение");
                        double bal = m - norm;
                        Console.WriteLine("Вам надо сбросить {0} кг", bal);
                    }
                    else if (I < 35 && I < 40)
                    {
                        Console.WriteLine("Резкое ожирение");
                        double bal = m - norm;
                        Console.WriteLine("Вам надо сбросить {0} кг", bal);
                    }
                    else if (I > 40)
                    {
                        Console.WriteLine("Очень резкое ожирение"); double bal = m - norm;
                        Console.WriteLine("Вам надо сбросить {0} кг", bal);
                    }
                     
                    
                    Console.ReadLine();
                    Console.Clear();
            break;
                #endregion

                case 7:
                    #region Task 6
                    DateTime start = DateTime.Now;
                    System.Threading.Thread.Sleep(20);

                    static int NumberSum(int n)
                    {
                        int s = 0;
                        while (n != 0)
                        {
                            s = s + n % 10;
                            n = n / 10;
                        }
                        return s;
                    }

                    static bool Div(int n,int i)
                    {
                        return i % n == 0;
                    }

                    int count = 0;
                    
                   for (int i =1; i <= 1000000000; i++)
                    {
                        int sc = NumberSum(i);
                        
                        if (Div(sc,i))
                        {
                            count = ++count;
                        }
                    }
                   
                    Console.WriteLine("Количество чисел = {0}",count);

                    DateTime finish = DateTime.Now;

                    Console.WriteLine(finish - start);

                    Console.ReadLine();
                    Console.Clear();
            break;
                #endregion

                case 8:
                    #region Task 7a

                    Console.WriteLine("Введите начальное число");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите конечное число");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Loop(a, b);
                    
                    Console.ReadLine();
                    Console.Clear();
                break;
                #endregion
                case 9:
                    #region Task 7b
                    int s=0;
                    Console.WriteLine("Введите начальное число");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите конечное число");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    
                    LoopSum(a1, b1,s);

                    
                    Console.ReadLine();
                    Console.Clear();
                break;
                    #endregion

            }

        }

    }
}
