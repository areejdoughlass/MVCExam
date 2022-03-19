using Microsoft.AspNetCore.Mvc;
using MVCExam.Data;
using MVCExam.Models;
using MVCExam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExam.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService departmentService;
        IEmployeeService employeeService;

        public DepartmentController(IEmployeeService _employeeService, IDepartmentService _departmentService)
        {
            employeeService = _employeeService;
            departmentService = _departmentService;
        }
        public IActionResult Index()
        {
            vmDepartment vm = new vmDepartment();
            List<Department> liDepartment = departmentService.LoadDepartments();
            List<Employee> liEmployees = employeeService.LoadEmployee();
            vm.department = liDepartment;
            vm.employee = liEmployees;
            return View("Department", vm);
        }
    }
}
