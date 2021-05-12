using System.ComponentModel.DataAnnotations;

namespace Wingap.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}