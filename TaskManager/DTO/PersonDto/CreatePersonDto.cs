using System.ComponentModel.DataAnnotations;

namespace TaskManager.DTO.PersonDto
{
    public class CreatePersonDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(30)]
        public string? Email { get; set; } = string.Empty;
        [Phone]
        [MaxLength(11)]
        [MinLength(11)]
        public string? Phone { get; set; } = string.Empty;
    }
}
