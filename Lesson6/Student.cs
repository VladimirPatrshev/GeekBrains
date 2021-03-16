using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Student
    {
        //Переделать программу «Пример использования коллекций» для решения следующих задач:
        // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
        //в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        //д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.

        public string firstName;
        public string lastName;
        public string university;
        public int age;
        public int course;
        public string city;

        // Создаем конструктор
        public Student(string firstName, string lastName, string university, int age,
            int course, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.course = course;
            this.age = age;
            this.city = city;
        }
        public string Names()
        {
            return $"{lastName} {firstName}";
        }
    }
}
