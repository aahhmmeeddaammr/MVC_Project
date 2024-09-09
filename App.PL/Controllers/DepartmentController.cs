using App.BLL.Interfaces;
using App.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace App.PL.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository departmentRepository;

		public DepartmentController(IDepartmentRepository departmentRepository) {
			this.departmentRepository = departmentRepository;
		}

		#region Create Department

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
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
			catch
			{
				return View(newD);
			}
		}
		#endregion

		#region Edit Department
		[HttpGet]
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
				return View(D);
			}
		}
		#endregion

		#region Delete Department
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
				return View(D);
			}
		}
		#endregion

		#region Department Details 
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
