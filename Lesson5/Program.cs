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
                Console.WriteLine("Задача 5 - введите 5");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;

                    case 1:
                        #region Task1
                        Console.WriteLine("Создать программу, которая будет проверять корректность ввода логина.\n" +
                            "Корректным логином будет строка от 2 до 10 символов,\n" +
                            "содержащая только буквы латинского алфавита или цифры,\n" +
                            "при этом цифра не может быть первой:\n" +
                            "а) без использования регулярных выражений;\n" +
                            "б) **с использованием регулярных выражений.\n" +
                            "Патрушев\n");

                        Console.WriteLine("Для вариант а) введите 1\n");
                        Console.WriteLine("Для вариант б) введите 2\n");

                        int punkt = int.Parse(Console.ReadLine());

                        switch (punkt)
                        {
                            case 1:

                                int dig=0;
                                int sum0 = 0;
                                int sum1 = 0;
                                string[] login = new string[10];
                                string[] pass = new string[10];

                                Console.WriteLine("Введите логин");
                                login[0] = Console.ReadLine();
                                Console.WriteLine("Введите пароль");
                                pass[0] = Console.ReadLine();

                                foreach (string s in pass)
                                {
                                    if (!(s.Length > 2 && s.Length < 10)) Console.WriteLine("Пароль слишком короткий");
                                    bool sucess = int.TryParse(s, out dig);
                                    if (sucess)
                                    {
                                        sum0++;
                                    }
                                    else Console.WriteLine("Пароль должен содержать хотя бы одну цифру");
                                } 
                                                                   
                                                                  
                                
                                if (sum0 > 0) Console.WriteLine("Пароль корректен");

                                if (login.Length>2 && login.Length < 10)
                                {
                                    Console.WriteLine("Логин слишком короткий");
                                }
                                else
                                {
                                    foreach (string s in login)
                                    {
                                        bool sucess = int.TryParse(s, out dig);
                                        if (sucess)
                                        {
                                            sum1++;
                                            if (sum1 > 0) Console.WriteLine("Логин корректен");
                                        }
                                        else Console.WriteLine("Логин должен содержать хотя бы одну цифру");
                                    }
                                    break;
                                }

                                break;
                                Console.ReadKey();
                                Console.Clear();


                            case 2:

                                break;

                        }                
                     Console.ReadKey();
                     Console.Clear();
                       break;

                    #endregion
                    case 2:
                        #region Task2
                        Console.WriteLine("Разработать статический класс Message,\n" +
                            "содержащий следующие статические методы для обработки текста:\n" +
                            "а) Вывести только те слова сообщения,  которые содержат не более n букв.\n" +
                            "б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n" +
                            "в) Найти самое длинное слово сообщения.\n" +
                            "г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n" +
                            "д) ***Создать метод, который производит частотный анализ текста." +
                            "В качестве параметра в него передается массив слов и текст,\n" +
                            "в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.\n" +
                            "Здесь требуется использовать класс Dictionary." +
                            "\nПатрушев\n");
                Console.WriteLine("Для вариант а) введите 1\n");
                Console.WriteLine("Для вариант б) введите 2\n");
                Console.WriteLine("Для вариант в) введите 3\n");
                Console.WriteLine("Для вариант г) введите 4\n");
                Console.WriteLine("Для вариант д) введите 5\n");
                int punkt2 = int.Parse(Console.ReadLine());

                switch (punkt2)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;
                }
                break;

                    #endregion

                    #region Task 3
                    case 3:

                        Console.WriteLine("*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой." +
                            "Например: badc являются перестановкой abcd. " +
                            "Патрушев\n");




                #endregion
                break;

                    case 4:
                        #region Task4
                        Console.WriteLine("*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.\n" +
                            "В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:\n" +
                            "< Фамилия > < Имя > < оценки >,где < Фамилия > — строка, состоящая не более чем из 20 символов,\n" +
                            "< Имя > — строка, состоящая не более чем из 15 символов, < оценки > — через пробел три целых числа,\n" +
                            "соответствующие оценкам по пятибалльной системе. < Фамилия > и<Имя>, а также < Имя > и < оценки > разделены одним пробелом.\n" +
                            "Пример входной строки:Иванов Петр 4 5 3\n" +
                            "Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.\n" +
                            "Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.\n" +
                            "Патрушев\n");

                Console.WriteLine("Для вариант а) введите 1\n");
                Console.WriteLine("Для вариант б) введите 2\n");
                int punkt3 = int.Parse(Console.ReadLine());

                switch (punkt3)
                {
                    case 1:


                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:


                        Console.ReadKey();
                        Console.Clear();

                        break;

                }
                Console.ReadKey();
                Console.Clear();
                break;
                    
                    case 5:
                        #region Task 5

                        Console.WriteLine("**Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет.\n" +
                            "Например: «Шариковую ручку изобрели в древнем Египте», «Да».\n" +
                            "Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.\n" +
                            "Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.\n" +
                            "Список вопросов ищите во вложении или воспользуйтесь интернетом.\n  " +
                            "Патрушев\n");





                break;
                #endregion

             
                    default:
                        Console.WriteLine("Задача не найдена");
                        break;
            
                        #endregion

                        Console.ReadKey();
                        Console.Clear();
                }
            }
        }
    }
}