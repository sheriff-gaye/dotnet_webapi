using System.ComponentModel.DataAnnotations;


namespace Application.DTOs
{
    public class CreateTaskDto
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; } = string.Empty;


        [Required]
        public string Description { get; set; } = string.Empty;


        [Required]
        public string Priority { get; set; } = string.Empty;
    }
}