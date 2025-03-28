using Company.data.Models;
using Company.service.Interfaces;
using Company.service.Interfaces.Employee.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Company.web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService , IDepartmentService departmentService)
        {
           _employeeService = employeeService;
           _departmentService = departmentService;
        }

        public IActionResult Index(string searchInp)
        {
            // ViewBag , ViewData , TempData
            //ViewBag.Message = "ViewBag0";
            //ViewData["MessageViewData"] = "ViewData1";
            //TempData["MessageTempData"] = "TempData2";

            IEnumerable<EmployeeDto> employees = new List<EmployeeDto>();

            if (string.IsNullOrEmpty(searchInp))
                employees = _employeeService.GetAll();
            else
                employees = _employeeService.GetEmployeeByName(searchInp);

            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("EmployeeError", "Invalid model");
                return View(employee);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EmployeeError", ex.Message);
                return View(employee);
            }
        }
    }
}
