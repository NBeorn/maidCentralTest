using System.ComponentModel.DataAnnotations;

namespace maidCentralTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}