using System.ComponentModel.DataAnnotations;

namespace Covid19KeralaApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}