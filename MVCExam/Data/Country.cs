using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { set; get; }

        public String Name { set; get; }

        public List<Employee> liEmployees { set; get; }
    }
}
