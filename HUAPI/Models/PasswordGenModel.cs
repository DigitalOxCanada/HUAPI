using System.ComponentModel.DataAnnotations;

namespace HUAPICore.Models
{
    /// <summary>
    /// model used for the api
    /// </summary>
    public class PasswordGenModel
    {
        [Required]
        public int Maximum { get; set; }

        public string Exclusions { get; set; }
        public bool ExcludeSymbols { get; set; }
        public bool RepeatCharacters { get; set; }
        public bool ConsecutiveCharacters { get; set; }

    }

}
