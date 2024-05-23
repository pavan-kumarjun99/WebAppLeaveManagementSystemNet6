using System.ComponentModel.DataAnnotations;

namespace WebAppLeaveManagementSystem.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name ="Total Requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        [Display(Name = "Cancelled Requests")]
        public int CancelledRequest { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }

        public EmployeeListVM Employee {  get; set; }
    }
}
