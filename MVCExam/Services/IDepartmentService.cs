using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Services
{
    public interface IDepartmentService
    {
        List<Department> LoadDepartments();
    }
}
