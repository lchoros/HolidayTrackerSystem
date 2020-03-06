using JPSHolidayTrackerSystem.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace JPSHolidayTrackerSystem.Shared.Entitities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage="First name is too long.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last name is required")]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? JoinedDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
