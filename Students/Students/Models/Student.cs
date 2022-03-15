using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Students.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "ФИО студента")]
        public string Name { get; set; }

        [Display(Name = "АДрес студента")]
        public string MailAdress { get; set; }
    }
}