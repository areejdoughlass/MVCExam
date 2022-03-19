using Microsoft.Extensions.Configuration;
using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Services
{
    public class DepartmentService : IDepartmentService
    {
        HRContext context;
        public DepartmentService(HRContext _context)
        {
            context = _context;
        }
        public List<Department> LoadDepartments()
        {
           List<Department> lidepartments =  context.department.ToList();
            return lidepartments;
        }
    }
}
