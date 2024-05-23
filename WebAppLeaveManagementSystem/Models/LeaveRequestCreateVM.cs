using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name ="Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }


        //Validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The StartDate must be before EndDate", new[] {nameof(StartDate), nameof(EndDate)});
            }

            if(RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comment Length should be less than 250 letters.", new[] { nameof(RequestComments) });
            }
        }
    }
}
