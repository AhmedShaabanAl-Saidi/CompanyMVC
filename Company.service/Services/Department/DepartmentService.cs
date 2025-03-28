using AutoMapper;
using Company.data.Models;
using Company.repository.Interfaces;
using Company.service.Interfaces;
using Company.service.Interfaces.Department.Dto;

namespace Company.service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(DepartmentDto department)
        {
            //var mapperDepartment = new DepartmentDto
            //{
            //    Name = department.Name,
            //    Code = department.Code,
            //    CreatedAt = DateTime.Now,
            //};

            var mapperDepartment = _mapper.Map<Department>(department);

            mapperDepartment.CreatedAt = DateTime.Now;

            _unitOfWork.DepartmentRepository.Add(mapperDepartment);
            _unitOfWork.Complete();
        }

        public void Delete(DepartmentDto department)
        {
            var mapperDepartment = _mapper.Map<Department>(department);

            _unitOfWork.DepartmentRepository.Delete(mapperDepartment);
            _unitOfWork.Complete();
        }

        public IEnumerable<DepartmentDto> GetAll()
        {
            var departments = _unitOfWork.DepartmentRepository.GetAll();

            var mapperDepartments = _mapper.Map<IEnumerable<DepartmentDto>>(departments);

            return mapperDepartments;
        }

        public DepartmentDto GetById(int? id)
        {
            if (id is null)
                return null;

            var department = _unitOfWork.DepartmentRepository.GetById(id.Value);

            if (department is null)
                return null;

            var mapperDepartment = _mapper.Map<DepartmentDto>(department);

            return mapperDepartment;
        }

        public void Update(DepartmentDto department)
        {
            //var dept = GetById(department.Id);

            //if (dept.Name != department.Name)
            //{
            //    if(GetAll().Any(x => x.Name == department.Name))
            //        throw new Exception("Department name already exists");
            //}

            //dept.Name = department.Name;
            //dept.Code = department.Code;

            //_unitOfWork.DepartmentRepository.Update(department);
            //_unitOfWork.Complete();
        }
    }
}
