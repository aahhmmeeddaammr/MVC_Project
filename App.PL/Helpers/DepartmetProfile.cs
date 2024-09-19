using App.DAL.Models;
using App.PL.ViewModels;
using AutoMapper;

namespace App.PL.Helpers
{
	public class DepartmetProfile:Profile
	{
        public DepartmetProfile()
        {
			CreateMap<Department,DepartmentViewModel>().ReverseMap();

		}
	}
}
