using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Models
{
    public class vmDepartment
    {
        public List<Department> department { set; get; }

        public List<Employee> employee { set; get; }
    }
}
