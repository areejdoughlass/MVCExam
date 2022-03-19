using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Data
{
    [Table ("Departments")]
    public class Department
    {
        public int ID { set; get; }

        public String Name { set; get; }

        public double Minsalary { set; get; }

        public double MaxSalary { set; get; }

        public List<Employee> liEmployees { set; get; }
    }
}
