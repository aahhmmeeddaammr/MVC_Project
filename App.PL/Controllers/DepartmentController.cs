using App.BLL.Interfaces;
using App.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;

namespace App.PL.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository departmentRepository;
		private readonly IWebHostEnvironment _env;

		public DepartmentController(IDepartmentRepository departmentRepository , IWebHostEnvironment env) {
			this.departmentRepository = departmentRepository;
			_env = env;
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
		public IActionResult Create(Department newD)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
                departmentRepository.Add(newD);
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
			return View(Department);
		}
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Edit([FromRoute] int id, Department D)
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
				departmentRepository.Update(D);
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
			return View(Department);
		}
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Delete([FromRoute] int id, Department D)
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
				departmentRepository.Delete(D);
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
			return View(Department);
		}

		#endregion
		public IActionResult Index()
		{
			var Departments = this.departmentRepository.GetAll();
			return View(Departments);
		}
	}
}
