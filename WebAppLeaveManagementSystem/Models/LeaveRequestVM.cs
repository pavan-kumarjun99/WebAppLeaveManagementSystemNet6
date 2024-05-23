using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        public int Days { get; set; }

        [Display(Name ="Date Requested")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        [Display(Name = "Leave Status")]
        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public EmployeeListVM Employee { get; set; }
        public string? RequestingEmployeeId { get; internal set; }
    }
}
