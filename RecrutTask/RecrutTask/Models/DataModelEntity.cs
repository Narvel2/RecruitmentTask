using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RecrutTask.Models
{
    /// <summary>
    /// I'm doing here model a base in EntityFramework TextId as ID in base and it is invisible in view, InputString is required
    /// </summary>
    public class DataModelEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TextId { get; set; }

        [Display(Name = "Write text ")]
        [Required(ErrorMessage = "You have to write a text first")]    
        public string InputString { get; set; }

        [Display(Name = "Text translated ")]
        public string TranslatedString { get; set; }
    }

}