
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class CreateCategoiresDto
    {

    
        [Required]
        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
    }

}