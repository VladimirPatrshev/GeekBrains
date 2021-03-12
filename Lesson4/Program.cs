using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4
{
    class Program
    {
        class Massive
        {
            private int[] a;

            public Massive(int n, int elt) //n - обьем массива elt - элементы массива
            {
                a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = elt;
            }
            public Massive(int n, int Elt1, int step) // создание массива заданной размерности и шага
            {
                a = new int[n];
                a[0] = Elt1;
                for (int i = 0; i < n; i++)
                {
                    if (i != 0)
                        a[i] = a[i - 1] + step;
                }
            }
            public Massive(string filename) //читаем из файла массив
            {
                if (File.Exists(filename))
                {
                    string[] stream = File.ReadAllLines(filename);
                    a = new int[stream.Length];
                    for (int i = 0; i < stream.Length; i++)
                    {
                        a[i] = int.Parse(stream[i]);
                    }
                }
                else Console.WriteLine("Ахтунг!! Файла нема!!!");
            }
            public int Maximum //поиск максимального элемента
            {
                get
                {
                    int maximum = a[0];
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] > maximum) maximum = a[i];
                    }
                    return maximum;
                }

            }
            public int Sum //суммируем элементы массива
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        sum = sum + a[i];
                    }
                    return sum;
                }
            }
            public int ChanVal //меняем знак на противоположный
            {
                set
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = a[i] * -1;
                    }
                }
            }
            public int Multi //умножаем каждый эл-т на множитель
            {
                set
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = a[i] * value;
                    }
                }
            }
            public int Minimum
            {
                get
                {
                    int minimum = a[0];
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] < minimum) minimum = a[i];
                    }
                    return minimum;
                }
            }
            public int Pos // считаем кол-во положительных эл-тов
            {
                get
                {
                    int count = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] > 0) count++;
                    }
                    return count;
                }
            }
            public int MaxElt //считаем кол-во максимальных эл-тов
            {
                get
                {
                    int max = Maximum;
                    int count = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == max) count++;
                    }
                    return count;
                }
            }
            public override string ToString() // массив в представляем строку
            {
                string s = "";
                foreach (int v in a)
                {
                    s = s + v + " ";
                }
                return s;
            }
            public static void SaveToFile(int[] a, string filename) // пишем массив в файл
            {
                StreamWriter write = new StreamWriter(filename);
                write.Write(a.Length);
                for (int i = 0; i < a.Length; i++)
                {
                    write.WriteLine($"\n{a[i]}");
                }
                write.Close();
            }
            public static int[] LoadFile(string filename) //загружаем из файла массив
            {
                if (File.Exists(filename))
                {
                    StreamReader read = new StreamReader(filename);
                    string str = read.ReadLine();
                    int.TryParse(str, out int El);// нулевой элемент, это размерность массива
                    int[] a = new int[El];
                    for (int i = 0; i < El; i++)
                    {
                        int.TryParse(read.ReadLine(), out int dig);
                        a[i] = dig;
                    }
                    read.Close();
                    return a;
                }
                throw new Exception("Ахтунг!!Файла нема!!");
            }
        }
        class TwoMeasure
        {
            public int[,] a;

            public TwoMeasure(int n, int m) // генерация случайных чисел в массив
            {
                a = new int[n, m];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = random.Next();
                    }
                }
            }

            public TwoMeasure(string fileName) // читаем из файла
            {
                fileName = "// ...//" + fileName;
                string[] stream = new string[0];
                try
                {
                    stream = File.ReadAllLines(fileName);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файла нема в : " + fileName);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Обнаружено исключение: " + ex.Message);
                }

                a = new int[stream.Length, stream.Length];

                for (int i = 0; i < stream.Length; i++)
                {
                    string[] tempArray = stream[i].Split(' ');
                    for (int j = 0; j < stream.Length; j++)
                    {
                        a[i, j] = int.Parse(tempArray[j]);
                    }
                }
            }

            public int Maximum // Находим максимальный элемент массива
            {
                get
                {
                    int max = a[0, 0];
                    for (int i = 0; i < a.GetLength(0); i++)
                        for (int j = 0; j < a.GetLength(1); j++)
                            if (a[i, j] > max)
                                max = a[i, j];
                    return max;
                }
            }

            public void Sum(out long sum) // Находим сумму элементов массива
            {
                sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum += a[i, j];
            }

            public void NumberMax(out string index)  //Находим номер максимального элемента массива
            {
                index = "-1, -1";
                int max = Maximum;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] == max)
                            index = i + ", " + j;
            }

            public void SumMore(out long sum, int min) //Находим сумму элементов больше заданного
            {
                sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > min)
                            sum += a[i, j];
                    }
            }

            public int Minimum  //Находим минимальный элемент массива
            {
                get
                {
                    int min = a[0, 0];
                    for (int i = 0; i < a.GetLength(0); i++)
                        for (int j = 0; j < a.GetLength(1); j++)
                            if (a[i, j] < min)
                                min = a[i, j];

                    return min;
                }
            }

            public string[] toString() //Выводим массив в строку
            {
                string[] s = new string[a.GetLength(0)];

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    s[i] += "[ ";
                    for (int j = 0; j < a.GetLength(1); j++)
                        s[i] += String.Format($"{a[i, j]:D10} ");
                    s[i] += " ]";
                }

                return s;
            }

            public void OutPutTwoMeasure(string[] array) //Выводим двумерный массив
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            public void SaveFile(string filename) //Пишем двумерный массив в файл
            {
                try
                {
                    StreamWriter write = new StreamWriter(filename);
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                            write.Write(a[i, j] + " ");

                        write.Write(Environment.NewLine);
                    }
                    write.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файла нема в : " + filename);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Обнаружено исключение: " + ex.Message);
                }
            }

            public void LoadFile(string filename) // Загружаем двумерный массив из файла
            {
                try
                {
                    StreamReader stream = new StreamReader(filename);
                    
                    int N = 4;
                    a = new int[N, N];

                    for (int i = 0; i < N; i++)
                    {
                        string[] tempArray = stream.ReadLine().Split(' ');
                        for (int j = 0; j < tempArray.Length-1; j++)
                        {
                            a[i, j] = int.Parse(tempArray[j]);
                        }
                    }

                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файла нема в : " + filename);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Обнаружено исключение: " + ex.Message);
                }

            }
            public void LoadFile2(string filename) // Загружаем двумерный массив из файла
            {
                try
                {
                    StreamReader stream = new StreamReader(filename);

                    int N = 3;
                    a = new int[N, N];

                    for (int i = 0; i < N; i++)
                    {
                        string[] tempArray = stream.ReadLine().Split(' ');
                        for (int j = 0; j < tempArray.Length; j++)
                        {
                            a[i, j] = Convert.ToChar(tempArray[j]);
                        }
                    }

                    stream.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файла нема в : " + filename);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Обнаружено исключение: " + ex.Message);
                }

            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания ");
                Console.WriteLine("Для выхода введите 0");
                Console.WriteLine("Задача 1 - введите 1");
                Console.WriteLine("Задача 2 - введите 2");
                Console.WriteLine("Задача 3 - введите 3");
                Console.WriteLine("Задача 4 - введите 4");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;

                    case 1:
                        #region Task1
                        Console.WriteLine("Дан  целочисленный  массив  из 20 элементов.\n " +
                            "Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.\n Заполнить случайными числами.\n" +
                            "Написать программу, позволяющую найти и вывести количество пар элементов массива,\n в которых только одно число делится на 3.\n" +
                            "В данной задаче под парой подразумевается два подряд идущих элемента массива.\n" +
                            "Патрушев\n");

                        int i;
                        int count = 0;
                        Random rnd = new Random();
                        int[] x = new int[20];
                        for (i = 0; i < 20; i++)
                        {
                            x[i] = rnd.Next(-10000, 10000);
                            Console.WriteLine(x[i] + " ");
                        }

                        for (i = 0; i < 19; i++)
                        {

                            if (x[i] % 3 == 0 || x[i + 1] % 3 == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Количество пар = {count}");


                        Console.ReadKey();
                        Console.Clear();
                        break;
                    #endregion
                    case 2:
                        #region Task2
                        Console.WriteLine("а) Дописать класс для работы с одномерным массивом." +
                        "Реализовать конструктор, создающий массив заданной размерности и\n заполняющий массив числами от начального значения с заданным шагом.\n" +
                        "Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,\n меняющий знаки у всех элементов массива, метод Multi," +
                        "умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. \n" +
                        "В Main продемонстрировать работу класса.\n " +
                        "б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл." +
                        "\nПатрушев\n");
                        Console.WriteLine("Для вариант а) введите 1\n");
                        Console.WriteLine("Для вариант б) введите 2\n");
                        int punkt = int.Parse(Console.ReadLine());

                        switch (punkt)
                        {
                            case 1:
                                Console.WriteLine("Введите размер массива");
                                int size = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите первый элемент массива");
                                int Elt1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите шаг изменения массива");
                                int step = int.Parse(Console.ReadLine());

                                Massive a = new Massive(size, Elt1, step);

                                Console.WriteLine($"Создан массив: {a}");

                                Console.WriteLine($"Сумма эл-тов ={a.Sum}");

                                a.ChanVal = -1;
                                Console.WriteLine($"Массив с другим знаком: {a}");

                                Console.WriteLine("Введите множитель массива");
                                a.Multi = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Массив умноженный на Ваш множитель {a}");

                                Console.WriteLine($"Максимальный член массива: {a.Maximum}");

                                Console.WriteLine($"Кол-во максимальных членов массива: {a.MaxElt}");

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Далее массив будет считан из файла\n");

                                int[] array = Massive.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "Array.txt");

                                for (int y = 0; y < array.Length; y++)
                                {
                                    Console.WriteLine($"{array[y]}");
                                }
                                Console.ReadKey();

                                Console.WriteLine("Массив будет сохранен в файл");
                                Massive.SaveToFile(array, AppDomain.CurrentDomain.BaseDirectory + "ArraySave.txt");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    #endregion

                    #region Task 3
                    case 3:

                        Console.WriteLine("Решить задачу с логинами из предыдущего урока,\n" +
                            "только логины и пароли считать из файла в массив.\n" +
                            "Создайте структуру Account, содержащую Login и Password.\n" +
                            "Патрушев\n");


                        var pass = new TwoMeasure(4,4);
                        pass.LoadFile2(AppDomain.CurrentDomain.BaseDirectory + "Pass.txt");



                        Console.WriteLine($"{ pass.toString()}");


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
                        string pass0 = "GeekBrains";
                        string login0 = "root";

                        Authorization(pass0, login0);

                        int pop = 3;

                        Console.WriteLine("Пройдите регистрацию");

                        Console.WriteLine("Введите логин");
                        string login1 = Console.ReadLine();
                        Console.WriteLine("Введите пароль");
                        string pass1 = Console.ReadLine();
                        Console.WriteLine("Спасибо за регистрацию, теперь выполните вход");

                        #endregion
                        break;

                    case 4:
                        #region Task4
                        Console.WriteLine(" *а) Реализовать класс для работы с двумерным массивом. " +
                            "Реализовать конструктор, заполняющий массив случайными числами.\n " +
                            "Создать методы, которые возвращают сумму всех элементов массива,\n" +
                            "сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива,\n" +
                            "свойство, возвращающее максимальный элемент массива,\n" +
                            "метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)\n" +
                            "* б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.\n" +
                            "Патрушев\n");

                        Console.WriteLine("Для вариант а) введите 1\n");
                        Console.WriteLine("Для вариант б) введите 2\n");
                        int punkt2 = int.Parse(Console.ReadLine());

                        switch (punkt2)
                        {
                            case 1:
                                Console.Write("Введите количество строк массива: ");
                                int size1 = int.Parse(Console.ReadLine());
                                Console.Write("Введите количество столбцов массива: ");
                                int size2 = int.Parse(Console.ReadLine());

                                TwoMeasure twoarray = new TwoMeasure(size1, size2);

                                Console.WriteLine("\nСоздан массив: ");
                                twoarray.OutPutTwoMeasure (twoarray.toString());
                                long sum = 0;
                                twoarray.Sum(out sum);

                                Console.WriteLine($"Сумма элементов массива: {sum}");

                                twoarray.SumMore(out sum, twoarray.a[0, 0]);
                                Console.WriteLine($"Cумма элементов массива, которые больше, первого элемента: {sum}");

                                Console.WriteLine($"Максимальный элемент массива: {twoarray.Maximum}");

                                Console.WriteLine($"Минимальный элемент массива: {twoarray.Minimum}");

                                string numMax = "";
                                twoarray.NumberMax(out numMax);
                                Console.WriteLine($"Номер максимального элемента: {numMax}");

                                break;

                            case 2:

                                var newTwoArray = new TwoMeasure(4, 4);
                                newTwoArray.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "TwoArray.txt");

                                for (int y = 0; y < newTwoArray.a.GetLength(0); y++)
                                {
                                    for (int j = 0; j < newTwoArray.a.GetLength(1); j++)
                                    {
                                        Console.Write($"{newTwoArray.a[y, j]} ");
                                    }
                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                newTwoArray.SaveFile(AppDomain.CurrentDomain.BaseDirectory + "TwoArraySave.txt");
                                Console.WriteLine("\nМассив сохранен в файл ");

                                Console.ReadKey();
                                Console.Clear();

                                break;
                                
                        }
                                Console.ReadKey();
                                Console.Clear();
                        break;

                    #endregion

                    default:
                        Console.WriteLine("Задача не найдена");
                        break;



                        Console.ReadKey();
                        Console.Clear();
                }
            }
        }
    }
}