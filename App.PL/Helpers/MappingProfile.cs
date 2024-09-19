using App.DAL.Models;
using App.PL.ViewModels;
using AutoMapper;

namespace App.PL.Helpers
{
	public class MappingProfile:Profile
	{
        public MappingProfile()
        {
            CreateMap<Employee,EmployeeViewModel>().ReverseMap();
        }
    }
}
