using System.ComponentModel.DataAnnotations;

namespace MVCWithModel.Models
{
    public class Character
    {
        public int CharacterID { get; set; }
        [Required(ErrorMessage ="Hey you need to put in a name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }
    }
}
