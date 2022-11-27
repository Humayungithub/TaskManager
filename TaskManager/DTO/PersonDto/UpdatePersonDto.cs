using System.ComponentModel.DataAnnotations;

namespace TaskManager.DTO.PersonDto
{
    public class UpdatePersonDto : BaseDtoPerson
    {
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(30)]
        public string? Email { get; set; }
        [Phone]
        [MaxLength(11)]
        [MinLength(11)]
        public string? Phone { get; set; }
    }
}
