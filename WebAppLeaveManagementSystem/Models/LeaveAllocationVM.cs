using System.ComponentModel.DataAnnotations;

namespace WebAppLeaveManagementSystem.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name ="Number Of Days")]
        [Required]
        [Range(1,50, ErrorMessage ="Invalid Number")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
        //public EmployeeListVM Employee { get; set; }
    }
}