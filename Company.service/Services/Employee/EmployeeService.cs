using Azure;
using System.Net;
using Company.data.Models;
using Company.repository.Interfaces;
using Company.service.Interfaces;
using Company.service.Interfaces.Employee.Dto;
using AutoMapper;
using Company.service.Helper;

namespace Company.service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(EmployeeDto employee)
        {
            // Manual mapping
            //Employee mapperEmployee = new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageURL = employee.ImageURL,
            //    Department = employee.Department,
            //    DepartmentId = employee.DepartmentId,
            //};

            employee.ImageUrl = DocumentSettings.UploadFiles(employee.Image, "Images");

            Employee mapperEmployee = _mapper.Map<Employee>(employee);

            _unitOfWork.EmployeeRepository.Add(mapperEmployee);
            _unitOfWork.Complete();
        }

        public void Delete(EmployeeDto employee)
        {
            //Employee mapperEmployee = new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageURL = employee.ImageURL,
            //    Department = employee.Department,
            //    DepartmentId = employee.DepartmentId,
            //};

            Employee mapperEmployee = _mapper.Map<Employee>(employee);

            _unitOfWork.EmployeeRepository.Delete(mapperEmployee);
            _unitOfWork.Complete();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();

            //var mapperEmployee = employees.Select(employee => new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageURL = employee.ImageURL,
            //    Department = employee.Department,
            //    DepartmentId = employee.DepartmentId,
            //});

            IEnumerable<EmployeeDto> mapperEmployee = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return mapperEmployee;
        }

        public EmployeeDto GetById(int? id)
        {
            if (id is null)
                return null;

            var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);

            if (employee is null)
                return null;

            //EmployeeDto mapperEmployee = new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageURL = employee.ImageURL,
            //    Department = employee.Department,
            //    DepartmentId = employee.DepartmentId,
            //};

            EmployeeDto mapperEmployee = _mapper.Map<EmployeeDto>(employee);

            return mapperEmployee;
        }

        public IEnumerable<EmployeeDto> GetEmployeeByName(string name)
        {
            var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);

            //var mapperEmployee = employees.Select(employee => new EmployeeDto
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageURL = employee.ImageURL,
            //    Department = employee.Department,
            //    DepartmentId = employee.DepartmentId,
            //});

            IEnumerable<EmployeeDto> mapperEmployee = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return mapperEmployee;
        }
        public void Update(EmployeeDto employee)
        {
            //_unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
