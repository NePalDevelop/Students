using System.Collections.Generic;

namespace Students.Models
{
    public static class InitStudents
    {
        public static List<Student> _students = new List<Student>
            {
               new Student { Id = 1, Name = "Иванов", MailAddress="stud1@yandex.ru" },
               new Student { Id = 2, Name = "Петров", MailAddress="stud2@yandex.ru" },
               new Student { Id = 3, Name = "Сидоров", MailAddress="stud3@yandex.ru" },
               new Student { Id = 4, Name = "Перельман", MailAddress="stud4@yandex.ru" },
               new Student { Id = 5, Name = "Капица", MailAddress="stud5@yandex.ru" },
               new Student { Id = 6, Name = "Ландау", MailAddress="stud6@yandex.ru" }
            };
    }
}