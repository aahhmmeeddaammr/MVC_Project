using App.BLL.Interfaces;
using App.DAL.Models;
using App.PL.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace App.PL.Controllers
{
	[Authorize]

	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository departmentRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment _env;
		private readonly IMapper mapper;

		public DepartmentController(IUnitOfWork unitOfWork , IWebHostEnvironment env , IMapper mapper ) {
            this.unitOfWork = unitOfWork;
			this.departmentRepository = unitOfWork.departmentRepository;
            _env = env;
			this.mapper = mapper;
		}

		#region Create Department

		[HttpGet]
		[AutoValidateAntiforgeryToken]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Create(DepartmentViewModel newD)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
				var department = mapper.Map<DepartmentViewModel, Department>(newD);
                departmentRepository.Add(department);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
			}
			catch(Exception ex)
			{
                if (_env.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "There is error occured during ubdate ");
                }
                return View(newD);
			}
		}
		#endregion

		#region Edit Department
		[HttpGet]
		[AutoValidateAntiforgeryToken]
		public IActionResult Edit(int? id)
		{
			if (id == null || !id.HasValue)
			{
				return View("Error");
			}
			var Department = departmentRepository.GetByID(id.Value);
			var DepartmentVM = mapper.Map< Department,DepartmentViewModel> (Department);
			return View(DepartmentVM);
		}
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Edit([FromRoute] int id, DepartmentViewModel D)
		{
			if (!ModelState.IsValid)
			{
				return View(D);
			}
			if (id != D.ID)
			{
				return BadRequest();
			}
			try
			{
				var department = mapper.Map<DepartmentViewModel, Department >(D);
				departmentRepository.Update(department);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				if (_env.IsDevelopment())
				{
					ModelState.AddModelError(string.Empty, ex.Message);
				}
				else
				{
					ModelState.AddModelError(string.Empty, "There is error occured during ubdate ");
				}
				return View(D);
			}
		}
		#endregion

		#region Delete Department
		[AutoValidateAntiforgeryToken]
		public IActionResult Delete(int? id)
		{
			if (id == null || !id.HasValue)
			{
				return View("Error");
			}
			var Department = departmentRepository.GetByID(id.Value);
			var DepartmentViewModel = mapper.Map<Department , DepartmentViewModel>(Department);
			return View(DepartmentViewModel);
		}
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Delete([FromRoute] int id, DepartmentViewModel D)
		{
			if (!ModelState.IsValid)
			{
				return View(D);
			}
			if (id != D.ID)
			{
				return BadRequest();
			}
			try
			{
				var department = mapper.Map<DepartmentViewModel, Department>(D);

                departmentRepository.Delete(department);
                unitOfWork.Complete();
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				if (_env.IsDevelopment())
				{
					ModelState.AddModelError(string.Empty, ex.Message);
				}
				else
				{
					ModelState.AddModelError(string.Empty, "There is error occured during ubdate ");
				}
				return View(D);
			}
		}
		#endregion

		#region Department Details 
		[AutoValidateAntiforgeryToken]
		public IActionResult Details(int? id)
		{
			if (id == null || !id.HasValue)
			{
				return View("Error");
			}
			var Department = departmentRepository.GetByID(id.Value);
			var DepartmentVM = mapper.Map<Department,DepartmentViewModel>(Department);
			return View(DepartmentVM);
		}

		#endregion
		public IActionResult Index()
		{
			var Departments = departmentRepository.GetAll();
			var DepartmentsVM = mapper.Map< IEnumerable<Department>,  IEnumerable< DepartmentViewModel>> (Departments);
			return View(DepartmentsVM);
		}
	}
}
