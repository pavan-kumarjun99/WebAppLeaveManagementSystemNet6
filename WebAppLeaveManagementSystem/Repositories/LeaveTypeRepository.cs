using WebAppLeaveManagementSystem.Contracts;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
