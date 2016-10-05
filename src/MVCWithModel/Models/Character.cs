using System.ComponentModel.DataAnnotations;

namespace MVCWithModel.Models
{
    public class Character
    {
        [Required(ErrorMessage ="Hey you need to put in a name!")]
        public string Name { get; set; }
    }
}
