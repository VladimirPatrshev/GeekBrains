using System;

namespace Lesson3
{
    struct Fraction
    {
        public int m;
        public int n;

        public Fraction Plus(Fraction x)
        {
            Fraction y;
            y.m = m * x.n + n * x.m;
            y.n = n * x.n;
            return y;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction y;
            y.m = m * x.n - n * x.m;
            y.n = n * x.n;
            return y;
        }
        public Fraction Multi(Fraction x)
        {
            Fraction y;
            y.m = m * x.m;
            y.n = n * x.n;
            return y;
        }
        public Fraction Division(Fraction x)
        {
            Fraction y;
            y.m = m * x.n;
            y.n = n * x.m;
            return y;
        }
        public override string ToString()
        {
            return m + "/" + n;
        }
        
    }
    struct Complex
    {

        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }


    class Program
    {

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания ");
                Console.WriteLine("Для выхода введите 0");
                Console.WriteLine("Задача 1 - введите 1");
                Console.WriteLine("Задача 2 - введите 2");
                Console.WriteLine("Задача 3 - введите 3");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    
                    case 1:
                #region Task1
                        Console.WriteLine("а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.\n" + //не понял что значит продемонстрировать работу
                                          "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\n" + // не понял проверить работу класса
                                          "в) Добавить диалог с использованием switch демонстрирующий работу класса.\n Патрушев\n"); // совсем не понял что требуется

                        Console.WriteLine("Для выбора варианта:  а) - введите 1\n  Для выбора варианта б) - введите 2\n  Для выбора варианта в) - введите 3\n");
                        int punkt = int.Parse(Console.ReadLine());

                        switch (punkt)
                        {
                            case 1:

                                Complex complex1;
                                complex1.re = 1;
                                complex1.im = 1;

                                Complex complex2;
                                complex2.re = 2;
                                complex2.im = 2;

                                Console.WriteLine($"Первое комплексное число: {complex1.ToString()}");
                                Console.WriteLine($"Второе комплексное число: {complex2.ToString()}");

                                Complex result = complex1.Plus(complex2);
                                Console.WriteLine($"Результат сложения чисел: {result.ToString()}");
                                result = complex1.Multi(complex2);
                                Console.WriteLine($"Результат умножения чисел: {result.ToString()}");


                                break;
                            case 2:

                                Complex complex3;
                                complex3.re = 1;
                                complex3.im = 1;

                                Complex complex4;
                                complex4.re = 2;
                                complex4.im = 2;

                                Console.WriteLine($"Первое комплексное число: {complex3.ToString()}");
                                Console.WriteLine($"Второе комплексное число: {complex4.ToString()}");

                                Complex result1 = complex3.Minus(complex4);
                                Console.WriteLine($"Результат вычитания чисел: {result1.ToString()}");
                                result1 = complex3.Multi(complex4);
                                Console.WriteLine($"Результат умножения чисел: {result1.ToString()}");
                                break;
                            case 3:
                                Console.WriteLine("Не понял, что требуется...");
                                break;
                        }
                        return;
                    #endregion

                    
                    case 2:
                #region Task2
                        Console.WriteLine("С клавиатуры вводятся ЧИСЛА, пока не будет введён 0 (каждое число в новой строке).\n " +
                            "Требуется подсчитать сумму всех нечётных положительных чисел.\n Сами числа и сумму вывести на экран, используя tryParse.\n Патрушев\n");

                        
                        
                            int s = 0;
                            Console.WriteLine("Введите число");
                            int a;
                            bool sucess = int.TryParse(Console.ReadLine(), out a);
                        if (sucess)
                        {
                            while (a != 0)
                            {
                                if (a > 0 && a % 2 != 0)
                                {
                                    s = s + a;
                                    Console.WriteLine("Введите следующее число, по окончании введите 0");
                                    bool sucess1 = int.TryParse(Console.ReadLine(), out a);
                                    if (sucess1)
                                        Console.WriteLine($"Введенное число = {a}, преобразование удалось");
                                    else
                                    {
                                        Console.WriteLine($"Преобразование не удалось");
                                        goto case 2;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Введите следующее число");
                                    bool sucess2 = int.TryParse(Console.ReadLine(), out a);
                                    if (sucess2) Console.WriteLine();
                                    else goto case 2;

                                }
                                Console.WriteLine($"Сумма нечетных положительных чисел ={s}");

                            }
                        }
                        else goto case 2;

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion

                    #region Task 3
                    case 3:

                        Console.WriteLine("1) *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.\n " +
                            "Предусмотреть методы сложения, вычитания, умножения и деления дробей.\n" +
                            "Написать программу, демонстрирующую все разработанные элементы класса.\n " +
                            "* Добавить свойства типа int для доступа к числителю и знаменателю;\n" +
                            "* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;\n" +
                            "** Добавить проверку, чтобы знаменатель не равнялся 0.\n" +
                            "Выбрасывать исключение ArgumentException('Знаменатель не может быть равен 0');\n" +
                            "***Добавить упрощение дробей.\n " +
                            "Патрушев\n");
                        Console.WriteLine("Для выбора решения условий задачи введите:\n 1 - *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.\n" +
                            " 2 - Предусмотреть методы сложения, вычитания, умножения и деления дробей.\n" +
                           // " * Добавить свойства типа int для доступа к числителю и знаменателю\n" уже реализовано
                            //" 3 - * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа\n" убрали из дз, но как сделать все равно не понял
                            " 4 - ** Добавить проверку, чтобы знаменатель не равнялся 0\n" +
                            "     Выбрасывать исключение ArgumentException('Знаменатель не может быть равен 0')\n" +
                            " 5 - ***Добавить упрощение дробей.\n");
                        int Text = int.Parse(Console.ReadLine());

                        switch (Text)
                        {
                            case 1:
                                Console.WriteLine("Введите числитель");
                                int numerator = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите знаменатель");
                                int denominator = int.Parse(Console.ReadLine());

                                Fraction fraction1;
                                fraction1.m = numerator;
                                fraction1.n = denominator;

                                Console.WriteLine($"Ваша дробь выглядит вот так : {fraction1.ToString()}");

                                break;

                            case 2:
                                Console.WriteLine("Введите числитель первой дроби");
                                int numerator2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите знаменатель первой дроби");
                                int denominator2 = int.Parse(Console.ReadLine());

                                Fraction fraction2;
                                fraction2.m = numerator2;
                                fraction2.n = denominator2;
                                Console.WriteLine($"Первая дробь {fraction2.ToString()}");


                                Console.WriteLine("Введите числитель второй дроби");
                                int numerator3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите знаменатель второй дроби");
                                int denominator3 = int.Parse(Console.ReadLine());

                                Fraction fraction3;
                                fraction3.m = numerator3;
                                fraction3.n = denominator3;
                                Console.WriteLine($"Вторая дробь {fraction3.ToString()}");

                                
                                Fraction result = fraction2.Plus(fraction3);
                                Console.WriteLine($"Результат сложения дробей = {result.ToString()}");

                                Fraction result1 = fraction2.Minus(fraction3);
                                Console.WriteLine($"Результат вычитания дробей = {result1.ToString()}");

                                Fraction result2 = fraction2.Multi(fraction3);
                                Console.WriteLine($"Результат умножения дробей = {result2.ToString()}");

                                Fraction result3 = fraction2.Division(fraction3);
                                Console.WriteLine($"Результат деления дробей = {result3.ToString()}");


                                break;

                            case 3:
                                //Console.WriteLine("Введите числитель первой дроби");
                                //int numerator4 = int.Parse(Console.ReadLine());
                                //Console.WriteLine("Введите знаменатель первой дроби");
                                //int denominator4 = int.Parse(Console.ReadLine());

                                //Fraction fraction4;
                                //fraction4.m = numerator4;
                                //fraction4.n = denominator4;
                                //Console.WriteLine($"Первая дробь {fraction4.ToString()}");


                                //Console.WriteLine("Введите числитель второй дроби");
                                //int numerator5 = int.Parse(Console.ReadLine());
                                //Console.WriteLine("Введите знаменатель второй дроби");
                                //int denominator5 = int.Parse(Console.ReadLine());

                                //Fraction fraction5;
                                //fraction5.m = numerator5;
                                //fraction5.n = denominator5;
                                //Console.WriteLine($"Вторая дробь {fraction5.ToString()}");

                                //Fraction result4 = fraction4.Plus(fraction5);
                                //Console.WriteLine($"Результат сложения дробей = {result4}");

                                //Console.WriteLine($"Числитель равен {result4.m}");
                                //int DecM =int.Parse( Console.ReadLine());

                                //Console.WriteLine($"Знаменатель равен {result4.n}");
                                //int DecN = int.Parse(Console.ReadLine());

                                //double Dec = DecM / DecN;
                                //Console.WriteLine($"{Dec}");

                               // Fraction result5 = fraction4.Minus(fraction5);
                              //  Console.WriteLine($"Результат вычитания дробей = {result5.ToString()}");
                               // double Dec1 = Convert.ToDouble(result5);
                             //   Console.WriteLine($"{Dec1}");

                              //  Fraction result6 = fraction4.Multi(fraction5);
                              //  Console.WriteLine($"Результат умножения дробей = {result6.ToString()}");
                             //   double Dec2 = Convert.ToDouble(result6);
                             //   Console.WriteLine($"{Dec2}");

                               // Fraction result7 = fraction4.Division(fraction5);
                               // Console.WriteLine($"Результат деления дробей = {result7.ToString()}");
                              //  double Dec3 = Convert.ToDouble(result7);
                               // Console.WriteLine($"{Dec3}");


                                break;

                            case 4:
                                Console.WriteLine("Введите числитель дроби");
                                int numerator6 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите знаменатель дроби");
                                int denominator6 =int.Parse(Console.ReadLine());
                                
                                if (denominator6 !=0)
                                {
                                    Fraction fraction6;
                                    fraction6.m = numerator6;
                                    fraction6.n = denominator6;
                                    Console.WriteLine($"Вы ввели дробь {fraction6}");
                                }
                                else
                                {
                                    Console.WriteLine("Знаменатель не может быть равен 0!");
                                    goto case 4;
                                }
                                    break;

                            case 5:
                                Console.WriteLine("Введите числитель неправильной дроби");
                                int numerator4 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите знаменатель дроби");
                                int denominator4 = int.Parse(Console.ReadLine());

                                if (numerator4 > denominator4)
                                {
                                    int whole = numerator4 / denominator4;
                                    int numerator5 = numerator4 - denominator4;

                                    Fraction fraction4;
                                    fraction4.m = numerator5;
                                    fraction4.n = denominator4;
                                    Console.WriteLine($"Правильная дробь {whole}+{fraction4.ToString()}");

                                }
                                    break;
                           
                        }

                        break;

                    default:
                        Console.WriteLine("Задача не найдена");
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
            #endregion
        }
    }
}
