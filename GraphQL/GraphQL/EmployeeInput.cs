using System.ComponentModel.DataAnnotations;

namespace GraphQL.GraphQL
{
    public class EmployeeInput
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Mobile { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Guid TenantId { get; set; }
    }
}
