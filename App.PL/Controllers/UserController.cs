using App.DAL.Models;
using App.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace App.PL.Controllers
{
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public UserController(UserManager<ApplicationUser> userManager , RoleManager<IdentityRole> roleManager)
        {
			_userManager = userManager;
			_roleManager = roleManager;
		}

		#region Details Of User Action
		public async Task<IActionResult> Details(string id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var User = await _userManager.FindByIdAsync(id);
			if (User == null)
			{
				return NotFound();
			}
			var MappedUser = new UserViewModel()
			{
				Id = User.Id,
				Email = User.Email,
				FullName = User.Fname + " " + User.Lname,
				Roles = _userManager.GetRolesAsync(User).Result,
			};
			return View(MappedUser);
		}

		#endregion

		public IActionResult Edit()
		{
			return View();
		}

		//public IActionResult Edit(UserViewModel model) {
				
		//}

		#region Get All And Search Action
		public async Task<IActionResult> Index(string email)
		{
			if (email == null)
			{
				var Users = await _userManager.Users.Select(User => new UserViewModel
				{
					Id = User.Id,
					Email = User.Email,
					FullName = User.Fname + " " + User.Lname,
					Roles = _userManager.GetRolesAsync(User).Result,
				}).ToListAsync();
				return View(Users);
			}
			else
			{
				var User = await _userManager.FindByEmailAsync(email);
				if (User == null)
				{
					return NotFound();
				}
				var MappedUser = new UserViewModel()
				{
					Id = User.Id,
					Email = User.Email,
					FullName = User.Fname + " " + User.Lname,
					Roles = _userManager.GetRolesAsync(User).Result,
				};
				return View(new List<UserViewModel>() { MappedUser });
			}
			return View();
		} 
		#endregion

	}
}
