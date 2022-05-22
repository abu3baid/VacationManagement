using System.ComponentModel.DataAnnotations;

namespace VacationManagement.Models
{
    public class VacationType:EntityBase
    {
        [StringLength(200)]
        [Display(Name ="Vacation Name")]
        public string VacationName { get; set; } = string.Empty;
        [Display(Name ="Vacation Color")]
        [StringLength(7)]
        public string BackgroundColor { get; set; } = string.Empty;
        [Display(Name = "Days Number")]
        public int DaysNumber { get; set; }
    }
}
