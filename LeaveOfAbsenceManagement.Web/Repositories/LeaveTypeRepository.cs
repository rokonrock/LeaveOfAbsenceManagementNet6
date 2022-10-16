using LeaveOfAbsenceManagement.Web.Contracts;
using LeaveOfAbsenceManagement.Web.Data;

namespace LeaveOfAbsenceManagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
