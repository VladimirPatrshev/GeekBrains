using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class StudentMethods
    {
        public static bool IsLastCourse(Student student)
        {
            if (student.course == 6)
                return true;

            return false;
        }

        public static bool IsCityMoscow(Student student)
        {
            if (student.city == "Москва")
                return true;

            return false;
        }

        public static bool IsCityMinsk(Student student)
        {
            if (student.city == "Минск")
                return true;

            return false;
        }

        public static bool IsUniverBNTY(Student student)
        {
            if (student.university == "БНТУ")
                return true;

            return false;
        }

        public static bool IsFirsCourse(Student student)
        {
            if (student.course == 1)
                return true;

            return false;
        }
    }
}

