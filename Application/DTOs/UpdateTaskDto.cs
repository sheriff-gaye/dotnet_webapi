using System.ComponentModel.DataAnnotations;


namespace Application.DTOs
{
    public class UpdateTaskDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;


        [Required]
        public string Description { get; set; } = string.Empty;


        [Required]
        public string Status { get; set; } = string.Empty;
    }
}