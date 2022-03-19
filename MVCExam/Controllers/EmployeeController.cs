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
    public class EmployeeController : Controller
    {

        IDepartmentService departmentService;
        IEmployeeService employeeService;
        ICountryService countryService;

        public EmployeeController(IEmployeeService _employeeService, IDepartmentService _departmentService, ICountryService _countryService)
        {
            employeeService = _employeeService;
            departmentService = _departmentService;
            countryService = _countryService;
        }
        public IActionResult Index()
        {
            vmEmployee vm = new vmEmployee();
            List<Department> liDepartment = departmentService.LoadDepartments();
            List<Country> liCountries = countryService.LoadCountries();
            vm.departments = liDepartment;
            vm.countries = liCountries;
            return View("NewEmployee",vm);
        }

        public IActionResult SaveEmployee(vmEmployee vm)
        {            
            List<Department> liDepartment = departmentService.LoadDepartments();
            List<Country> liCountries = countryService.LoadCountries();
            vm.departments = liDepartment;
            vm.countries = liCountries;
            employeeService.InsertRecord(vm.employee);
            return View("NewEmployee", vm);
        }
    }
}
