using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Data
{
    public class Employee
    {
        public int ID { set; get; }

        [Required]
        public String Name { set; get; }

        [Required]
        public String Phone { set; get; }

        [Required]
        public String Email { set; get; }

        public DateTime BirthDate { set; get; }

        [ForeignKey ("country")]
        public int CountryId { set; get; }

        public Country country { set; get; }

        [ForeignKey("department")]
        public int DepartmentId { set; get; }

        public Department department { set; get; }

        public String Path { set; get; }

        [NotMapped]
        public IFormFile Image { set; get; }
    }
}
