using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildTrackAPI.models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmployeeCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        [MaxLength(15)]
        public string? Mobile { get; set; }

        public DateTime DateOfJoining { get; set; }

        public decimal Salary { get; set; }

        // Foreign Keys
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
