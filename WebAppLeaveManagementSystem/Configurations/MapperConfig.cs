using AutoMapper;
using WebAppLeaveManagementSystem.Data;
using WebAppLeaveManagementSystem.Models;

namespace WebAppLeaveManagementSystem.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
