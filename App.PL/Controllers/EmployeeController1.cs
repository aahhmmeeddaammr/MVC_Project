﻿using App.BLL.Interfaces;
using App.DAL.Data;
using App.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;

namespace App.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment _env;

        public EmployeeController(IEmployeeRepository employee , IWebHostEnvironment env)
        {
            this.employeeRepository = employee;
            _env = env;
        }
        [HttpGet]
        public IActionResult Delete(int ? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            var emp = employeeRepository.GetByID(id.Value);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete([FromRoute] int id, Employee employee)
        {

            try
            {
                var emp = employeeRepository.Delete(employee);
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

        #region Update Employee
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var emp = employeeRepository.GetByID(id.Value);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit([FromRoute] int id, Employee employee)
        {

            try
            {
                var emp = employeeRepository.Update(employee);
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
            return View();
        }
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            try
            {
                int Effected = employeeRepository.Add(employee);
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
                return View(emp);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest();
            }
        } 
        #endregion

        #region Get All Employees
        public IActionResult Index()
        {
            try
            {
                var employees = employeeRepository.GetAll();

                return View(employees);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        } 
        #endregion
    }
}
