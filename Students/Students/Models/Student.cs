using System.ComponentModel.DataAnnotations;

namespace Students.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "ФИО студента")]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Адрес студента")]
        [EmailAddress]
        public string MailAddress { get; set; }
    }
}