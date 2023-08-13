using System.ComponentModel.DataAnnotations;

namespace CamelSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}