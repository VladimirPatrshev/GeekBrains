using System;
using System.Collections.Generic;
using System.IO;
using static Lesson6.StudentConstants;
using static Lesson6.StudentMethods;

namespace Lesson6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task3();
        }
        static void Task1()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a*x^2:");

            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            FunctionTables.Table(new Funсtion(FunctionTables.MyFunction), -1.5, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            FunctionTables.Table(new Funсtion(FunctionTables.MyFunction), 3, -2, 2);

            Console.ReadKey();
            Console.Clear();
        }

        static void Task3()
        {
            int studentFiveCourse = 0;
            int studentSixCourse = 0;
            List<Student> studentList = new List<Student>();    // Создаем список студентов
                                                                // DateTime dt = DateTime.Now;
            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("..\\..\\Student6.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] studentSegments = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    studentList.Add(new Student(
                        studentSegments[FirstName]
                        , studentSegments[LastName]
                        , studentSegments[University]
                        , int.Parse(studentSegments[Age])
                        , int.Parse(studentSegments[Course])
                        , studentSegments[City]));

                    // Одновременно подсчитываем количество студентов пятого и шестого курсов
                    if (int.Parse(studentSegments[Course]) == 5)
                    {
                        studentFiveCourse++;
                    }
                    else if (int.Parse(studentSegments[Course]) == 6)
                    {
                        studentSixCourse++;
                    }

                    if (int.Parse(studentSegments[Age]) > 17 && int.Parse(studentSegments[Age]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(studentSegments[Course])))
                            cousreFrequency[int.Parse(studentSegments[Course])] += 1;
                        else
                            cousreFrequency.Add(int.Parse(studentSegments[Course]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов:" + studentList.Count);
            Console.WriteLine("Студентов пятого курса:{0}", studentFiveCourse);
            Console.WriteLine("Студентов шестого курса:{0}", studentSixCourse);
            Console.WriteLine("\nCтуденты в возрасте от 18 до 20 лет на каком курсе учатся.");
            ICollection<int> keys = cousreFrequency.Keys;
            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, cousreFrequency[key]);
            Console.WriteLine($"\n{result}");

            studentList.Sort(new Comparison<Student>(AgeCompare));
            Console.WriteLine("Отсортируем студентов по возрасту: ");
            foreach (var v in studentList) Console.WriteLine($"{v.firstName} {v.age}");

            studentList.Sort(new Comparison<Student>(CourceAndAgeCompare));
            Console.WriteLine("\nОтсортируем студентов по курсу и возрасту: ");
            foreach (var v in studentList) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Методы подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.");

            Console.WriteLine("\nСтуденты 1-го курса\n--------------");
            foreach (var student in studentList.FindAll(IsFirsCourse))
            {
                Console.WriteLine(student.Names());
            }

            Console.WriteLine("\nСтуденты последнего курса\n--------------");
            foreach (var student in studentList.FindAll(IsLastCourse))
            {
                Console.WriteLine(student.Names());
            }

            Console.WriteLine("\nСтуденты, которые учатся в БНТУ\n-------------- ");
            foreach (var student in studentList.FindAll(IsUniverBNTY))
            {
                Console.WriteLine(student.Names());

            }

            Console.WriteLine("\nCтуденты, которые учатся в Минске\n--------------");
            foreach (var student in studentList.FindAll(IsCityMinsk))
            {
                Console.WriteLine(student.Names());

            }

            Console.WriteLine("\nCтуденты, которые учатся в Москве\n--------------");
            foreach (var student in studentList.FindAll(IsCityMoscow))
            {
                Console.WriteLine(student.Names());

            }
            Console.ReadKey();
            Console.Clear();
        }

        static int AgeCompare(Student student1, Student student2)  // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(student1.age.ToString(), student2.age.ToString());    // Сравниваем две строки
        }

        static int CourceAndAgeCompare(Student student1, Student student2)
        {
            if (student1.course > student2.course)
                return 1;
            if (student1.course < student2.course)
                return -1;
            if (student1.age > student2.age)
                return 1;
            if (student1.age < student2.age)
                return -1;
            return 0;
        }

    }
}
