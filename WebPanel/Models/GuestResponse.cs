using System.ComponentModel.DataAnnotations;

namespace WebPanel.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Gib bitte deinen Namen an")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gib bitte deine E-Mail an")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gib bitte deine Handynummer an")]
        public string Handy { get; set; }

        [Required(ErrorMessage = "Gib bitte an ob du Erscheinen wirst")]
        public bool? WillAttend { get; set; }
    }
}
