using System.ComponentModel.DataAnnotations;

namespace BuildTrackAPI.models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DesignationName { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
