using System.ComponentModel.DataAnnotations;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
