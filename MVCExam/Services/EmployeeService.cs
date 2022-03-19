using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Services
{
    public class EmployeeService : IEmployeeService
    {
        HRContext context;
        public EmployeeService(HRContext _context)
        {
            context = _context;
        }

        public void InsertRecord(Employee employee)
        {            
            context.employee.Add(employee);
            context.SaveChanges();
        }

        public List<Employee> LoadEmployee()
        {
            List<Employee> liemployees = context.employee.ToList();
            return liemployees;
        }
    }
}
