using App.BLL.Interfaces;
using App.BLL.Repositories;
using App.DAL.Data;
using App.DAL.Models;
using App.PL.Helpers;
using App.PL.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace App.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment _env;
        private readonly IDepartmentRepository departmentRepository;
		private readonly IMapper mapper;

		public EmployeeController(IUnitOfWork unitOfWork, IWebHostEnvironment env  ,IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.employeeRepository = unitOfWork.employeeRepository;
            _env = env;
            this.departmentRepository = unitOfWork.departmentRepository;
			this.mapper = mapper;
		}
        
        #region Delete Employee
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = employeeRepository.GetByID(id.Value);
            var EmployeeVM = mapper.Map<Employee, EmployeeViewModel>(emp);
            if (EmployeeVM == null)
            {
                return NotFound();
            }
            return View(EmployeeVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete([FromRoute] int id, EmployeeViewModel employee)
        {

            try
            {
                DocumentSettings.DeleteFile(employee.ProfileImage, "ProfileImages");
                var Employee = mapper.Map<EmployeeViewModel, Employee>(employee);
                    employeeRepository.Delete(Employee);
                var emp = unitOfWork.Complete();

                if (emp == 0)
                {
                    throw new Exception("Invaild Data");
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(employee);
            }
        }

        #endregion

        #region Update Employee
        public IActionResult Edit(int? id)
         {
            if (id == null)
            {
                return BadRequest();
            }

			var emp = employeeRepository.GetByID(id.Value);
			var EmployeeVM = mapper.Map<Employee, EmployeeViewModel>(emp);
            unitOfWork.Complete();
            if (EmployeeVM == null)
			{
				return NotFound();
			}
			return View(EmployeeVM);
		}
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit([FromRoute] int id, EmployeeViewModel employee)
        {

            try
            {
                employee.ProfileImage = DocumentSettings.UploadFile(employee.Image, "ProfileImages");
                var Employee = mapper.Map<EmployeeViewModel, Employee>(employee);
                employeeRepository.Update(Employee);
				var emp = unitOfWork.Complete();
				if (emp == 0)
				{
					throw new Exception("Invaild Data");
				}
				else
				{
					return RedirectToAction(nameof(Index));
				}
			}
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(employee);
            }
        } 
        #endregion

        #region Create New Employee
        public IActionResult Create()
        {
            ViewData["Departments"] = departmentRepository.GetAll();
            return View();
        }
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            try
            {
                employee.ProfileImage = DocumentSettings.UploadFile(employee.Image, "ProfileImages");
                var Emp = mapper.Map<EmployeeViewModel,Employee>(employee);
                    employeeRepository.Add(Emp);
                int Effected = unitOfWork.Complete();
                if (Effected == 0)
                {
                    throw new Exception("Invalid Data");
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {

                return View(employee);
            }
        }

        #endregion

        #region Details Of One Employee
        [AutoValidateAntiforgeryToken]

        public IActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            try
            {
                var emp = employeeRepository.GetByID(id.Value);
                var MappedEmployee = mapper.Map<Employee, EmployeeViewModel>(emp);
                return View(MappedEmployee);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest();
            }
        } 
        #endregion

        #region Get All Employees
        public IActionResult Index(string name , int? DepartmentID)
        {
            if (DepartmentID.HasValue)
            {
                var employees = employeeRepository.GetAllEmployeesByDepartment(DepartmentID.Value);
                var EmployeesViewModel = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
                return View(EmployeesViewModel);
            }
            if (name == null)
            {
				var employees = employeeRepository.GetAll();
				var EmployeesViewModel = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
				return View(EmployeesViewModel);
            }
            
            try
            {
                var employees = employeeRepository.GetAllEmployeesByName(name.ToLower());
                var EmployeesViewModel = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
                return View(EmployeesViewModel);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        } 
        #endregion
    }
}
