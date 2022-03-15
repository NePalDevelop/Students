using System.Collections.Generic;

namespace Students.Models
{
    public static class InitStudents
    {
        public static List<Student> Students() {

            var students = new List<Student>
            {
               new Student { Id = 1, Name = "Иванов", MailAdress="stud1@yandex.ru" },
               new Student { Id = 2, Name = "Петров", MailAdress="stud2@yandex.ru" },
               new Student { Id = 3, Name = "Сидоров", MailAdress="stud3@yandex.ru" },
               new Student { Id = 4, Name = "Перельман", MailAdress="stud4@yandex.ru" },
               new Student { Id = 5, Name = "Капица", MailAdress="stud5@yandex.ru" },
               new Student { Id = 6, Name = "Ландау", MailAdress="stud6@yandex.ru" }
            };

            return students;
        }
    }
}