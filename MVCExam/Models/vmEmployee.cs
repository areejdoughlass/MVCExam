using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Models
{
    public class vmEmployee
    {
        public Employee employee { set; get; }

        public List<Department> departments { set; get; }

        public List<Country> countries { set; get; }
    }
}
