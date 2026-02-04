


using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class UpdateCategoiresDto
    {

       
        
        [Required]
        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
    }

}