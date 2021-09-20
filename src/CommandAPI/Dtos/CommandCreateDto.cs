using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(25)]
        public string HowTo {get; set;}
        
        [Required]
        public string Platform {get; set;}
        
        [Required]
        public string CommandLine {get; set;}
    }
}