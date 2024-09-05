using App.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.PL.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository departmentRepository;

		public DepartmentController(IDepartmentRepository departmentRepository) {
			this.departmentRepository = departmentRepository;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
