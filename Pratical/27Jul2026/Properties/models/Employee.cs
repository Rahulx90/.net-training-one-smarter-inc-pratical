using System.ComponentModel.DataAnnotations;

namespace _27Jul2026.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Last Name is required")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required")]
        public string Dept { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNum { get; set; } = string.Empty;
    }
}
