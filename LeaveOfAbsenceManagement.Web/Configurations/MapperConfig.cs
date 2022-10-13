using AutoMapper;
using LeaveOfAbsenceManagement.Web.Data;
using LeaveOfAbsenceManagement.Web.Models;

namespace LeaveOfAbsenceManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();       
        }
    }
}
